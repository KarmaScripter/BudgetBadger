// <copyright file="{ClassName}.cs" company="Terry D. Eppler">
// Copyright (c) Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    
    
        // ********************************************************************************************************************************
        // *********************************************************  ASSEMBLIES   ********************************************************
        // ********************************************************************************************************************************

        using System;
        using System;
        using System.ComponentModel;
        using System.Threading;
        using System.Windows.Forms;
        using VisualPlus.Toolkit.Controls.Editors;
        using VisualPlus.Toolkit.Controls.Interactivity;
        using VisualPlus.Toolkit.Controls.Layout;

        partial class Message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Message));
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            this.BackPanel = new VisualPlus.Toolkit.Controls.Layout.VisualPanel();
            this.NoButton = new BudgetExecution.ButtonPanel();
            this.YesButton = new BudgetExecution.ButtonPanel();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.TextBox = new VisualPlus.Toolkit.Controls.Editors.VisualRichTextBox();
            this.Info = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.CloseBox = new BudgetExecution.ClosePanel();
            this.PictureBox = new BudgetExecution.PicturePanel();
            this.TopTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.BackPanel.SuspendLayout();
            this.Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.TopTablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.BackPanel.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.BackPanel.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BackPanel.Border.HoverColor = System.Drawing.SystemColors.HotTrack;
            this.BackPanel.Border.HoverVisible = false;
            this.BackPanel.Border.Rounding = 6;
            this.BackPanel.Border.Thickness = 1;
            this.BackPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.BackPanel.Border.Visible = true;
            this.BackPanel.Controls.Add(this.NoButton);
            this.BackPanel.Controls.Add(this.YesButton);
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BackPanel.ForeColor = System.Drawing.Color.LightGray;
            this.BackPanel.Location = new System.Drawing.Point(1, 403);
            this.BackPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Padding = new System.Windows.Forms.Padding(1);
            this.BackPanel.Size = new System.Drawing.Size(648, 113);
            this.BackPanel.TabIndex = 3;
            this.BackPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.BackPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // NoButton
            // 
            this.NoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.NoButton.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.NoButton.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.NoButton.BackColorState.Hover = System.Drawing.Color.SteelBlue;
            this.NoButton.BackColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.NoButton.BindingSource = null;
            this.NoButton.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.NoButton.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.NoButton.Border.HoverVisible = true;
            this.NoButton.Border.Rounding = 6;
            this.NoButton.Border.Thickness = 1;
            this.NoButton.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.NoButton.Border.Visible = true;
            this.NoButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.NoButton.Field = BudgetExecution.Field.NS;
            this.NoButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.NoButton.ForeColor = System.Drawing.Color.LightGray;
            this.NoButton.HoverText = "Close Window";
            this.NoButton.Image = null;
            this.NoButton.Images = null;
            this.NoButton.Location = new System.Drawing.Point(358, 17);
            this.NoButton.Margin = new System.Windows.Forms.Padding(0);
            this.NoButton.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(201, 74);
            this.NoButton.TabIndex = 1;
            this.NoButton.Tag = "Close";
            this.NoButton.Text = "NO";
            this.NoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.NoButton.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.NoButton.TextStyle.Enabled = System.Drawing.Color.LightGray;
            this.NoButton.TextStyle.Hover = System.Drawing.Color.LightGray;
            this.NoButton.TextStyle.Pressed = System.Drawing.Color.White;
            this.NoButton.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.NoButton.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.NoButton.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.NoButton.ToolTip = null;
            // 
            // YesButton
            // 
            this.YesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.YesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.YesButton.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.YesButton.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.YesButton.BackColorState.Hover = System.Drawing.Color.SteelBlue;
            this.YesButton.BackColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.YesButton.BindingSource = null;
            this.YesButton.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.YesButton.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.YesButton.Border.HoverVisible = true;
            this.YesButton.Border.Rounding = 6;
            this.YesButton.Border.Thickness = 1;
            this.YesButton.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.YesButton.Border.Visible = true;
            this.YesButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.YesButton.Field = BudgetExecution.Field.NS;
            this.YesButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.YesButton.ForeColor = System.Drawing.Color.LightGray;
            this.YesButton.HoverText = "Accept";
            this.YesButton.Image = null;
            this.YesButton.Images = null;
            this.YesButton.Location = new System.Drawing.Point(86, 17);
            this.YesButton.Margin = new System.Windows.Forms.Padding(0);
            this.YesButton.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(201, 74);
            this.YesButton.TabIndex = 0;
            this.YesButton.Tag = "Accept";
            this.YesButton.Text = "YES";
            this.YesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.YesButton.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.YesButton.TextStyle.Enabled = System.Drawing.Color.LightGray;
            this.YesButton.TextStyle.Hover = System.Drawing.Color.LightGray;
            this.YesButton.TextStyle.Pressed = System.Drawing.Color.White;
            this.YesButton.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.YesButton.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.YesButton.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.YesButton.ToolTip = null;
            // 
            // Table
            // 
            this.Table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.Table.ColumnCount = 3;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.75129F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.24871F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.Table.Controls.Add(this.TextBox, 1, 0);
            this.Table.Location = new System.Drawing.Point(1, 76);
            this.Table.Name = "Table";
            this.Table.Padding = new System.Windows.Forms.Padding(1);
            this.Table.RowCount = 1;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.Size = new System.Drawing.Size(653, 321);
            this.Table.TabIndex = 4;
            // 
            // TextBox
            // 
            this.TextBox.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TextBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBox.Border.HoverColor = System.Drawing.Color.Blue;
            this.TextBox.Border.HoverVisible = false;
            this.TextBox.Border.Rounding = 6;
            this.TextBox.Border.Thickness = 1;
            this.TextBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox.Border.Visible = true;
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox.ForeColor = System.Drawing.Color.LightGray;
            this.TextBox.Location = new System.Drawing.Point(86, 4);
            this.TextBox.MaxLength = 2147483647;
            this.TextBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = false;
            this.TextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.TextBox.ShowSelectionMargin = false;
            this.TextBox.Size = new System.Drawing.Size(471, 313);
            this.TextBox.TabIndex = 0;
            this.TextBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.TextBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Info
            // 
            this.Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Info.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.ForeColor = System.Drawing.Color.White;
            this.Info.Location = new System.Drawing.Point(30, 3);
            this.Info.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.Info.Name = "Info";
            this.Info.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.Info.Outline = false;
            this.Info.OutlineColor = System.Drawing.Color.Red;
            this.Info.OutlineLocation = new System.Drawing.Point(0, 0);
            this.Info.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Info.ReflectionSpacing = 0;
            this.Info.ShadowColor = System.Drawing.Color.Black;
            this.Info.ShadowDirection = 315;
            this.Info.ShadowLocation = new System.Drawing.Point(0, 0);
            this.Info.ShadowOpacity = 100;
            this.Info.Size = new System.Drawing.Size(502, 20);
            this.Info.TabIndex = 5;
            this.Info.Text = "Label";
            this.Info.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Info.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Info.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.Info.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Info.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Info.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Info.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Info.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Info.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // CloseBox
            // 
            this.CloseBox.CloseHoverBackColor = System.Drawing.Color.Maroon;
            this.CloseBox.CloseHoverForeColor = System.Drawing.Color.White;
            this.CloseBox.CloseNormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.CloseBox.DisabledForeColor = System.Drawing.Color.DimGray;
            this.CloseBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBox.Font = new System.Drawing.Font("Roboto", 8F);
            this.CloseBox.ForeColor = System.Drawing.Color.LightGray;
            this.CloseBox.Location = new System.Drawing.Point(548, 0);
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
            this.CloseBox.TabIndex = 7;
            this.CloseBox.ThemeAuthor = "Terry D. Eppler";
            this.CloseBox.ThemeName = "Budget Execution";
            this.CloseBox.ToolTip = null;
            // 
            // PictureBox
            // 
            this.PictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox.BindingSource = null;
            this.PictureBox.DataFilter = null;
            this.PictureBox.ErrorImage = null;
            this.PictureBox.Field = BudgetExecution.Field.NS;
            this.PictureBox.HoverText = null;
            this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
            this.PictureBox.ImageList = null;
            this.PictureBox.Location = new System.Drawing.Point(3, 5);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Padding = new System.Windows.Forms.Padding(1);
            this.PictureBox.Size = new System.Drawing.Size(21, 16);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 6;
            this.PictureBox.TabStop = false;
            this.PictureBox.ToolTip = null;
            // 
            // TopTablePanel
            // 
            this.TopTablePanel.BackColor = System.Drawing.Color.Transparent;
            this.TopTablePanel.ColumnCount = 3;
            this.TopTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.046729F));
            this.TopTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.95327F));
            this.TopTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.TopTablePanel.Controls.Add(this.PictureBox, 0, 0);
            this.TopTablePanel.Controls.Add(this.CloseBox, 2, 0);
            this.TopTablePanel.Controls.Add(this.Info, 1, 0);
            this.TopTablePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopTablePanel.Location = new System.Drawing.Point(1, 1);
            this.TopTablePanel.Name = "TopTablePanel";
            this.TopTablePanel.RowCount = 1;
            this.TopTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopTablePanel.Size = new System.Drawing.Size(648, 26);
            this.TopTablePanel.TabIndex = 3;
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Roboto", 8.25F);
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            captionImage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            captionImage1.Image = ((System.Drawing.Image)(resources.GetObject("captionImage1.Image")));
            captionImage1.Location = new System.Drawing.Point(20, 10);
            captionImage1.Name = "CaptionImage1";
            captionImage1.Size = new System.Drawing.Size(15, 15);
            this.CaptionImages.Add(captionImage1);
            this.ClientSize = new System.Drawing.Size(650, 517);
            this.ControlBox = false;
            this.Controls.Add(this.TopTablePanel);
            this.Controls.Add(this.BackPanel);
            this.Controls.Add(this.Table);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.MinimizeBox = false;
            this.Name = "Message";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.ShowMouseOver = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.BackPanel.ResumeLayout(false);
            this.Table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.TopTablePanel.ResumeLayout(false);
            this.ResumeLayout(false);

            }

            #endregion

        public VisualPanel BackPanel;
        public TableLayoutPanel Table;
        public VisualRichTextBox TextBox;
        public VisualLabel Info;
        public PicturePanel PictureBox;
        public ClosePanel CloseBox;
        public ButtonPanel NoButton;
        public ButtonPanel YesButton;
        private TableLayoutPanel TopTablePanel;
    }
    
}
