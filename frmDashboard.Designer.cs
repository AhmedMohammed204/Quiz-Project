namespace Quiz
{
    partial class frmDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMainDashboard = new System.Windows.Forms.Button();
            this.panelScreens = new System.Windows.Forms.Panel();
            this.lblAdminData = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(8)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.lblAdminData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 69);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMainDashboard);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 505);
            this.panel2.TabIndex = 1;
            // 
            // btnMainDashboard
            // 
            this.btnMainDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(68)))), ((int)(((byte)(242)))));
            this.btnMainDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMainDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnMainDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnMainDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnMainDashboard.Name = "btnMainDashboard";
            this.btnMainDashboard.Size = new System.Drawing.Size(200, 78);
            this.btnMainDashboard.TabIndex = 0;
            this.btnMainDashboard.Text = "Main";
            this.btnMainDashboard.UseVisualStyleBackColor = false;
            this.btnMainDashboard.Click += new System.EventHandler(this.btnMainDashboard_Click);
            // 
            // panelScreens
            // 
            this.panelScreens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelScreens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScreens.Location = new System.Drawing.Point(200, 69);
            this.panelScreens.Name = "panelScreens";
            this.panelScreens.Size = new System.Drawing.Size(961, 505);
            this.panelScreens.TabIndex = 2;
            // 
            // lblAdminData
            // 
            this.lblAdminData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdminData.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminData.ForeColor = System.Drawing.Color.White;
            this.lblAdminData.Location = new System.Drawing.Point(0, 0);
            this.lblAdminData.Name = "lblAdminData";
            this.lblAdminData.Size = new System.Drawing.Size(1161, 69);
            this.lblAdminData.TabIndex = 0;
            this.lblAdminData.Text = "AdminData";
            this.lblAdminData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(1161, 574);
            this.Controls.Add(this.panelScreens);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1177, 613);
            this.Name = "frmDashboard";
            this.Text = "Quiz Dashoard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMainDashboard;
        private System.Windows.Forms.Panel panelScreens;
        private System.Windows.Forms.Label lblAdminData;
    }
}