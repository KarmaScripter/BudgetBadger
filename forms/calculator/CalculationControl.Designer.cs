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

        partial class CalculationControl : CalculatorData
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
                this.Result = new LabelPanel();
                this.Calculator = new CalculationPanel();
                this.BackPanel.SuspendLayout();
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

                this.BackPanel.Border.HoverColor = System.Drawing.SystemColors.HotTrack;
                this.BackPanel.Border.HoverVisible = false;
                this.BackPanel.Border.Rounding = 6;
                this.BackPanel.Border.Thickness = 1;
                this.BackPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.BackPanel.Border.Visible = true;
                this.BackPanel.Children = null;
                this.BackPanel.Controls.Add( this.Result );
                this.BackPanel.Controls.Add( this.Calculator );
                this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
                this.BackPanel.Field = Field.NS;
                this.BackPanel.DataFilter = null;
                this.BackPanel.ForeColor = System.Drawing.Color.LightGray;
                this.BackPanel.Location = new System.Drawing.Point( 1, 1 );
                this.BackPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.BackPanel.Name = "BackPanel";
                this.BackPanel.Padding = new System.Windows.Forms.Padding( 1 );
                this.BackPanel.Size = new System.Drawing.Size( 281, 325 );
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
                // Result
                // 
                this.Result.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Result.Dock = System.Windows.Forms.DockStyle.Fill;
                this.Result.Field = Field.NS;
                this.Result.DataFilter = null;

                this.Result.Font = new System.Drawing.Font( "Roboto", 11.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.Result.ForeColor = System.Drawing.Color.White;
                this.Result.Location = new System.Drawing.Point( 0, 0 );
                this.Result.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.Result.Name = "Result";
                this.Result.Numeric = Numeric.Default;
                this.Result.Orientation = System.Windows.Forms.Orientation.Horizontal;
                this.Result.Outline = false;

                this.Result.OutlineColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Result.OutlineLocation = new System.Drawing.Point( 0, 0 );

                this.Result.ReflectionColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 120 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Result.ReflectionSpacing = 0;
                this.Result.ShadowColor = System.Drawing.Color.Black;
                this.Result.ShadowDirection = 315;
                this.Result.ShadowLocation = new System.Drawing.Point( 0, 0 );
                this.Result.ShadowOpacity = 100;
                this.Result.Size = new System.Drawing.Size( 281, 50 );
                this.Result.TabIndex = 1;
                this.Result.Text = "$";
                this.Result.TextAlignment = System.Drawing.StringAlignment.Center;
                this.Result.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.Result.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.Result.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Result.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Result.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Result.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.Result.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.Result.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.Result.ToolTip = null;

                // 
                // Calculator
                // 
                this.Calculator.AccessibleDescription = "Calculator control";
                this.Calculator.AccessibleName = "Calculator Control";

                this.Calculator.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Calculator.BackgroundColor = new Syncfusion.Drawing.BrushInfo(
                    System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                        ( (int)( ( (byte)( 5 ) ) ) ) ) );

                this.Calculator.BeforeTouchSize = new System.Drawing.Size( 281, 275 );
                this.Calculator.BindingSource = null;
                this.Calculator.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
                this.Calculator.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
                this.Calculator.Culture = new System.Globalization.CultureInfo( "en-US" );
                this.Calculator.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.Calculator.DoubleValue = 0D;
                this.Calculator.Field = Field.NS;
                this.Calculator.DataFilter = null;
                this.Calculator.Font = new System.Drawing.Font( "Roboto", 10F );
                this.Calculator.ForeColor = System.Drawing.Color.LightGray;
                this.Calculator.HorizontalSpacing = 5;
                this.Calculator.Location = new System.Drawing.Point( 0, 50 );

                this.Calculator.MetroColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Calculator.Name = "Calculator";
                this.Calculator.Padding = new System.Windows.Forms.Padding( 1 );
                this.Calculator.RightToLeft = System.Windows.Forms.RightToLeft.No;
                this.Calculator.ShowDisplayArea = false;
                this.Calculator.Size = new System.Drawing.Size( 281, 275 );
                this.Calculator.TabIndex = 0;
                this.Calculator.TextBox = null;
                this.Calculator.ToolTip = null;
                this.Calculator.UseVerticalAndHorizontalSpacing = true;
                this.Calculator.UseVisualStyle = true;
                this.Calculator.VerticalSpacing = 5;

                // 
                // CalculationControl
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.Controls.Add( this.BackPanel );
                this.Name = "CalculationControl";
                this.Size = new System.Drawing.Size( 283, 327 );
                this.BackPanel.ResumeLayout( false );
                this.ResumeLayout( false );

            }

            #endregion

            public LayoutPanel BackPanel;

            public CalculationPanel Calculator;

            public LabelPanel Result;
        }
    
}
