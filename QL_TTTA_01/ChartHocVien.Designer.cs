namespace QL_TTTA_01
{
    partial class ChartHocVien
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbMaKhoa = new Bunifu.UI.WinForms.BunifuDropdown();
            this.button1 = new System.Windows.Forms.Button();
            this.ChartDiemSo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDiemSo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbbMaKhoa);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 49);
            this.panel1.TabIndex = 3;
            // 
            // cbbMaKhoa
            // 
            this.cbbMaKhoa.BackColor = System.Drawing.Color.Transparent;
            this.cbbMaKhoa.BackgroundColor = System.Drawing.Color.White;
            this.cbbMaKhoa.BorderColor = System.Drawing.Color.Silver;
            this.cbbMaKhoa.BorderRadius = 1;
            this.cbbMaKhoa.Color = System.Drawing.Color.Silver;
            this.cbbMaKhoa.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbbMaKhoa.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbbMaKhoa.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbbMaKhoa.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbbMaKhoa.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbbMaKhoa.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbbMaKhoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbbMaKhoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbMaKhoa.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbbMaKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaKhoa.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbbMaKhoa.FillDropDown = true;
            this.cbbMaKhoa.FillIndicator = false;
            this.cbbMaKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbMaKhoa.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.cbbMaKhoa.ForeColor = System.Drawing.Color.Black;
            this.cbbMaKhoa.FormattingEnabled = true;
            this.cbbMaKhoa.Icon = null;
            this.cbbMaKhoa.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbbMaKhoa.IndicatorColor = System.Drawing.Color.Gray;
            this.cbbMaKhoa.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbbMaKhoa.ItemBackColor = System.Drawing.Color.White;
            this.cbbMaKhoa.ItemBorderColor = System.Drawing.Color.White;
            this.cbbMaKhoa.ItemForeColor = System.Drawing.Color.Black;
            this.cbbMaKhoa.ItemHeight = 34;
            this.cbbMaKhoa.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cbbMaKhoa.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbbMaKhoa.ItemTopMargin = 3;
            this.cbbMaKhoa.Location = new System.Drawing.Point(0, 0);
            this.cbbMaKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbMaKhoa.Name = "cbbMaKhoa";
            this.cbbMaKhoa.Size = new System.Drawing.Size(189, 40);
            this.cbbMaKhoa.TabIndex = 5;
            this.cbbMaKhoa.Text = null;
            this.cbbMaKhoa.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbbMaKhoa.TextLeftMargin = 5;
            this.cbbMaKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbMaKhoa_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(254)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::QL_TTTA_01.Properties.Resources.log_out__2_xanh32px;
            this.button1.Location = new System.Drawing.Point(1033, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 49);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChartDiemSo
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartDiemSo.ChartAreas.Add(chartArea1);
            this.ChartDiemSo.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.ChartDiemSo.Legends.Add(legend1);
            this.ChartDiemSo.Location = new System.Drawing.Point(0, 49);
            this.ChartDiemSo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChartDiemSo.Name = "ChartDiemSo";
            this.ChartDiemSo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Số lượng học sinh đạt được";
            this.ChartDiemSo.Series.Add(series1);
            this.ChartDiemSo.Size = new System.Drawing.Size(1133, 653);
            this.ChartDiemSo.TabIndex = 4;
            this.ChartDiemSo.Text = "ChartDiemSo";
            title1.BackColor = System.Drawing.Color.White;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.Blue;
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.MintCream;
            title1.ShadowOffset = 1;
            title1.Text = "Thống kê điểm học viên";
            title1.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            this.ChartDiemSo.Titles.Add(title1);
            // 
            // ChartHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 702);
            this.Controls.Add(this.ChartDiemSo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChartHocVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChartHocVien";
            this.Load += new System.EventHandler(this.ChartHocVien_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartDiemSo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private Bunifu.UI.WinForms.BunifuDropdown cbbMaKhoa;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartDiemSo;
    }
}