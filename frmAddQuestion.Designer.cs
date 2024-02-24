namespace Quiz
{
    partial class frmAddQuestion
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
            this.pbQuestionPhoto = new System.Windows.Forms.PictureBox();
            this.pbExplainPhoto = new System.Windows.Forms.PictureBox();
            this.cbSubjects = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOptions = new System.Windows.Forms.ComboBox();
            this.btnQuestionPhoto = new System.Windows.Forms.Button();
            this.btnExplainPhoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExplainPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbQuestionPhoto
            // 
            this.pbQuestionPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbQuestionPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbQuestionPhoto.Location = new System.Drawing.Point(596, 103);
            this.pbQuestionPhoto.Name = "pbQuestionPhoto";
            this.pbQuestionPhoto.Size = new System.Drawing.Size(168, 114);
            this.pbQuestionPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQuestionPhoto.TabIndex = 0;
            this.pbQuestionPhoto.TabStop = false;
            // 
            // pbExplainPhoto
            // 
            this.pbExplainPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbExplainPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbExplainPhoto.Location = new System.Drawing.Point(596, 236);
            this.pbExplainPhoto.Name = "pbExplainPhoto";
            this.pbExplainPhoto.Size = new System.Drawing.Size(168, 114);
            this.pbExplainPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExplainPhoto.TabIndex = 1;
            this.pbExplainPhoto.TabStop = false;
            this.pbExplainPhoto.Click += new System.EventHandler(this.pbExplainPhoto_Click);
            // 
            // cbSubjects
            // 
            this.cbSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubjects.FormattingEnabled = true;
            this.cbSubjects.Location = new System.Drawing.Point(38, 131);
            this.cbSubjects.Name = "cbSubjects";
            this.cbSubjects.Size = new System.Drawing.Size(182, 21);
            this.cbSubjects.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(68)))), ((int)(((byte)(242)))));
            this.label3.Location = new System.Drawing.Point(33, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subject:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(68)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(33, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Correct Answer:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbOptions
            // 
            this.cbOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOptions.FormattingEnabled = true;
            this.cbOptions.Location = new System.Drawing.Point(38, 196);
            this.cbOptions.Name = "cbOptions";
            this.cbOptions.Size = new System.Drawing.Size(182, 21);
            this.cbOptions.TabIndex = 1;
            // 
            // btnQuestionPhoto
            // 
            this.btnQuestionPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuestionPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(68)))), ((int)(((byte)(242)))));
            this.btnQuestionPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestionPhoto.Location = new System.Drawing.Point(486, 190);
            this.btnQuestionPhoto.Name = "btnQuestionPhoto";
            this.btnQuestionPhoto.Size = new System.Drawing.Size(104, 27);
            this.btnQuestionPhoto.TabIndex = 2;
            this.btnQuestionPhoto.Text = "Question Photo";
            this.btnQuestionPhoto.UseVisualStyleBackColor = false;
            this.btnQuestionPhoto.Click += new System.EventHandler(this.btnQuestionPhoto_Click);
            // 
            // btnExplainPhoto
            // 
            this.btnExplainPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExplainPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(68)))), ((int)(((byte)(242)))));
            this.btnExplainPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExplainPhoto.Location = new System.Drawing.Point(486, 323);
            this.btnExplainPhoto.Name = "btnExplainPhoto";
            this.btnExplainPhoto.Size = new System.Drawing.Size(104, 27);
            this.btnExplainPhoto.TabIndex = 3;
            this.btnExplainPhoto.Text = "Explain Photo";
            this.btnExplainPhoto.UseVisualStyleBackColor = false;
            this.btnExplainPhoto.Click += new System.EventHandler(this.btnExplainPhoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(68)))), ((int)(((byte)(242)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(405, 374);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 60);
            this.btnSave.TabIndex = 8;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(68)))), ((int)(((byte)(242)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(737, 52);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(191)))), ((int)(((byte)(175)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(198, 374);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(157, 60);
            this.btnClose.TabIndex = 10;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddQuestion
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(797, 467);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExplainPhoto);
            this.Controls.Add(this.btnQuestionPhoto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbOptions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSubjects);
            this.Controls.Add(this.pbExplainPhoto);
            this.Controls.Add(this.pbQuestionPhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddQuestion";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Text = "frmTxt";
            this.Load += new System.EventHandler(this.frmAddQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExplainPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbQuestionPhoto;
        private System.Windows.Forms.PictureBox pbExplainPhoto;
        private System.Windows.Forms.ComboBox cbSubjects;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOptions;
        private System.Windows.Forms.Button btnQuestionPhoto;
        private System.Windows.Forms.Button btnExplainPhoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
    }
}