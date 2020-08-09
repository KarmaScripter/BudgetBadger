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

        partial class PdfDocument
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
                Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings pdfViewerPrinterSettings1 =
                    new Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings();

                System.ComponentModel.ComponentResourceManager resources =
                    new System.ComponentModel.ComponentResourceManager( typeof( PdfDocument ) );

                Syncfusion.Windows.Forms.CaptionImage captionImage1 =
                    new Syncfusion.Windows.Forms.CaptionImage();

                this.pdfViewerControl1 = new Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl();
                this.SuspendLayout();

                // 
                // pdfViewerControl1
                // 
                this.pdfViewerControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.pdfViewerControl1.EnableNotificationBar = true;
                this.pdfViewerControl1.IsBookmarkEnabled = true;
                this.pdfViewerControl1.Location = new System.Drawing.Point( 1, 4 );
                this.pdfViewerControl1.Name = "pdfViewerControl1";
                this.pdfViewerControl1.PageBorderThickness = 1;

                pdfViewerPrinterSettings1.PrintLocation =
                    ( (System.Drawing.PointF)( resources.GetObject(
                        "pdfViewerPrinterSettings1.PrintLocation" ) ) );

                this.pdfViewerControl1.PrinterSettings = pdfViewerPrinterSettings1;
                this.pdfViewerControl1.ScrollDisplacementValue = 0;
                this.pdfViewerControl1.ShowHorizontalScrollBar = true;
                this.pdfViewerControl1.ShowToolBar = true;
                this.pdfViewerControl1.ShowVerticalScrollBar = true;
                this.pdfViewerControl1.Size = new System.Drawing.Size( 1114, 879 );
                this.pdfViewerControl1.TabIndex = 0;
                this.pdfViewerControl1.Text = "pdfViewerControl1";
                this.pdfViewerControl1.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.Default;

                // 
                // PdfDocument
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

                captionImage1.Location = new System.Drawing.Point( 10, 10 );
                captionImage1.Name = "CaptionImage1";
                captionImage1.Size = new System.Drawing.Size( 20, 20 );
                this.CaptionImages.Add( captionImage1 );
                this.ClientSize = new System.Drawing.Size( 1116, 884 );
                this.Controls.Add( this.pdfViewerControl1 );
                this.DoubleBuffered = true;

                this.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.ForeColor = System.Drawing.Color.LightGray;
                this.Icon = ( (System.Drawing.Icon)( resources.GetObject( "$this.Icon" ) ) );
                this.MaximizeBox = false;

                this.MetroColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.MinimizeBox = false;
                this.Name = "PdfDocument";
                this.Padding = new System.Windows.Forms.Padding( 1 );
                this.ShowIcon = false;
                this.ShowMaximizeBox = false;
                this.ShowMinimizeBox = false;
                this.ShowMouseOver = true;
                this.ResumeLayout( false );

            }

            #endregion

            private PdfViewerControl pdfViewerControl1;
        }
    
}