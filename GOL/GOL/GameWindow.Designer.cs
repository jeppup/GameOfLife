namespace GOL
{
    partial class GameWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.DisplayGrid = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.play_Button = new System.Windows.Forms.Button();
            this.pause_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game of Life";
            // 
            // DisplayGrid
            // 
            this.DisplayGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayGrid.Location = new System.Drawing.Point(52, 65);
            this.DisplayGrid.Name = "DisplayGrid";
            this.DisplayGrid.Size = new System.Drawing.Size(472, 206);
            this.DisplayGrid.TabIndex = 1;
            this.DisplayGrid.TabStop = false;
            this.DisplayGrid.Click += new System.EventHandler(this.DisplayGrid_Click);
            this.DisplayGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DisplayGrid_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Step";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.stepButton_Click);
            // 
            // play_Button
            // 
            this.play_Button.Location = new System.Drawing.Point(211, 289);
            this.play_Button.Name = "play_Button";
            this.play_Button.Size = new System.Drawing.Size(75, 23);
            this.play_Button.TabIndex = 3;
            this.play_Button.Text = "Play";
            this.play_Button.UseVisualStyleBackColor = true;
            this.play_Button.Click += new System.EventHandler(this.play_Button_Click);
            // 
            // pause_Button
            // 
            this.pause_Button.Location = new System.Drawing.Point(292, 289);
            this.pause_Button.Name = "pause_Button";
            this.pause_Button.Size = new System.Drawing.Size(75, 23);
            this.pause_Button.TabIndex = 4;
            this.pause_Button.Text = "Pause";
            this.pause_Button.UseVisualStyleBackColor = true;
            this.pause_Button.Click += new System.EventHandler(this.pause_Button_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(587, 324);
            this.Controls.Add(this.pause_Button);
            this.Controls.Add(this.play_Button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DisplayGrid);
            this.Controls.Add(this.label1);
            this.Name = "GameWindow";
            this.Text = "GameWindow";
            ((System.ComponentModel.ISupportInitialize)(this.DisplayGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox DisplayGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button play_Button;
        private System.Windows.Forms.Button pause_Button;
    }
}