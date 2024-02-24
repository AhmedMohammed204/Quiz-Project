namespace Quiz
{
    partial class frmQuestion
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
            this.components = new System.ComponentModel.Container();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelTimer = new System.Windows.Forms.Panel();
            this.lblSubject = new System.Windows.Forms.Label();
            this.panelQuestionImage = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbQuestionImage = new System.Windows.Forms.PictureBox();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnNext = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelTimer.SuspendLayout();
            this.panelQuestionImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblSubject);
            this.panelHeader.Controls.Add(this.panelTimer);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(25, 25);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(996, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // panelTimer
            // 
            this.panelTimer.Controls.Add(this.lblTimer);
            this.panelTimer.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTimer.Location = new System.Drawing.Point(796, 0);
            this.panelTimer.Name = "panelTimer";
            this.panelTimer.Size = new System.Drawing.Size(200, 70);
            this.panelTimer.TabIndex = 0;
            // 
            // lblSubject
            // 
            this.lblSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(87)))));
            this.lblSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(0, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(796, 70);
            this.lblSubject.TabIndex = 1;
            this.lblSubject.Text = "Subject";
            this.lblSubject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelQuestionImage
            // 
            this.panelQuestionImage.Controls.Add(this.pbQuestionImage);
            this.panelQuestionImage.Controls.Add(this.panel3);
            this.panelQuestionImage.Controls.Add(this.panel2);
            this.panelQuestionImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuestionImage.Location = new System.Drawing.Point(25, 95);
            this.panelQuestionImage.Name = "panelQuestionImage";
            this.panelQuestionImage.Size = new System.Drawing.Size(996, 263);
            this.panelQuestionImage.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 263);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(746, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 263);
            this.panel3.TabIndex = 1;
            // 
            // pbQuestionImage
            // 
            this.pbQuestionImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbQuestionImage.Location = new System.Drawing.Point(250, 0);
            this.pbQuestionImage.Name = "pbQuestionImage";
            this.pbQuestionImage.Size = new System.Drawing.Size(496, 263);
            this.pbQuestionImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQuestionImage.TabIndex = 2;
            this.pbQuestionImage.TabStop = false;
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(87)))));
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(25, 364);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(362, 63);
            this.btnA.TabIndex = 2;
            this.btnA.Tag = "1";
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // btnB
            // 
            this.btnB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(87)))));
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(639, 364);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(362, 63);
            this.btnB.TabIndex = 3;
            this.btnB.Tag = "2";
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(87)))));
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(25, 433);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(362, 63);
            this.btnC.TabIndex = 4;
            this.btnC.Tag = "3";
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // btnD
            // 
            this.btnD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(87)))));
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(639, 433);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(362, 63);
            this.btnD.TabIndex = 5;
            this.btnD.Tag = "4";
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(0, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(200, 70);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(190)))), ((int)(((byte)(182)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(749, 540);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(252, 62);
            this.btnNext.TabIndex = 6;
            this.btnNext.Tag = "4";
            this.btnNext.Text = "Next ";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1046, 630);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.panelQuestionImage);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmQuestion";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.Text = "frmQuestion";
            this.Load += new System.EventHandler(this.frmQuestion_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelTimer.ResumeLayout(false);
            this.panelQuestionImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Panel panelTimer;
        private System.Windows.Forms.Panel panelQuestionImage;
        private System.Windows.Forms.PictureBox pbQuestionImage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnNext;
    }
}