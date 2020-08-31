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
        using Syncfusion.Windows.Forms.PdfViewer;

        partial class PdfForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdfForm));
            Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings pdfViewerPrinterSettings1 = new Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings();
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBox = new BudgetExecution.PicturePanel();
            this.Label = new BudgetExecution.LabelPanel();
            this.CloseBox = new BudgetExecution.ClosePanel();
            this.BackPanel = new BudgetExecution.LayoutPanel();
            this.PdfDocument = new BudgetExecution.PdfPanel();
            this.Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.BackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.ColumnCount = 3;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.66667F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.33334F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.Table.Controls.Add(this.PictureBox, 0, 0);
            this.Table.Controls.Add(this.Label, 1, 0);
            this.Table.Controls.Add(this.CloseBox, 2, 0);
            this.Table.Dock = System.Windows.Forms.DockStyle.Top;
            this.Table.Location = new System.Drawing.Point(1, 1);
            this.Table.Margin = new System.Windows.Forms.Padding(5);
            this.Table.Name = "Table";
            this.Table.RowCount = 1;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.Size = new System.Drawing.Size(1114, 40);
            this.Table.TabIndex = 1;
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox.BindingSource = null;
            this.PictureBox.DataFilter = null;
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Field = BudgetExecution.Field.NS;
            this.PictureBox.HoverText = null;
            this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
            this.PictureBox.ImageList = null;
            this.PictureBox.Location = new System.Drawing.Point(3, 3);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Padding = new System.Windows.Forms.Padding(1);
            this.PictureBox.Size = new System.Drawing.Size(90, 34);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.ToolTip = null;
            // 
            // Label
            // 
            this.Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Label.BindingSource = null;
            this.Label.DataFilter = null;
            this.Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label.Field = BudgetExecution.Field.NS;
            this.Label.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.Color.White;
            this.Label.Location = new System.Drawing.Point(99, 3);
            this.Label.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.Label.Name = "Label";
            this.Label.Numeric = BudgetExecution.Numeric.NS;
            this.Label.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.Label.Outline = false;
            this.Label.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Label.OutlineLocation = new System.Drawing.Point(0, 0);
            this.Label.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label.ReflectionSpacing = 0;
            this.Label.ShadowColor = System.Drawing.Color.Black;
            this.Label.ShadowDirection = 315;
            this.Label.ShadowLocation = new System.Drawing.Point(0, 0);
            this.Label.ShadowOpacity = 100;
            this.Label.Size = new System.Drawing.Size(797, 34);
            this.Label.TabIndex = 1;
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
            // CloseBox
            // 
            this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBox.CloseHoverBackColor = System.Drawing.Color.Maroon;
            this.CloseBox.CloseHoverForeColor = System.Drawing.Color.White;
            this.CloseBox.CloseNormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.CloseBox.DisabledForeColor = System.Drawing.Color.DimGray;
            this.CloseBox.Font = new System.Drawing.Font("Roboto", 8F);
            this.CloseBox.ForeColor = System.Drawing.Color.LightGray;
            this.CloseBox.Location = new System.Drawing.Point(1014, 0);
            this.CloseBox.Margin = new System.Windows.Forms.Padding(0);
            this.CloseBox.MaximizeBox = true;
            this.CloseBox.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CloseBox.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.CloseBox.MaximizeNormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.CloseBox.MinimizeBox = true;
            this.CloseBox.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CloseBox.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.CloseBox.MinimizeNormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(100, 25);
            this.CloseBox.Style = MetroSet_UI.Design.Style.Custom;
            this.CloseBox.StyleManager = null;
            this.CloseBox.TabIndex = 2;
            this.CloseBox.Text = "closePanel1";
            this.CloseBox.ThemeAuthor = "Terry D. Eppler";
            this.CloseBox.ThemeName = "Budget Execution";
            this.CloseBox.ToolTip = null;
            // 
            // BackPanel
            // 
            this.BackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BackPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BackPanel.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BackPanel.BindingSource = null;
            this.BackPanel.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BackPanel.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.BackPanel.Border.HoverVisible = false;
            this.BackPanel.Border.Rounding = 6;
            this.BackPanel.Border.Thickness = 1;
            this.BackPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.BackPanel.Border.Visible = true;
            this.BackPanel.Children = null;
            this.BackPanel.Controls.Add(this.PdfDocument);
            this.BackPanel.DataFilter = null;
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Field = BudgetExecution.Field.NS;
            this.BackPanel.ForeColor = System.Drawing.Color.LightGray;
            this.BackPanel.Location = new System.Drawing.Point(1, 41);
            this.BackPanel.Margin = new System.Windows.Forms.Padding(5);
            this.BackPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Padding = new System.Windows.Forms.Padding(5);
            this.BackPanel.Size = new System.Drawing.Size(1114, 842);
            this.BackPanel.TabIndex = 2;
            this.BackPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.BackPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BackPanel.ToolTip = null;
            // 
            // PdfDocument
            // 
            this.PdfDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.PdfDocument.DataFilter = null;
            this.PdfDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PdfDocument.EnableNotificationBar = true;
            this.PdfDocument.Field = BudgetExecution.Field.NS;
            this.PdfDocument.ForeColor = System.Drawing.Color.LightGray;
            this.PdfDocument.HoverText = null;
            this.PdfDocument.IsBookmarkEnabled = true;
            this.PdfDocument.Location = new System.Drawing.Point(0, 0);
            this.PdfDocument.Margin = new System.Windows.Forms.Padding(5);
            this.PdfDocument.Name = "PdfDocument";
            this.PdfDocument.PageBorderThickness = 1;
            this.PdfDocument.PdfFileName = null;
            pdfViewerPrinterSettings1.PrintLocation = ((System.Drawing.PointF)(resources.GetObject("pdfViewerPrinterSettings1.PrintLocation")));
            this.PdfDocument.PrinterSettings = pdfViewerPrinterSettings1;
            this.PdfDocument.ScrollDisplacementValue = 0;
            this.PdfDocument.ShowHorizontalScrollBar = true;
            this.PdfDocument.ShowToolBar = true;
            this.PdfDocument.ShowVerticalScrollBar = true;
            this.PdfDocument.Size = new System.Drawing.Size(1114, 842);
            this.PdfDocument.TabIndex = 0;
            this.PdfDocument.ToolTip = null;
            this.PdfDocument.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.Default;
            // 
            // PdfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BorderColor = System.Drawing.Color.Blue;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.Red;
            this.CaptionFont = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            captionImage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            captionImage1.Image = ((System.Drawing.Image)(resources.GetObject("captionImage1.Image")));
            captionImage1.Location = new System.Drawing.Point(10, 10);
            captionImage1.Name = "CaptionImage1";
            captionImage1.Size = new System.Drawing.Size(20, 20);
            this.CaptionImages.Add(captionImage1);
            this.ClientSize = new System.Drawing.Size(1116, 884);
            this.ControlBox = false;
            this.Controls.Add(this.BackPanel);
            this.Controls.Add(this.Table);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.MinimizeBox = false;
            this.Name = "PdfForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.ShowMouseOver = true;
            this.Table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.BackPanel.ResumeLayout(false);
            this.ResumeLayout(false);

            }

        #endregion

        public System.Windows.Forms.TableLayoutPanel Table;
        private PicturePanel PictureBox;
        private LabelPanel Label;
        public ClosePanel CloseBox;
        public LayoutPanel BackPanel;
        public PdfPanel PdfDocument;
    }
    
}