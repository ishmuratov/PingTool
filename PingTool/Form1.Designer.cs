namespace PingTool
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainDataGridView = new System.Windows.Forms.DataGridView();
            this.ViewTimer = new System.Windows.Forms.Timer(this.components);
            this.btAddHost = new System.Windows.Forms.Button();
            this.btDeleteHost = new System.Windows.Forms.Button();
            this.btEditHost = new System.Windows.Forms.Button();
            this.btOpenLog = new System.Windows.Forms.Button();
            this.btSettings = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainDataGridView
            // 
            this.MainDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MainDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.MainDataGridView.Location = new System.Drawing.Point(12, 12);
            this.MainDataGridView.Name = "MainDataGridView";
            this.MainDataGridView.ReadOnly = true;
            this.MainDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainDataGridView.Size = new System.Drawing.Size(629, 289);
            this.MainDataGridView.TabIndex = 0;
            // 
            // ViewTimer
            // 
            this.ViewTimer.Enabled = true;
            this.ViewTimer.Interval = 10000;
            this.ViewTimer.Tick += new System.EventHandler(this.PingTimer_Tick);
            // 
            // btAddHost
            // 
            this.btAddHost.Location = new System.Drawing.Point(647, 12);
            this.btAddHost.Name = "btAddHost";
            this.btAddHost.Size = new System.Drawing.Size(141, 23);
            this.btAddHost.TabIndex = 1;
            this.btAddHost.Text = "Добавить хост";
            this.btAddHost.UseVisualStyleBackColor = true;
            this.btAddHost.Click += new System.EventHandler(this.btAddHost_Click);
            // 
            // btDeleteHost
            // 
            this.btDeleteHost.Location = new System.Drawing.Point(647, 73);
            this.btDeleteHost.Name = "btDeleteHost";
            this.btDeleteHost.Size = new System.Drawing.Size(141, 23);
            this.btDeleteHost.TabIndex = 2;
            this.btDeleteHost.Text = "Удалить хост";
            this.btDeleteHost.UseVisualStyleBackColor = true;
            this.btDeleteHost.Click += new System.EventHandler(this.btDeleteHost_Click);
            // 
            // btEditHost
            // 
            this.btEditHost.Location = new System.Drawing.Point(647, 44);
            this.btEditHost.Name = "btEditHost";
            this.btEditHost.Size = new System.Drawing.Size(141, 23);
            this.btEditHost.TabIndex = 3;
            this.btEditHost.Text = "Изменить хост";
            this.btEditHost.UseVisualStyleBackColor = true;
            this.btEditHost.Click += new System.EventHandler(this.btEditHost_Click);
            // 
            // btOpenLog
            // 
            this.btOpenLog.Location = new System.Drawing.Point(647, 278);
            this.btOpenLog.Name = "btOpenLog";
            this.btOpenLog.Size = new System.Drawing.Size(141, 23);
            this.btOpenLog.TabIndex = 4;
            this.btOpenLog.Text = "Открыть Log";
            this.btOpenLog.UseVisualStyleBackColor = true;
            this.btOpenLog.Click += new System.EventHandler(this.btOpenLog_Click);
            // 
            // btSettings
            // 
            this.btSettings.Location = new System.Drawing.Point(647, 249);
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(141, 23);
            this.btSettings.TabIndex = 5;
            this.btSettings.Text = "Настройки";
            this.btSettings.UseVisualStyleBackColor = true;
            this.btSettings.Click += new System.EventHandler(this.btSettings_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(647, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 323);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btSettings);
            this.Controls.Add(this.btOpenLog);
            this.Controls.Add(this.btEditHost);
            this.Controls.Add(this.btDeleteHost);
            this.Controls.Add(this.btAddHost);
            this.Controls.Add(this.MainDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PingTool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MainDataGridView;
        private System.Windows.Forms.Timer ViewTimer;
        private System.Windows.Forms.Button btAddHost;
        private System.Windows.Forms.Button btDeleteHost;
        private System.Windows.Forms.Button btEditHost;
        private System.Windows.Forms.Button btOpenLog;
        private System.Windows.Forms.Button btSettings;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

