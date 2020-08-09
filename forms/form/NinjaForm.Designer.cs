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
        using System.Windows.Forms;

        partial class NinjaForm
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

                System.ComponentModel.ComponentResourceManager resources =
                    new System.ComponentModel.ComponentResourceManager( typeof( NinjaForm ) );

                this.BackPanel = new LayoutPanel();
                this.CloseBox = new ClosePanel();
                this.Header = new System.Windows.Forms.TableLayoutPanel();
                this.Label = new LabelPanel();
                this.Picture = new PicturePanel();
                this.BackPanel.SuspendLayout();
                this.Header.SuspendLayout();
                ( (System.ComponentModel.ISupportInitialize)( this.Picture ) ).BeginInit();
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

                this.BackPanel.Border.HoverColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.BackPanel.Border.HoverVisible = false;
                this.BackPanel.Border.Rounding = 6;
                this.BackPanel.Border.Thickness = 0;
                this.BackPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.BackPanel.Border.Visible = false;
                this.BackPanel.Children = null;
                this.BackPanel.Controls.Add( this.Header );
                this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
                this.BackPanel.Field = Field.NS;
                this.BackPanel.ForeColor = System.Drawing.Color.LightGray;
                this.BackPanel.Location = new System.Drawing.Point( 0, 0 );
                this.BackPanel.Margin = new System.Windows.Forms.Padding( 0 );
                this.BackPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.BackPanel.Name = "BackPanel";
                this.BackPanel.Padding = new System.Windows.Forms.Padding( 1 );
                this.BackPanel.Size = new System.Drawing.Size( 1188, 663 );
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
                // CloseBox
                // 
                this.CloseBox.Anchor =
                    ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Top
                        | System.Windows.Forms.AnchorStyles.Right ) ) );

                this.CloseBox.BackColor = System.Drawing.Color.Transparent;
                this.CloseBox.Font = new System.Drawing.Font( "Roboto", 8F );
                this.CloseBox.ForeColor = System.Drawing.Color.LightGray;

                // 
                // 
                // 
                this.CloseBox.HelpButton.BackColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.CloseBox.HelpButton.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.CloseBox.HelpButton.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.CloseBox.HelpButton.BackColorState.Hover = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ) );

                this.CloseBox.HelpButton.BackColorState.Pressed = System.Drawing.SystemColors.HotTrack;

                this.CloseBox.HelpButton.BoxType =
                    VisualPlus.Toolkit.VisualBase.ControlBoxButton.ControlBoxType.Default;

                this.CloseBox.HelpButton.ForeColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.CloseBox.HelpButton.ForeColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.CloseBox.HelpButton.ForeColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.CloseBox.HelpButton.ForeColorState.Hover = System.Drawing.Color.Yellow;
                this.CloseBox.HelpButton.ForeColorState.Pressed = System.Drawing.SystemColors.HotTrack;

                this.CloseBox.HelpButton.Image =
                    ( (System.Drawing.Image)( resources.GetObject( "resource.Image" ) ) );

                this.CloseBox.HelpButton.Location = new System.Drawing.Point( 0, 0 );
                this.CloseBox.HelpButton.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.CloseBox.HelpButton.Name = "";
                this.CloseBox.HelpButton.OffsetLocation = new System.Drawing.Point( 0, 1 );
                this.CloseBox.HelpButton.Size = new System.Drawing.Size( 30, 25 );
                this.CloseBox.HelpButton.TabIndex = 0;
                this.CloseBox.HelpButton.Tag = "Documentation";
                this.CloseBox.HelpButton.Text = "s";

                this.CloseBox.HelpButton.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.CloseBox.HelpButton.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.CloseBox.HelpButton.TextStyle.Hover = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.CloseBox.HelpButton.TextStyle.Pressed = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.CloseBox.HelpButton.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.CloseBox.HelpButton.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.CloseBox.HelpButton.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.CloseBox.Location = new System.Drawing.Point( 1068, 0 );
                this.CloseBox.Margin = new System.Windows.Forms.Padding( 0 );

                // 
                // 
                // 
                this.CloseBox.MaximizeButton.BackColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.CloseBox.MaximizeButton.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.CloseBox.MaximizeButton.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.CloseBox.MaximizeButton.BackColorState.Hover = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ) );

                this.CloseBox.MaximizeButton.BackColorState.Pressed = System.Drawing.SystemColors.HotTrack;

                this.CloseBox.MaximizeButton.BoxType =
                    VisualPlus.Toolkit.VisualBase.ControlBoxButton.ControlBoxType.Default;

                this.CloseBox.MaximizeButton.ForeColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.CloseBox.MaximizeButton.ForeColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.CloseBox.MaximizeButton.ForeColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.CloseBox.MaximizeButton.ForeColorState.Hover = System.Drawing.Color.White;
                this.CloseBox.MaximizeButton.ForeColorState.Pressed = System.Drawing.SystemColors.HotTrack;

                this.CloseBox.MaximizeButton.Image =
                    ( (System.Drawing.Image)( resources.GetObject( "resource.Image1" ) ) );

                this.CloseBox.MaximizeButton.Location = new System.Drawing.Point( 48, 0 );
                this.CloseBox.MaximizeButton.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.CloseBox.MaximizeButton.Name = "";
                this.CloseBox.MaximizeButton.OffsetLocation = new System.Drawing.Point( 1, 1 );
                this.CloseBox.MaximizeButton.Size = new System.Drawing.Size( 30, 25 );
                this.CloseBox.MaximizeButton.TabIndex = 2;
                this.CloseBox.MaximizeButton.Tag = "Maximum Size";
                this.CloseBox.MaximizeButton.Text = "1";

                this.CloseBox.MaximizeButton.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.CloseBox.MaximizeButton.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.CloseBox.MaximizeButton.TextStyle.Hover = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.CloseBox.MaximizeButton.TextStyle.Pressed = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.CloseBox.MaximizeButton.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;

                this.CloseBox.MaximizeButton.TextStyle.TextLineAlignment =
                    System.Drawing.StringAlignment.Center;

                this.CloseBox.MaximizeButton.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                // 
                // 
                // 
                this.CloseBox.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.CloseBox.MinimizeButton.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.CloseBox.MinimizeButton.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.CloseBox.MinimizeButton.BackColorState.Hover = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ) );

                this.CloseBox.MinimizeButton.BackColorState.Pressed = System.Drawing.SystemColors.HotTrack;

                this.CloseBox.MinimizeButton.BoxType =
                    VisualPlus.Toolkit.VisualBase.ControlBoxButton.ControlBoxType.Default;

                this.CloseBox.MinimizeButton.ForeColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.CloseBox.MinimizeButton.ForeColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.CloseBox.MinimizeButton.ForeColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.CloseBox.MinimizeButton.ForeColorState.Hover = System.Drawing.Color.White;
                this.CloseBox.MinimizeButton.ForeColorState.Pressed = System.Drawing.SystemColors.HotTrack;

                this.CloseBox.MinimizeButton.Image =
                    ( (System.Drawing.Image)( resources.GetObject( "resource.Image2" ) ) );

                this.CloseBox.MinimizeButton.Location = new System.Drawing.Point( 24, 0 );
                this.CloseBox.MinimizeButton.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.CloseBox.MinimizeButton.Name = "";
                this.CloseBox.MinimizeButton.OffsetLocation = new System.Drawing.Point( 2, 0 );
                this.CloseBox.MinimizeButton.Size = new System.Drawing.Size( 30, 25 );
                this.CloseBox.MinimizeButton.TabIndex = 1;
                this.CloseBox.MinimizeButton.Tag = "Minimum Size";
                this.CloseBox.MinimizeButton.Text = "0";

                this.CloseBox.MinimizeButton.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.CloseBox.MinimizeButton.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.CloseBox.MinimizeButton.TextStyle.Hover = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.CloseBox.MinimizeButton.TextStyle.Pressed = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.CloseBox.MinimizeButton.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;

                this.CloseBox.MinimizeButton.TextStyle.TextLineAlignment =
                    System.Drawing.StringAlignment.Center;

                this.CloseBox.MinimizeButton.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.CloseBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.CloseBox.Name = "CloseBox";
                this.CloseBox.Size = new System.Drawing.Size( 120, 25 );
                this.CloseBox.TabIndex = 0;

                this.CloseBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.CloseBox.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.CloseBox.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.CloseBox.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.CloseBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.CloseBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.CloseBox.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.CloseBox.ToolTip = null;

                // 
                // Header
                // 
                this.Header.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Header.ColumnCount = 3;

                this.Header.ColumnStyles.Add(
                    new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent,
                        7.456979F ) );

                this.Header.ColumnStyles.Add(
                    new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent,
                        92.54302F ) );

                this.Header.ColumnStyles.Add(
                    new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 165F ) );

                this.Header.Controls.Add( this.CloseBox, 2, 0 );
                this.Header.Controls.Add( this.Label, 1, 0 );
                this.Header.Controls.Add( this.Picture, 0, 0 );
                this.Header.Dock = System.Windows.Forms.DockStyle.Top;
                this.Header.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
                this.Header.Location = new System.Drawing.Point( 0, 0 );
                this.Header.Name = "Header";
                this.Header.RowCount = 1;

                this.Header.RowStyles.Add(
                    new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );

                this.Header.Size = new System.Drawing.Size( 1188, 50 );
                this.Header.TabIndex = 1;

                // 
                // Label
                // 
                this.Label.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Label.Dock = System.Windows.Forms.DockStyle.Fill;
                this.Label.Field = Field.NS;
                this.Label.DataFilter = null;

                this.Label.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.Label.ForeColor = System.Drawing.Color.LightGray;
                this.Label.Location = new System.Drawing.Point( 91, 3 );
                this.Label.Margin = new System.Windows.Forms.Padding( 15, 3, 3, 3 );
                this.Label.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.Label.Name = "Label";
                this.Label.Numeric = Numeric.Default;
                this.Label.Orientation = System.Windows.Forms.Orientation.Horizontal;
                this.Label.Outline = false;

                this.Label.OutlineColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Label.OutlineLocation = new System.Drawing.Point( 0, 0 );

                this.Label.ReflectionColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 120 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label.ReflectionSpacing = 0;
                this.Label.ShadowColor = System.Drawing.Color.Black;
                this.Label.ShadowDirection = 315;
                this.Label.ShadowLocation = new System.Drawing.Point( 0, 0 );
                this.Label.ShadowOpacity = 100;
                this.Label.Size = new System.Drawing.Size( 928, 44 );
                this.Label.TabIndex = 1;
                this.Label.Text = "Title";
                this.Label.TextAlignment = System.Drawing.StringAlignment.Near;
                this.Label.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.Label.TextStyle.Disabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 131 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ) );

                this.Label.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.Label.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.Label.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.Label.ToolTip = null;

                // 
                // Picture
                // 
                this.Picture.BackColor = System.Drawing.Color.Transparent;
                this.Picture.BindingSource = null;
                this.Picture.Dock = System.Windows.Forms.DockStyle.Fill;
                this.Picture.Field = Field.NS;
                this.Picture.HoverText = null;
                this.Picture.ImageList = null;
                this.Picture.Location = new System.Drawing.Point( 3, 3 );
                this.Picture.Name = "Picture";
                this.Picture.Size = new System.Drawing.Size( 70, 44 );
                this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                this.Picture.TabIndex = 2;
                this.Picture.TabStop = false;
                this.Picture.ToolTip = null;

                // 
                // NinjaForm
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF( 96F, 96F );
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
                this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

                this.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.BorderColor = System.Drawing.Color.SteelBlue;
                this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;

                this.CaptionBarColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.CaptionBarHeight = 0;

                this.CaptionButtonColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.CaptionButtonHoverColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.CaptionFont = new System.Drawing.Font( "Roboto", 11.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.CaptionForeColor = System.Drawing.Color.LightGray;
                this.ClientSize = new System.Drawing.Size( 1188, 663 );
                this.ControlBox = false;
                this.Controls.Add( this.BackPanel );
                this.DoubleBuffered = true;

                this.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.ForeColor = System.Drawing.Color.LightGray;
                this.Icon = ( (System.Drawing.Icon)( resources.GetObject( "$this.Icon" ) ) );
                this.MaximizeBox = false;
                this.MaximumSize = new System.Drawing.Size( 1900, 1060 );

                this.MetroColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.MinimizeBox = false;
                this.MinimumSize = new System.Drawing.Size( 600, 400 );
                this.Name = "NinjaForm";
                this.ShowIcon = false;
                this.ShowMaximizeBox = false;
                this.ShowMinimizeBox = false;
                this.ShowMouseOver = true;
                this.BackPanel.ResumeLayout( false );
                this.Header.ResumeLayout( false );
                ( (System.ComponentModel.ISupportInitialize)( this.Picture ) ).EndInit();
                this.ResumeLayout( false );

            }

            #endregion

            public LayoutPanel BackPanel;

            public TableLayoutPanel Header;

            public LabelPanel Label;

            public PicturePanel Picture;

            public ClosePanel CloseBox;
        }

}