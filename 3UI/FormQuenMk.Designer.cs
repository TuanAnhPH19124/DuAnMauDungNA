namespace _3UI
{
    partial class FormQuenMk
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
            this.label2 = new System.Windows.Forms.Label();
            this.TbxEmail = new System.Windows.Forms.TextBox();
            this.TbxMaNv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnXacNhan = new System.Windows.Forms.Button();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quên mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // TbxEmail
            // 
            this.TbxEmail.Location = new System.Drawing.Point(79, 103);
            this.TbxEmail.Name = "TbxEmail";
            this.TbxEmail.Size = new System.Drawing.Size(225, 23);
            this.TbxEmail.TabIndex = 2;
            // 
            // TbxMaNv
            // 
            this.TbxMaNv.Location = new System.Drawing.Point(79, 167);
            this.TbxMaNv.Name = "TbxMaNv";
            this.TbxMaNv.Size = new System.Drawing.Size(225, 23);
            this.TbxMaNv.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã nhân viên";
            // 
            // BtnXacNhan
            // 
            this.BtnXacNhan.Location = new System.Drawing.Point(102, 229);
            this.BtnXacNhan.Name = "BtnXacNhan";
            this.BtnXacNhan.Size = new System.Drawing.Size(75, 23);
            this.BtnXacNhan.TabIndex = 5;
            this.BtnXacNhan.Text = "Xác nhận";
            this.BtnXacNhan.UseVisualStyleBackColor = true;
            this.BtnXacNhan.Click += new System.EventHandler(this.BtnXacNhan_Click);
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(198, 229);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(75, 23);
            this.BtnThoat.TabIndex = 6;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.UseVisualStyleBackColor = true;
            // 
            // FormQuenMk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 284);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.BtnXacNhan);
            this.Controls.Add(this.TbxMaNv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbxEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuenMk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuenMk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TbxEmail;
        private TextBox TbxMaNv;
        private Label label3;
        private Button BtnXacNhan;
        private Button BtnThoat;
    }
}