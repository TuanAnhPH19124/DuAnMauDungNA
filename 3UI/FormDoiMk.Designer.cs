namespace _3UI
{
    partial class FormDoiMk
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
            this.Lblandau = new System.Windows.Forms.Label();
            this.TbxXacNhanMk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxMkMoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnDoiMk = new System.Windows.Forms.Button();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lblandau
            // 
            this.Lblandau.AutoSize = true;
            this.Lblandau.Location = new System.Drawing.Point(58, 26);
            this.Lblandau.Name = "Lblandau";
            this.Lblandau.Size = new System.Drawing.Size(204, 15);
            this.Lblandau.TabIndex = 0;
            this.Lblandau.Text = "Lần đầu đăng nhập cần đổi mật khẩu";
            this.Lblandau.Visible = false;
            // 
            // TbxXacNhanMk
            // 
            this.TbxXacNhanMk.Location = new System.Drawing.Point(45, 183);
            this.TbxXacNhanMk.Name = "TbxXacNhanMk";
            this.TbxXacNhanMk.Size = new System.Drawing.Size(217, 23);
            this.TbxXacNhanMk.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Xác nhận mật khẩu mới";
            // 
            // TbxMkMoi
            // 
            this.TbxMkMoi.Location = new System.Drawing.Point(45, 116);
            this.TbxMkMoi.Name = "TbxMkMoi";
            this.TbxMkMoi.Size = new System.Drawing.Size(217, 23);
            this.TbxMkMoi.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mật khẩu mới";
            // 
            // BtnDoiMk
            // 
            this.BtnDoiMk.Location = new System.Drawing.Point(45, 234);
            this.BtnDoiMk.Name = "BtnDoiMk";
            this.BtnDoiMk.Size = new System.Drawing.Size(93, 23);
            this.BtnDoiMk.TabIndex = 7;
            this.BtnDoiMk.Text = "Đổi mật khẩu";
            this.BtnDoiMk.UseVisualStyleBackColor = true;
            this.BtnDoiMk.Click += new System.EventHandler(this.BtnDoiMk_Click);
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(164, 234);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(98, 23);
            this.BtnThoat.TabIndex = 8;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // FormDoiMk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 272);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.BtnDoiMk);
            this.Controls.Add(this.TbxMkMoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbxXacNhanMk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lblandau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDoiMk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDoiMk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Lblandau;
        private TextBox TbxXacNhanMk;
        private Label label3;
        private TextBox TbxMkMoi;
        private Label label4;
        private Button BtnDoiMk;
        private Button BtnThoat;
    }
}