﻿
namespace BudgetExecution
{

    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System.ComponentModel;
    using System.Threading;

    partial class ListBoxControl
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
            this.ListBox = new ListPanel();
            this.TopPanel = new LayoutPanel();
            this.Label = new LabelPanel();
            this.BottomPanel = new LayoutPanel();
            this.TopPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();

            // 
            // ListBox
            // 
            this.ListBox.BindingSource = null;

            this.ListBox.BorderColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.ListBox.DisabledBackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.ListBox.DisabledForeColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.ListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBox.Field = Field.NS;
            this.ListBox.DataFilter = null;
            this.ListBox.Font = new System.Drawing.Font( "Roboto", 8F );

            this.ListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ),
                ( (int)( ( (byte)( 30 ) ) ) ) );

            this.ListBox.HoveredItemColor = System.Drawing.Color.White;
            this.ListBox.HoverText = null;
            this.ListBox.ItemHeight = 30;
            this.ListBox.Location = new System.Drawing.Point( 0, 0 );
            this.ListBox.MultiSelect = false;
            this.ListBox.Name = "ListBox";
            this.ListBox.Padding = new System.Windows.Forms.Padding( 1 );
            this.ListBox.SelectedIndex = -1;
            this.ListBox.SelectedItem = null;
            this.ListBox.SelectedItemBackColor = System.Drawing.Color.SteelBlue;
            this.ListBox.SelectedItemColor = System.Drawing.Color.White;
            this.ListBox.SelectedValue = null;
            this.ListBox.ShowBorder = false;
            this.ListBox.ShowScrollBar = false;
            this.ListBox.Size = new System.Drawing.Size( 243, 233 );
            this.ListBox.Style = MetroSet_UI.Design.Style.Custom;
            this.ListBox.StyleManager = null;
            this.ListBox.TabIndex = 0;
            this.ListBox.ThemeAuthor = "Terry D. Eppler";
            this.ListBox.ThemeName = "Budget Execution";

            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.TopPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ) );

            this.TopPanel.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ) );

            this.TopPanel.BindingSource = null;

            this.TopPanel.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.TopPanel.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.TopPanel.Border.HoverVisible = true;
            this.TopPanel.Border.Rounding = 6;
            this.TopPanel.Border.Thickness = 1;
            this.TopPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TopPanel.Border.Visible = true;
            this.TopPanel.Children = null;
            this.TopPanel.Controls.Add( this.Label );
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Field = Field.NS;
            this.TopPanel.ForeColor = System.Drawing.Color.LightGray;
            this.TopPanel.Location = new System.Drawing.Point( 1, 1 );
            this.TopPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Padding = new System.Windows.Forms.Padding( 1 );
            this.TopPanel.Size = new System.Drawing.Size( 243, 38 );
            this.TopPanel.TabIndex = 1;

            this.TopPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                ( (int)( ( (byte)( 129 ) ) ) ) );

            this.TopPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.TopPanel.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.TopPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.TopPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TopPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

            this.TopPanel.TextStyle.TextRenderingHint =
                System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // 
            // Label
            // 
            this.Label.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label.Field = Field.NS;
            this.Label.DataFilter = null;

            this.Label.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

            this.Label.ForeColor = System.Drawing.Color.LightGray;
            this.Label.Location = new System.Drawing.Point( 0, 0 );
            this.Label.Margin = new System.Windows.Forms.Padding( 10, 3, 3, 3 );
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

            this.Label.ShadowColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.Label.ShadowDirection = 315;
            this.Label.ShadowLocation = new System.Drawing.Point( 0, 0 );
            this.Label.ShadowOpacity = 100;
            this.Label.Size = new System.Drawing.Size( 243, 38 );
            this.Label.TabIndex = 0;
            this.Label.Text = "Title Text";
            this.Label.TextAlignment = System.Drawing.StringAlignment.Near;
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
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.BottomPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ) );

            this.BottomPanel.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ) );

            this.BottomPanel.BindingSource = null;

            this.BottomPanel.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.BottomPanel.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.BottomPanel.Border.HoverVisible = true;
            this.BottomPanel.Border.Rounding = 6;
            this.BottomPanel.Border.Thickness = 1;
            this.BottomPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.BottomPanel.Border.Visible = true;
            this.BottomPanel.Children = null;
            this.BottomPanel.Controls.Add( this.ListBox );
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomPanel.Field = Field.NS;
            this.BottomPanel.ForeColor = System.Drawing.Color.LightGray;
            this.BottomPanel.Location = new System.Drawing.Point( 1, 39 );
            this.BottomPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Padding = new System.Windows.Forms.Padding( 1 );
            this.BottomPanel.Size = new System.Drawing.Size( 243, 233 );
            this.BottomPanel.TabIndex = 2;
            this.BottomPanel.Text = "layoutPanel1";

            this.BottomPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                ( (int)( ( (byte)( 129 ) ) ) ) );

            this.BottomPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ) );

            this.BottomPanel.TextStyle.Hover = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ) );

            this.BottomPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ) );

            this.BottomPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BottomPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

            this.BottomPanel.TextStyle.TextRenderingHint =
                System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // ListBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.BottomPanel );
            this.Controls.Add( this.TopPanel );
            this.Name = "ListBoxControl";
            this.Size = new System.Drawing.Size( 245, 273 );
            this.TopPanel.ResumeLayout( false );
            this.BottomPanel.ResumeLayout( false );
            this.ResumeLayout( false );

        }

        #endregion

        public ListPanel ListBox;

        public LayoutPanel TopPanel;

        public LabelPanel Label;

        public LayoutPanel BottomPanel;
    }
}
