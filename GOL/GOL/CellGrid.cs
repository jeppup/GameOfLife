using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOL
{
    public class CellGrid
    {
        private Cell[, ] cells;
        private float x_res, y_res, xSize, ySize;
        private int N, M;

        public CellGrid(int n, int m, float x_res, float y_res) {
            this.cells = new Cell[n, m];
            this.N = n;
            this.M = m;
            this.x_res = x_res;
            this.y_res = y_res;
            this.xSize = x_res / n;
            this.ySize = y_res / m;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    cells[i, j] = new Cell(i * xSize, j * ySize, xSize, ySize);
                }
            }
        }

        public Cell GetCellHit(double x, double y)
        {
            return null;
        }

        public void SwitchCellState(float xPos, float yPos)
        {
            int i = (int)(xPos / xSize);
            int j = (int)(yPos / ySize);

            cells[i, j].SwitchState();
        }

        public void DrawCells(PictureBox displayGrid, Graphics g)
        {
            foreach (var cell in cells)
            {
                cell.DrawCell(displayGrid, g);
            }
        }

        public void StepSystem()
        {
            var newCells = new Cell[N, M];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    var neighbors = CountLivingNeighbors(i, j);
                    if (cells[i, j].State == CellState.Alive)
                    {
                        if (neighbors < 2)
                            newCells[i, j] = new Cell(cells[i, j], CellState.Dead);
                        else if (neighbors > 3)
                            newCells[i, j] = new Cell(cells[i, j], CellState.Dead);
                        else
                            newCells[i, j] = new Cell(cells[i, j], CellState.Alive);
                    }
                    else if (cells[i, j].State == CellState.Dead && neighbors == 3)
                        newCells[i, j] = new Cell(cells[i, j], CellState.Alive);
                    else
                        newCells[i, j] = new Cell(cells[i, j], CellState.Dead);
                }
            }

            this.cells = newCells;
        }

        private int CountLivingNeighbors(int midX, int midY)
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int x = midX - 1 + i;
                    int y = midY - 1 + j;
                    if (x < 0 || x >= N || y < 0 || y >= M || (x == midX && y == midY)) { }
                    else if (cells[x, y].State == CellState.Alive)
                        count++;
                }
            }

            return count;
        }
    }
}
