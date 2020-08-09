// <copyright file="{ClassName}.cs" company="Terry D. Eppler">
// Copyright (c) Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    
    
        // ********************************************************************************************************************************
        // *********************************************************  ASSEMBLIES   ********************************************************
        // ********************************************************************************************************************************

        using System;
        using System;
        using System.ComponentModel;
        using System.Threading;
        using System.Windows.Forms;
        using VisualPlus.Toolkit.Controls.Editors;
        using VisualPlus.Toolkit.Controls.Interactivity;
        using VisualPlus.Toolkit.Controls.Layout;

        partial class Message
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

                Syncfusion.Windows.Forms.CaptionImage captionImage1 =
                    new Syncfusion.Windows.Forms.CaptionImage();

                System.ComponentModel.ComponentResourceManager resources =
                    new System.ComponentModel.ComponentResourceManager( typeof( Message ) );

                this.BackPanel = new VisualPlus.Toolkit.Controls.Layout.VisualPanel();
                this.FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
                this.visualButton1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
                this.visualButton2 = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
                this.visualButton3 = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
                this.Table = new System.Windows.Forms.TableLayoutPanel();
                this.visualRichTextBox1 = new VisualPlus.Toolkit.Controls.Editors.VisualRichTextBox();
                this.Info = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
                this.BackPanel.SuspendLayout();
                this.FlowPanel.SuspendLayout();
                this.Table.SuspendLayout();
                this.SuspendLayout();

                // 
                // BackPanel
                // 
                this.BackPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.BackPanel.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.BackPanel.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.BackPanel.Border.HoverColor = System.Drawing.SystemColors.HotTrack;
                this.BackPanel.Border.HoverVisible = false;
                this.BackPanel.Border.Rounding = 6;
                this.BackPanel.Border.Thickness = 1;
                this.BackPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.BackPanel.Border.Visible = true;
                this.BackPanel.Controls.Add( this.FlowPanel );
                this.BackPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.BackPanel.ForeColor = System.Drawing.Color.LightGray;
                this.BackPanel.Location = new System.Drawing.Point( 1, 361 );
                this.BackPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.BackPanel.Name = "BackPanel";
                this.BackPanel.Padding = new System.Windows.Forms.Padding( 1 );
                this.BackPanel.Size = new System.Drawing.Size( 634, 88 );
                this.BackPanel.TabIndex = 3;

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
                // FlowPanel
                // 
                this.FlowPanel.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.FlowPanel.Controls.Add( this.visualButton1 );
                this.FlowPanel.Controls.Add( this.visualButton2 );
                this.FlowPanel.Controls.Add( this.visualButton3 );
                this.FlowPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.FlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
                this.FlowPanel.ForeColor = System.Drawing.Color.LightGray;
                this.FlowPanel.Location = new System.Drawing.Point( 0, 0 );
                this.FlowPanel.Name = "FlowPanel";
                this.FlowPanel.Padding = new System.Windows.Forms.Padding( 1 );
                this.FlowPanel.Size = new System.Drawing.Size( 634, 88 );
                this.FlowPanel.TabIndex = 0;
                this.FlowPanel.WrapContents = false;

                // 
                // visualButton1
                // 
                this.visualButton1.Anchor =
                    ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top
                            | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );

                this.visualButton1.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.visualButton1.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.visualButton1.BackColorState.Hover = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ),
                    ( (int)( ( (byte)( 15 ) ) ) ) );

                this.visualButton1.BackColorState.Pressed = System.Drawing.SystemColors.HotTrack;

                this.visualButton1.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.visualButton1.Border.HoverColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.visualButton1.Border.HoverVisible = true;
                this.visualButton1.Border.Rounding = 6;
                this.visualButton1.Border.Thickness = 1;
                this.visualButton1.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.visualButton1.Border.Visible = true;
                this.visualButton1.DialogResult = System.Windows.Forms.DialogResult.None;
                this.visualButton1.ForeColor = System.Drawing.Color.LightGray;
                this.visualButton1.Image = null;
                this.visualButton1.Location = new System.Drawing.Point( 451, 4 );
                this.visualButton1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.visualButton1.Name = "visualButton1";
                this.visualButton1.Size = new System.Drawing.Size( 178, 78 );
                this.visualButton1.TabIndex = 0;
                this.visualButton1.Text = "Cancel";
                this.visualButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;

                this.visualButton1.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.visualButton1.TextStyle.Enabled = System.Drawing.Color.LightGray;

                this.visualButton1.TextStyle.Hover = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.visualButton1.TextStyle.Pressed = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.visualButton1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.visualButton1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.visualButton1.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                // 
                // visualButton2
                // 
                this.visualButton2.Anchor =
                    ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top
                            | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );

                this.visualButton2.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.visualButton2.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.visualButton2.BackColorState.Hover = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ),
                    ( (int)( ( (byte)( 15 ) ) ) ) );

                this.visualButton2.BackColorState.Pressed = System.Drawing.SystemColors.HotTrack;

                this.visualButton2.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.visualButton2.Border.HoverColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.visualButton2.Border.HoverVisible = true;
                this.visualButton2.Border.Rounding = 6;
                this.visualButton2.Border.Thickness = 1;
                this.visualButton2.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.visualButton2.Border.Visible = true;
                this.visualButton2.DialogResult = System.Windows.Forms.DialogResult.None;
                this.visualButton2.ForeColor = System.Drawing.Color.LightGray;
                this.visualButton2.Image = null;
                this.visualButton2.Location = new System.Drawing.Point( 267, 4 );
                this.visualButton2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.visualButton2.Name = "visualButton2";
                this.visualButton2.Size = new System.Drawing.Size( 178, 78 );
                this.visualButton2.TabIndex = 1;
                this.visualButton2.Text = "Accept";
                this.visualButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;

                this.visualButton2.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.visualButton2.TextStyle.Enabled = System.Drawing.Color.LightGray;

                this.visualButton2.TextStyle.Hover = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.visualButton2.TextStyle.Pressed = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.visualButton2.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.visualButton2.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.visualButton2.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                // 
                // visualButton3
                // 
                this.visualButton3.Anchor =
                    ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top
                            | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );

                this.visualButton3.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.visualButton3.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.visualButton3.BackColorState.Hover = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ),
                    ( (int)( ( (byte)( 15 ) ) ) ) );

                this.visualButton3.BackColorState.Pressed = System.Drawing.SystemColors.HotTrack;

                this.visualButton3.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.visualButton3.Border.HoverColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.visualButton3.Border.HoverVisible = true;
                this.visualButton3.Border.Rounding = 6;
                this.visualButton3.Border.Thickness = 1;
                this.visualButton3.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.visualButton3.Border.Visible = true;
                this.visualButton3.DialogResult = System.Windows.Forms.DialogResult.None;
                this.visualButton3.ForeColor = System.Drawing.Color.LightGray;
                this.visualButton3.Image = null;
                this.visualButton3.Location = new System.Drawing.Point( 65, 4 );
                this.visualButton3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.visualButton3.Name = "visualButton3";
                this.visualButton3.Size = new System.Drawing.Size( 196, 78 );
                this.visualButton3.TabIndex = 2;
                this.visualButton3.Text = "Browse";
                this.visualButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;

                this.visualButton3.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.visualButton3.TextStyle.Enabled = System.Drawing.Color.LightGray;

                this.visualButton3.TextStyle.Hover = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.visualButton3.TextStyle.Pressed = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.visualButton3.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.visualButton3.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.visualButton3.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                // 
                // Table
                // 
                this.Table.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Table.ColumnCount = 3;

                this.Table.ColumnStyles.Add(
                    new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent,
                        14.75129F ) );

                this.Table.ColumnStyles.Add(
                    new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent,
                        85.24871F ) );

                this.Table.ColumnStyles.Add(
                    new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 68F ) );

                this.Table.Controls.Add( this.visualRichTextBox1, 1, 0 );
                this.Table.Dock = System.Windows.Forms.DockStyle.Top;
                this.Table.Location = new System.Drawing.Point( 1, 34 );
                this.Table.Name = "Table";
                this.Table.Padding = new System.Windows.Forms.Padding( 1 );
                this.Table.RowCount = 1;

                this.Table.RowStyles.Add(
                    new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );

                this.Table.Size = new System.Drawing.Size( 634, 321 );
                this.Table.TabIndex = 4;

                // 
                // visualRichTextBox1
                // 
                this.visualRichTextBox1.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.visualRichTextBox1.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ),
                    ( (int)( ( (byte)( 15 ) ) ) ) );

                this.visualRichTextBox1.Border.Color = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.visualRichTextBox1.Border.HoverColor = System.Drawing.SystemColors.HotTrack;
                this.visualRichTextBox1.Border.HoverVisible = false;
                this.visualRichTextBox1.Border.Rounding = 6;
                this.visualRichTextBox1.Border.Thickness = 1;
                this.visualRichTextBox1.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.visualRichTextBox1.Border.Visible = true;
                this.visualRichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
                this.visualRichTextBox1.ForeColor = System.Drawing.Color.LightGray;
                this.visualRichTextBox1.Location = new System.Drawing.Point( 87, 4 );
                this.visualRichTextBox1.MaxLength = 2147483647;
                this.visualRichTextBox1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.visualRichTextBox1.Name = "visualRichTextBox1";
                this.visualRichTextBox1.ReadOnly = false;
                this.visualRichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
                this.visualRichTextBox1.ShowSelectionMargin = false;
                this.visualRichTextBox1.Size = new System.Drawing.Size( 474, 313 );
                this.visualRichTextBox1.TabIndex = 0;

                this.visualRichTextBox1.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.visualRichTextBox1.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.visualRichTextBox1.TextStyle.Hover = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.visualRichTextBox1.TextStyle.Pressed = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.visualRichTextBox1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.visualRichTextBox1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.visualRichTextBox1.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                // 
                // Info
                // 
                this.Info.Dock = System.Windows.Forms.DockStyle.Top;
                this.Info.ForeColor = System.Drawing.Color.LightGray;
                this.Info.Location = new System.Drawing.Point( 1, 1 );
                this.Info.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.Info.Name = "Info";
                this.Info.Orientation = System.Windows.Forms.Orientation.Horizontal;
                this.Info.Outline = false;
                this.Info.OutlineColor = System.Drawing.Color.Red;
                this.Info.OutlineLocation = new System.Drawing.Point( 0, 0 );

                this.Info.ReflectionColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 120 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Info.ReflectionSpacing = 0;
                this.Info.ShadowColor = System.Drawing.Color.Black;
                this.Info.ShadowDirection = 315;
                this.Info.ShadowLocation = new System.Drawing.Point( 0, 0 );
                this.Info.ShadowOpacity = 100;
                this.Info.Size = new System.Drawing.Size( 634, 33 );
                this.Info.TabIndex = 5;
                this.Info.Text = "Label";
                this.Info.TextAlignment = System.Drawing.StringAlignment.Center;
                this.Info.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.Info.TextStyle.Disabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 131 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ) );

                this.Info.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Info.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Info.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Info.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.Info.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.Info.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                // 
                // Message
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF( 96F, 96F );
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;

                this.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.BorderColor = System.Drawing.SystemColors.HotTrack;

                this.CaptionBarColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.CaptionButtonColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.CaptionButtonHoverColor = System.Drawing.Color.White;
                this.CaptionFont = new System.Drawing.Font( "Roboto", 8.25F );

                this.CaptionForeColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                captionImage1.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 15 ) ) ) ),
                    ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ) );

                captionImage1.Image =
                    ( (System.Drawing.Image)( resources.GetObject( "captionImage1.Image" ) ) );

                captionImage1.Location = new System.Drawing.Point( 20, 10 );
                captionImage1.Name = "CaptionImage1";
                captionImage1.Size = new System.Drawing.Size( 15, 15 );
                this.CaptionImages.Add( captionImage1 );
                this.ClientSize = new System.Drawing.Size( 636, 450 );
                this.Controls.Add( this.BackPanel );
                this.Controls.Add( this.Table );
                this.Controls.Add( this.Info );
                this.DoubleBuffered = true;

                this.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.ForeColor = System.Drawing.Color.LightGray;
                this.Icon = ( (System.Drawing.Icon)( resources.GetObject( "$this.Icon" ) ) );
                this.MaximizeBox = false;

                this.MetroColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.MinimizeBox = false;
                this.Name = "Message";
                this.Padding = new System.Windows.Forms.Padding( 1 );
                this.ShowIcon = false;
                this.ShowMaximizeBox = false;
                this.ShowMinimizeBox = false;
                this.ShowMouseOver = true;
                this.Text = "Message";
                this.BackPanel.ResumeLayout( false );
                this.FlowPanel.ResumeLayout( false );
                this.Table.ResumeLayout( false );
                this.ResumeLayout( false );

            }

            #endregion

            public VisualPanel BackPanel;

            public FlowLayoutPanel FlowPanel;

            private VisualButton visualButton1;

            private VisualButton visualButton2;

            private VisualButton visualButton3;

            public TableLayoutPanel Table;

            public VisualRichTextBox visualRichTextBox1;

            public VisualLabel Info;
        }
    
}