namespace Quiz
{
    partial class frmQuiz
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
            this.panelQuizMain = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMath = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPhysics = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTimer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelQuizMain.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuizMain
            // 
            this.panelQuizMain.Controls.Add(this.label3);
            this.panelQuizMain.Controls.Add(this.label2);
            this.panelQuizMain.Controls.Add(this.cbTimer);
            this.panelQuizMain.Controls.Add(this.panel3);
            this.panelQuizMain.Controls.Add(this.panel2);
            this.panelQuizMain.Controls.Add(this.panel1);
            this.panelQuizMain.Controls.Add(this.label1);
            this.panelQuizMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuizMain.Location = new System.Drawing.Point(0, 0);
            this.panelQuizMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelQuizMain.Name = "panelQuizMain";
            this.panelQuizMain.Size = new System.Drawing.Size(1016, 539);
            this.panelQuizMain.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMath);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 414);
            this.panel3.TabIndex = 16;
            // 
            // btnMath
            // 
            this.btnMath.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMath.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMath.FlatAppearance.BorderSize = 2;
            this.btnMath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(119)))), ((int)(((byte)(22)))));
            this.btnMath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMath.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMath.ForeColor = System.Drawing.Color.White;
            this.btnMath.Location = new System.Drawing.Point(0, 0);
            this.btnMath.Name = "btnMath";
            this.btnMath.Size = new System.Drawing.Size(325, 84);
            this.btnMath.TabIndex = 7;
            this.btnMath.Text = "Math";
            this.btnMath.UseVisualStyleBackColor = false;
            this.btnMath.Click += new System.EventHandler(this.btnMath_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPhysics);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(691, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 414);
            this.panel2.TabIndex = 15;
            // 
            // btnPhysics
            // 
            this.btnPhysics.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPhysics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhysics.FlatAppearance.BorderSize = 2;
            this.btnPhysics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(119)))), ((int)(((byte)(22)))));
            this.btnPhysics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhysics.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhysics.ForeColor = System.Drawing.Color.White;
            this.btnPhysics.Location = new System.Drawing.Point(0, 0);
            this.btnPhysics.Name = "btnPhysics";
            this.btnPhysics.Size = new System.Drawing.Size(325, 84);
            this.btnPhysics.TabIndex = 9;
            this.btnPhysics.Text = "Physics";
            this.btnPhysics.UseVisualStyleBackColor = false;
            this.btnPhysics.Click += new System.EventHandler(this.btnPhysics_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 52);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(87)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1016, 73);
            this.label1.TabIndex = 13;
            this.label1.Text = "Quiz !";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbTimer
            // 
            this.cbTimer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimer.FormattingEnabled = true;
            this.cbTimer.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60"});
            this.cbTimer.Location = new System.Drawing.Point(390, 212);
            this.cbTimer.Name = "cbTimer";
            this.cbTimer.Size = new System.Drawing.Size(177, 28);
            this.cbTimer.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 73);
            this.label2.TabIndex = 19;
            this.label2.Text = "Time:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(591, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Seconds";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // frmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1016, 539);
            this.Controls.Add(this.panelQuizMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuiz";
            this.Text = "frmQuiz";
            this.panelQuizMain.ResumeLayout(false);
            this.panelQuizMain.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelQuizMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMath;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPhysics;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTimer;
    }
}