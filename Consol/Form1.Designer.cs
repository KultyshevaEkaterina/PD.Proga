
namespace Consol
{
    partial class Form1
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
            this.TextBoxk = new System.Windows.Forms.TextBox();
            this.labelk = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Done = new System.Windows.Forms.Button();
            this.TextBoxd = new System.Windows.Forms.TextBox();
            this.labeld = new System.Windows.Forms.Label();
            this.textBoxh = new System.Windows.Forms.TextBox();
            this.h = new System.Windows.Forms.Label();
            this.groupBoxRes = new System.Windows.Forms.GroupBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxRes.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxk
            // 
            this.TextBoxk.Location = new System.Drawing.Point(197, 80);
            this.TextBoxk.Multiline = true;
            this.TextBoxk.Name = "TextBoxk";
            this.TextBoxk.Size = new System.Drawing.Size(131, 33);
            this.TextBoxk.TabIndex = 0;
            this.TextBoxk.TextChanged += new System.EventHandler(this.k_TextChanged);
            // 
            // labelk
            // 
            this.labelk.AutoSize = true;
            this.labelk.BackColor = System.Drawing.Color.White;
            this.labelk.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelk.Location = new System.Drawing.Point(153, 48);
            this.labelk.Name = "labelk";
            this.labelk.Size = new System.Drawing.Size(228, 17);
            this.labelk.TabIndex = 1;
            this.labelk.Text = "Коэффициент продуктивности:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Done);
            this.groupBox1.Controls.Add(this.TextBoxd);
            this.groupBox1.Controls.Add(this.labeld);
            this.groupBox1.Controls.Add(this.textBoxh);
            this.groupBox1.Controls.Add(this.h);
            this.groupBox1.Controls.Add(this.labelk);
            this.groupBox1.Controls.Add(this.TextBoxk);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 426);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите значения";
            // 
            // Done
            // 
            this.Done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Done.Location = new System.Drawing.Point(156, 350);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(225, 52);
            this.Done.TabIndex = 6;
            this.Done.Text = "Выполнить";
            this.Done.UseVisualStyleBackColor = false;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // TextBoxd
            // 
            this.TextBoxd.Location = new System.Drawing.Point(198, 282);
            this.TextBoxd.Multiline = true;
            this.TextBoxd.Name = "TextBoxd";
            this.TextBoxd.Size = new System.Drawing.Size(129, 33);
            this.TextBoxd.TabIndex = 5;
            // 
            // labeld
            // 
            this.labeld.AutoSize = true;
            this.labeld.BackColor = System.Drawing.Color.White;
            this.labeld.Location = new System.Drawing.Point(180, 251);
            this.labeld.Name = "labeld";
            this.labeld.Size = new System.Drawing.Size(157, 19);
            this.labeld.TabIndex = 4;
            this.labeld.Text = "Диаметр скважины:";
            // 
            // textBoxh
            // 
            this.textBoxh.Location = new System.Drawing.Point(198, 186);
            this.textBoxh.Multiline = true;
            this.textBoxh.Name = "textBoxh";
            this.textBoxh.Size = new System.Drawing.Size(130, 33);
            this.textBoxh.TabIndex = 3;
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.BackColor = System.Drawing.Color.White;
            this.h.Location = new System.Drawing.Point(194, 150);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(143, 19);
            this.h.TabIndex = 2;
            this.h.Text = "Мощность пласта:";
            // 
            // groupBoxRes
            // 
            this.groupBoxRes.Controls.Add(this.buttonRemove);
            this.groupBoxRes.Controls.Add(this.textBoxRes);
            this.groupBoxRes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxRes.Location = new System.Drawing.Point(577, 12);
            this.groupBoxRes.Name = "groupBoxRes";
            this.groupBoxRes.Size = new System.Drawing.Size(200, 426);
            this.groupBoxRes.TabIndex = 6;
            this.groupBoxRes.TabStop = false;
            this.groupBoxRes.Text = "Результат";
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonRemove.Location = new System.Drawing.Point(20, 341);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(160, 52);
            this.buttonRemove.TabIndex = 8;
            this.buttonRemove.Text = "Обратно";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.FormMain_Click);
            // 
            // textBoxRes
            // 
            this.textBoxRes.BackColor = System.Drawing.Color.White;
            this.textBoxRes.Location = new System.Drawing.Point(16, 160);
            this.textBoxRes.Multiline = true;
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.ReadOnly = true;
            this.textBoxRes.Size = new System.Drawing.Size(164, 50);
            this.textBoxRes.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxRes);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Формула Борисова";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxRes.ResumeLayout(false);
            this.groupBoxRes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxk;
        private System.Windows.Forms.Label labelk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.TextBox TextBoxd;
        private System.Windows.Forms.Label labeld;
        private System.Windows.Forms.TextBox textBoxh;
        private System.Windows.Forms.Label h;
        private System.Windows.Forms.GroupBox groupBoxRes;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TextBox textBoxRes;
    }
}