﻿
namespace Virt_lab_25
{
    partial class Register
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
            this.enterRegister = new System.Windows.Forms.Button();
            this.closeRegister = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.@group = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterRegister
            // 
            this.enterRegister.Location = new System.Drawing.Point(13, 151);
            this.enterRegister.Name = "enterRegister";
            this.enterRegister.Size = new System.Drawing.Size(110, 23);
            this.enterRegister.TabIndex = 0;
            this.enterRegister.Text = "Ввод";
            this.enterRegister.UseVisualStyleBackColor = true;
            this.enterRegister.Click += new System.EventHandler(this.enterRegister_Click);
            // 
            // closeRegister
            // 
            this.closeRegister.Location = new System.Drawing.Point(135, 151);
            this.closeRegister.Name = "closeRegister";
            this.closeRegister.Size = new System.Drawing.Size(110, 23);
            this.closeRegister.TabIndex = 1;
            this.closeRegister.Text = "Выход";
            this.closeRegister.UseVisualStyleBackColor = true;
            this.closeRegister.Click += new System.EventHandler(this.closeRegister_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(106, 58);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(139, 20);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(106, 84);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(139, 20);
            this.textBoxGroup.TabIndex = 3;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(12, 61);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(87, 13);
            this.name.TabIndex = 4;
            this.name.Text = "Имя и фамилия";
            // 
            // group
            // 
            this.@group.AutoSize = true;
            this.@group.Location = new System.Drawing.Point(13, 87);
            this.@group.Name = "group";
            this.@group.Size = new System.Drawing.Size(42, 13);
            this.@group.TabIndex = 5;
            this.@group.Text = "Группа";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Загрузка протокола";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Изучение эффекта Холла в проводниках";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 234);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.@group);
            this.Controls.Add(this.name);
            this.Controls.Add(this.textBoxGroup);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.closeRegister);
            this.Controls.Add(this.enterRegister);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лаб. Работа";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button button1;

        #endregion

        private System.Windows.Forms.Button enterRegister;
        private System.Windows.Forms.Button closeRegister;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label @group;
    }
}