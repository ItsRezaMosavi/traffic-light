namespace traffic_light
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnLeftRed = new Button();
            btnLeftYellow = new Button();
            btnLeftGreen = new Button();
            btnUpRed = new Button();
            btnUpYellow = new Button();
            btnUpGreen = new Button();
            btnDownRed = new Button();
            btnDownYellow = new Button();
            btnDownGreen = new Button();
            btnRightRed = new Button();
            btnRightYellow = new Button();
            btnRightGreen = new Button();
            tmrMain = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnLeftRed
            // 
            btnLeftRed.BackColor = Color.White;
            btnLeftRed.Location = new Point(97, 186);
            btnLeftRed.Name = "btnLeftRed";
            btnLeftRed.Size = new Size(59, 50);
            btnLeftRed.TabIndex = 0;
            btnLeftRed.Text = " ";
            btnLeftRed.UseVisualStyleBackColor = false;
            // 
            // btnLeftYellow
            // 
            btnLeftYellow.BackColor = Color.White;
            btnLeftYellow.Location = new Point(97, 237);
            btnLeftYellow.Name = "btnLeftYellow";
            btnLeftYellow.Size = new Size(59, 50);
            btnLeftYellow.TabIndex = 1;
            btnLeftYellow.Text = " ";
            btnLeftYellow.UseVisualStyleBackColor = false;
            // 
            // btnLeftGreen
            // 
            btnLeftGreen.BackColor = Color.Green;
            btnLeftGreen.Location = new Point(97, 288);
            btnLeftGreen.Name = "btnLeftGreen";
            btnLeftGreen.Size = new Size(59, 50);
            btnLeftGreen.TabIndex = 2;
            btnLeftGreen.Text = " ";
            btnLeftGreen.UseVisualStyleBackColor = false;
            // 
            // btnUpRed
            // 
            btnUpRed.BackColor = Color.Red;
            btnUpRed.Location = new Point(338, 12);
            btnUpRed.Name = "btnUpRed";
            btnUpRed.Size = new Size(59, 50);
            btnUpRed.TabIndex = 3;
            btnUpRed.Text = " ";
            btnUpRed.UseVisualStyleBackColor = false;
            // 
            // btnUpYellow
            // 
            btnUpYellow.BackColor = Color.White;
            btnUpYellow.Location = new Point(338, 63);
            btnUpYellow.Name = "btnUpYellow";
            btnUpYellow.Size = new Size(59, 50);
            btnUpYellow.TabIndex = 4;
            btnUpYellow.Text = " ";
            btnUpYellow.UseVisualStyleBackColor = false;
            // 
            // btnUpGreen
            // 
            btnUpGreen.BackColor = Color.White;
            btnUpGreen.Location = new Point(338, 114);
            btnUpGreen.Name = "btnUpGreen";
            btnUpGreen.Size = new Size(59, 50);
            btnUpGreen.TabIndex = 5;
            btnUpGreen.Text = " ";
            btnUpGreen.UseVisualStyleBackColor = false;
            // 
            // btnDownRed
            // 
            btnDownRed.BackColor = Color.Red;
            btnDownRed.Location = new Point(338, 344);
            btnDownRed.Name = "btnDownRed";
            btnDownRed.Size = new Size(59, 50);
            btnDownRed.TabIndex = 6;
            btnDownRed.Text = " ";
            btnDownRed.UseVisualStyleBackColor = false;
            // 
            // btnDownYellow
            // 
            btnDownYellow.BackColor = Color.White;
            btnDownYellow.Location = new Point(338, 395);
            btnDownYellow.Name = "btnDownYellow";
            btnDownYellow.Size = new Size(59, 50);
            btnDownYellow.TabIndex = 7;
            btnDownYellow.Text = " ";
            btnDownYellow.UseVisualStyleBackColor = false;
            // 
            // btnDownGreen
            // 
            btnDownGreen.BackColor = Color.White;
            btnDownGreen.Location = new Point(338, 446);
            btnDownGreen.Name = "btnDownGreen";
            btnDownGreen.Size = new Size(59, 50);
            btnDownGreen.TabIndex = 8;
            btnDownGreen.Text = " ";
            btnDownGreen.UseVisualStyleBackColor = false;
            // 
            // btnRightRed
            // 
            btnRightRed.BackColor = Color.White;
            btnRightRed.Location = new Point(584, 180);
            btnRightRed.Name = "btnRightRed";
            btnRightRed.Size = new Size(59, 50);
            btnRightRed.TabIndex = 9;
            btnRightRed.Text = " ";
            btnRightRed.UseVisualStyleBackColor = false;
            // 
            // btnRightYellow
            // 
            btnRightYellow.BackColor = Color.White;
            btnRightYellow.Location = new Point(584, 233);
            btnRightYellow.Name = "btnRightYellow";
            btnRightYellow.Size = new Size(59, 50);
            btnRightYellow.TabIndex = 10;
            btnRightYellow.Text = " ";
            btnRightYellow.UseVisualStyleBackColor = false;
            // 
            // btnRightGreen
            // 
            btnRightGreen.BackColor = Color.Green;
            btnRightGreen.Location = new Point(584, 286);
            btnRightGreen.Name = "btnRightGreen";
            btnRightGreen.Size = new Size(59, 50);
            btnRightGreen.TabIndex = 11;
            btnRightGreen.Text = " ";
            btnRightGreen.UseVisualStyleBackColor = false;
            // 
            // tmrMain
            // 
            tmrMain.Enabled = true;
            tmrMain.Interval = 1000;
            tmrMain.Tick += tmrMain_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 532);
            Controls.Add(btnRightGreen);
            Controls.Add(btnRightYellow);
            Controls.Add(btnRightRed);
            Controls.Add(btnDownGreen);
            Controls.Add(btnDownYellow);
            Controls.Add(btnDownRed);
            Controls.Add(btnUpGreen);
            Controls.Add(btnUpYellow);
            Controls.Add(btnUpRed);
            Controls.Add(btnLeftGreen);
            Controls.Add(btnLeftYellow);
            Controls.Add(btnLeftRed);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnLeftRed;
        private Button btnLeftYellow;
        private Button btnLeftGreen;
        private Button btnUpRed;
        private Button btnUpYellow;
        private Button btnUpGreen;
        private Button btnDownRed;
        private Button btnDownYellow;
        private Button btnDownGreen;
        private Button btnRightRed;
        private Button btnRightYellow;
        private Button btnRightGreen;
        private System.Windows.Forms.Timer tmrMain;
    }
}
