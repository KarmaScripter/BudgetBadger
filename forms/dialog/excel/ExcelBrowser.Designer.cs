using System;

namespace BudgetExecution
{
    using System.ComponentModel;
    using System.Threading;
    using System.Windows.Forms;
    using VisualPlus.Toolkit.Controls.Editors;
    using VisualPlus.Toolkit.Controls.Interactivity;
    using VisualPlus.Toolkit.Controls.Layout;

    partial class ExcelBrowser
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
                new System.ComponentModel.ComponentResourceManager( typeof( ExcelBrowser ) );

            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();

            this.visualLabel1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.BackPanel = new VisualPlus.Toolkit.Controls.Layout.VisualPanel();
            this.FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.visualButton1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.visualButton2 = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.visualButton3 = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.Dialog = new System.Windows.Forms.OpenFileDialog();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.visualRichTextBox1 = new VisualPlus.Toolkit.Controls.Editors.VisualRichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SideLabel = new LabelPanel();
            this.visualCheckBox1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualCheckBox();
            this.visualCheckBox2 = new VisualPlus.Toolkit.Controls.Interactivity.VisualCheckBox();
            this.visualCheckBox3 = new VisualPlus.Toolkit.Controls.Interactivity.VisualCheckBox();
            this.BackPanel.SuspendLayout();
            this.FlowPanel.SuspendLayout();
            this.Table.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();

            // 
            // visualLabel1
            // 
            this.visualLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.visualLabel1.ForeColor = System.Drawing.Color.LightGray;
            this.visualLabel1.Location = new System.Drawing.Point( 1, 1 );
            this.visualLabel1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel1.Name = "visualLabel1";
            this.visualLabel1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel1.Outline = false;
            this.visualLabel1.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel1.OutlineLocation = new System.Drawing.Point( 0, 0 );

            this.visualLabel1.ReflectionColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 120 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.visualLabel1.ReflectionSpacing = 0;
            this.visualLabel1.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel1.ShadowDirection = 315;
            this.visualLabel1.ShadowLocation = new System.Drawing.Point( 0, 0 );
            this.visualLabel1.ShadowOpacity = 100;
            this.visualLabel1.Size = new System.Drawing.Size( 640, 31 );
            this.visualLabel1.TabIndex = 1;
            this.visualLabel1.Text = "Label";
            this.visualLabel1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel1.TextLineAlignment = System.Drawing.StringAlignment.Center;

            this.visualLabel1.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                ( (int)( ( (byte)( 129 ) ) ) ) );

            this.visualLabel1.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.visualLabel1.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.visualLabel1.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.visualLabel1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

            this.visualLabel1.TextStyle.TextRenderingHint =
                System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // 
            // BackPanel
            // 
            this.BackPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.BackPanel.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

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
            this.BackPanel.Location = new System.Drawing.Point( 1, 358 );
            this.BackPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Padding = new System.Windows.Forms.Padding( 1 );
            this.BackPanel.Size = new System.Drawing.Size( 640, 91 );
            this.BackPanel.TabIndex = 2;

            this.BackPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 131 ) ) ) ),
                ( (int)( ( (byte)( 129 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ) );

            this.BackPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.BackPanel.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.BackPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

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
            this.FlowPanel.Location = new System.Drawing.Point( 0, 3 );
            this.FlowPanel.Name = "FlowPanel";
            this.FlowPanel.Padding = new System.Windows.Forms.Padding( 1 );
            this.FlowPanel.Size = new System.Drawing.Size( 640, 88 );
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
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.visualButton1.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.visualButton1.BackColorState.Hover = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ) );

            this.visualButton1.BackColorState.Pressed = System.Drawing.SystemColors.HotTrack;

            this.visualButton1.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.visualButton1.Border.HoverColor = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.visualButton1.Border.HoverVisible = true;
            this.visualButton1.Border.Rounding = 6;
            this.visualButton1.Border.Thickness = 1;
            this.visualButton1.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualButton1.Border.Visible = true;
            this.visualButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.visualButton1.ForeColor = System.Drawing.Color.LightGray;
            this.visualButton1.Image = null;
            this.visualButton1.Location = new System.Drawing.Point( 457, 4 );
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

            this.visualButton1.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.visualButton1.TextStyle.Pressed = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

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
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.visualButton2.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.visualButton2.BackColorState.Hover = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ) );

            this.visualButton2.BackColorState.Pressed = System.Drawing.SystemColors.HotTrack;

            this.visualButton2.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.visualButton2.Border.HoverColor = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.visualButton2.Border.HoverVisible = true;
            this.visualButton2.Border.Rounding = 6;
            this.visualButton2.Border.Thickness = 1;
            this.visualButton2.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualButton2.Border.Visible = true;
            this.visualButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.visualButton2.ForeColor = System.Drawing.Color.LightGray;
            this.visualButton2.Image = null;
            this.visualButton2.Location = new System.Drawing.Point( 273, 4 );
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

            this.visualButton2.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.visualButton2.TextStyle.Pressed = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

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
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.visualButton3.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.visualButton3.BackColorState.Hover = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ) );

            this.visualButton3.BackColorState.Pressed = System.Drawing.SystemColors.HotTrack;

            this.visualButton3.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.visualButton3.Border.HoverColor = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.visualButton3.Border.HoverVisible = true;
            this.visualButton3.Border.Rounding = 6;
            this.visualButton3.Border.Thickness = 1;
            this.visualButton3.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualButton3.Border.Visible = true;
            this.visualButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.visualButton3.ForeColor = System.Drawing.Color.LightGray;
            this.visualButton3.Image = null;
            this.visualButton3.Location = new System.Drawing.Point( 89, 4 );
            this.visualButton3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualButton3.Name = "visualButton3";
            this.visualButton3.Size = new System.Drawing.Size( 178, 78 );
            this.visualButton3.TabIndex = 2;
            this.visualButton3.Text = "Browse";
            this.visualButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;

            this.visualButton3.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                ( (int)( ( (byte)( 129 ) ) ) ) );

            this.visualButton3.TextStyle.Enabled = System.Drawing.Color.LightGray;

            this.visualButton3.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.visualButton3.TextStyle.Pressed = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.visualButton3.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualButton3.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

            this.visualButton3.TextStyle.TextRenderingHint =
                System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // 
            // Dialog
            // 
            this.Dialog.DefaultExt = "xlsx";
            this.Dialog.FileName = "Excel";
            this.Dialog.Filter = "Excel FIles | *.xlsx | *.xls | *.csv";
            this.Dialog.Title = "Browse to Excel File";

            // 
            // Table
            // 
            this.Table.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.Table.ColumnCount = 3;

            this.Table.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 18.4466F ) );

            this.Table.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 81.5534F ) );

            this.Table.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 136F ) );

            this.Table.Controls.Add( this.visualRichTextBox1, 1, 0 );
            this.Table.Controls.Add( this.tableLayoutPanel1, 2, 0 );
            this.Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table.Location = new System.Drawing.Point( 1, 32 );
            this.Table.Name = "Table";
            this.Table.Padding = new System.Windows.Forms.Padding( 1 );
            this.Table.RowCount = 1;

            this.Table.RowStyles.Add(
                new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );

            this.Table.Size = new System.Drawing.Size( 640, 326 );
            this.Table.TabIndex = 5;

            // 
            // visualRichTextBox1
            // 
            this.visualRichTextBox1.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.visualRichTextBox1.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ) );

            this.visualRichTextBox1.Border.Color = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

            this.visualRichTextBox1.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.visualRichTextBox1.Border.HoverVisible = false;
            this.visualRichTextBox1.Border.Rounding = 6;
            this.visualRichTextBox1.Border.Thickness = 1;
            this.visualRichTextBox1.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualRichTextBox1.Border.Visible = true;
            this.visualRichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualRichTextBox1.ForeColor = System.Drawing.Color.LightGray;
            this.visualRichTextBox1.Location = new System.Drawing.Point( 96, 4 );
            this.visualRichTextBox1.MaxLength = 2147483647;
            this.visualRichTextBox1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualRichTextBox1.Name = "visualRichTextBox1";
            this.visualRichTextBox1.ReadOnly = false;
            this.visualRichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.visualRichTextBox1.ShowSelectionMargin = false;
            this.visualRichTextBox1.Size = new System.Drawing.Size( 403, 318 );
            this.visualRichTextBox1.TabIndex = 0;

            this.visualRichTextBox1.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                ( (int)( ( (byte)( 129 ) ) ) ) );

            this.visualRichTextBox1.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.visualRichTextBox1.TextStyle.Hover = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.visualRichTextBox1.TextStyle.Pressed = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.visualRichTextBox1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualRichTextBox1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

            this.visualRichTextBox1.TextStyle.TextRenderingHint =
                System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;

            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );

            this.tableLayoutPanel1.Controls.Add( this.visualCheckBox2, 0, 3 );
            this.tableLayoutPanel1.Controls.Add( this.SideLabel, 0, 0 );
            this.tableLayoutPanel1.Controls.Add( this.visualCheckBox1, 0, 1 );
            this.tableLayoutPanel1.Controls.Add( this.visualCheckBox3, 0, 2 );
            this.tableLayoutPanel1.Location = new System.Drawing.Point( 505, 4 );
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;

            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 65.85366F ) );

            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 34.14634F ) );

            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 33F ) );

            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 39F ) );

            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 38F ) );

            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );

            this.tableLayoutPanel1.Size = new System.Drawing.Size( 131, 233 );
            this.tableLayoutPanel1.TabIndex = 1;

            // 
            // SideLabel
            // 
            this.SideLabel.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.SideLabel.BindingSource = null;
            this.SideLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SideLabel.Field = Field.NS;
            this.SideLabel.DataFilter = null;
            this.SideLabel.Font = new System.Drawing.Font( "Roboto", 8F );
            this.SideLabel.ForeColor = System.Drawing.Color.LightGray;
            this.SideLabel.Location = new System.Drawing.Point( 3, 55 );
            this.SideLabel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.SideLabel.Name = "SideLabel";
            this.SideLabel.Numeric = Numeric.NS;
            this.SideLabel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.SideLabel.Outline = false;

            this.SideLabel.OutlineColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.SideLabel.OutlineLocation = new System.Drawing.Point( 0, 0 );

            this.SideLabel.ReflectionColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 120 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.SideLabel.ReflectionSpacing = 0;
            this.SideLabel.ShadowColor = System.Drawing.Color.Black;
            this.SideLabel.ShadowDirection = 315;
            this.SideLabel.ShadowLocation = new System.Drawing.Point( 0, 0 );
            this.SideLabel.ShadowOpacity = 100;
            this.SideLabel.Size = new System.Drawing.Size( 125, 23 );
            this.SideLabel.TabIndex = 2;
            this.SideLabel.Text = "Inlude";
            this.SideLabel.TextAlignment = System.Drawing.StringAlignment.Near;
            this.SideLabel.TextLineAlignment = System.Drawing.StringAlignment.Far;

            this.SideLabel.TextStyle.Disabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 131 ) ) ) ),
                ( (int)( ( (byte)( 129 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ) );

            this.SideLabel.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.SideLabel.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.SideLabel.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.SideLabel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.SideLabel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

            this.SideLabel.TextStyle.TextRenderingHint =
                System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;


            // 
            // visualCheckBox1
            // 
            this.visualCheckBox1.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

            this.visualCheckBox1.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.visualCheckBox1.Border.HoverVisible = true;
            this.visualCheckBox1.Border.Rounding = 3;
            this.visualCheckBox1.Border.Thickness = 1;
            this.visualCheckBox1.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualCheckBox1.Border.Visible = true;
            this.visualCheckBox1.Box = new System.Drawing.Size( 14, 14 );

            this.visualCheckBox1.BoxColorState.Disabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.visualCheckBox1.BoxColorState.Enabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 40 ) ) ) ), ( (int)( ( (byte)( 40 ) ) ) ), ( (int)( ( (byte)( 40 ) ) ) ) );

            this.visualCheckBox1.BoxColorState.Hover = System.Drawing.Color.SteelBlue;
            this.visualCheckBox1.BoxColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.visualCheckBox1.BoxSpacing = 2;
            this.visualCheckBox1.Checked = true;
            this.visualCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.visualCheckBox1.CheckStyle.AutoSize = true;
            this.visualCheckBox1.CheckStyle.Bounds = new System.Drawing.Rectangle( 0, 0, 125, 23 );
            this.visualCheckBox1.CheckStyle.Character = '✔';
            this.visualCheckBox1.CheckStyle.CheckColor = System.Drawing.Color.Lime;

            this.visualCheckBox1.CheckStyle.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

            this.visualCheckBox1.CheckStyle.Image =
                ( (System.Drawing.Image)( resources.GetObject( "resource.Image1" ) ) );

            this.visualCheckBox1.CheckStyle.ShapeRounding = 3;
            this.visualCheckBox1.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualCheckBox1.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.visualCheckBox1.CheckStyle.Thickness = 2F;
            this.visualCheckBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.visualCheckBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.visualCheckBox1.ForeColor = System.Drawing.Color.LightGray;
            this.visualCheckBox1.IsBoxLarger = false;
            this.visualCheckBox1.Location = new System.Drawing.Point( 10, 97 );
            this.visualCheckBox1.Margin = new System.Windows.Forms.Padding( 10, 3, 3, 3 );
            this.visualCheckBox1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualCheckBox1.Name = "visualCheckBox1";
            this.visualCheckBox1.Size = new System.Drawing.Size( 118, 23 );
            this.visualCheckBox1.TabIndex = 3;
            this.visualCheckBox1.Text = "    .xlsx";
            this.visualCheckBox1.TextSize = new System.Drawing.Size( 38, 15 );

            this.visualCheckBox1.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                ( (int)( ( (byte)( 129 ) ) ) ) );

            this.visualCheckBox1.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.visualCheckBox1.TextStyle.Hover = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.visualCheckBox1.TextStyle.Pressed = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.visualCheckBox1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualCheckBox1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

            this.visualCheckBox1.TextStyle.TextRenderingHint =
                System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // 
            // visualCheckBox2
            // 
            this.visualCheckBox2.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

            this.visualCheckBox2.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.visualCheckBox2.Border.HoverVisible = true;
            this.visualCheckBox2.Border.Rounding = 3;
            this.visualCheckBox2.Border.Thickness = 1;
            this.visualCheckBox2.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualCheckBox2.Border.Visible = true;
            this.visualCheckBox2.Box = new System.Drawing.Size( 14, 14 );

            this.visualCheckBox2.BoxColorState.Disabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.visualCheckBox2.BoxColorState.Enabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 40 ) ) ) ), ( (int)( ( (byte)( 40 ) ) ) ), ( (int)( ( (byte)( 40 ) ) ) ) );

            this.visualCheckBox2.BoxColorState.Hover = System.Drawing.Color.SteelBlue;
            this.visualCheckBox2.BoxColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.visualCheckBox2.BoxSpacing = 2;
            this.visualCheckBox2.CheckStyle.AutoSize = true;
            this.visualCheckBox2.CheckStyle.Bounds = new System.Drawing.Rectangle( 0, 0, 125, 23 );
            this.visualCheckBox2.CheckStyle.Character = '✔';

            this.visualCheckBox2.CheckStyle.CheckColor = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 45 ) ) ) ), ( (int)( ( (byte)( 136 ) ) ) ),
                ( (int)( ( (byte)( 45 ) ) ) ) );

            this.visualCheckBox2.CheckStyle.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

            this.visualCheckBox2.CheckStyle.Image =
                ( (System.Drawing.Image)( resources.GetObject( "resource.Image" ) ) );

            this.visualCheckBox2.CheckStyle.ShapeRounding = 3;
            this.visualCheckBox2.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualCheckBox2.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.visualCheckBox2.CheckStyle.Thickness = 2F;
            this.visualCheckBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visualCheckBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.visualCheckBox2.ForeColor = System.Drawing.Color.LightGray;
            this.visualCheckBox2.IsBoxLarger = false;
            this.visualCheckBox2.Location = new System.Drawing.Point( 10, 169 );
            this.visualCheckBox2.Margin = new System.Windows.Forms.Padding( 10, 3, 3, 3 );
            this.visualCheckBox2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualCheckBox2.Name = "visualCheckBox2";
            this.visualCheckBox2.Size = new System.Drawing.Size( 118, 23 );
            this.visualCheckBox2.TabIndex = 4;
            this.visualCheckBox2.Text = "    .csv";
            this.visualCheckBox2.TextSize = new System.Drawing.Size( 35, 15 );

            this.visualCheckBox2.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                ( (int)( ( (byte)( 129 ) ) ) ) );

            this.visualCheckBox2.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.visualCheckBox2.TextStyle.Hover = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.visualCheckBox2.TextStyle.Pressed = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.visualCheckBox2.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualCheckBox2.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

            this.visualCheckBox2.TextStyle.TextRenderingHint =
                System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // 
            // visualCheckBox3
            // 
            this.visualCheckBox3.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

            this.visualCheckBox3.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.visualCheckBox3.Border.HoverVisible = true;
            this.visualCheckBox3.Border.Rounding = 3;
            this.visualCheckBox3.Border.Thickness = 1;
            this.visualCheckBox3.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualCheckBox3.Border.Visible = true;
            this.visualCheckBox3.Box = new System.Drawing.Size( 14, 14 );

            this.visualCheckBox3.BoxColorState.Disabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.visualCheckBox3.BoxColorState.Enabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 40 ) ) ) ), ( (int)( ( (byte)( 40 ) ) ) ), ( (int)( ( (byte)( 40 ) ) ) ) );

            this.visualCheckBox3.BoxColorState.Hover = System.Drawing.Color.SteelBlue;
            this.visualCheckBox3.BoxColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.visualCheckBox3.BoxSpacing = 2;
            this.visualCheckBox3.CheckStyle.AutoSize = true;
            this.visualCheckBox3.CheckStyle.Bounds = new System.Drawing.Rectangle( 0, 0, 125, 23 );
            this.visualCheckBox3.CheckStyle.Character = '✔';

            this.visualCheckBox3.CheckStyle.CheckColor = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 45 ) ) ) ), ( (int)( ( (byte)( 136 ) ) ) ),
                ( (int)( ( (byte)( 45 ) ) ) ) );

            this.visualCheckBox3.CheckStyle.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

            this.visualCheckBox3.CheckStyle.Image =
                ( (System.Drawing.Image)( resources.GetObject( "resource.Image2" ) ) );

            this.visualCheckBox3.CheckStyle.ShapeRounding = 3;
            this.visualCheckBox3.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualCheckBox3.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.visualCheckBox3.CheckStyle.Thickness = 2F;
            this.visualCheckBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visualCheckBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.visualCheckBox3.ForeColor = System.Drawing.Color.LightGray;
            this.visualCheckBox3.IsBoxLarger = false;
            this.visualCheckBox3.Location = new System.Drawing.Point( 10, 130 );
            this.visualCheckBox3.Margin = new System.Windows.Forms.Padding( 10, 3, 3, 3 );
            this.visualCheckBox3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualCheckBox3.Name = "visualCheckBox3";
            this.visualCheckBox3.Size = new System.Drawing.Size( 118, 23 );
            this.visualCheckBox3.TabIndex = 5;
            this.visualCheckBox3.Text = "    .xls";
            this.visualCheckBox3.TextSize = new System.Drawing.Size( 32, 15 );

            this.visualCheckBox3.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                ( (int)( ( (byte)( 129 ) ) ) ) );

            this.visualCheckBox3.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.visualCheckBox3.TextStyle.Hover = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.visualCheckBox3.TextStyle.Pressed = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.visualCheckBox3.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualCheckBox3.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

            this.visualCheckBox3.TextStyle.TextRenderingHint =
                System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // 
            // ExcelBrowser
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

            this.CaptionFont = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

            this.CaptionForeColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            captionImage1.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 15 ) ) ) ),
                ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ) );

            captionImage1.Image = ( (System.Drawing.Image)( resources.GetObject( "captionImage1.Image" ) ) );

            captionImage1.Location = new System.Drawing.Point( 20, 10 );
            captionImage1.Name = "CaptionImage1";
            captionImage1.Size = new System.Drawing.Size( 25, 20 );
            this.CaptionImages.Add( captionImage1 );
            this.ClientSize = new System.Drawing.Size( 642, 450 );
            this.Controls.Add( this.Table );
            this.Controls.Add( this.visualLabel1 );
            this.Controls.Add( this.BackPanel );

            this.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ( (System.Drawing.Icon)( resources.GetObject( "$this.Icon" ) ) );
            this.MaximizeBox = false;

            this.MetroColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 15 ) ) ) ),
                ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ) );

            this.MinimizeBox = false;
            this.Name = "ExcelBrowser";
            this.Padding = new System.Windows.Forms.Padding( 1 );
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.ShowMouseOver = true;
            this.Text = "ExcelBrowser";
            this.BackPanel.ResumeLayout( false );
            this.FlowPanel.ResumeLayout( false );
            this.Table.ResumeLayout( false );
            this.tableLayoutPanel1.ResumeLayout( false );
            this.ResumeLayout( false );

        }

        #endregion

        public VisualLabel visualLabel1;

        public VisualPanel BackPanel;

        public FlowLayoutPanel FlowPanel;

        private VisualButton visualButton1;

        private VisualButton visualButton2;

        private VisualButton visualButton3;

        public OpenFileDialog Dialog;

        public TableLayoutPanel Table;

        public VisualRichTextBox visualRichTextBox1;

        private TableLayoutPanel tableLayoutPanel1;

        private LabelPanel SideLabel;

        public VisualCheckBox visualCheckBox1;

        public VisualCheckBox visualCheckBox2;

        public VisualCheckBox visualCheckBox3;
    }

}
