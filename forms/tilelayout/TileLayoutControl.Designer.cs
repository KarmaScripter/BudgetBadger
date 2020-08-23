// <copyright file="TilePanel.cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    
    
        // **************************************************************************************************************************
        // ********************************************      ASSEMBLIES    **********************************************************
        // **************************************************************************************************************************

        using System;
        using System.ComponentModel;
        using System.Threading;
        using Syncfusion.Windows.Forms.Tools;

        partial class TileLayoutControl
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
            this.BackPanel = new BudgetExecution.LayoutPanel();
            this.TileLayout = new BudgetExecution.TilePanel();
            this.FirstGroup = new Syncfusion.Windows.Forms.Tools.LayoutGroup();
            this.SecondGroup = new Syncfusion.Windows.Forms.Tools.LayoutGroup();
            this.BackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TileLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TileLayout.MainLayout)).BeginInit();
            this.TileLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirstGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BackPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BackPanel.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BackPanel.BindingSource = null;
            this.BackPanel.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BackPanel.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.BackPanel.Border.HoverVisible = true;
            this.BackPanel.Border.Rounding = 6;
            this.BackPanel.Border.Thickness = 1;
            this.BackPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.BackPanel.Border.Visible = true;
            this.BackPanel.Children = null;
            this.BackPanel.Controls.Add(this.TileLayout);
            this.BackPanel.DataFilter = null;
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Field = BudgetExecution.Field.NS;
            this.BackPanel.ForeColor = System.Drawing.Color.LightGray;
            this.BackPanel.Location = new System.Drawing.Point(1, 1);
            this.BackPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Padding = new System.Windows.Forms.Padding(1);
            this.BackPanel.Size = new System.Drawing.Size(812, 344);
            this.BackPanel.TabIndex = 0;
            this.BackPanel.Text = "layoutPanel1";
            this.BackPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.BackPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // TileLayout
            // 
            this.TileLayout.AllowNewGroup = false;
            this.TileLayout.AutoScroll = true;
            this.TileLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TileLayout.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5))))));
            this.TileLayout.BindingSource = null;
            this.TileLayout.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.TileLayout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TileLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TileLayout.Controls.Add(this.FirstGroup);
            this.TileLayout.Controls.Add(this.SecondGroup);
            this.TileLayout.DataFilter = null;
            this.TileLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TileLayout.ExitButtonImage = null;
            this.TileLayout.Field = BudgetExecution.Field.NS;
            this.TileLayout.Font = new System.Drawing.Font("Roboto", 8F);
            this.TileLayout.ForeColor = System.Drawing.Color.LightGray;
            this.TileLayout.HoverText = null;
            this.TileLayout.ImageBuilder = null;
            this.TileLayout.ImageList = null;
            this.TileLayout.Items = 0;
            this.TileLayout.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.TileLayout.MainLayout.ContainerControl = this.BackPanel;
            this.TileLayout.Name = "TileLayout";
            this.TileLayout.NewGroupButtonImage = null;
            this.TileLayout.NewGroupIndicatorColor = System.Drawing.Color.Black;
            this.TileLayout.Padding = new System.Windows.Forms.Padding(1);
            this.TileLayout.SetParentFormFlat = true;
            this.TileLayout.ShowGroupTitle = true;
            this.TileLayout.ShowItemPreview = true;
            this.TileLayout.ShowPreviewButtonImage = null;
            this.TileLayout.Size = new System.Drawing.Size(812, 344);
            this.TileLayout.Streamer = null;
            this.TileLayout.TabIndex = 0;
            this.TileLayout.TextAlignment = Syncfusion.Windows.Forms.Tools.TextAlignment.Center;
            this.TileLayout.TitleFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TileLayout.Transparency = 10;
            // 
            // FirstGroup
            // 
            this.FirstGroup.BackColor = System.Drawing.Color.Transparent;
            this.FirstGroup.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.FirstGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FirstGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstGroup.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstGroup.Location = new System.Drawing.Point(100, 124);
            this.FirstGroup.Name = "FirstGroup";
            this.FirstGroup.SetItem = true;
            this.FirstGroup.Size = new System.Drawing.Size(260, 194);
            this.FirstGroup.TabIndex = 0;
            // 
            // SecondGroup
            // 
            this.SecondGroup.BackColor = System.Drawing.Color.Transparent;
            this.SecondGroup.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.SecondGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SecondGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecondGroup.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondGroup.Location = new System.Drawing.Point(435, 124);
            this.SecondGroup.Name = "SecondGroup";
            this.SecondGroup.SetItem = true;
            this.SecondGroup.Size = new System.Drawing.Size(260, 194);
            this.SecondGroup.TabIndex = 1;
            // 
            // TileLayoutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BackPanel);
            this.Name = "TileLayoutControl";
            this.Size = new System.Drawing.Size(814, 346);
            this.BackPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TileLayout.MainLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TileLayout)).EndInit();
            this.TileLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FirstGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondGroup)).EndInit();
            this.ResumeLayout(false);

            }

            #endregion

            public LayoutPanel BackPanel;

            public TilePanel TileLayout;

            public LayoutGroup FirstGroup;

            public LayoutGroup SecondGroup;
        }
    
}
