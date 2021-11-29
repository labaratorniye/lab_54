
namespace Virt_lab_25
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.closemain = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.check_Results = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Timers.Timer();
            this.nomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.timer4)).BeginInit();
            this.SuspendLayout();
            // 
            // closemain
            // 
            this.closemain.Location = new System.Drawing.Point(894, 373);
            this.closemain.Name = "closemain";
            this.closemain.Size = new System.Drawing.Size(98, 43);
            this.closemain.TabIndex = 1;
            this.closemain.Text = "Выход";
            this.closemain.UseVisualStyleBackColor = true;
            this.closemain.Click += new System.EventHandler(this.button1_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(791, 373);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(97, 43);
            this.Button2.TabIndex = 5;
            this.Button2.Text = "Измерить";
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(224, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 40);
            this.button3.TabIndex = 10;
            this.button3.Text = "Методические материалы";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(118, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 40);
            this.button4.TabIndex = 11;
            this.button4.Text = "Протокол";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 40);
            this.button5.TabIndex = 12;
            this.button5.Text = "Порядок выполнения работы";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.nomer, this.l});
            this.dataGridView1.Location = new System.Drawing.Point(12, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.Size = new System.Drawing.Size(295, 259);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // check_Results
            // 
            this.check_Results.BackColor = System.Drawing.SystemColors.Window;
            this.check_Results.Location = new System.Drawing.Point(894, 322);
            this.check_Results.Name = "check_Results";
            this.check_Results.Size = new System.Drawing.Size(97, 45);
            this.check_Results.TabIndex = 19;
            this.check_Results.Text = "Проверить результаты";
            this.check_Results.UseVisualStyleBackColor = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.SynchronizingObject = this;
            // 
            // nomer
            // 
            this.nomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nomer.HeaderText = "I - ток в электромагинте, А";
            this.nomer.MinimumWidth = 6;
            this.nomer.Name = "nomer";
            this.nomer.Width = 154;
            // 
            // l
            // 
            this.l.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.l.HeaderText = "Δφi - э.д.с. в датчике Холла, В";
            this.l.MinimumWidth = 6;
            this.l.Name = "l";
            this.l.Width = 128;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1003, 425);
            this.Controls.Add(this.check_Results);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.closemain);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №54";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.timer4)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Timers.Timer timer4;

        #endregion
        private System.Windows.Forms.Button closemain;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button check_Results;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;

        //private System.Windows.Forms.Timer timer1;
        //private System.Windows.Forms.Timer timer2;
        //private System.Windows.Forms.Timer timer3;
        //private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn l;
    }
}

