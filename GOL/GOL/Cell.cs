using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOL
{
    public class Cell
    {
        public CellState State { get; private set; }
        private static System.Drawing.Pen deadPen = new System.Drawing.Pen(Color.Red, 1F);
        private static System.Drawing.Pen alivePen = new System.Drawing.Pen(Color.Green, 2F);
        
        float X, Y, XSize, YSize;
        public Cell(float x, float y, float xSize, float ySize)
        {
            X = x;
            Y = y;
            XSize = xSize;
            YSize = ySize;
            State = CellState.Dead;
        }

        public Cell(Cell oldCell, CellState newState)
        {
            this.X = oldCell.X;
            this.Y = oldCell.Y;
            this.XSize = oldCell.XSize;
            this.YSize = oldCell.YSize;
            State = newState;
            
        }

        public void DrawCell(PictureBox displayGrid, Graphics g)
        {
            if (State == CellState.Dead)
                DrawEmptyCell(displayGrid, g);
            else if (State == CellState.Alive)
                DrawAliveCell(displayGrid, g);
        }

        public void SwitchState()
        {
            if (State == CellState.Alive)
                State = CellState.Dead;
            else if (State == CellState.Dead)
                State = CellState.Alive;
        }

        public void SetState(CellState state)
        {
            this.State = state;
        }

        private void DrawEmptyCell(PictureBox displayGrid, Graphics g)
        {
            g.DrawRectangle(deadPen, X, Y, XSize, YSize);
        }

        private void DrawAliveCell(PictureBox displayGrid, Graphics g)
        {
            g.FillRectangle(System.Drawing.Brushes.Green, X, Y, XSize, YSize);
        }
    }

    public enum CellState { Dead, Alive}
}
