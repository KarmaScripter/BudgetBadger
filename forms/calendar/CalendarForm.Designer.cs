// <copyright file="{ClassName}.cs" company="Terry D. Eppler">
// Copyright (c) Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    

    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System.ComponentModel;
    using System.Threading;

    partial class CalendarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarForm));
            this.CloseBox = new BudgetExecution.ClosePanel();
            this.Picture = new BudgetExecution.PicturePanel();
            this.Table1 = new System.Windows.Forms.TableLayoutPanel();
            this.Label = new BudgetExecution.LabelPanel();
            this.Calendar = new BudgetExecution.CalendarPanel();
            this.BudgetBinding = new BudgetExecution.BudgetBinding();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.Table1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Calendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).BeginInit();
            this.SuspendLayout();
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
            this.CloseBox.Location = new System.Drawing.Point(418, 0);
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
            this.CloseBox.TabIndex = 3;
            this.CloseBox.ThemeAuthor = "Terry D. Eppler";
            this.CloseBox.ThemeName = "Budget Execution";
            this.CloseBox.ToolTip = null;
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.Color.Transparent;
            this.Picture.BindingSource = null;
            this.Picture.DataFilter = null;
            this.Picture.ErrorImage = null;
            this.Picture.Field = BudgetExecution.Field.NS;
            this.Picture.HoverText = null;
            this.Picture.Image = ((System.Drawing.Image)(resources.GetObject("Picture.Image")));
            this.Picture.ImageList = null;
            this.Picture.InitialImage = ((System.Drawing.Image)(resources.GetObject("Picture.InitialImage")));
            this.Picture.Location = new System.Drawing.Point(0, 0);
            this.Picture.Margin = new System.Windows.Forms.Padding(0);
            this.Picture.Name = "Picture";
            this.Picture.Padding = new System.Windows.Forms.Padding(1);
            this.Picture.Size = new System.Drawing.Size(56, 17);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 2;
            this.Picture.TabStop = false;
            this.Picture.ToolTip = null;
            // 
            // Table1
            // 
            this.Table1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.Table1.ColumnCount = 3;
            this.Table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.18428F));
            this.Table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.81572F));
            this.Table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.Table1.Controls.Add(this.Picture, 0, 0);
            this.Table1.Controls.Add(this.CloseBox, 2, 0);
            this.Table1.Controls.Add(this.Label, 1, 0);
            this.Table1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Table1.Location = new System.Drawing.Point(0, 0);
            this.Table1.Name = "Table1";
            this.Table1.RowCount = 1;
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table1.Size = new System.Drawing.Size(518, 26);
            this.Table1.TabIndex = 4;
            // 
            // Label
            // 
            this.Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.Label.BindingSource = null;
            this.Label.DataFilter = null;
            this.Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label.Field = BudgetExecution.Field.NS;
            this.Label.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.Color.LightGray;
            this.Label.Location = new System.Drawing.Point(117, 3);
            this.Label.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.Label.Name = "Label";
            this.Label.Numeric = BudgetExecution.Numeric.NS;
            this.Label.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.Label.Outline = false;
            this.Label.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.Label.OutlineLocation = new System.Drawing.Point(0, 0);
            this.Label.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label.ReflectionSpacing = 0;
            this.Label.ShadowColor = System.Drawing.Color.Black;
            this.Label.ShadowDirection = 315;
            this.Label.ShadowLocation = new System.Drawing.Point(0, 0);
            this.Label.ShadowOpacity = 100;
            this.Label.Size = new System.Drawing.Size(286, 20);
            this.Label.TabIndex = 4;
            this.Label.Text = "Title";
            this.Label.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Label.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Label.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.Label.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Label.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Label.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.Label.ToolTip = null;
            // 
            // Calendar
            // 
            this.Calendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Calendar.BindingSource = this.BudgetBinding;
            this.Calendar.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.Calendar.BorderColor = System.Drawing.Color.Transparent;
            this.Calendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Calendar.BottomHeight = 23;
            this.Calendar.Culture = new System.Globalization.CultureInfo("");
            this.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Calendar.DaysColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Calendar.DaysFont = new System.Drawing.Font("Roboto", 8F);
            this.Calendar.DaysHeaderInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(221)))), ((int)(((byte)(238))))));
            this.Calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Calendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.Calendar.Font = new System.Drawing.Font("Roboto", 8F);
            this.Calendar.ForeColor = System.Drawing.Color.LightGray;
            this.Calendar.GridBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.Calendar.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None;
            this.Calendar.HeaderEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.Calendar.HeaderFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.Calendar.HeaderHeight = 40;
            this.Calendar.HeaderStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Calendar.HeadForeColor = System.Drawing.Color.White;
            this.Calendar.HighlightColor = System.Drawing.Color.Black;
            this.Calendar.Iso8601CalenderFormat = false;
            this.Calendar.Location = new System.Drawing.Point(0, 26);
            this.Calendar.MetroColor = System.Drawing.Color.Blue;
            this.Calendar.Name = "Calendar";
            this.Calendar.ScrollButtonSize = new System.Drawing.Size(24, 24);
            this.Calendar.Size = new System.Drawing.Size(518, 384);
            this.Calendar.Style = Syncfusion.Windows.Forms.VisualStyle.Office2010;
            this.Calendar.TabIndex = 5;
            this.Calendar.ToolTip = null;
            this.Calendar.WeekFont = new System.Drawing.Font("Verdana", 8F);
            // 
            // 
            // 
            this.Calendar.NoneButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2010;
            this.Calendar.NoneButton.AutoSize = true;
            this.Calendar.NoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Calendar.NoneButton.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.Calendar.NoneButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Calendar.NoneButton.IsBackStageButton = false;
            this.Calendar.NoneButton.Location = new System.Drawing.Point(446, 0);
            this.Calendar.NoneButton.Size = new System.Drawing.Size(72, 23);
            this.Calendar.NoneButton.Text = "None";
            this.Calendar.NoneButton.UseVisualStyle = true;
            // 
            // 
            // 
            this.Calendar.TodayButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2010;
            this.Calendar.TodayButton.AutoSize = true;
            this.Calendar.TodayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Calendar.TodayButton.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.Calendar.TodayButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Calendar.TodayButton.IsBackStageButton = false;
            this.Calendar.TodayButton.Location = new System.Drawing.Point(0, 0);
            this.Calendar.TodayButton.Size = new System.Drawing.Size(446, 23);
            this.Calendar.TodayButton.Text = "Today";
            this.Calendar.TodayButton.UseVisualStyle = true;
            // 
            // BudgetBinding
            // 
            this.BudgetBinding.DataFilter = null;
            this.BudgetBinding.Numeric = BudgetExecution.Numeric.NS;
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.CaptionFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(518, 410);
            this.ControlBox = false;
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.Table1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.Name = "CalendarForm";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.Table1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Calendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public ClosePanel CloseBox;

        public PicturePanel Picture;
        public System.Windows.Forms.TableLayoutPanel Table1;
        private LabelPanel Label;
        public BudgetBinding BudgetBinding;
        public CalendarPanel Calendar;
    }

}
