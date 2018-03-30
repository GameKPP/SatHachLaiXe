using System.Windows.Forms;

namespace SatHachBangLaiXe
{
    partial class FrmThi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThi));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnChamDiem1 = new DevExpress.XtraEditors.SimpleButton();
            this.lbSatHachBangLai = new System.Windows.Forms.Label();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pn_DeThi = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lbMaDe = new MetroFramework.Controls.MetroLabel();
            this.lbmade1 = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbCauHoi = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(39, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(924, 401);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.btnThoat1);
            this.panel1.Controls.Add(this.btnChamDiem1);
            this.panel1.Controls.Add(this.lbSatHachBangLai);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(19, 515);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 208);
            this.panel1.TabIndex = 1;
            // 
            // btnThoat1
            // 
            this.btnThoat1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnThoat1.Appearance.Options.UseFont = true;
            this.btnThoat1.Appearance.Options.UseForeColor = true;
            this.btnThoat1.Location = new System.Drawing.Point(645, 145);
            this.btnThoat1.Name = "btnThoat1";
            this.btnThoat1.Size = new System.Drawing.Size(254, 36);
            this.btnThoat1.TabIndex = 334;
            this.btnThoat1.Text = "THOÁT";
            this.btnThoat1.Click += new System.EventHandler(this.btnThoat1_Click);
            // 
            // btnChamDiem1
            // 
            this.btnChamDiem1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnChamDiem1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnChamDiem1.Appearance.Options.UseFont = true;
            this.btnChamDiem1.Appearance.Options.UseForeColor = true;
            this.btnChamDiem1.Location = new System.Drawing.Point(346, 145);
            this.btnChamDiem1.Name = "btnChamDiem1";
            this.btnChamDiem1.Size = new System.Drawing.Size(254, 36);
            this.btnChamDiem1.TabIndex = 334;
            this.btnChamDiem1.Text = "CHẤM ĐIỂM";
            this.btnChamDiem1.Click += new System.EventHandler(this.btnChamDiem1_Click);
            // 
            // lbSatHachBangLai
            // 
            this.lbSatHachBangLai.AutoSize = true;
            this.lbSatHachBangLai.BackColor = System.Drawing.Color.MintCream;
            this.lbSatHachBangLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSatHachBangLai.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbSatHachBangLai.Location = new System.Drawing.Point(340, 60);
            this.lbSatHachBangLai.Name = "lbSatHachBangLai";
            this.lbSatHachBangLai.Size = new System.Drawing.Size(589, 35);
            this.lbSatHachBangLai.TabIndex = 5;
            this.lbSatHachBangLai.Text = "       Thi Sát Hạch Bằng Lái Trực Tuyến      ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.MintCream;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.OrangeRed;
            this.metroLabel2.Location = new System.Drawing.Point(346, 74);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(0, 0);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.Orange;
            this.metroLabel1.Location = new System.Drawing.Point(25, 6);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(173, 19);
            this.metroLabel1.TabIndex = 111;
            this.metroLabel1.Text = "THÔNG TIN BẢN QUYỀN";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(282, 164);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(19, 489);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(944, 23);
            this.metroProgressBar1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pn_DeThi);
            this.panel2.Location = new System.Drawing.Point(975, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 720);
            this.panel2.TabIndex = 3;
            // 
            // pn_DeThi
            // 
            this.pn_DeThi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_DeThi.Location = new System.Drawing.Point(17, 11);
            this.pn_DeThi.Name = "pn_DeThi";
            this.pn_DeThi.Size = new System.Drawing.Size(247, 706);
            this.pn_DeThi.TabIndex = 1;
            this.pn_DeThi.Click += new System.EventHandler(this.pn_DeThi_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLink1.Location = new System.Drawing.Point(-4, 3);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(448, 23);
            this.metroLink1.TabIndex = 4;
            this.metroLink1.Text = "Phần thi kết thúc sau khi hết thời gian hoặc khi thí sinh nhất nút \'Kết Thúc\' ";
            this.metroLink1.UseCustomBackColor = true;
            this.metroLink1.UseCustomForeColor = true;
            this.metroLink1.UseSelectable = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Controls.Add(this.metroLink1);
            this.panel3.Location = new System.Drawing.Point(19, 734);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(944, 26);
            this.panel3.TabIndex = 4;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(790, 32);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "MÃ ĐỀ: ";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.UseStyleColors = true;
            // 
            // lbMaDe
            // 
            this.lbMaDe.AutoSize = true;
            this.lbMaDe.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbMaDe.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbMaDe.Location = new System.Drawing.Point(960, 32);
            this.lbMaDe.Name = "lbMaDe";
            this.lbMaDe.Size = new System.Drawing.Size(0, 0);
            this.lbMaDe.Style = MetroFramework.MetroColorStyle.Red;
            this.lbMaDe.TabIndex = 8;
            this.lbMaDe.UseCustomBackColor = true;
            this.lbMaDe.UseCustomForeColor = true;
            this.lbMaDe.UseStyleColors = true;
            // 
            // lbmade1
            // 
            this.lbmade1.AutoSize = true;
            this.lbmade1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbmade1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbmade1.Location = new System.Drawing.Point(847, 27);
            this.lbmade1.Name = "lbmade1";
            this.lbmade1.Size = new System.Drawing.Size(0, 0);
            this.lbmade1.Style = MetroFramework.MetroColorStyle.Blue;
            this.lbmade1.TabIndex = 7;
            this.lbmade1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbmade1.UseCustomBackColor = true;
            this.lbmade1.UseCustomForeColor = true;
            this.lbmade1.UseStyleColors = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbCauHoi
            // 
            this.lbCauHoi.AutoSize = true;
            this.lbCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCauHoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbCauHoi.Location = new System.Drawing.Point(989, 24);
            this.lbCauHoi.Name = "lbCauHoi";
            this.lbCauHoi.Size = new System.Drawing.Size(0, 17);
            this.lbCauHoi.TabIndex = 9;
            // 
            // timer2
            // 
            this.timer2.Interval = 12000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(23, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tổng Thời Gian 20 Phút:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // FrmThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 773);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCauHoi);
            this.Controls.Add(this.lbMaDe);
            this.Controls.Add(this.lbmade1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmThi";
            this.Text = "Thi Sát Hạch Bằng Lái";
            this.Load += new System.EventHandler(this.FrmThi_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Anserkey);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyup11);
            this.ParentChanged += new System.EventHandler(this.FrmThi_ParentChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FrmPhieuTraLoi ptl;

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel pn_DeThi;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lbMaDe;
        private MetroFramework.Controls.MetroLabel lbmade1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbSatHachBangLai;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private Label lbCauHoi;
        private Timer timer2;
        private Label label1;
        private DevExpress.XtraEditors.SimpleButton btnChamDiem1;
        private DevExpress.XtraEditors.SimpleButton btnThoat1;
        private Label label2;
    }
}