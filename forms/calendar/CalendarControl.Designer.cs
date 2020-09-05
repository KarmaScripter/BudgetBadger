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

        partial class CalendarControl
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

            #region Component Designer generated code

            /// <summary> 
            /// Required method for Designer support - do not modify 
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            this.components = new System.ComponentModel.Container();
            this.BackPanel = new BudgetExecution.LayoutPanel();
            this.Calendar = new BudgetExecution.CalendarPanel();
            this.BudgetBinding = new BudgetExecution.BudgetBinding();
            this.BackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Calendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).BeginInit();
            this.SuspendLayout();
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
            this.BackPanel.Controls.Add(this.Calendar);
            this.BackPanel.DataFilter = null;
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Field = BudgetExecution.Field.NS;
            this.BackPanel.ForeColor = System.Drawing.Color.LightGray;
            this.BackPanel.Location = new System.Drawing.Point(5, 5);
            this.BackPanel.Margin = new System.Windows.Forms.Padding(5);
            this.BackPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Padding = new System.Windows.Forms.Padding(5);
            this.BackPanel.Size = new System.Drawing.Size(520, 365);
            this.BackPanel.TabIndex = 0;
            this.BackPanel.Text = "layoutPanel1";
            this.BackPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.BackPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BackPanel.ToolTip = null;
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
            this.Calendar.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Dashed;
            this.Calendar.HeaderEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.Calendar.HeaderFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.Calendar.HeaderHeight = 40;
            this.Calendar.HeaderStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Calendar.HeadForeColor = System.Drawing.Color.White;
            this.Calendar.HighlightColor = System.Drawing.Color.Black;
            this.Calendar.Iso8601CalenderFormat = false;
            this.Calendar.Location = new System.Drawing.Point(0, 0);
            this.Calendar.MetroColor = System.Drawing.Color.Blue;
            this.Calendar.Name = "Calendar";
            this.Calendar.ScrollButtonSize = new System.Drawing.Size(24, 24);
            this.Calendar.Size = new System.Drawing.Size(520, 365);
            this.Calendar.Style = Syncfusion.Windows.Forms.VisualStyle.Office2010;
            this.Calendar.TabIndex = 0;
            this.Calendar.ToolTip = null;
            this.Calendar.WeekFont = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // 
            // 
            this.Calendar.NoneButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2010;
            this.Calendar.NoneButton.AutoSize = true;
            this.Calendar.NoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Calendar.NoneButton.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.Calendar.NoneButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Calendar.NoneButton.IsBackStageButton = false;
            this.Calendar.NoneButton.Location = new System.Drawing.Point(448, 0);
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
            this.Calendar.TodayButton.Size = new System.Drawing.Size(448, 23);
            this.Calendar.TodayButton.Text = "Today";
            this.Calendar.TodayButton.UseVisualStyle = true;
            // 
            // BudgetBinding
            // 
            this.BudgetBinding.DataFilter = null;
            this.BudgetBinding.Numeric = BudgetExecution.Numeric.NS;
            // 
            // CalendarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BackPanel);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CalendarControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(530, 375);
            this.BackPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Calendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).EndInit();
            this.ResumeLayout(false);

            }

            #endregion

            public LayoutPanel BackPanel;

            public CalendarPanel Calendar;
        private BudgetBinding BudgetBinding;
    }
    
}
