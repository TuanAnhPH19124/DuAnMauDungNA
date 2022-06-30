namespace _3UI
{
    partial class FormDangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.TbxEmail = new System.Windows.Forms.TextBox();
            this.TbxMatkhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LlbQuenMk = new System.Windows.Forms.LinkLabel();
            this.BtnLogIn = new System.Windows.Forms.Button();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CbNhoMk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // TbxEmail
            // 
            this.TbxEmail.Location = new System.Drawing.Point(49, 143);
            this.TbxEmail.Name = "TbxEmail";
            this.TbxEmail.Size = new System.Drawing.Size(223, 23);
            this.TbxEmail.TabIndex = 1;
            // 
            // TbxMatkhau
            // 
            this.TbxMatkhau.Location = new System.Drawing.Point(49, 219);
            this.TbxMatkhau.Name = "TbxMatkhau";
            this.TbxMatkhau.Size = new System.Drawing.Size(223, 23);
            this.TbxMatkhau.TabIndex = 3;
            this.TbxMatkhau.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(49, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // LlbQuenMk
            // 
            this.LlbQuenMk.AutoSize = true;
            this.LlbQuenMk.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LlbQuenMk.LinkColor = System.Drawing.Color.Red;
            this.LlbQuenMk.Location = new System.Drawing.Point(178, 245);
            this.LlbQuenMk.Name = "LlbQuenMk";
            this.LlbQuenMk.Size = new System.Drawing.Size(94, 13);
            this.LlbQuenMk.TabIndex = 4;
            this.LlbQuenMk.TabStop = true;
            this.LlbQuenMk.Text = "Quên mật khẩu ?";
            this.LlbQuenMk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlbQuenMk_LinkClicked);
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.Location = new System.Drawing.Point(69, 279);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(75, 23);
            this.BtnLogIn.TabIndex = 5;
            this.BtnLogIn.Text = "Đăng nhập";
            this.BtnLogIn.UseVisualStyleBackColor = true;
            this.BtnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(168, 279);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(75, 23);
            this.BtnThoat.TabIndex = 6;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Đăng nhập";
            // 
            // CbNhoMk
            // 
            this.CbNhoMk.AutoSize = true;
            this.CbNhoMk.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbNhoMk.Location = new System.Drawing.Point(49, 245);
            this.CbNhoMk.Name = "CbNhoMk";
            this.CbNhoMk.Size = new System.Drawing.Size(99, 17);
            this.CbNhoMk.TabIndex = 8;
            this.CbNhoMk.Text = "Nhớ mật khẩu";
            this.CbNhoMk.UseVisualStyleBackColor = true;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(327, 363);
            this.Controls.Add(this.CbNhoMk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.BtnLogIn);
            this.Controls.Add(this.LlbQuenMk);
            this.Controls.Add(this.TbxMatkhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbxEmail);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TbxEmail;
        private TextBox TbxMatkhau;
        private Label label2;
        private LinkLabel LlbQuenMk;
        private Button BtnLogIn;
        private Button BtnThoat;
        private Label label3;
        private CheckBox CbNhoMk;
    }
}