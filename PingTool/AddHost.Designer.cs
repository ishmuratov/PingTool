namespace PingTool
{
    partial class AddHost
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.lbNewHostName = new System.Windows.Forms.Label();
            this.lbNewHost = new System.Windows.Forms.Label();
            this.tbNewHostName = new System.Windows.Forms.TextBox();
            this.tbNewHostAdd = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.lbNewHostName);
            this.groupBox1.Controls.Add(this.lbNewHost);
            this.groupBox1.Controls.Add(this.tbNewHostName);
            this.groupBox1.Controls.Add(this.tbNewHostAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(9, 99);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(247, 23);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // lbNewHostName
            // 
            this.lbNewHostName.AutoSize = true;
            this.lbNewHostName.Location = new System.Drawing.Point(27, 65);
            this.lbNewHostName.Name = "lbNewHostName";
            this.lbNewHostName.Size = new System.Drawing.Size(32, 13);
            this.lbNewHostName.TabIndex = 3;
            this.lbNewHostName.Text = "Имя:";
            // 
            // lbNewHost
            // 
            this.lbNewHost.AutoSize = true;
            this.lbNewHost.Location = new System.Drawing.Point(6, 19);
            this.lbNewHost.Name = "lbNewHost";
            this.lbNewHost.Size = new System.Drawing.Size(53, 13);
            this.lbNewHost.TabIndex = 2;
            this.lbNewHost.Text = "IP-адрес:";
            // 
            // tbNewHostName
            // 
            this.tbNewHostName.Location = new System.Drawing.Point(65, 60);
            this.tbNewHostName.Name = "tbNewHostName";
            this.tbNewHostName.Size = new System.Drawing.Size(191, 20);
            this.tbNewHostName.TabIndex = 1;
            // 
            // tbNewHostAdd
            // 
            this.tbNewHostAdd.Location = new System.Drawing.Point(65, 19);
            this.tbNewHostAdd.Name = "tbNewHostAdd";
            this.tbNewHostAdd.Size = new System.Drawing.Size(191, 20);
            this.tbNewHostAdd.TabIndex = 0;
            // 
            // AddHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 162);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AddHost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddHost";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbNewHostName;
        private System.Windows.Forms.Label lbNewHost;
        public System.Windows.Forms.TextBox tbNewHostName;
        public System.Windows.Forms.TextBox tbNewHostAdd;
        public System.Windows.Forms.Button btAdd;
    }
}