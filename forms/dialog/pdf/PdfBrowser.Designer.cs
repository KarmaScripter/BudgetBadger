
namespace BudgetExecution
{
    
    
        // ********************************************************************************************************************************
        // *********************************************************  ASSEMBLIES   ********************************************************
        // ********************************************************************************************************************************
        
        using System;
        using System.ComponentModel;
        using System.Threading;
        using System.Windows.Forms;
        using VisualPlus.Toolkit.Controls.Editors;
        using VisualPlus.Toolkit.Controls.Interactivity;
        using VisualPlus.Toolkit.Controls.Layout;

        partial class PdfBrowser
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
                    new System.ComponentModel.ComponentResourceManager( typeof( PdfBrowser ) );

                this.visualLabel1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
                this.visualPanel2 = new VisualPlus.Toolkit.Controls.Layout.VisualPanel();
                this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
                this.visualButton1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
                this.visualButton2 = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
                this.visualButton3 = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
                this.Table = new System.Windows.Forms.TableLayoutPanel();
                this.visualRichTextBox1 = new VisualPlus.Toolkit.Controls.Editors.VisualRichTextBox();
                this.visualPanel2.SuspendLayout();
                this.flowLayoutPanel1.SuspendLayout();
                this.Table.SuspendLayout();
                this.SuspendLayout();

                // 
                // visualLabel1
                // 
                this.visualLabel1.Dock = System.Windows.Forms.DockStyle.Top;
                this.visualLabel1.ForeColor = System.Drawing.Color.LightGray;
                this.visualLabel1.Location = new System.Drawing.Point( 0, 0 );
                this.visualLabel1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.visualLabel1.Name = "visualLabel1";
                this.visualLabel1.Orientation = System.Windows.Forms.Orientation.Horizontal;
                this.visualLabel1.Outline = false;
                this.visualLabel1.OutlineColor = System.Drawing.Color.Red;
                this.visualLabel1.OutlineLocation = new System.Drawing.Point( 0, 0 );

                this.visualLabel1.ReflectionColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 120 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.visualLabel1.ReflectionSpacing = 0;
                this.visualLabel1.ShadowColor = System.Drawing.Color.Black;
                this.visualLabel1.ShadowDirection = 315;
                this.visualLabel1.ShadowLocation = new System.Drawing.Point( 0, 0 );
                this.visualLabel1.ShadowOpacity = 100;
                this.visualLabel1.Size = new System.Drawing.Size( 656, 33 );
                this.visualLabel1.TabIndex = 0;
                this.visualLabel1.Text = "Label";
                this.visualLabel1.TextAlignment = System.Drawing.StringAlignment.Center;
                this.visualLabel1.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.visualLabel1.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.visualLabel1.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.visualLabel1.TextStyle.Hover = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.visualLabel1.TextStyle.Pressed = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.visualLabel1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.visualLabel1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.visualLabel1.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                // 
                // visualPanel2
                // 
                this.visualPanel2.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.visualPanel2.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.visualPanel2.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.visualPanel2.Border.HoverColor = System.Drawing.SystemColors.HotTrack;
                this.visualPanel2.Border.HoverVisible = false;
                this.visualPanel2.Border.Rounding = 6;
                this.visualPanel2.Border.Thickness = 1;
                this.visualPanel2.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.visualPanel2.Border.Visible = true;
                this.visualPanel2.Controls.Add( this.flowLayoutPanel1 );
                this.visualPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.visualPanel2.ForeColor = System.Drawing.Color.LightGray;
                this.visualPanel2.Location = new System.Drawing.Point( 0, 347 );
                this.visualPanel2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.visualPanel2.Name = "visualPanel2";
                this.visualPanel2.Padding = new System.Windows.Forms.Padding( 1 );
                this.visualPanel2.Size = new System.Drawing.Size( 656, 103 );
                this.visualPanel2.TabIndex = 3;
                this.visualPanel2.Text = "visualPanel2";

                this.visualPanel2.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.visualPanel2.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.visualPanel2.TextStyle.Hover = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.visualPanel2.TextStyle.Pressed = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.visualPanel2.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.visualPanel2.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.visualPanel2.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                // 
                // flowLayoutPanel1
                // 
                this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.flowLayoutPanel1.Controls.Add( this.visualButton1 );
                this.flowLayoutPanel1.Controls.Add( this.visualButton2 );
                this.flowLayoutPanel1.Controls.Add( this.visualButton3 );
                this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
                this.flowLayoutPanel1.Location = new System.Drawing.Point( 0, 15 );
                this.flowLayoutPanel1.Name = "flowLayoutPanel1";
                this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding( 1 );
                this.flowLayoutPanel1.Size = new System.Drawing.Size( 656, 88 );
                this.flowLayoutPanel1.TabIndex = 0;
                this.flowLayoutPanel1.WrapContents = false;

                // 
                // visualButton1
                // 
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

                this.visualButton1.Border.HoverColor = System.Drawing.SystemColors.HotTrack;
                this.visualButton1.Border.HoverVisible = false;
                this.visualButton1.Border.Rounding = 6;
                this.visualButton1.Border.Thickness = 1;
                this.visualButton1.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.visualButton1.Border.Visible = true;
                this.visualButton1.DialogResult = System.Windows.Forms.DialogResult.None;
                this.visualButton1.ForeColor = System.Drawing.Color.LightGray;
                this.visualButton1.Image = null;
                this.visualButton1.Location = new System.Drawing.Point( 473, 4 );
                this.visualButton1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.visualButton1.Name = "visualButton1";
                this.visualButton1.Size = new System.Drawing.Size( 178, 70 );
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

                this.visualButton2.Border.HoverColor = System.Drawing.SystemColors.HotTrack;
                this.visualButton2.Border.HoverVisible = false;
                this.visualButton2.Border.Rounding = 6;
                this.visualButton2.Border.Thickness = 1;
                this.visualButton2.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.visualButton2.Border.Visible = true;
                this.visualButton2.DialogResult = System.Windows.Forms.DialogResult.None;
                this.visualButton2.ForeColor = System.Drawing.Color.LightGray;
                this.visualButton2.Image = null;
                this.visualButton2.Location = new System.Drawing.Point( 289, 4 );
                this.visualButton2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.visualButton2.Name = "visualButton2";
                this.visualButton2.Size = new System.Drawing.Size( 178, 70 );
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

                this.visualButton3.Border.HoverColor = System.Drawing.SystemColors.HotTrack;
                this.visualButton3.Border.HoverVisible = false;
                this.visualButton3.Border.Rounding = 6;
                this.visualButton3.Border.Thickness = 1;
                this.visualButton3.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.visualButton3.Border.Visible = true;
                this.visualButton3.DialogResult = System.Windows.Forms.DialogResult.None;
                this.visualButton3.ForeColor = System.Drawing.Color.LightGray;
                this.visualButton3.Image = null;
                this.visualButton3.Location = new System.Drawing.Point( 105, 4 );
                this.visualButton3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.visualButton3.Name = "visualButton3";
                this.visualButton3.Size = new System.Drawing.Size( 178, 70 );
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
                    new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 14.6087F ) );

                this.Table.ColumnStyles.Add(
                    new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 85.3913F ) );

                this.Table.ColumnStyles.Add(
                    new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 78F ) );

                this.Table.Controls.Add( this.visualRichTextBox1, 1, 0 );
                this.Table.Dock = System.Windows.Forms.DockStyle.Top;
                this.Table.Location = new System.Drawing.Point( 0, 33 );
                this.Table.Name = "Table";
                this.Table.Padding = new System.Windows.Forms.Padding( 1 );
                this.Table.RowCount = 1;

                this.Table.RowStyles.Add(
                    new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );

                this.Table.Size = new System.Drawing.Size( 656, 323 );
                this.Table.TabIndex = 5;

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
                this.visualRichTextBox1.Location = new System.Drawing.Point( 88, 4 );
                this.visualRichTextBox1.MaxLength = 2147483647;
                this.visualRichTextBox1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.visualRichTextBox1.Name = "visualRichTextBox1";
                this.visualRichTextBox1.ReadOnly = false;
                this.visualRichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
                this.visualRichTextBox1.ShowSelectionMargin = false;
                this.visualRichTextBox1.Size = new System.Drawing.Size( 485, 315 );
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
                // PdfBrowser
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

                this.CaptionButtonHoverColor = System.Drawing.Color.Red;

                this.CaptionFont = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.CaptionForeColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                captionImage1.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                captionImage1.Image =
                    ( (System.Drawing.Image)( resources.GetObject( "captionImage1.Image" ) ) );

                captionImage1.Location = new System.Drawing.Point( 20, 10 );
                captionImage1.Name = "PdfImage";
                captionImage1.Size = new System.Drawing.Size( 25, 20 );
                this.CaptionImages.Add( captionImage1 );
                this.ClientSize = new System.Drawing.Size( 656, 450 );
                this.Controls.Add( this.Table );
                this.Controls.Add( this.visualLabel1 );
                this.Controls.Add( this.visualPanel2 );
                this.DoubleBuffered = true;

                this.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.ForeColor = System.Drawing.Color.LightGray;
                this.Icon = ( (System.Drawing.Icon)( resources.GetObject( "$this.Icon" ) ) );
                this.MaximizeBox = false;

                this.MetroColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.MinimizeBox = false;
                this.Name = "PdfBrowser";
                this.ShowIcon = false;
                this.ShowMaximizeBox = false;
                this.ShowMinimizeBox = false;
                this.ShowMouseOver = true;
                this.Text = "PdfBrowser";
                this.visualPanel2.ResumeLayout( false );
                this.flowLayoutPanel1.ResumeLayout( false );
                this.Table.ResumeLayout( false );
                this.ResumeLayout( false );

            }

            #endregion

            public VisualLabel visualLabel1;

            public VisualPanel visualPanel2;

            public FlowLayoutPanel flowLayoutPanel1;

            public VisualButton visualButton1;

            public VisualButton visualButton2;

            public VisualButton visualButton3;

            public TableLayoutPanel Table;

            public VisualRichTextBox visualRichTextBox1;
        }
    
}