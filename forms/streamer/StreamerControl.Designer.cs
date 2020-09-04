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
            this.ImageStreamer = new BudgetExecution.Streamer();
            this.BudgetBinding = new BudgetExecution.BudgetBinding();
            this.BackPanel = new BudgetExecution.LayoutPanel();
            this.ToolTip = new BudgetExecution.ToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).BeginInit();
            this.BackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageStreamer
            // 
            this.ImageStreamer.AllowDragging = true;
            this.ImageStreamer.BindingSource = this.BudgetBinding;
            this.ImageStreamer.BudgetImages = null;
            this.ImageStreamer.DataFilter = null;
            this.ImageStreamer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageStreamer.Field = BudgetExecution.Field.NS;
            this.ImageStreamer.HoverText = null;
            this.ImageStreamer.ImageList = null;
            this.ImageStreamer.InternalBackColor = System.Drawing.Color.Transparent;
            this.ImageStreamer.Location = new System.Drawing.Point(0, 0);
            this.ImageStreamer.Name = "ImageStreamer";
            this.ImageStreamer.Padding = new System.Windows.Forms.Padding(1);
            this.ImageStreamer.ShowNavigator = true;
            this.ImageStreamer.Size = new System.Drawing.Size(118, 118);
            this.ImageStreamer.SlideShow = true;
            this.ImageStreamer.TabIndex = 0;
            this.ImageStreamer.TextAnimationDirection = Syncfusion.Windows.Forms.Tools.ImageStreamer.TextStreamDirection.RightToLeft;
            this.ImageStreamer.ToolTip = this.ToolTip;
            // 
            // BudgetBinding
            // 
            this.BudgetBinding.DataFilter = null;
            this.BudgetBinding.Numeric = BudgetExecution.Numeric.NS;
            // 
            // BackPanel
            // 
            this.BackPanel.BackColor = System.Drawing.Color.Transparent;
            this.BackPanel.BackColorState.Disabled = System.Drawing.Color.Transparent;
            this.BackPanel.BackColorState.Enabled = System.Drawing.Color.Transparent;
            this.BackPanel.BindingSource = null;
            this.BackPanel.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BackPanel.Border.HoverColor = System.Drawing.SystemColors.HotTrack;
            this.BackPanel.Border.HoverVisible = true;
            this.BackPanel.Border.Rounding = 6;
            this.BackPanel.Border.Thickness = 1;
            this.BackPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.BackPanel.Border.Visible = true;
            this.BackPanel.Children = null;
            this.BackPanel.Controls.Add(this.ImageStreamer);
            this.BackPanel.DataFilter = null;
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Field = BudgetExecution.Field.NS;
            this.BackPanel.ForeColor = System.Drawing.Color.LightGray;
            this.BackPanel.Location = new System.Drawing.Point(1, 1);
            this.BackPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Padding = new System.Windows.Forms.Padding(1);
            this.BackPanel.Size = new System.Drawing.Size(118, 118);
            this.BackPanel.TabIndex = 1;
            this.BackPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.BackPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BackPanel.ToolTip = null;
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 5000;
            this.ToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ToolTip.BindingSource = null;
            this.ToolTip.BorderColor = System.Drawing.Color.Blue;
            this.ToolTip.ForeColor = System.Drawing.Color.LightGray;
            this.ToolTip.InitialDelay = 500;
            this.ToolTip.Name = null;
            this.ToolTip.OwnerDraw = true;
            this.ToolTip.ReshowDelay = 100;
            this.ToolTip.Style = MetroSet_UI.Design.Style.Custom;
            this.ToolTip.StyleManager = null;
            this.ToolTip.ThemeAuthor = "Terry D. Eppler";
            this.ToolTip.ThemeName = "Budget Execution";
            this.ToolTip.TipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTip.TipTitle = "";
            // 
            // StreamerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BindingSource = this.BudgetBinding;
            this.Controls.Add(this.BackPanel);
            this.Name = "StreamerControl";
            this.Size = new System.Drawing.Size(120, 120);
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).EndInit();
            this.BackPanel.ResumeLayout(false);
            this.ResumeLayout(false);

            }

            #endregion

            public Streamer ImageStreamer;

            public LayoutPanel BackPanel;
        public BudgetBinding BudgetBinding;
        public ToolTip ToolTip;
    }
    
}
