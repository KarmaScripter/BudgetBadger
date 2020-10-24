namespace BudgetExecution
{
    using System;
    using System.ComponentModel;
    using System.Threading;
    using Syncfusion.Windows.Forms;
    using VisualPlus.Toolkit.Controls.Interactivity;

    partial class Error : MetroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Error));
            this.Info = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.StackPanel = new BudgetExecution.RichTextPanel();
            this.CloseBox = new BudgetExecution.ClosePanel();
            this.Table1 = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBox = new BudgetExecution.PicturePanel();
            this.TopLabel = new BudgetExecution.LabelPanel();
            this.Table2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPanel1 = new BudgetExecution.ButtonPanel();
            this.buttonPanel2 = new BudgetExecution.ButtonPanel();
            this.buttonPanel3 = new BudgetExecution.ButtonPanel();
            this.visualSeparator1 = new VisualPlus.Toolkit.Controls.Layout.VisualSeparator();
            this.visualSeparator2 = new VisualPlus.Toolkit.Controls.Layout.VisualSeparator();
            this.Table1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.Table2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.ForeColor = System.Drawing.Color.LightGray;
            this.Info.Location = new System.Drawing.Point(65, 48);
            this.Info.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.Info.Name = "Info";
            this.Info.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.Info.Outline = false;
            this.Info.OutlineColor = System.Drawing.Color.Red;
            this.Info.OutlineLocation = new System.Drawing.Point(0, 0);
            this.Info.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Info.ReflectionSpacing = 0;
            this.Info.ShadowColor = System.Drawing.Color.Black;
            this.Info.ShadowDirection = 315;
            this.Info.ShadowLocation = new System.Drawing.Point(0, 0);
            this.Info.ShadowOpacity = 100;
            this.Info.Size = new System.Drawing.Size(557, 27);
            this.Info.TabIndex = 0;
            this.Info.Text = "Source :";
            this.Info.TextAlignment = System.Drawing.StringAlignment.Near;
            this.Info.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Info.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.Info.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Info.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Info.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Info.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Info.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Info.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // StackPanel
            // 
            this.StackPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.StackPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.StackPanel.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.StackPanel.BindingSource = null;
            this.StackPanel.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.StackPanel.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.StackPanel.Border.HoverVisible = true;
            this.StackPanel.Border.Rounding = 6;
            this.StackPanel.Border.Thickness = 1;
            this.StackPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.StackPanel.Border.Visible = true;
            this.StackPanel.DataFilter = null;
            this.StackPanel.Field = BudgetExecution.Field.NS;
            this.StackPanel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StackPanel.ForeColor = System.Drawing.Color.LightGray;
            this.StackPanel.Location = new System.Drawing.Point(44, 100);
            this.StackPanel.Margin = new System.Windows.Forms.Padding(5);
            this.StackPanel.MaxLength = 2147483647;
            this.StackPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.StackPanel.Name = "StackPanel";
            this.StackPanel.Numeric = BudgetExecution.Numeric.NS;
            this.StackPanel.ReadOnly = false;
            this.StackPanel.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.StackPanel.ShowSelectionMargin = false;
            this.StackPanel.Size = new System.Drawing.Size(562, 275);
            this.StackPanel.TabIndex = 1;
            this.StackPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.StackPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StackPanel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StackPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StackPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.StackPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.StackPanel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.StackPanel.ToolTip = null;
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
            this.CloseBox.Location = new System.Drawing.Point(550, 0);
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
            this.CloseBox.TabIndex = 2;
            this.CloseBox.Text = "closePanel1";
            this.CloseBox.ThemeAuthor = "Terry D. Eppler";
            this.CloseBox.ThemeName = "Budget Execution";
            this.CloseBox.ToolTip = null;
            // 
            // Table1
            // 
            this.Table1.ColumnCount = 3;
            this.Table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.876228F));
            this.Table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.12377F));
            this.Table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.Table1.Controls.Add(this.PictureBox, 0, 0);
            this.Table1.Controls.Add(this.CloseBox, 2, 0);
            this.Table1.Controls.Add(this.TopLabel, 1, 0);
            this.Table1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Table1.Location = new System.Drawing.Point(0, 0);
            this.Table1.Name = "Table1";
            this.Table1.RowCount = 1;
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table1.Size = new System.Drawing.Size(650, 26);
            this.Table1.TabIndex = 3;
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
            this.PictureBox.Location = new System.Drawing.Point(3, 3);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Padding = new System.Windows.Forms.Padding(1);
            this.PictureBox.Size = new System.Drawing.Size(20, 16);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.ToolTip = null;
            // 
            // TopLabel
            // 
            this.TopLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.TopLabel.BindingSource = null;
            this.TopLabel.DataFilter = null;
            this.TopLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopLabel.Field = BudgetExecution.Field.NS;
            this.TopLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopLabel.ForeColor = System.Drawing.Color.Red;
            this.TopLabel.Location = new System.Drawing.Point(37, 3);
            this.TopLabel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Numeric = BudgetExecution.Numeric.NS;
            this.TopLabel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopLabel.Outline = false;
            this.TopLabel.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.TopLabel.OutlineLocation = new System.Drawing.Point(0, 0);
            this.TopLabel.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TopLabel.ReflectionSpacing = 0;
            this.TopLabel.ShadowColor = System.Drawing.Color.Black;
            this.TopLabel.ShadowDirection = 315;
            this.TopLabel.ShadowLocation = new System.Drawing.Point(0, 0);
            this.TopLabel.ShadowOpacity = 100;
            this.TopLabel.Size = new System.Drawing.Size(464, 20);
            this.TopLabel.TabIndex = 3;
            this.TopLabel.Text = "Error";
            this.TopLabel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TopLabel.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.TopLabel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.TopLabel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TopLabel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TopLabel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TopLabel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TopLabel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.TopLabel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TopLabel.ToolTip = null;
            // 
            // Table2
            // 
            this.Table2.ColumnCount = 5;
            this.Table2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.84058F));
            this.Table2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.15942F));
            this.Table2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.Table2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.Table2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.Table2.Controls.Add(this.buttonPanel1, 1, 0);
            this.Table2.Controls.Add(this.buttonPanel2, 2, 0);
            this.Table2.Controls.Add(this.buttonPanel3, 3, 0);
            this.Table2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Table2.Location = new System.Drawing.Point(0, 411);
            this.Table2.Name = "Table2";
            this.Table2.RowCount = 1;
            this.Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table2.Size = new System.Drawing.Size(650, 106);
            this.Table2.TabIndex = 4;
            // 
            // buttonPanel1
            // 
            this.buttonPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.buttonPanel1.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.buttonPanel1.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.buttonPanel1.BackColorState.Hover = System.Drawing.Color.SteelBlue;
            this.buttonPanel1.BackColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.buttonPanel1.BindingSource = null;
            this.buttonPanel1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.buttonPanel1.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.buttonPanel1.Border.HoverVisible = true;
            this.buttonPanel1.Border.Rounding = 6;
            this.buttonPanel1.Border.Thickness = 1;
            this.buttonPanel1.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.buttonPanel1.Border.Visible = true;
            this.buttonPanel1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPanel1.Field = BudgetExecution.Field.NS;
            this.buttonPanel1.Font = new System.Drawing.Font("Roboto", 8F);
            this.buttonPanel1.ForeColor = System.Drawing.Color.LightGray;
            this.buttonPanel1.HoverText = null;
            this.buttonPanel1.Image = null;
            this.buttonPanel1.Images = null;
            this.buttonPanel1.Location = new System.Drawing.Point(42, 0);
            this.buttonPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPanel1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.buttonPanel1.Name = "buttonPanel1";
            this.buttonPanel1.Size = new System.Drawing.Size(185, 80);
            this.buttonPanel1.TabIndex = 0;
            this.buttonPanel1.Text = "Accept";
            this.buttonPanel1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.buttonPanel1.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.buttonPanel1.TextStyle.Enabled = System.Drawing.Color.LightGray;
            this.buttonPanel1.TextStyle.Hover = System.Drawing.Color.LightGray;
            this.buttonPanel1.TextStyle.Pressed = System.Drawing.Color.White;
            this.buttonPanel1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.buttonPanel1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.buttonPanel1.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.buttonPanel1.ToolTip = null;
            // 
            // buttonPanel2
            // 
            this.buttonPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.buttonPanel2.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.buttonPanel2.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.buttonPanel2.BackColorState.Hover = System.Drawing.Color.SteelBlue;
            this.buttonPanel2.BackColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.buttonPanel2.BindingSource = null;
            this.buttonPanel2.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.buttonPanel2.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.buttonPanel2.Border.HoverVisible = true;
            this.buttonPanel2.Border.Rounding = 6;
            this.buttonPanel2.Border.Thickness = 1;
            this.buttonPanel2.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.buttonPanel2.Border.Visible = true;
            this.buttonPanel2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPanel2.Field = BudgetExecution.Field.NS;
            this.buttonPanel2.Font = new System.Drawing.Font("Roboto", 8F);
            this.buttonPanel2.ForeColor = System.Drawing.Color.LightGray;
            this.buttonPanel2.HoverText = null;
            this.buttonPanel2.Image = null;
            this.buttonPanel2.Images = null;
            this.buttonPanel2.Location = new System.Drawing.Point(227, 0);
            this.buttonPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPanel2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.buttonPanel2.Name = "buttonPanel2";
            this.buttonPanel2.Size = new System.Drawing.Size(183, 80);
            this.buttonPanel2.TabIndex = 1;
            this.buttonPanel2.Text = "Continue";
            this.buttonPanel2.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.buttonPanel2.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.buttonPanel2.TextStyle.Enabled = System.Drawing.Color.LightGray;
            this.buttonPanel2.TextStyle.Hover = System.Drawing.Color.LightGray;
            this.buttonPanel2.TextStyle.Pressed = System.Drawing.Color.White;
            this.buttonPanel2.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.buttonPanel2.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.buttonPanel2.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.buttonPanel2.ToolTip = null;
            // 
            // buttonPanel3
            // 
            this.buttonPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.buttonPanel3.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.buttonPanel3.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.buttonPanel3.BackColorState.Hover = System.Drawing.Color.SteelBlue;
            this.buttonPanel3.BackColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.buttonPanel3.BindingSource = null;
            this.buttonPanel3.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.buttonPanel3.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.buttonPanel3.Border.HoverVisible = true;
            this.buttonPanel3.Border.Rounding = 6;
            this.buttonPanel3.Border.Thickness = 1;
            this.buttonPanel3.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.buttonPanel3.Border.Visible = true;
            this.buttonPanel3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPanel3.Field = BudgetExecution.Field.NS;
            this.buttonPanel3.Font = new System.Drawing.Font("Roboto", 8F);
            this.buttonPanel3.ForeColor = System.Drawing.Color.LightGray;
            this.buttonPanel3.HoverText = null;
            this.buttonPanel3.Image = null;
            this.buttonPanel3.Images = null;
            this.buttonPanel3.Location = new System.Drawing.Point(410, 0);
            this.buttonPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPanel3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.buttonPanel3.Name = "buttonPanel3";
            this.buttonPanel3.Size = new System.Drawing.Size(193, 80);
            this.buttonPanel3.TabIndex = 2;
            this.buttonPanel3.Text = "Ignore";
            this.buttonPanel3.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.buttonPanel3.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.buttonPanel3.TextStyle.Enabled = System.Drawing.Color.LightGray;
            this.buttonPanel3.TextStyle.Hover = System.Drawing.Color.LightGray;
            this.buttonPanel3.TextStyle.Pressed = System.Drawing.Color.White;
            this.buttonPanel3.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.buttonPanel3.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.buttonPanel3.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.buttonPanel3.ToolTip = null;
            // 
            // visualSeparator1
            // 
            this.visualSeparator1.ForeColor = System.Drawing.Color.Maroon;
            this.visualSeparator1.Line = System.Drawing.Color.Maroon;
            this.visualSeparator1.Location = new System.Drawing.Point(0, 27);
            this.visualSeparator1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualSeparator1.Name = "visualSeparator1";
            this.visualSeparator1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualSeparator1.Shadow = System.Drawing.Color.Maroon;
            this.visualSeparator1.ShadowVisible = true;
            this.visualSeparator1.Size = new System.Drawing.Size(650, 4);
            this.visualSeparator1.TabIndex = 5;
            this.visualSeparator1.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.visualSeparator1.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualSeparator1.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualSeparator1.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualSeparator1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualSeparator1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualSeparator1.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // visualSeparator2
            // 
            this.visualSeparator2.ForeColor = System.Drawing.Color.Maroon;
            this.visualSeparator2.Line = System.Drawing.Color.Maroon;
            this.visualSeparator2.Location = new System.Drawing.Point(0, 401);
            this.visualSeparator2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualSeparator2.Name = "visualSeparator2";
            this.visualSeparator2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualSeparator2.Shadow = System.Drawing.Color.Maroon;
            this.visualSeparator2.ShadowVisible = true;
            this.visualSeparator2.Size = new System.Drawing.Size(650, 4);
            this.visualSeparator2.TabIndex = 6;
            this.visualSeparator2.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.visualSeparator2.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualSeparator2.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualSeparator2.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualSeparator2.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualSeparator2.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualSeparator2.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.CaptionFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(650, 517);
            this.ControlBox = false;
            this.Controls.Add(this.visualSeparator2);
            this.Controls.Add(this.visualSeparator1);
            this.Controls.Add(this.Table2);
            this.Controls.Add(this.Table1);
            this.Controls.Add(this.StackPanel);
            this.Controls.Add(this.Info);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.Name = "Error";
            this.Table1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.Table2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public RichTextPanel StackPanel;
        public VisualLabel Info;
        private ClosePanel CloseBox;
        private System.Windows.Forms.TableLayoutPanel Table1;
        public PicturePanel PictureBox;
        public LabelPanel TopLabel;
        private System.Windows.Forms.TableLayoutPanel Table2;
        private ButtonPanel buttonPanel1;
        private ButtonPanel buttonPanel2;
        private ButtonPanel buttonPanel3;
        public VisualPlus.Toolkit.Controls.Layout.VisualSeparator visualSeparator1;
        public VisualPlus.Toolkit.Controls.Layout.VisualSeparator visualSeparator2;
    }
}
