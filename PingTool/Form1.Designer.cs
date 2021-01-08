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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainDataGridView = new System.Windows.Forms.DataGridView();
            this.ViewTimer = new System.Windows.Forms.Timer(this.components);
            this.btAddHost = new System.Windows.Forms.Button();
            this.btDeleteHost = new System.Windows.Forms.Button();
            this.btEditHost = new System.Windows.Forms.Button();
            this.btOpenLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainDataGridView
            // 
            this.MainDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MainDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.MainDataGridView.Location = new System.Drawing.Point(12, 12);
            this.MainDataGridView.Name = "MainDataGridView";
            this.MainDataGridView.ReadOnly = true;
            this.MainDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainDataGridView.Size = new System.Drawing.Size(629, 426);
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
            this.btOpenLog.Location = new System.Drawing.Point(647, 415);
            this.btOpenLog.Name = "btOpenLog";
            this.btOpenLog.Size = new System.Drawing.Size(141, 23);
            this.btOpenLog.TabIndex = 4;
            this.btOpenLog.Text = "Открыть Log";
            this.btOpenLog.UseVisualStyleBackColor = true;
            this.btOpenLog.Click += new System.EventHandler(this.btOpenLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btOpenLog);
            this.Controls.Add(this.btEditHost);
            this.Controls.Add(this.btDeleteHost);
            this.Controls.Add(this.btAddHost);
            this.Controls.Add(this.MainDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PingTool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MainDataGridView;
        private System.Windows.Forms.Timer ViewTimer;
        private System.Windows.Forms.Button btAddHost;
        private System.Windows.Forms.Button btDeleteHost;
        private System.Windows.Forms.Button btEditHost;
        private System.Windows.Forms.Button btOpenLog;
    }
}

