namespace WindowsFormsApp1
{
    partial class frmTest
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
            this.lblKetQua = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnHieu = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKetQua
            // 
            this.lblKetQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblKetQua.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKetQua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblKetQua.Location = new System.Drawing.Point(0, 0);
            this.lblKetQua.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(842, 91);
            this.lblKetQua.TabIndex = 0;
            this.lblKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblA
            // 
            this.lblA.Location = new System.Drawing.Point(14, 112);
            this.lblA.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(194, 32);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "Số nguyên a: ";
            // 
            // lblB
            // 
            this.lblB.Location = new System.Drawing.Point(14, 169);
            this.lblB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(194, 32);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "Số nguyên b:";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(249, 166);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(560, 39);
            this.txtB.TabIndex = 4;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(249, 109);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(560, 39);
            this.txtA.TabIndex = 3;
            // 
            // btnTong
            // 
            this.btnTong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTong.Location = new System.Drawing.Point(20, 270);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(208, 71);
            this.btnTong.TabIndex = 5;
            this.btnTong.Text = "&Tổng";
            this.btnTong.UseVisualStyleBackColor = false;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnHieu
            // 
            this.btnHieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHieu.Location = new System.Drawing.Point(313, 270);
            this.btnHieu.Name = "btnHieu";
            this.btnHieu.Size = new System.Drawing.Size(208, 71);
            this.btnHieu.TabIndex = 6;
            this.btnHieu.Text = "&Hiệu";
            this.btnHieu.UseVisualStyleBackColor = false;
            this.btnHieu.Click += new System.EventHandler(this.btnHieu_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReset.Location = new System.Drawing.Point(601, 270);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(208, 71);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(313, 379);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(208, 71);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(842, 480);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnHieu);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblKetQua);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính Tổng - Hiệu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnHieu;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThoat;
    }
}

