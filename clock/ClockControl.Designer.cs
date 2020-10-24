namespace BudgetExecution
{
    partial class ClockControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Tools.DigitalClockRenderer digitalClockRenderer1 = new Syncfusion.Windows.Forms.Tools.DigitalClockRenderer();
            Syncfusion.Windows.Forms.Tools.ClockRenderer clockRenderer1 = new Syncfusion.Windows.Forms.Tools.ClockRenderer();
            this.Clock = new BudgetExecution.ClockPanel();
            this.BackPanel = new BudgetExecution.LayoutPanel();
            this.BudgetBinding = new BudgetExecution.BudgetBinding();
            this.ToolTip = new BudgetExecution.ToolTip();
            this.BackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).BeginInit();
            this.SuspendLayout();
            // 
            // Clock
            // 
            this.Clock.BackColor = System.Drawing.Color.Transparent;
            this.Clock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.Clock.BeforeTouchSize = new System.Drawing.Size(188, 94);
            this.Clock.BindingSource = null;
            this.Clock.BorderColor = System.Drawing.Color.Transparent;
            this.Clock.ClockFormat = "HH:mm:ss";
            this.Clock.ClockFrame = Syncfusion.Windows.Forms.Tools.ClockFrames.RectangularFrame;
            this.Clock.ClockShape = Syncfusion.Windows.Forms.Tools.ClockShapes.Rectangle;
            this.Clock.ClockType = Syncfusion.Windows.Forms.Tools.ClockTypes.Digital;
            this.Clock.CurrentDateTime = new System.DateTime(2020, 9, 4, 12, 42, 34, 16);
            this.Clock.CustomTime = new System.DateTime(2020, 9, 5, 6, 48, 9, 824);
            this.Clock.DigitalRenderer = digitalClockRenderer1;
            this.Clock.DisplayDates = true;
            this.Clock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Clock.ForeColor = System.Drawing.Color.LightGray;
            this.Clock.Location = new System.Drawing.Point(0, 0);
            this.Clock.MinimumSize = new System.Drawing.Size(75, 75);
            this.Clock.MinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(119)))));
            this.Clock.Name = "Clock";
            this.Clock.Now = new System.DateTime(2020, 9, 4, 12, 42, 34, 28);
            this.Clock.Padding = new System.Windows.Forms.Padding(1);
            this.Clock.Remainder = new System.DateTime(2020, 9, 4, 12, 42, 34, 15);
            this.Clock.Renderer = clockRenderer1;
            this.Clock.ShowBorder = false;
            this.Clock.ShowClockFrame = false;
            this.Clock.ShowCustomTimeClock = false;
            this.Clock.ShowHourDesignator = true;
            this.Clock.Size = new System.Drawing.Size(188, 94);
            this.Clock.StopTimer = false;
            this.Clock.TabIndex = 0;
            this.Clock.Text = "clockPanel1";
            this.Clock.ToolTip = null;
            // 
            // BackPanel
            // 
            this.BackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.BackPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.BackPanel.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.BackPanel.BindingSource = null;
            this.BackPanel.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.BackPanel.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.BackPanel.Border.HoverVisible = false;
            this.BackPanel.Border.Rounding = 6;
            this.BackPanel.Border.Thickness = 1;
            this.BackPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.BackPanel.Border.Visible = true;
            this.BackPanel.Children = null;
            this.BackPanel.Controls.Add(this.Clock);
            this.BackPanel.DataFilter = null;
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Field = BudgetExecution.Field.NS;
            this.BackPanel.ForeColor = System.Drawing.Color.LightGray;
            this.BackPanel.Location = new System.Drawing.Point(1, 1);
            this.BackPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Padding = new System.Windows.Forms.Padding(1);
            this.BackPanel.Size = new System.Drawing.Size(188, 93);
            this.BackPanel.TabIndex = 1;
            this.BackPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.BackPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BackPanel.ToolTip = null;
            // 
            // BudgetBinding
            // 
            this.BudgetBinding.DataFilter = null;
            this.BudgetBinding.Numeric = BudgetExecution.Numeric.NS;
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
            // ClockControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BackPanel);
            this.Name = "ClockControl";
            this.Size = new System.Drawing.Size(190, 95);
            this.BackPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ClockPanel Clock;
        public BudgetBinding BudgetBinding;
        public ToolTip ToolTip;
        public LayoutPanel BackPanel;
    }
}
