using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOL
{
    public partial class GameWindow : Form
    {
        CellGrid cellGrid;
        public GameWindow(int rows, int columns)
        {
            InitializeComponent();
            cellGrid = new CellGrid(rows, columns, DisplayGrid.Size.Width, DisplayGrid.Size.Height);
            this.DisplayGrid.Paint += GameWindow_Paint;
        }

        private void GameWindow_Paint(object sender, PaintEventArgs e)
        {
            cellGrid.DrawCells(DisplayGrid, e.Graphics);
        }

        private void SetupGrid()
        {
            cellGrid = new CellGrid(3, 5, DisplayGrid.Size.Width, DisplayGrid.Size.Height);
            var g = DisplayGrid.CreateGraphics();
            cellGrid.DrawCells(DisplayGrid, g);
        }

        private void DisplayGrid_Click(object sender, EventArgs e)
        {

        }

        private void DisplayGrid_MouseClick(object sender, MouseEventArgs e)
        {
            cellGrid.SwitchCellState(e.X, e.Y);
            DisplayGrid.Invalidate();
        }

        private void stepButton_Click(object sender, EventArgs e)
        {
            cellGrid.StepSystem();
            DisplayGrid.Invalidate();
        }

        bool Stop = false;
        private void play_Button_Click(object sender, EventArgs e)
        {
            play_Button.Enabled = false;
            Task.Factory.StartNew(() =>
            {
                Stop = false;
                while(Stop == false)
                {
                    this.Invoke((Action)(() => {
                        cellGrid.StepSystem();
                        DisplayGrid.Invalidate();
                    }));
                    
                    Task.Delay(200).Wait();
                }
                
            });
        }

        private void pause_Button_Click(object sender, EventArgs e)
        {
            Stop = true;
            play_Button.Enabled = true;
        }
    }
}
