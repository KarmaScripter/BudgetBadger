namespace BudgetExecution
{
    partial class ChartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartForm));
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.CloseBox = new BudgetExecution.ClosePanel();
            this.HeaderLabel = new BudgetExecution.LabelPanel();
            this.PictureBox = new BudgetExecution.PicturePanel();
            this.Chart = new BudgetExecution.BudgetChartControl();
            this.BudgetBinding = new BudgetExecution.BudgetBinding();
            this.Navigator = new BudgetExecution.ToolPanel();
            this.Separator1 = new BudgetExecution.ToolSeparator();
            this.BarLabel = new BudgetExecution.BarLabel();
            this.ToolTip = new BudgetExecution.ToolTip();
            this.Separator2 = new BudgetExecution.ToolSeparator();
            this.FirstButton = new BudgetExecution.BarButton();
            this.Separator3 = new BudgetExecution.ToolSeparator();
            this.PreviousButton = new BudgetExecution.BarButton();
            this.Separator4 = new BudgetExecution.ToolSeparator();
            this.TextBox = new BudgetExecution.BarTextBox();
            this.Separator5 = new BudgetExecution.ToolSeparator();
            this.NextButton = new BudgetExecution.BarButton();
            this.Separator6 = new BudgetExecution.ToolSeparator();
            this.LastButton = new BudgetExecution.BarButton();
            this.Separator7 = new BudgetExecution.ToolSeparator();
            this.CalculatorButton = new BudgetExecution.BarButton();
            this.Separator8 = new BudgetExecution.ToolSeparator();
            this.BrowseButton = new BudgetExecution.BarButton();
            this.Separator9 = new BudgetExecution.ToolSeparator();
            this.PrintButton = new BudgetExecution.BarButton();
            this.Separator10 = new BudgetExecution.ToolSeparator();
            this.ExcelButton = new BudgetExecution.BarButton();
            this.Separator12 = new BudgetExecution.ToolSeparator();
            this.ComboBox = new BudgetExecution.BarComboBox();
            this.Separator11 = new BudgetExecution.ToolSeparator();
            this.Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).BeginInit();
            this.Navigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.Table.ColumnCount = 4;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.81076F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.18924F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 226F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.Table.Controls.Add(this.CloseBox, 3, 0);
            this.Table.Controls.Add(this.HeaderLabel, 1, 0);
            this.Table.Controls.Add(this.PictureBox, 0, 0);
            this.Table.Dock = System.Windows.Forms.DockStyle.Top;
            this.Table.Location = new System.Drawing.Point(0, 0);
            this.Table.Name = "Table";
            this.Table.RowCount = 1;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.Size = new System.Drawing.Size(945, 26);
            this.Table.TabIndex = 0;
            // 
            // CloseBox
            // 
            this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBox.CloseHoverBackColor = System.Drawing.Color.Red;
            this.CloseBox.CloseHoverForeColor = System.Drawing.Color.White;
            this.CloseBox.CloseNormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.CloseBox.DisabledForeColor = System.Drawing.Color.DimGray;
            this.CloseBox.Font = new System.Drawing.Font("Roboto", 8F);
            this.CloseBox.ForeColor = System.Drawing.Color.LightGray;
            this.CloseBox.Location = new System.Drawing.Point(845, 0);
            this.CloseBox.Margin = new System.Windows.Forms.Padding(0);
            this.CloseBox.MaximizeBox = true;
            this.CloseBox.MaximizeHoverBackColor = System.Drawing.Color.Blue;
            this.CloseBox.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.CloseBox.MaximizeNormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.CloseBox.MinimizeBox = true;
            this.CloseBox.MinimizeHoverBackColor = System.Drawing.Color.Blue;
            this.CloseBox.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.CloseBox.MinimizeNormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(100, 25);
            this.CloseBox.Style = MetroSet_UI.Design.Style.Custom;
            this.CloseBox.StyleManager = null;
            this.CloseBox.TabIndex = 0;
            this.CloseBox.Text = "closePanel1";
            this.CloseBox.ThemeAuthor = "Terry D. Eppler";
            this.CloseBox.ThemeName = "Budget Execution";
            this.CloseBox.ToolTip = null;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.HeaderLabel.BindingSource = null;
            this.HeaderLabel.DataFilter = null;
            this.HeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderLabel.Field = BudgetExecution.Field.NS;
            this.HeaderLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.LightGray;
            this.HeaderLabel.Location = new System.Drawing.Point(104, 3);
            this.HeaderLabel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Numeric = BudgetExecution.Numeric.NS;
            this.HeaderLabel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.HeaderLabel.Outline = false;
            this.HeaderLabel.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.HeaderLabel.OutlineLocation = new System.Drawing.Point(0, 0);
            this.HeaderLabel.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HeaderLabel.ReflectionSpacing = 0;
            this.HeaderLabel.ShadowColor = System.Drawing.Color.Black;
            this.HeaderLabel.ShadowDirection = 315;
            this.HeaderLabel.ShadowLocation = new System.Drawing.Point(0, 0);
            this.HeaderLabel.ShadowOpacity = 100;
            this.HeaderLabel.Size = new System.Drawing.Size(463, 20);
            this.HeaderLabel.TabIndex = 2;
            this.HeaderLabel.Text = "Title";
            this.HeaderLabel.TextAlignment = System.Drawing.StringAlignment.Near;
            this.HeaderLabel.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.HeaderLabel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.HeaderLabel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HeaderLabel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HeaderLabel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HeaderLabel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.HeaderLabel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.HeaderLabel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.HeaderLabel.ToolTip = null;
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox.BindingSource = null;
            this.PictureBox.DataFilter = null;
            this.PictureBox.Field = BudgetExecution.Field.NS;
            this.PictureBox.HoverText = null;
            this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
            this.PictureBox.ImageList = null;
            this.PictureBox.Location = new System.Drawing.Point(0, 0);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Padding = new System.Windows.Forms.Padding(1);
            this.PictureBox.Size = new System.Drawing.Size(46, 16);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 3;
            this.PictureBox.TabStop = false;
            this.PictureBox.ToolTip = null;
            // 
            // Chart
            // 
            this.Chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Chart.BindingSource = this.BudgetBinding;
            this.Chart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Chart.DataFilter = null;
            this.Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chart.Field = BudgetExecution.Field.NS;
            this.Chart.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart.ForeColor = System.Drawing.Color.LightGray;
            this.Chart.HoverText = null;
            this.Chart.Location = new System.Drawing.Point(0, 26);
            this.Chart.Name = "Chart";
            this.Chart.Numeric = BudgetExecution.Numeric.NS;
            this.Chart.Padding = new System.Windows.Forms.Padding(1);
            this.Chart.Size = new System.Drawing.Size(945, 583);
            this.Chart.TabIndex = 1;
            // 
            // BudgetBinding
            // 
            this.BudgetBinding.DataFilter = null;
            this.BudgetBinding.Numeric = BudgetExecution.Numeric.NS;
            // 
            // Navigator
            // 
            this.Navigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Navigator.BindingSource = this.BudgetBinding;
            this.Navigator.BorderStyle = Syncfusion.Windows.Forms.Tools.ToolStripBorderStyle.StaticEdge;
            this.Navigator.Buttons = null;
            this.Navigator.CaptionFont = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.Navigator.DataFilter = null;
            this.Navigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Navigator.Field = BudgetExecution.Field.NS;
            this.Navigator.Font = new System.Drawing.Font("Roboto", 8F);
            this.Navigator.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Navigator.Image = null;
            this.Navigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Separator1,
            this.BarLabel,
            this.Separator2,
            this.FirstButton,
            this.Separator3,
            this.PreviousButton,
            this.Separator4,
            this.TextBox,
            this.Separator5,
            this.NextButton,
            this.Separator6,
            this.LastButton,
            this.Separator7,
            this.CalculatorButton,
            this.Separator8,
            this.BrowseButton,
            this.Separator9,
            this.PrintButton,
            this.Separator10,
            this.ExcelButton,
            this.Separator12,
            this.ComboBox,
            this.Separator11});
            this.Navigator.Location = new System.Drawing.Point(0, 609);
            this.Navigator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.Navigator.Name = "Navigator";
            this.Navigator.Numeric = BudgetExecution.Numeric.NS;
            this.Navigator.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            this.Navigator.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.Navigator.ShowCaption = true;
            this.Navigator.Size = new System.Drawing.Size(945, 51);
            this.Navigator.TabIndex = 2;
            // 
            // Separator1
            // 
            this.Separator1.ForeColor = System.Drawing.Color.Black;
            this.Separator1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(6, 31);
            // 
            // BarLabel
            // 
            this.BarLabel.BindingSource = this.BudgetBinding;
            this.BarLabel.Field = BudgetExecution.Field.NS;
            this.BarLabel.Font = new System.Drawing.Font("Roboto", 8F);
            this.BarLabel.ForeColor = System.Drawing.Color.Black;
            this.BarLabel.HoverText = null;
            this.BarLabel.Margin = new System.Windows.Forms.Padding(5);
            this.BarLabel.Name = "Label";
            this.BarLabel.Size = new System.Drawing.Size(68, 21);
            this.BarLabel.Tag = "Label";
            this.BarLabel.Text = "Data Source";
            this.BarLabel.ToolTip = this.ToolTip;
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 5000;
            this.ToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ToolTip.BindingSource = null;
            this.ToolTip.BorderColor = System.Drawing.Color.Blue;
            this.ToolTip.ForeColor = System.Drawing.Color.LightGray;
            this.ToolTip.InitialDelay = 500;
            this.ToolTip.Name = null;
            this.ToolTip.OwnerDraw = true;
            this.ToolTip.ReshowDelay = 100;
            this.ToolTip.Style = MetroSet_UI.Design.Style.Custom;
            this.ToolTip.StyleManager = null;
            this.ToolTip.ThemeAuthor = "Terry D. Eppler";
            this.ToolTip.ThemeName = "Budget Execution";
            this.ToolTip.TipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTip.TipTitle = "";
            // 
            // Separator2
            // 
            this.Separator2.ForeColor = System.Drawing.Color.Black;
            this.Separator2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Separator2.Name = "Separator2";
            this.Separator2.Size = new System.Drawing.Size(6, 31);
            // 
            // FirstButton
            // 
            this.FirstButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.FirstButton.Bar = BudgetExecution.Tool.NS;
            this.FirstButton.BindingSource = this.BudgetBinding;
            this.FirstButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FirstButton.Field = BudgetExecution.Field.NS;
            this.FirstButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.FirstButton.ForeColor = System.Drawing.Color.LightGray;
            this.FirstButton.HoverText = null;
            this.FirstButton.Image = ((System.Drawing.Image)(resources.GetObject("FirstButton.Image")));
            this.FirstButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FirstButton.Margin = new System.Windows.Forms.Padding(5);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(23, 21);
            this.FirstButton.Text = "barButton1";
            this.FirstButton.ToolTip = this.ToolTip;
            // 
            // Separator3
            // 
            this.Separator3.ForeColor = System.Drawing.Color.Black;
            this.Separator3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Separator3.Name = "Separator3";
            this.Separator3.Size = new System.Drawing.Size(6, 31);
            // 
            // PreviousButton
            // 
            this.PreviousButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.PreviousButton.Bar = BudgetExecution.Tool.NS;
            this.PreviousButton.BindingSource = this.BudgetBinding;
            this.PreviousButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PreviousButton.Field = BudgetExecution.Field.NS;
            this.PreviousButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.PreviousButton.ForeColor = System.Drawing.Color.LightGray;
            this.PreviousButton.HoverText = null;
            this.PreviousButton.Image = ((System.Drawing.Image)(resources.GetObject("PreviousButton.Image")));
            this.PreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PreviousButton.Margin = new System.Windows.Forms.Padding(5);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(23, 21);
            this.PreviousButton.Text = "barButton2";
            this.PreviousButton.ToolTip = this.ToolTip;
            // 
            // Separator4
            // 
            this.Separator4.ForeColor = System.Drawing.Color.Black;
            this.Separator4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Separator4.Name = "Separator4";
            this.Separator4.Size = new System.Drawing.Size(6, 31);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox.BindingSource = this.BudgetBinding;
            this.TextBox.Field = BudgetExecution.Field.NS;
            this.TextBox.Font = new System.Drawing.Font("Roboto", 8F);
            this.TextBox.ForeColor = System.Drawing.Color.LightGray;
            this.TextBox.HoverText = "";
            this.TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(150, 21);
            this.TextBox.Tag = "";
            this.TextBox.ToolTip = this.ToolTip;
            // 
            // Separator5
            // 
            this.Separator5.ForeColor = System.Drawing.Color.Black;
            this.Separator5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Separator5.Name = "Separator5";
            this.Separator5.Size = new System.Drawing.Size(6, 31);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.NextButton.Bar = BudgetExecution.Tool.NS;
            this.NextButton.BindingSource = this.BudgetBinding;
            this.NextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextButton.Field = BudgetExecution.Field.NS;
            this.NextButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.NextButton.ForeColor = System.Drawing.Color.LightGray;
            this.NextButton.HoverText = null;
            this.NextButton.Image = ((System.Drawing.Image)(resources.GetObject("NextButton.Image")));
            this.NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NextButton.Margin = new System.Windows.Forms.Padding(5);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(23, 21);
            this.NextButton.Text = "barButton3";
            this.NextButton.ToolTip = this.ToolTip;
            // 
            // Separator6
            // 
            this.Separator6.ForeColor = System.Drawing.Color.Black;
            this.Separator6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Separator6.Name = "Separator6";
            this.Separator6.Size = new System.Drawing.Size(6, 31);
            // 
            // LastButton
            // 
            this.LastButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.LastButton.Bar = BudgetExecution.Tool.NS;
            this.LastButton.BindingSource = this.BudgetBinding;
            this.LastButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LastButton.Field = BudgetExecution.Field.NS;
            this.LastButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.LastButton.ForeColor = System.Drawing.Color.LightGray;
            this.LastButton.HoverText = null;
            this.LastButton.Image = ((System.Drawing.Image)(resources.GetObject("LastButton.Image")));
            this.LastButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LastButton.Margin = new System.Windows.Forms.Padding(5);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(23, 21);
            this.LastButton.Text = "barButton4";
            this.LastButton.ToolTip = this.ToolTip;
            // 
            // Separator7
            // 
            this.Separator7.ForeColor = System.Drawing.Color.Black;
            this.Separator7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Separator7.Name = "Separator7";
            this.Separator7.Size = new System.Drawing.Size(6, 31);
            // 
            // CalculatorButton
            // 
            this.CalculatorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.CalculatorButton.Bar = BudgetExecution.Tool.NS;
            this.CalculatorButton.BindingSource = this.BudgetBinding;
            this.CalculatorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CalculatorButton.Field = BudgetExecution.Field.NS;
            this.CalculatorButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.CalculatorButton.ForeColor = System.Drawing.Color.LightGray;
            this.CalculatorButton.HoverText = null;
            this.CalculatorButton.Image = ((System.Drawing.Image)(resources.GetObject("CalculatorButton.Image")));
            this.CalculatorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CalculatorButton.Margin = new System.Windows.Forms.Padding(5);
            this.CalculatorButton.Name = "CalculatorButton";
            this.CalculatorButton.Size = new System.Drawing.Size(23, 21);
            this.CalculatorButton.Text = "barButton5";
            this.CalculatorButton.ToolTip = this.ToolTip;
            // 
            // Separator8
            // 
            this.Separator8.ForeColor = System.Drawing.Color.Black;
            this.Separator8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Separator8.Name = "Separator8";
            this.Separator8.Size = new System.Drawing.Size(6, 31);
            // 
            // BrowseButton
            // 
            this.BrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BrowseButton.Bar = BudgetExecution.Tool.NS;
            this.BrowseButton.BindingSource = this.BudgetBinding;
            this.BrowseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BrowseButton.Field = BudgetExecution.Field.NS;
            this.BrowseButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.BrowseButton.ForeColor = System.Drawing.Color.LightGray;
            this.BrowseButton.HoverText = null;
            this.BrowseButton.Image = ((System.Drawing.Image)(resources.GetObject("BrowseButton.Image")));
            this.BrowseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(5);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(23, 21);
            this.BrowseButton.Text = "barButton6";
            this.BrowseButton.ToolTip = this.ToolTip;
            // 
            // Separator9
            // 
            this.Separator9.ForeColor = System.Drawing.Color.Black;
            this.Separator9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Separator9.Name = "Separator9";
            this.Separator9.Size = new System.Drawing.Size(6, 31);
            // 
            // PrintButton
            // 
            this.PrintButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.PrintButton.Bar = BudgetExecution.Tool.NS;
            this.PrintButton.BindingSource = this.BudgetBinding;
            this.PrintButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrintButton.Field = BudgetExecution.Field.NS;
            this.PrintButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.PrintButton.ForeColor = System.Drawing.Color.LightGray;
            this.PrintButton.HoverText = null;
            this.PrintButton.Image = ((System.Drawing.Image)(resources.GetObject("PrintButton.Image")));
            this.PrintButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintButton.Margin = new System.Windows.Forms.Padding(5);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(23, 21);
            this.PrintButton.Text = "barButton7";
            this.PrintButton.ToolTip = this.ToolTip;
            // 
            // Separator10
            // 
            this.Separator10.ForeColor = System.Drawing.Color.Black;
            this.Separator10.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Separator10.Name = "Separator10";
            this.Separator10.Size = new System.Drawing.Size(6, 31);
            // 
            // ExcelButton
            // 
            this.ExcelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ExcelButton.Bar = BudgetExecution.Tool.NS;
            this.ExcelButton.BindingSource = this.BudgetBinding;
            this.ExcelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExcelButton.Field = BudgetExecution.Field.NS;
            this.ExcelButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.ExcelButton.ForeColor = System.Drawing.Color.LightGray;
            this.ExcelButton.HoverText = null;
            this.ExcelButton.Image = ((System.Drawing.Image)(resources.GetObject("ExcelButton.Image")));
            this.ExcelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExcelButton.Margin = new System.Windows.Forms.Padding(5);
            this.ExcelButton.Name = "ExcelButton";
            this.ExcelButton.Size = new System.Drawing.Size(23, 21);
            this.ExcelButton.Text = "barButton8";
            this.ExcelButton.ToolTip = null;
            // 
            // Separator12
            // 
            this.Separator12.ForeColor = System.Drawing.Color.Black;
            this.Separator12.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Separator12.Name = "Separator12";
            this.Separator12.Size = new System.Drawing.Size(6, 31);
            // 
            // ComboBox
            // 
            this.ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ComboBox.BindingSource = null;
            this.ComboBox.DropDownHeight = 200;
            this.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox.Field = BudgetExecution.Field.NS;
            this.ComboBox.Font = new System.Drawing.Font("Roboto", 8F);
            this.ComboBox.ForeColor = System.Drawing.Color.LightGray;
            this.ComboBox.HoverText = "Make Selection";
            this.ComboBox.IntegralHeight = false;
            this.ComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.ComboBox.MaxDropDownItems = 30;
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(150, 21);
            this.ComboBox.Tag = "Make Selection";
            this.ComboBox.ToolTip = this.ToolTip;
            this.ComboBox.ToolTipText = "Make Selection";
            // 
            // Separator11
            // 
            this.Separator11.ForeColor = System.Drawing.Color.Black;
            this.Separator11.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Separator11.Name = "Separator11";
            this.Separator11.Size = new System.Drawing.Size(6, 31);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.CaptionFont = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(945, 660);
            this.ControlBox = false;
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.Navigator);
            this.Controls.Add(this.Table);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.Name = "ChartForm";
            this.Table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).EndInit();
            this.Navigator.ResumeLayout(false);
            this.Navigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel Table;
        public ToolPanel Navigator;
        private BarButton ExcelButton;
        private BarComboBox ComboBox;
        public ToolTip ToolTip;
        public BarLabel BarLabel;
        public ToolSeparator Separator1;
        public ToolSeparator Separator2;
        public ToolSeparator Separator3;
        public ToolSeparator Separator4;
        public BarTextBox TextBox;
        public ToolSeparator Separator5;
        public ToolSeparator Separator6;
        public ToolSeparator Separator7;
        public ToolSeparator Separator8;
        public ToolSeparator Separator9;
        public ToolSeparator Separator10;
        public ToolSeparator Separator12;
        public ToolSeparator Separator11;
        public BarButton FirstButton;
        public BarButton PreviousButton;
        public BarButton NextButton;
        public BarButton LastButton;
        public BarButton CalculatorButton;
        public BarButton BrowseButton;
        public BarButton PrintButton;
        public LabelPanel HeaderLabel;
        public ClosePanel CloseBox;
        private BudgetBinding BudgetBinding;
        public PicturePanel PictureBox;
        public BudgetChartControl Chart;
    }
}