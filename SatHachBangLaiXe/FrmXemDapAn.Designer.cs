namespace SatHachBangLaiXe
{
    partial class FrmXemDapAn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sATHACHBANGLAI1DataSet = new SatHachBangLaiXe.SATHACHBANGLAI1DataSet();
            this.xemDapAnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xem_Dap_AnTableAdapter = new SatHachBangLaiXe.SATHACHBANGLAI1DataSetTableAdapters.Xem_Dap_AnTableAdapter();
            this.sATHACHBANGLAI1DataSet1 = new SatHachBangLaiXe.SATHACHBANGLAI1DataSet1();
            this.xemDapAnBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.xem_Dap_AnTableAdapter1 = new SatHachBangLaiXe.SATHACHBANGLAI1DataSet1TableAdapters.Xem_Dap_AnTableAdapter();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.btnThoatThongKe = new MetroFramework.Controls.MetroButton();
            this.sATHACHBANGLAI1DataSet4 = new SatHachBangLaiXe.SATHACHBANGLAI1DataSet4();
            this.xemDapAnSaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xem_Dap_An_SaiTableAdapter = new SatHachBangLaiXe.SATHACHBANGLAI1DataSet4TableAdapters.Xem_Dap_An_SaiTableAdapter();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.sTTCauHoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dapAnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTTCauHoiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dapAnDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbCauDung = new MetroFramework.Controls.MetroLabel();
            this.lbCauSai = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.sATHACHBANGLAI1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xemDapAnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sATHACHBANGLAI1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xemDapAnBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sATHACHBANGLAI1DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xemDapAnSaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // sATHACHBANGLAI1DataSet
            // 
            this.sATHACHBANGLAI1DataSet.DataSetName = "SATHACHBANGLAI1DataSet";
            this.sATHACHBANGLAI1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xemDapAnBindingSource
            // 
            this.xemDapAnBindingSource.DataMember = "Xem_Dap_An";
            this.xemDapAnBindingSource.DataSource = this.sATHACHBANGLAI1DataSet;
            // 
            // xem_Dap_AnTableAdapter
            // 
            this.xem_Dap_AnTableAdapter.ClearBeforeFill = true;
            // 
            // sATHACHBANGLAI1DataSet1
            // 
            this.sATHACHBANGLAI1DataSet1.DataSetName = "SATHACHBANGLAI1DataSet1";
            this.sATHACHBANGLAI1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xemDapAnBindingSource1
            // 
            this.xemDapAnBindingSource1.DataMember = "Xem_Dap_An";
            this.xemDapAnBindingSource1.DataSource = this.sATHACHBANGLAI1DataSet1;
            // 
            // xem_Dap_AnTableAdapter1
            // 
            this.xem_Dap_AnTableAdapter1.ClearBeforeFill = true;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTCauHoiDataGridViewTextBoxColumn,
            this.dapAnDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.xemDapAnSaiBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle8;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.metroGrid1.Location = new System.Drawing.Point(23, 81);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(390, 350);
            this.metroGrid1.TabIndex = 1;
            this.metroGrid1.UseCustomBackColor = true;
            this.metroGrid1.UseCustomForeColor = true;
            // 
            // btnThoatThongKe
            // 
            this.btnThoatThongKe.Location = new System.Drawing.Point(731, 6);
            this.btnThoatThongKe.Name = "btnThoatThongKe";
            this.btnThoatThongKe.Size = new System.Drawing.Size(80, 33);
            this.btnThoatThongKe.TabIndex = 2;
            this.btnThoatThongKe.Text = "Thoát";
            this.btnThoatThongKe.UseSelectable = true;
            this.btnThoatThongKe.Click += new System.EventHandler(this.btnThoatThongKe_Click);
            // 
            // sATHACHBANGLAI1DataSet4
            // 
            this.sATHACHBANGLAI1DataSet4.DataSetName = "SATHACHBANGLAI1DataSet4";
            this.sATHACHBANGLAI1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xemDapAnSaiBindingSource
            // 
            this.xemDapAnSaiBindingSource.DataMember = "Xem_Dap_An_Sai";
            this.xemDapAnSaiBindingSource.DataSource = this.sATHACHBANGLAI1DataSet4;
            // 
            // xem_Dap_An_SaiTableAdapter
            // 
            this.xem_Dap_An_SaiTableAdapter.ClearBeforeFill = true;
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.AutoGenerateColumns = false;
            this.metroGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.metroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTCauHoiDataGridViewTextBoxColumn1,
            this.dapAnDataGridViewTextBoxColumn1});
            this.metroGrid2.DataSource = this.xemDapAnBindingSource1;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle11;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.metroGrid2.Location = new System.Drawing.Point(428, 81);
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(362, 350);
            this.metroGrid2.TabIndex = 1;
            this.metroGrid2.UseCustomBackColor = true;
            this.metroGrid2.UseCustomForeColor = true;
            // 
            // metroLink1
            // 
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink1.ForeColor = System.Drawing.Color.Teal;
            this.metroLink1.Location = new System.Drawing.Point(52, 52);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(122, 23);
            this.metroLink1.TabIndex = 3;
            this.metroLink1.Text = "Câu Làm Đúng";
            this.metroLink1.UseCustomForeColor = true;
            this.metroLink1.UseSelectable = true;
            // 
            // metroLink2
            // 
            this.metroLink2.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink2.ForeColor = System.Drawing.Color.Teal;
            this.metroLink2.Location = new System.Drawing.Point(447, 52);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(122, 23);
            this.metroLink2.TabIndex = 3;
            this.metroLink2.Text = "Câu Làm Sai";
            this.metroLink2.UseCustomForeColor = true;
            this.metroLink2.UseSelectable = true;
            // 
            // sTTCauHoiDataGridViewTextBoxColumn
            // 
            this.sTTCauHoiDataGridViewTextBoxColumn.DataPropertyName = "STTCauHoi";
            this.sTTCauHoiDataGridViewTextBoxColumn.HeaderText = "Câu Hỏi";
            this.sTTCauHoiDataGridViewTextBoxColumn.Name = "sTTCauHoiDataGridViewTextBoxColumn";
            // 
            // dapAnDataGridViewTextBoxColumn
            // 
            this.dapAnDataGridViewTextBoxColumn.DataPropertyName = "DapAn";
            this.dapAnDataGridViewTextBoxColumn.HeaderText = "Đáp Án";
            this.dapAnDataGridViewTextBoxColumn.Name = "dapAnDataGridViewTextBoxColumn";
            // 
            // sTTCauHoiDataGridViewTextBoxColumn1
            // 
            this.sTTCauHoiDataGridViewTextBoxColumn1.DataPropertyName = "STTCauHoi";
            this.sTTCauHoiDataGridViewTextBoxColumn1.HeaderText = "Câu Hỏi";
            this.sTTCauHoiDataGridViewTextBoxColumn1.Name = "sTTCauHoiDataGridViewTextBoxColumn1";
            // 
            // dapAnDataGridViewTextBoxColumn1
            // 
            this.dapAnDataGridViewTextBoxColumn1.DataPropertyName = "DapAn";
            this.dapAnDataGridViewTextBoxColumn1.HeaderText = "Đáp Án";
            this.dapAnDataGridViewTextBoxColumn1.Name = "dapAnDataGridViewTextBoxColumn1";
            // 
            // lbCauDung
            // 
            this.lbCauDung.AutoSize = true;
            this.lbCauDung.Location = new System.Drawing.Point(167, 52);
            this.lbCauDung.Name = "lbCauDung";
            this.lbCauDung.Size = new System.Drawing.Size(45, 19);
            this.lbCauDung.TabIndex = 4;
            this.lbCauDung.Text = "mmm";
            // 
            // lbCauSai
            // 
            this.lbCauSai.AutoSize = true;
            this.lbCauSai.Location = new System.Drawing.Point(558, 52);
            this.lbCauSai.Name = "lbCauSai";
            this.lbCauSai.Size = new System.Drawing.Size(45, 19);
            this.lbCauSai.TabIndex = 4;
            this.lbCauSai.Text = "mmm";
            // 
            // FrmXemDapAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 454);
            this.Controls.Add(this.lbCauSai);
            this.Controls.Add(this.lbCauDung);
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.btnThoatThongKe);
            this.Controls.Add(this.metroGrid2);
            this.Controls.Add(this.metroGrid1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmXemDapAn";
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.FrmXemDapAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sATHACHBANGLAI1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xemDapAnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sATHACHBANGLAI1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xemDapAnBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sATHACHBANGLAI1DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xemDapAnSaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SATHACHBANGLAI1DataSet sATHACHBANGLAI1DataSet;
        private System.Windows.Forms.BindingSource xemDapAnBindingSource;
        private SATHACHBANGLAI1DataSetTableAdapters.Xem_Dap_AnTableAdapter xem_Dap_AnTableAdapter;
        private SATHACHBANGLAI1DataSet1 sATHACHBANGLAI1DataSet1;
        private System.Windows.Forms.BindingSource xemDapAnBindingSource1;
        private SATHACHBANGLAI1DataSet1TableAdapters.Xem_Dap_AnTableAdapter xem_Dap_AnTableAdapter1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroButton btnThoatThongKe;
        private SATHACHBANGLAI1DataSet4 sATHACHBANGLAI1DataSet4;
        private System.Windows.Forms.BindingSource xemDapAnSaiBindingSource;
        private SATHACHBANGLAI1DataSet4TableAdapters.Xem_Dap_An_SaiTableAdapter xem_Dap_An_SaiTableAdapter;
        private MetroFramework.Controls.MetroGrid metroGrid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTCauHoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dapAnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTCauHoiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dapAnDataGridViewTextBoxColumn1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroLabel lbCauDung;
        private MetroFramework.Controls.MetroLabel lbCauSai;
    }
}