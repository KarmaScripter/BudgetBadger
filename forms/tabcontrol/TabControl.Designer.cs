// <copyright file="TabPage.cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    
    
        // ******************************************************************************************************************************
        // ******************************************************   ASSEMBLIES   ********************************************************
        // ******************************************************************************************************************************
        
        using System;
        using System.ComponentModel;
        using System.Threading;
        using Syncfusion.Windows.Forms.Tools;

        partial class TabControl
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
            this.Tab = new BudgetExecution.TabPanel();
            this.TabPage1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.TabPage2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.TabPage3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.TabPage4 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.TabPage5 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.TabPage6 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.TabPage7 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.TabPage8 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.TabPage9 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.TabPage10 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.BudgetBinding = new BudgetExecution.BudgetBinding();
            this.BackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab)).BeginInit();
            this.Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).BeginInit();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BackPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BackPanel.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BackPanel.BindingSource = null;
            this.BackPanel.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BackPanel.Border.HoverColor = System.Drawing.SystemColors.HotTrack;
            this.BackPanel.Border.HoverVisible = true;
            this.BackPanel.Border.Rounding = 6;
            this.BackPanel.Border.Thickness = 1;
            this.BackPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.BackPanel.Border.Visible = true;
            this.BackPanel.Children = null;
            this.BackPanel.Controls.Add(this.Tab);
            this.BackPanel.DataFilter = null;
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Field = BudgetExecution.Field.NS;
            this.BackPanel.ForeColor = System.Drawing.Color.LightGray;
            this.BackPanel.Location = new System.Drawing.Point(1, 1);
            this.BackPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Padding = new System.Windows.Forms.Padding(1);
            this.BackPanel.Size = new System.Drawing.Size(1148, 600);
            this.BackPanel.TabIndex = 0;
            this.BackPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.BackPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BackPanel.ToolTip = null;
            // 
            // Tab
            // 
            this.Tab.ActiveTabColor = System.Drawing.Color.Empty;
            this.Tab.ActiveTabForeColor = System.Drawing.Color.LightGray;
            this.Tab.AdjustTopGap = 5;
            this.Tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Tab.BeforeTouchSize = new System.Drawing.Size(1148, 600);
            this.Tab.BindingSource = null;
            this.Tab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tab.BorderWidth = 1;
            this.Tab.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Tab.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.Tab.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.Tab.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.Tab.Controls.Add(this.TabPage1);
            this.Tab.Controls.Add(this.TabPage2);
            this.Tab.Controls.Add(this.TabPage3);
            this.Tab.Controls.Add(this.TabPage4);
            this.Tab.Controls.Add(this.TabPage5);
            this.Tab.Controls.Add(this.TabPage6);
            this.Tab.Controls.Add(this.TabPage7);
            this.Tab.Controls.Add(this.TabPage8);
            this.Tab.Controls.Add(this.TabPage9);
            this.Tab.Controls.Add(this.TabPage10);
            this.Tab.DataFilter = null;
            this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab.Field = BudgetExecution.Field.NS;
            this.Tab.FixedSingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Tab.FocusOnTabClick = false;
            this.Tab.Font = new System.Drawing.Font("Roboto", 8F);
            this.Tab.ForeColor = System.Drawing.Color.LightGray;
            this.Tab.HotTrack = true;
            this.Tab.InactiveCloseButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Tab.InactiveTabColor = System.Drawing.Color.Empty;
            this.Tab.InActiveTabForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Tab.ItemSize = new System.Drawing.Size(120, 20);
            this.Tab.Location = new System.Drawing.Point(0, 0);
            this.Tab.Name = "Tab";
            this.Tab.ReservedSpace = 120;
            this.Tab.ReserveTabSpace = true;
            this.Tab.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Tab.ShowSeparator = false;
            this.Tab.Size = new System.Drawing.Size(1148, 600);
            this.Tab.TabIndex = 0;
            this.Tab.TabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Tab.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            // 
            // TabPage1
            // 
            this.TabPage1.ForeColor = System.Drawing.Color.LightGray;
            this.TabPage1.Image = null;
            this.TabPage1.ImageSize = new System.Drawing.Size(16, 16);
            this.TabPage1.Location = new System.Drawing.Point(0, 24);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(1);
            this.TabPage1.ShowCloseButton = false;
            this.TabPage1.Size = new System.Drawing.Size(1148, 421);
            this.TabPage1.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TabPage1.TabForeColor = System.Drawing.Color.LightGray;
            this.TabPage1.TabIndex = 1;
            this.TabPage1.Text = "Tab Page 1";
            this.TabPage1.ThemesEnabled = false;
            // 
            // TabPage2
            // 
            this.TabPage2.ForeColor = System.Drawing.Color.LightGray;
            this.TabPage2.Image = null;
            this.TabPage2.ImageSize = new System.Drawing.Size(16, 16);
            this.TabPage2.Location = new System.Drawing.Point(0, 24);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(1);
            this.TabPage2.ShowCloseButton = false;
            this.TabPage2.Size = new System.Drawing.Size(1148, 421);
            this.TabPage2.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TabPage2.TabForeColor = System.Drawing.Color.LightGray;
            this.TabPage2.TabIndex = 2;
            this.TabPage2.Text = "Tab Page 2";
            this.TabPage2.ThemesEnabled = false;
            // 
            // TabPage3
            // 
            this.TabPage3.Image = null;
            this.TabPage3.ImageSize = new System.Drawing.Size(16, 16);
            this.TabPage3.Location = new System.Drawing.Point(0, 24);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(1);
            this.TabPage3.ShowCloseButton = false;
            this.TabPage3.Size = new System.Drawing.Size(1148, 421);
            this.TabPage3.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TabPage3.TabForeColor = System.Drawing.Color.LightGray;
            this.TabPage3.TabIndex = 3;
            this.TabPage3.Text = "Tab Page 3";
            this.TabPage3.ThemesEnabled = false;
            // 
            // TabPage4
            // 
            this.TabPage4.Image = null;
            this.TabPage4.ImageSize = new System.Drawing.Size(16, 16);
            this.TabPage4.Location = new System.Drawing.Point(0, 24);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Padding = new System.Windows.Forms.Padding(1);
            this.TabPage4.ShowCloseButton = false;
            this.TabPage4.Size = new System.Drawing.Size(1148, 576);
            this.TabPage4.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TabPage4.TabForeColor = System.Drawing.Color.LightGray;
            this.TabPage4.TabIndex = 4;
            this.TabPage4.Text = "Tab Page 4";
            this.TabPage4.ThemesEnabled = false;
            // 
            // TabPage5
            // 
            this.TabPage5.Image = null;
            this.TabPage5.ImageSize = new System.Drawing.Size(16, 16);
            this.TabPage5.Location = new System.Drawing.Point(0, 24);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Padding = new System.Windows.Forms.Padding(1);
            this.TabPage5.ShowCloseButton = false;
            this.TabPage5.Size = new System.Drawing.Size(1148, 421);
            this.TabPage5.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TabPage5.TabForeColor = System.Drawing.Color.LightGray;
            this.TabPage5.TabIndex = 5;
            this.TabPage5.Text = "Tab Page 5";
            this.TabPage5.ThemesEnabled = false;
            // 
            // TabPage6
            // 
            this.TabPage6.Image = null;
            this.TabPage6.ImageSize = new System.Drawing.Size(16, 16);
            this.TabPage6.Location = new System.Drawing.Point(0, 24);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Padding = new System.Windows.Forms.Padding(1);
            this.TabPage6.ShowCloseButton = false;
            this.TabPage6.Size = new System.Drawing.Size(1148, 421);
            this.TabPage6.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TabPage6.TabForeColor = System.Drawing.Color.LightGray;
            this.TabPage6.TabIndex = 6;
            this.TabPage6.Text = "Tab Page 6";
            this.TabPage6.ThemesEnabled = false;
            // 
            // TabPage7
            // 
            this.TabPage7.Image = null;
            this.TabPage7.ImageSize = new System.Drawing.Size(16, 16);
            this.TabPage7.Location = new System.Drawing.Point(0, 24);
            this.TabPage7.Name = "TabPage7";
            this.TabPage7.Padding = new System.Windows.Forms.Padding(1);
            this.TabPage7.ShowCloseButton = false;
            this.TabPage7.Size = new System.Drawing.Size(1148, 421);
            this.TabPage7.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TabPage7.TabForeColor = System.Drawing.Color.LightGray;
            this.TabPage7.TabIndex = 7;
            this.TabPage7.Text = "Tab Page 7";
            this.TabPage7.ThemesEnabled = false;
            // 
            // TabPage8
            // 
            this.TabPage8.Image = null;
            this.TabPage8.ImageSize = new System.Drawing.Size(16, 16);
            this.TabPage8.Location = new System.Drawing.Point(0, 24);
            this.TabPage8.Name = "TabPage8";
            this.TabPage8.Padding = new System.Windows.Forms.Padding(1);
            this.TabPage8.ShowCloseButton = false;
            this.TabPage8.Size = new System.Drawing.Size(1148, 421);
            this.TabPage8.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TabPage8.TabForeColor = System.Drawing.Color.LightGray;
            this.TabPage8.TabIndex = 8;
            this.TabPage8.Text = "Tab Page 8";
            this.TabPage8.ThemesEnabled = false;
            // 
            // TabPage9
            // 
            this.TabPage9.Image = null;
            this.TabPage9.ImageSize = new System.Drawing.Size(16, 16);
            this.TabPage9.Location = new System.Drawing.Point(0, 24);
            this.TabPage9.Name = "TabPage9";
            this.TabPage9.Padding = new System.Windows.Forms.Padding(1);
            this.TabPage9.ShowCloseButton = false;
            this.TabPage9.Size = new System.Drawing.Size(1148, 421);
            this.TabPage9.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TabPage9.TabForeColor = System.Drawing.Color.LightGray;
            this.TabPage9.TabIndex = 9;
            this.TabPage9.Text = "Tab Page 9";
            this.TabPage9.ThemesEnabled = false;
            // 
            // TabPage10
            // 
            this.TabPage10.Image = null;
            this.TabPage10.ImageSize = new System.Drawing.Size(16, 16);
            this.TabPage10.Location = new System.Drawing.Point(0, 24);
            this.TabPage10.Name = "TabPage10";
            this.TabPage10.Padding = new System.Windows.Forms.Padding(1);
            this.TabPage10.ShowCloseButton = false;
            this.TabPage10.Size = new System.Drawing.Size(1148, 421);
            this.TabPage10.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TabPage10.TabForeColor = System.Drawing.Color.LightGray;
            this.TabPage10.TabIndex = 10;
            this.TabPage10.Text = "Tab Page 10";
            this.TabPage10.ThemesEnabled = false;
            // 
            // BudgetBinding
            // 
            this.BudgetBinding.DataFilter = null;
            this.BudgetBinding.Numeric = BudgetExecution.Numeric.NS;
            // 
            // TabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BackPanel);
            this.Name = "TabControl";
            this.Size = new System.Drawing.Size(1150, 602);
            this.BackPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tab)).EndInit();
            this.Tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).EndInit();
            this.ResumeLayout(false);

            }

            #endregion

            public LayoutPanel BackPanel;

            public TabPanel Tab;

            public TabPageAdv TabPage1;

            public TabPageAdv TabPage2;

            public TabPageAdv TabPage3;

            public TabPageAdv TabPage4;

            public TabPageAdv TabPage5;

            public TabPageAdv TabPage6;

            public TabPageAdv TabPage7;

            public TabPageAdv TabPage8;

            public TabPageAdv TabPage9;

            public TabPageAdv TabPage10;
        public BudgetBinding BudgetBinding;
    }
    
}
