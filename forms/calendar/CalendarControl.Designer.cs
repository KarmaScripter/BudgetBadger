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
                this.BackPanel = new LayoutPanel();
                this.Calendar = new CalendarPanel();
                this.BackPanel.SuspendLayout();
                ( (System.ComponentModel.ISupportInitialize)( this.Calendar ) ).BeginInit();
                this.SuspendLayout();

                // 
                // BackPanel
                // 
                this.BackPanel.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.BackPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.BackPanel.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.BackPanel.BindingSource = null;

                this.BackPanel.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.BackPanel.Border.HoverColor = System.Drawing.Color.SteelBlue;
                this.BackPanel.Border.HoverVisible = false;
                this.BackPanel.Border.Rounding = 6;
                this.BackPanel.Border.Thickness = 1;
                this.BackPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.BackPanel.Border.Visible = true;
                this.BackPanel.Children = null;
                this.BackPanel.Controls.Add( this.Calendar );
                this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
                this.BackPanel.Field = Field.NS;
                this.BackPanel.DataFilter = null;
                this.BackPanel.ForeColor = System.Drawing.Color.LightGray;
                this.BackPanel.Location = new System.Drawing.Point( 1, 1 );
                this.BackPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.BackPanel.Name = "BackPanel";
                this.BackPanel.Padding = new System.Windows.Forms.Padding( 1 );
                this.BackPanel.Size = new System.Drawing.Size( 346, 340 );
                this.BackPanel.TabIndex = 0;
                this.BackPanel.Text = "layoutPanel1";

                this.BackPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.BackPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.BackPanel.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.BackPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.BackPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.BackPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.BackPanel.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.BackPanel.ToolTip = null;

                // 
                // Calendar
                // 
                this.Calendar.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Calendar.BindingSource = null;
                this.Calendar.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;

                this.Calendar.BorderColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 209 ) ) ) ),
                    ( (int)( ( (byte)( 211 ) ) ) ), ( (int)( ( (byte)( 212 ) ) ) ) );

                this.Calendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.Calendar.BottomHeight = 30;
                this.Calendar.Culture = new System.Globalization.CultureInfo( "" );

                this.Calendar.DayNamesColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Calendar.DayNamesFont =
                    new System.Drawing.Font( "Roboto", 10F, System.Drawing.FontStyle.Bold );

                this.Calendar.DaysColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Calendar.DaysFont = new System.Drawing.Font( "Roboto", 10F );

                this.Calendar.DaysHeaderInterior = new Syncfusion.Drawing.BrushInfo(
                    System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 208 ) ) ) ),
                        ( (int)( ( (byte)( 221 ) ) ) ), ( (int)( ( (byte)( 238 ) ) ) ) ) );

                this.Calendar.Dock = System.Windows.Forms.DockStyle.Fill;
                this.Calendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
                this.Calendar.Font = new System.Drawing.Font( "Roboto", 8F );
                this.Calendar.ForeColor = System.Drawing.Color.LightGray;

                this.Calendar.GridBackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 208 ) ) ) ),
                    ( (int)( ( (byte)( 221 ) ) ) ), ( (int)( ( (byte)( 238 ) ) ) ) );

                this.Calendar.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None;

                this.Calendar.HeaderEndColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 208 ) ) ) ),
                    ( (int)( ( (byte)( 221 ) ) ) ), ( (int)( ( (byte)( 238 ) ) ) ) );

                this.Calendar.HeaderFont =
                    new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Bold );

                this.Calendar.HeaderHeight = 40;
                this.Calendar.HeaderStartColor = System.Drawing.SystemColors.ControlDarkDark;
                this.Calendar.HeadForeColor = System.Drawing.Color.White;
                this.Calendar.HighlightColor = System.Drawing.Color.Black;
                this.Calendar.Iso8601CalenderFormat = false;
                this.Calendar.Location = new System.Drawing.Point( 0, 0 );

                this.Calendar.MetroColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 22 ) ) ) ),
                    ( (int)( ( (byte)( 165 ) ) ) ), ( (int)( ( (byte)( 220 ) ) ) ) );

                this.Calendar.Name = "Calendar";
                this.Calendar.ScrollButtonSize = new System.Drawing.Size( 24, 24 );
                this.Calendar.Size = new System.Drawing.Size( 346, 340 );
                this.Calendar.Style = Syncfusion.Windows.Forms.VisualStyle.Office2010;
                this.Calendar.TabIndex = 0;
                this.Calendar.ToolTip = null;
                this.Calendar.WeekFont = new System.Drawing.Font( "Verdana", 8F );

                // 
                // 
                // 
                this.Calendar.NoneButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2010;
                this.Calendar.NoneButton.AutoSize = true;

                this.Calendar.NoneButton.BackColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Calendar.NoneButton.BeforeTouchSize = new System.Drawing.Size( 75, 23 );
                this.Calendar.NoneButton.ForeColor = System.Drawing.SystemColors.ControlText;
                this.Calendar.NoneButton.IsBackStageButton = false;
                this.Calendar.NoneButton.Location = new System.Drawing.Point( 274, 0 );
                this.Calendar.NoneButton.Size = new System.Drawing.Size( 72, 30 );
                this.Calendar.NoneButton.Text = "None";
                this.Calendar.NoneButton.UseVisualStyle = true;

                // 
                // 
                // 
                this.Calendar.TodayButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2010;
                this.Calendar.TodayButton.AutoSize = true;

                this.Calendar.TodayButton.BackColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Calendar.TodayButton.BeforeTouchSize = new System.Drawing.Size( 75, 23 );
                this.Calendar.TodayButton.ForeColor = System.Drawing.SystemColors.ControlText;
                this.Calendar.TodayButton.IsBackStageButton = false;
                this.Calendar.TodayButton.Location = new System.Drawing.Point( 0, 0 );
                this.Calendar.TodayButton.Size = new System.Drawing.Size( 274, 30 );
                this.Calendar.TodayButton.Text = "Today";
                this.Calendar.TodayButton.UseVisualStyle = true;

                // 
                // CalendarControl
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.Controls.Add( this.BackPanel );
                this.Name = "CalendarControl";
                this.Size = new System.Drawing.Size( 348, 342 );
                this.BackPanel.ResumeLayout( false );
                ( (System.ComponentModel.ISupportInitialize)( this.Calendar ) ).EndInit();
                this.ResumeLayout( false );

            }

            #endregion

            public LayoutPanel BackPanel;

            public CalendarPanel Calendar;
        }
    
}
