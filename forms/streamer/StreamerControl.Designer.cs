// <copyright file="{ClassName}.cs" company="Terry D. Eppler">
// Copyright (c) Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    
    
        // **************************************************************************************************************************
        // ********************************************      ASSEMBLIES    **********************************************************
        // **************************************************************************************************************************
        
        using System;
        using System.ComponentModel;
        using System.Threading;

        partial class StreamerControl
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
                this.ImageStreamer = new Streamer();
                this.BackPanel = new LayoutPanel();
                this.BackPanel.SuspendLayout();
                this.SuspendLayout();

                // 
                // ImageStreamer
                // 
                this.ImageStreamer.AllowDragging = true;
                this.ImageStreamer.BindingSource = null;
                this.ImageStreamer.BudgetImages = null;
                this.ImageStreamer.Dock = System.Windows.Forms.DockStyle.Fill;
                this.ImageStreamer.Field = Field.NS;
                this.ImageStreamer.DataFilter = null;
                this.ImageStreamer.HoverText = null;
                this.ImageStreamer.ImageList = null;
                this.ImageStreamer.InternalBackColor = System.Drawing.Color.Transparent;
                this.ImageStreamer.Location = new System.Drawing.Point( 0, 0 );
                this.ImageStreamer.Name = "ImageStreamer";
                this.ImageStreamer.Padding = new System.Windows.Forms.Padding( 1 );
                this.ImageStreamer.ShowNavigator = true;
                this.ImageStreamer.Size = new System.Drawing.Size( 118, 118 );
                this.ImageStreamer.SlideShow = true;
                this.ImageStreamer.TabIndex = 0;

                this.ImageStreamer.TextAnimationDirection = Syncfusion.Windows.Forms.Tools.ImageStreamer
                    .TextStreamDirection.RightToLeft;

                // 
                // BackPanel
                // 
                this.BackPanel.BackColor = System.Drawing.Color.Transparent;
                this.BackPanel.BackColorState.Disabled = System.Drawing.Color.Transparent;
                this.BackPanel.BackColorState.Enabled = System.Drawing.Color.Transparent;
                this.BackPanel.BindingSource = null;

                this.BackPanel.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.BackPanel.Border.HoverColor = System.Drawing.SystemColors.HotTrack;
                this.BackPanel.Border.HoverVisible = true;
                this.BackPanel.Border.Rounding = 6;
                this.BackPanel.Border.Thickness = 1;
                this.BackPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.BackPanel.Border.Visible = true;
                this.BackPanel.Children = null;
                this.BackPanel.Controls.Add( this.ImageStreamer );
                this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
                this.BackPanel.Field = Field.NS;
                this.BackPanel.DataFilter = null;
                this.BackPanel.ForeColor = System.Drawing.Color.LightGray;
                this.BackPanel.Location = new System.Drawing.Point( 1, 1 );
                this.BackPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.BackPanel.Name = "BackPanel";
                this.BackPanel.Padding = new System.Windows.Forms.Padding( 1 );
                this.BackPanel.Size = new System.Drawing.Size( 118, 118 );
                this.BackPanel.TabIndex = 1;

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
                // StreamerControl
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.Controls.Add( this.BackPanel );
                this.Name = "StreamerControl";
                this.Size = new System.Drawing.Size( 120, 120 );
                this.BackPanel.ResumeLayout( false );
                this.ResumeLayout( false );

            }

            #endregion

            public Streamer ImageStreamer;

            public LayoutPanel BackPanel;
        }
    
}
