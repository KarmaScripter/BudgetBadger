﻿// <copyright file="{ClassName}.cs" company="Terry D. Eppler">
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
        using System.Windows.Forms;

        partial class BudgetChartControl
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
                this.Chart = new BudgetChartPanel();
                this.BackPanel = new LayoutPanel();
                this.BindingSource = new System.Windows.Forms.BindingSource( this.components );
                this.BackPanel.SuspendLayout();
                ( (System.ComponentModel.ISupportInitialize)( this.BindingSource ) ).BeginInit();
                this.SuspendLayout();

                // 
                // Chart
                // 
                this.Chart.AllowGradientPalette = true;
                this.Chart.AllowUserEditStyles = true;
                this.Chart.AutoHighlight = true;

                this.Chart.BackInterior = new Syncfusion.Drawing.BrushInfo(
                    System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                        ( (int)( ( (byte)( 5 ) ) ) ) ) );

                this.Chart.ChartArea.AutoScale = true;

                this.Chart.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(
                    System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                        ( (int)( ( (byte)( 5 ) ) ) ) ) );

                this.Chart.ChartArea.BorderColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Chart.ChartArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.Chart.ChartArea.CursorLocation = new System.Drawing.Point( 0, 0 );
                this.Chart.ChartArea.CursorReDraw = false;
                this.Chart.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins( 3, 3, 3, 3 );

                this.Chart.ChartInterior = new Syncfusion.Drawing.BrushInfo(
                    Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.LightGray,
                    System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                        ( (int)( ( (byte)( 5 ) ) ) ) ) );

                this.Chart.DataSourceName = "[none]";
                this.Chart.Depth = 250F;
                this.Chart.DisplayChartContextMenu = false;
                this.Chart.DisplaySeriesContextMenu = false;
                this.Chart.Dock = System.Windows.Forms.DockStyle.Fill;
                this.Chart.EnableMouseRotation = true;
                this.Chart.IsWindowLess = false;

                // 
                // 
                // 
                this.Chart.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(
                    System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                        ( (int)( ( (byte)( 5 ) ) ) ) ) );

                this.Chart.Legend.Font = new System.Drawing.Font( "Roboto", 8F );
                this.Chart.Legend.ItemsAlignment = System.Drawing.StringAlignment.Center;
                this.Chart.Legend.ItemsSize = new System.Drawing.Size( 12, 12 );
                this.Chart.Legend.Location = new System.Drawing.Point( 704, 68 );
                this.Chart.Legend.ShowItemsShadow = true;
                this.Chart.Legend.ShowSymbol = true;
                this.Chart.Legend.VisibleCheckBox = true;
                this.Chart.Localize = null;
                this.Chart.Location = new System.Drawing.Point( 0, 0 );
                this.Chart.Name = "Chart";
                this.Chart.Padding = new System.Windows.Forms.Padding( 1 );
                this.Chart.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Metro;

                this.Chart.PrimaryXAxis.LogLabelsDisplayMode =
                    Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;

                this.Chart.PrimaryXAxis.Margin = true;

                this.Chart.PrimaryYAxis.LogLabelsDisplayMode =
                    Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;

                this.Chart.PrimaryYAxis.Margin = true;
                this.Chart.RealMode3D = true;
                this.Chart.Rotation = 0.1F;
                this.Chart.Series3D = true;
                this.Chart.SeriesHighlight = true;

                this.Chart.ShadowColor = new Syncfusion.Drawing.BrushInfo(
                    Syncfusion.Drawing.GradientStyle.PathRectangle,
                    System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                        ( (int)( ( (byte)( 5 ) ) ) ) ), System.Drawing.Color.Silver );

                this.Chart.ShowScrollBars = false;
                this.Chart.Size = new System.Drawing.Size( 818, 562 );
                this.Chart.Spacing = 5F;
                this.Chart.SpacingBetweenPoints = 5F;
                this.Chart.Style3D = true;
                this.Chart.TabIndex = 0;
                this.Chart.Text = "BudgetChart";
                this.Chart.Tilt = 5F;

                // 
                // 
                // 
                this.Chart.Title.Name = "Default";
                this.Chart.Titles.Add( this.Chart.Title );

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
                this.BackPanel.Controls.Add( this.Chart );
                this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
                this.BackPanel.Field = Field.NS;
                this.BackPanel.DataFilter = null;
                this.BackPanel.ForeColor = System.Drawing.Color.LightGray;
                this.BackPanel.Location = new System.Drawing.Point( 1, 1 );
                this.BackPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.BackPanel.Name = "BackPanel";
                this.BackPanel.Padding = new System.Windows.Forms.Padding( 1 );
                this.BackPanel.Size = new System.Drawing.Size( 818, 562 );
                this.BackPanel.TabIndex = 1;
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

                // 
                // BudgetChart
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF( 96F, 96F );
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;

                this.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Controls.Add( this.BackPanel );
                this.DoubleBuffered = true;

                this.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.ForeColor = System.Drawing.Color.LightGray;
                this.Name = "BudgetChartControl";
                this.Padding = new System.Windows.Forms.Padding( 1 );
                this.Size = new System.Drawing.Size( 820, 564 );
                this.BackPanel.ResumeLayout( false );
                ( (System.ComponentModel.ISupportInitialize)( this.BindingSource ) ).EndInit();
                this.ResumeLayout( false );

            }

            #endregion

            public BudgetChartPanel Chart;

            public LayoutPanel BackPanel;

            public BindingSource BindingSource;
        }
    
}
