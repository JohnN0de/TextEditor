namespace Текстовый_редактор_ПР4
{
    partial class FindReplace
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFind = new System.Windows.Forms.TabPage();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabReplace = new System.Windows.Forms.TabPage();
            this.buttonRepAll = new System.Windows.Forms.Button();
            this.buttonRep = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonFind2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabReplace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFind);
            this.tabControl1.Controls.Add(this.tabReplace);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(425, 132);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabFind
            // 
            this.tabFind.Controls.Add(this.numericUpDown2);
            this.tabFind.Controls.Add(this.label3);
            this.tabFind.Controls.Add(this.numericUpDown1);
            this.tabFind.Controls.Add(this.label2);
            this.tabFind.Controls.Add(this.button1);
            this.tabFind.Controls.Add(this.buttonFind);
            this.tabFind.Controls.Add(this.textBox1);
            this.tabFind.Controls.Add(this.label1);
            this.tabFind.Location = new System.Drawing.Point(4, 22);
            this.tabFind.Name = "tabFind";
            this.tabFind.Padding = new System.Windows.Forms.Padding(3);
            this.tabFind.Size = new System.Drawing.Size(417, 106);
            this.tabFind.TabIndex = 0;
            this.tabFind.Text = "Найти";
            this.tabFind.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(351, 39);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "По:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(351, 13);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "С:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(244, 11);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 2;
            this.buttonFind.Text = "Искать>>";
            this.buttonFind.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Найти:";
            // 
            // tabReplace
            // 
            this.tabReplace.Controls.Add(this.buttonRepAll);
            this.tabReplace.Controls.Add(this.buttonRep);
            this.tabReplace.Controls.Add(this.textBox3);
            this.tabReplace.Controls.Add(this.label7);
            this.tabReplace.Controls.Add(this.numericUpDown3);
            this.tabReplace.Controls.Add(this.label4);
            this.tabReplace.Controls.Add(this.numericUpDown4);
            this.tabReplace.Controls.Add(this.label5);
            this.tabReplace.Controls.Add(this.button2);
            this.tabReplace.Controls.Add(this.buttonFind2);
            this.tabReplace.Controls.Add(this.textBox2);
            this.tabReplace.Controls.Add(this.label6);
            this.tabReplace.Location = new System.Drawing.Point(4, 22);
            this.tabReplace.Name = "tabReplace";
            this.tabReplace.Padding = new System.Windows.Forms.Padding(3);
            this.tabReplace.Size = new System.Drawing.Size(417, 106);
            this.tabReplace.TabIndex = 1;
            this.tabReplace.Text = "Заменить";
            this.tabReplace.UseVisualStyleBackColor = true;
            // 
            // buttonRepAll
            // 
            this.buttonRepAll.Location = new System.Drawing.Point(244, 68);
            this.buttonRepAll.Name = "buttonRepAll";
            this.buttonRepAll.Size = new System.Drawing.Size(147, 23);
            this.buttonRepAll.TabIndex = 19;
            this.buttonRepAll.Text = "Заменить все";
            this.buttonRepAll.UseVisualStyleBackColor = true;
            // 
            // buttonRep
            // 
            this.buttonRep.Location = new System.Drawing.Point(78, 68);
            this.buttonRep.Name = "buttonRep";
            this.buttonRep.Size = new System.Drawing.Size(148, 23);
            this.buttonRep.TabIndex = 18;
            this.buttonRep.Text = "Заменить";
            this.buttonRep.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(78, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 20);
            this.textBox3.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Заменить на:";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(351, 39);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "По:";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(351, 13);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown4.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "С:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonFind2
            // 
            this.buttonFind2.Location = new System.Drawing.Point(244, 11);
            this.buttonFind2.Name = "buttonFind2";
            this.buttonFind2.Size = new System.Drawing.Size(75, 23);
            this.buttonFind2.TabIndex = 10;
            this.buttonFind2.Text = "Искать>>";
            this.buttonFind2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(65, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Найти:";
            // 
            // FindReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 132);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FindReplace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Найти";
            this.TopMost = true;
            this.tabControl1.ResumeLayout(false);
            this.tabFind.ResumeLayout(false);
            this.tabFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabReplace.ResumeLayout(false);
            this.tabReplace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabFind;
        private System.Windows.Forms.TabPage tabReplace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.NumericUpDown numericUpDown3;
        public System.Windows.Forms.NumericUpDown numericUpDown4;
        public System.Windows.Forms.Button buttonFind2;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Button buttonRepAll;
        public System.Windows.Forms.Button buttonRep;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.Button buttonFind;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.NumericUpDown numericUpDown2;
        public System.Windows.Forms.TextBox textBox1;
    }
}