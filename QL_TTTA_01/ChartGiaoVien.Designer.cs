namespace QL_TTTA_01
{
    partial class ChartGiaoVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartGiaoVien));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuChartCanvas1 = new Bunifu.Charts.WinForms.BunifuChartCanvas();
            this.DoughnutChartGiaoVien = new Bunifu.Charts.WinForms.ChartTypes.BunifuDoughnutChart(this.components);
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtNumMax = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtNumMin = new Bunifu.UI.WinForms.BunifuTextBox();
            this.SuspendLayout();
            // 
            // bunifuChartCanvas1
            // 
            this.bunifuChartCanvas1.AnimationDuration = 2000;
            this.bunifuChartCanvas1.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart;
            this.bunifuChartCanvas1.BackColor = System.Drawing.Color.White;
            this.bunifuChartCanvas1.CanvasPadding = new System.Windows.Forms.Padding(0);
            this.bunifuChartCanvas1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuChartCanvas1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuChartCanvas1.Labels = new string[0];
            this.bunifuChartCanvas1.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.start;
            this.bunifuChartCanvas1.LegendDisplay = true;
            this.bunifuChartCanvas1.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuChartCanvas1.LegendForeColor = System.Drawing.Color.DarkGray;
            this.bunifuChartCanvas1.LegendFullWidth = false;
            this.bunifuChartCanvas1.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.left;
            this.bunifuChartCanvas1.LegendRevese = true;
            this.bunifuChartCanvas1.LegendRTL = true;
            this.bunifuChartCanvas1.Location = new System.Drawing.Point(0, 59);
            this.bunifuChartCanvas1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuChartCanvas1.Name = "bunifuChartCanvas1";
            this.bunifuChartCanvas1.ShowXAxis = false;
            this.bunifuChartCanvas1.ShowYAxis = false;
            this.bunifuChartCanvas1.Size = new System.Drawing.Size(834, 452);
            this.bunifuChartCanvas1.TabIndex = 25;
            this.bunifuChartCanvas1.Title = "";
            this.bunifuChartCanvas1.TitleLineHeight = 1.2D;
            this.bunifuChartCanvas1.TitlePadding = 10;
            this.bunifuChartCanvas1.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.bunifuChartCanvas1.TooltipBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.TooltipFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuChartCanvas1.TooltipForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuChartCanvas1.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest;
            this.bunifuChartCanvas1.TooltipsEnabled = true;
            this.bunifuChartCanvas1.XAxesBeginAtZero = true;
            this.bunifuChartCanvas1.XAxesDrawTicks = true;
            this.bunifuChartCanvas1.XAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.XAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas1.XAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.XAxesGridLines = false;
            this.bunifuChartCanvas1.XAxesLabel = "";
            this.bunifuChartCanvas1.XAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.XAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas1.XAxesLineWidth = 1;
            this.bunifuChartCanvas1.XAxesStacked = false;
            this.bunifuChartCanvas1.XAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.XAxesZeroLineWidth = 1;
            this.bunifuChartCanvas1.YAxesBeginAtZero = true;
            this.bunifuChartCanvas1.YAxesDrawTicks = true;
            this.bunifuChartCanvas1.YAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.YAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas1.YAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.YAxesGridLines = false;
            this.bunifuChartCanvas1.YAxesLabel = "";
            this.bunifuChartCanvas1.YAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.YAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas1.YAxesLineWidth = 1;
            this.bunifuChartCanvas1.YAxesStacked = false;
            this.bunifuChartCanvas1.YAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.YAxesZeroLineWidth = 1;
            this.bunifuChartCanvas1.Load += new System.EventHandler(this.bunifuChartCanvas1_Load);
            // 
            // DoughnutChartGiaoVien
            // 
            this.DoughnutChartGiaoVien.BackgroundColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("DoughnutChartGiaoVien.BackgroundColor")));
            this.DoughnutChartGiaoVien.BorderColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("DoughnutChartGiaoVien.BorderColor")));
            this.DoughnutChartGiaoVien.BorderWidth = 0;
            this.DoughnutChartGiaoVien.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("DoughnutChartGiaoVien.Data")));
            this.DoughnutChartGiaoVien.HoverBackgroundColor = System.Drawing.Color.Empty;
            this.DoughnutChartGiaoVien.HoverBorderColor = System.Drawing.Color.Empty;
            this.DoughnutChartGiaoVien.HoverBorderWidth = 0;
            this.DoughnutChartGiaoVien.Label = "";
            this.DoughnutChartGiaoVien.TargetCanvas = this.bunifuChartCanvas1;
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = false;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.Gold;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Exit";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges1;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.White;
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.Gold;
            this.bunifuButton1.IdleBorderRadius = 30;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.Gold;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(636, 4);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.OnDisabledState.BorderRadius = 30;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.BorderRadius = 30;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.Gold;
            this.bunifuButton1.OnIdleState.BorderRadius = 30;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.Gold;
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.BorderRadius = 30;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(92, 31);
            this.bunifuButton1.TabIndex = 30;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // txtNumMax
            // 
            this.txtNumMax.AcceptsReturn = false;
            this.txtNumMax.AcceptsTab = false;
            this.txtNumMax.AnimationSpeed = 200;
            this.txtNumMax.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNumMax.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNumMax.BackColor = System.Drawing.Color.Transparent;
            this.txtNumMax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNumMax.BackgroundImage")));
            this.txtNumMax.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtNumMax.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNumMax.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtNumMax.BorderColorIdle = System.Drawing.Color.White;
            this.txtNumMax.BorderRadius = 1;
            this.txtNumMax.BorderThickness = 0;
            this.txtNumMax.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNumMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumMax.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumMax.DefaultText = "10";
            this.txtNumMax.FillColor = System.Drawing.Color.White;
            this.txtNumMax.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtNumMax.HideSelection = true;
            this.txtNumMax.IconLeft = null;
            this.txtNumMax.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumMax.IconPadding = 10;
            this.txtNumMax.IconRight = null;
            this.txtNumMax.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumMax.Lines = new string[] {
        "10"};
            this.txtNumMax.Location = new System.Drawing.Point(414, 8);
            this.txtNumMax.MaxLength = 32767;
            this.txtNumMax.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNumMax.Modified = false;
            this.txtNumMax.Multiline = false;
            this.txtNumMax.Name = "txtNumMax";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNumMax.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNumMax.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNumMax.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.White;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.DodgerBlue;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNumMax.OnIdleState = stateProperties4;
            this.txtNumMax.Padding = new System.Windows.Forms.Padding(3);
            this.txtNumMax.PasswordChar = '\0';
            this.txtNumMax.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtNumMax.PlaceholderText = "Enter number";
            this.txtNumMax.ReadOnly = false;
            this.txtNumMax.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumMax.SelectedText = "";
            this.txtNumMax.SelectionLength = 0;
            this.txtNumMax.SelectionStart = 0;
            this.txtNumMax.ShortcutsEnabled = true;
            this.txtNumMax.Size = new System.Drawing.Size(66, 25);
            this.txtNumMax.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtNumMax.TabIndex = 29;
            this.txtNumMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumMax.TextMarginBottom = 0;
            this.txtNumMax.TextMarginLeft = 0;
            this.txtNumMax.TextMarginTop = 0;
            this.txtNumMax.TextPlaceholder = "Enter number";
            this.txtNumMax.UseSystemPasswordChar = false;
            this.txtNumMax.WordWrap = true;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuLabel2.Location = new System.Drawing.Point(380, 8);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(33, 25);
            this.bunifuLabel2.TabIndex = 28;
            this.bunifuLabel2.Text = "đến";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuLabel1.Location = new System.Drawing.Point(40, 8);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(306, 25);
            this.bunifuLabel1.TabIndex = 27;
            this.bunifuLabel1.Text = "Tổng số lượng học sinh đạt điểm từ ";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtNumMin
            // 
            this.txtNumMin.AcceptsReturn = false;
            this.txtNumMin.AcceptsTab = false;
            this.txtNumMin.AnimationSpeed = 200;
            this.txtNumMin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNumMin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNumMin.BackColor = System.Drawing.Color.Transparent;
            this.txtNumMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNumMin.BackgroundImage")));
            this.txtNumMin.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtNumMin.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNumMin.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtNumMin.BorderColorIdle = System.Drawing.Color.White;
            this.txtNumMin.BorderRadius = 1;
            this.txtNumMin.BorderThickness = 0;
            this.txtNumMin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNumMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumMin.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumMin.DefaultText = "5";
            this.txtNumMin.FillColor = System.Drawing.Color.White;
            this.txtNumMin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtNumMin.HideSelection = true;
            this.txtNumMin.IconLeft = null;
            this.txtNumMin.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumMin.IconPadding = 10;
            this.txtNumMin.IconRight = null;
            this.txtNumMin.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumMin.Lines = new string[] {
        "5"};
            this.txtNumMin.Location = new System.Drawing.Point(349, 8);
            this.txtNumMin.MaxLength = 32767;
            this.txtNumMin.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNumMin.Modified = false;
            this.txtNumMin.Multiline = false;
            this.txtNumMin.Name = "txtNumMin";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNumMin.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNumMin.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNumMin.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.White;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.DodgerBlue;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNumMin.OnIdleState = stateProperties8;
            this.txtNumMin.Padding = new System.Windows.Forms.Padding(3);
            this.txtNumMin.PasswordChar = '\0';
            this.txtNumMin.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtNumMin.PlaceholderText = "Enter number";
            this.txtNumMin.ReadOnly = false;
            this.txtNumMin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumMin.SelectedText = "";
            this.txtNumMin.SelectionLength = 0;
            this.txtNumMin.SelectionStart = 0;
            this.txtNumMin.ShortcutsEnabled = true;
            this.txtNumMin.Size = new System.Drawing.Size(66, 25);
            this.txtNumMin.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtNumMin.TabIndex = 26;
            this.txtNumMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumMin.TextMarginBottom = 0;
            this.txtNumMin.TextMarginLeft = 0;
            this.txtNumMin.TextMarginTop = 0;
            this.txtNumMin.TextPlaceholder = "Enter number";
            this.txtNumMin.UseSystemPasswordChar = false;
            this.txtNumMin.WordWrap = true;
            // 
            // ChartGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.bunifuChartCanvas1);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.txtNumMax);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.txtNumMin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChartGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChartGiaoVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Charts.WinForms.BunifuChartCanvas bunifuChartCanvas1;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuDoughnutChart DoughnutChartGiaoVien;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuTextBox txtNumMax;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuTextBox txtNumMin;
    }
}