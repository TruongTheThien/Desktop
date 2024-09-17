namespace QuanLiThuVienSachCaNhan
{
    partial class ThemSach
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
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bnt_themsach = new System.Windows.Forms.Button();
            this.cbbChuDe = new System.Windows.Forms.ComboBox();
            this.rdKeA = new System.Windows.Forms.RadioButton();
            this.rdKeB = new System.Windows.Forms.RadioButton();
            this.rdKeC = new System.Windows.Forms.RadioButton();
            this.rdKeD = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(257, 63);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(212, 22);
            this.txtMaSach.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên sách:";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(257, 102);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(212, 22);
            this.txtTenSach.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tác giả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chủ đề:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vị trí:";
            // 
            // bnt_themsach
            // 
            this.bnt_themsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_themsach.Location = new System.Drawing.Point(283, 320);
            this.bnt_themsach.Margin = new System.Windows.Forms.Padding(4);
            this.bnt_themsach.Name = "bnt_themsach";
            this.bnt_themsach.Size = new System.Drawing.Size(132, 59);
            this.bnt_themsach.TabIndex = 12;
            this.bnt_themsach.Text = "Thêm sách";
            this.bnt_themsach.UseVisualStyleBackColor = true;
            this.bnt_themsach.Click += new System.EventHandler(this.bnt_themsach_Click);
            // 
            // cbbChuDe
            // 
            this.cbbChuDe.FormattingEnabled = true;
            this.cbbChuDe.Location = new System.Drawing.Point(257, 206);
            this.cbbChuDe.Margin = new System.Windows.Forms.Padding(4);
            this.cbbChuDe.Name = "cbbChuDe";
            this.cbbChuDe.Size = new System.Drawing.Size(212, 24);
            this.cbbChuDe.TabIndex = 15;
            this.cbbChuDe.SelectedIndexChanged += new System.EventHandler(this.cbbChuDe_SelectedIndexChanged);
            // 
            // rdKeA
            // 
            this.rdKeA.AutoSize = true;
            this.rdKeA.Checked = true;
            this.rdKeA.Location = new System.Drawing.Point(257, 251);
            this.rdKeA.Name = "rdKeA";
            this.rdKeA.Size = new System.Drawing.Size(56, 20);
            this.rdKeA.TabIndex = 19;
            this.rdKeA.TabStop = true;
            this.rdKeA.Text = "Kệ A";
            this.rdKeA.UseVisualStyleBackColor = true;
            // 
            // rdKeB
            // 
            this.rdKeB.AutoSize = true;
            this.rdKeB.Location = new System.Drawing.Point(312, 251);
            this.rdKeB.Name = "rdKeB";
            this.rdKeB.Size = new System.Drawing.Size(56, 20);
            this.rdKeB.TabIndex = 19;
            this.rdKeB.Text = "Kệ B";
            this.rdKeB.UseVisualStyleBackColor = true;
            // 
            // rdKeC
            // 
            this.rdKeC.AutoSize = true;
            this.rdKeC.Location = new System.Drawing.Point(366, 251);
            this.rdKeC.Name = "rdKeC";
            this.rdKeC.Size = new System.Drawing.Size(56, 20);
            this.rdKeC.TabIndex = 19;
            this.rdKeC.Text = "Kệ C";
            this.rdKeC.UseVisualStyleBackColor = true;
            // 
            // rdKeD
            // 
            this.rdKeD.AutoSize = true;
            this.rdKeD.Location = new System.Drawing.Point(421, 251);
            this.rdKeD.Name = "rdKeD";
            this.rdKeD.Size = new System.Drawing.Size(57, 20);
            this.rdKeD.TabIndex = 19;
            this.rdKeD.Text = "Kệ D";
            this.rdKeD.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(257, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 24);
            this.comboBox1.TabIndex = 20;
            // 
            // ThemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 417);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rdKeD);
            this.Controls.Add(this.rdKeC);
            this.Controls.Add(this.rdKeB);
            this.Controls.Add(this.rdKeA);
            this.Controls.Add(this.cbbChuDe);
            this.Controls.Add(this.bnt_themsach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaSach);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThemSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Sách";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bnt_themsach;
        private System.Windows.Forms.ComboBox cbbChuDe;
        private System.Windows.Forms.RadioButton rdKeA;
        private System.Windows.Forms.RadioButton rdKeB;
        private System.Windows.Forms.RadioButton rdKeC;
        private System.Windows.Forms.RadioButton rdKeD;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}