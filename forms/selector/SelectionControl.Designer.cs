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

        partial class SelectionControl
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
                this.Label = new LabelPanel();
                this.selector1 = new SelectionPanel();
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
                this.BackPanel.Controls.Add( this.selector1 );
                this.BackPanel.Controls.Add( this.Label );
                this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
                this.BackPanel.Field = Field.NS;
                this.BackPanel.DataFilter = null;
                this.BackPanel.ForeColor = System.Drawing.Color.LightGray;
                this.BackPanel.Location = new System.Drawing.Point( 1, 1 );
                this.BackPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.BackPanel.Name = "BackPanel";
                this.BackPanel.Padding = new System.Windows.Forms.Padding( 1 );
                this.BackPanel.Size = new System.Drawing.Size( 914, 616 );
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

                // 
                // Label
                // 
                this.Label.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Label.Dock = System.Windows.Forms.DockStyle.Top;
                this.Label.Field = Field.NS;
                this.Label.DataFilter = null;

                this.Label.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.Label.ForeColor = System.Drawing.Color.LightGray;
                this.Label.Location = new System.Drawing.Point( 0, 0 );
                this.Label.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.Label.Name = "Label";
                this.Label.Numeric = Numeric.NS;
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
                this.Label.Size = new System.Drawing.Size( 914, 43 );
                this.Label.TabIndex = 0;
                this.Label.Text = "Text Information";
                this.Label.TextAlignment = System.Drawing.StringAlignment.Center;
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

                // 
                // selector1
                // 
                this.selector1.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.selector1.BudgetImages = null;
                this.selector1.Dock = System.Windows.Forms.DockStyle.Fill;
                this.selector1.Font = new System.Drawing.Font( "Roboto", 8F );
                this.selector1.ForeColor = System.Drawing.Color.LightGray;
                this.selector1.HighlightColor = System.Drawing.SystemColors.HotTrack;

                this.selector1.ImageshadeColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.selector1.ImageSlides = true;
                this.selector1.Location = new System.Drawing.Point( 0, 43 );
                this.selector1.MaximumSize = new System.Drawing.Size( 1400, 900 );
                this.selector1.Name = "selector1";
                this.selector1.Padding = new System.Windows.Forms.Padding( 1 );
                this.selector1.PadX = 0;
                this.selector1.PadY = 0;
                this.selector1.Perspective = 4F;
                this.selector1.RotateAlways = false;
                this.selector1.SelectionImages = null;
                this.selector1.ShowImagePreview = true;
                this.selector1.ShowImageShadow = true;
                this.selector1.Size = new System.Drawing.Size( 914, 573 );
                this.selector1.TabIndex = 1;
                this.selector1.Text = "selector1";
                this.selector1.TouchTransitionSpeed = 1F;
                this.selector1.UseOriginalImageinPreview = false;
                this.selector1.VisualStyle = Syncfusion.Windows.Forms.Tools.CarouselVisualStyle.Metro;

                // 
                // SelectionControl
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.Controls.Add( this.BackPanel );
                this.Name = "SelectionControl";
                this.Size = new System.Drawing.Size( 916, 618 );
                this.BackPanel.ResumeLayout( false );
                this.ResumeLayout( false );

            }

            #endregion

            public LayoutPanel BackPanel;

            public SelectionPanel selector1;

            public LabelPanel Label;
        }
    
}
