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

    partial class CalendarForm
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
                new System.ComponentModel.ComponentResourceManager( typeof( CalendarForm ) );

            this.CloseBox = new ClosePanel();

            this.CalendarControl = new CalendarControl();

            this.Picture = new PicturePanel();
            ( (System.ComponentModel.ISupportInitialize)( this.Picture ) ).BeginInit();
            this.SuspendLayout();

            // 
            // CloseBox
            // 
            this.CloseBox.Anchor =
                ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Top
                    | System.Windows.Forms.AnchorStyles.Right ) ) );

            this.CloseBox.BackColor = System.Drawing.Color.Transparent;
            this.CloseBox.Font = new System.Drawing.Font( "Roboto", 8F );
            this.CloseBox.ForeColor = System.Drawing.Color.LightGray;

            // 
            // 
            // 
            this.CloseBox.HelpButton.BackColor = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ) );

            this.CloseBox.HelpButton.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ) );

            this.CloseBox.HelpButton.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ) );

            this.CloseBox.HelpButton.BackColorState.Hover = System.Drawing.Color.SteelBlue;
            this.CloseBox.HelpButton.BackColorState.Pressed = System.Drawing.Color.SteelBlue;

            this.CloseBox.HelpButton.BoxType =
                VisualPlus.Toolkit.VisualBase.ControlBoxButton.ControlBoxType.Default;

            this.CloseBox.HelpButton.ForeColor = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ) );

            this.CloseBox.HelpButton.ForeColorState.Disabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ) );

            this.CloseBox.HelpButton.ForeColorState.Enabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ) );

            this.CloseBox.HelpButton.ForeColorState.Hover = System.Drawing.Color.White;
            this.CloseBox.HelpButton.ForeColorState.Pressed = System.Drawing.Color.White;

            this.CloseBox.HelpButton.Image =
                ( (System.Drawing.Image)( resources.GetObject( "resource.Image" ) ) );

            this.CloseBox.HelpButton.Location = new System.Drawing.Point( 0, 0 );
            this.CloseBox.HelpButton.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.CloseBox.HelpButton.Name = "";
            this.CloseBox.HelpButton.OffsetLocation = new System.Drawing.Point( 0, 1 );
            this.CloseBox.HelpButton.Size = new System.Drawing.Size( 50, 25 );
            this.CloseBox.HelpButton.TabIndex = 0;
            this.CloseBox.HelpButton.Tag = "Documentation";
            this.CloseBox.HelpButton.Text = "s";

            this.CloseBox.HelpButton.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                ( (int)( ( (byte)( 129 ) ) ) ) );

            this.CloseBox.HelpButton.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ) );

            this.CloseBox.HelpButton.TextStyle.Hover = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ) );

            this.CloseBox.HelpButton.TextStyle.Pressed = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ) );

            this.CloseBox.HelpButton.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.CloseBox.HelpButton.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

            this.CloseBox.HelpButton.TextStyle.TextRenderingHint =
                System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            this.CloseBox.Location = new System.Drawing.Point( 162, 1 );

            // 
            // 
            // 
            this.CloseBox.MaximizeButton.BackColor = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ) );

            this.CloseBox.MaximizeButton.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ) );

            this.CloseBox.MaximizeButton.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ) );

            this.CloseBox.MaximizeButton.BackColorState.Hover = System.Drawing.Color.SteelBlue;
            this.CloseBox.MaximizeButton.BackColorState.Pressed = System.Drawing.Color.SteelBlue;

            this.CloseBox.MaximizeButton.BoxType =
                VisualPlus.Toolkit.VisualBase.ControlBoxButton.ControlBoxType.Default;

            this.CloseBox.MaximizeButton.ForeColor = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ) );

            this.CloseBox.MaximizeButton.ForeColorState.Disabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ) );

            this.CloseBox.MaximizeButton.ForeColorState.Enabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ) );

            this.CloseBox.MaximizeButton.ForeColorState.Hover = System.Drawing.Color.White;
            this.CloseBox.MaximizeButton.ForeColorState.Pressed = System.Drawing.Color.White;

            this.CloseBox.MaximizeButton.Image =
                ( (System.Drawing.Image)( resources.GetObject( "resource.Image1" ) ) );

            this.CloseBox.MaximizeButton.Location = new System.Drawing.Point( 74, 0 );
            this.CloseBox.MaximizeButton.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.CloseBox.MaximizeButton.Name = "";
            this.CloseBox.MaximizeButton.OffsetLocation = new System.Drawing.Point( 1, 1 );
            this.CloseBox.MaximizeButton.Size = new System.Drawing.Size( 50, 25 );
            this.CloseBox.MaximizeButton.TabIndex = 2;
            this.CloseBox.MaximizeButton.Tag = "Maximize";
            this.CloseBox.MaximizeButton.Text = "1";

            this.CloseBox.MaximizeButton.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                ( (int)( ( (byte)( 129 ) ) ) ) );

            this.CloseBox.MaximizeButton.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ) );

            this.CloseBox.MaximizeButton.TextStyle.Hover = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ) );

            this.CloseBox.MaximizeButton.TextStyle.Pressed = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ) );

            this.CloseBox.MaximizeButton.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;

            this.CloseBox.MaximizeButton.TextStyle.TextLineAlignment =
                System.Drawing.StringAlignment.Center;

            this.CloseBox.MaximizeButton.TextStyle.TextRenderingHint =
                System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // 
            // 
            // 
            this.CloseBox.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ) );

            this.CloseBox.MinimizeButton.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ) );

            this.CloseBox.MinimizeButton.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ) );

            this.CloseBox.MinimizeButton.BackColorState.Hover = System.Drawing.Color.SteelBlue;
            this.CloseBox.MinimizeButton.BackColorState.Pressed = System.Drawing.Color.SteelBlue;

            this.CloseBox.MinimizeButton.BoxType =
                VisualPlus.Toolkit.VisualBase.ControlBoxButton.ControlBoxType.Default;

            this.CloseBox.MinimizeButton.ForeColor = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ) );

            this.CloseBox.MinimizeButton.ForeColorState.Disabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ) );

            this.CloseBox.MinimizeButton.ForeColorState.Enabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ) );

            this.CloseBox.MinimizeButton.ForeColorState.Hover = System.Drawing.Color.White;
            this.CloseBox.MinimizeButton.ForeColorState.Pressed = System.Drawing.Color.White;

            this.CloseBox.MinimizeButton.Image =
                ( (System.Drawing.Image)( resources.GetObject( "resource.Image2" ) ) );

            this.CloseBox.MinimizeButton.Location = new System.Drawing.Point( 24, 0 );
            this.CloseBox.MinimizeButton.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.CloseBox.MinimizeButton.Name = "";
            this.CloseBox.MinimizeButton.OffsetLocation = new System.Drawing.Point( 2, 0 );
            this.CloseBox.MinimizeButton.Size = new System.Drawing.Size( 50, 25 );
            this.CloseBox.MinimizeButton.TabIndex = 1;
            this.CloseBox.MinimizeButton.Tag = "Minimize";
            this.CloseBox.MinimizeButton.Text = "0";

            this.CloseBox.MinimizeButton.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                ( (int)( ( (byte)( 129 ) ) ) ) );

            this.CloseBox.MinimizeButton.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ) );

            this.CloseBox.MinimizeButton.TextStyle.Hover = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ) );

            this.CloseBox.MinimizeButton.TextStyle.Pressed = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ) );

            this.CloseBox.MinimizeButton.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;

            this.CloseBox.MinimizeButton.TextStyle.TextLineAlignment =
                System.Drawing.StringAlignment.Center;

            this.CloseBox.MinimizeButton.TextStyle.TextRenderingHint =
                System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            this.CloseBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size( 200, 25 );
            this.CloseBox.TabIndex = 0;

            this.CloseBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                ( (int)( ( (byte)( 129 ) ) ) ) );

            this.CloseBox.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.CloseBox.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.CloseBox.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.CloseBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.CloseBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

            this.CloseBox.TextStyle.TextRenderingHint =
                System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            this.CloseBox.ToolTip = null;

            // 
            // CalendarControl
            // 
            this.CalendarControl.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.CalendarControl.BindingSource = null;
            this.CalendarControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CalendarControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CalendarControl.Field = Field.NS;
            this.CalendarControl.Font = new System.Drawing.Font( "Roboto", 8F );
            this.CalendarControl.ForeColor = System.Drawing.Color.LightGray;
            this.CalendarControl.HoverText = null;
            this.CalendarControl.Location = new System.Drawing.Point( 0, 32 );
            this.CalendarControl.Name = "CalendarControl";
            this.CalendarControl.Padding = new System.Windows.Forms.Padding( 1 );
            this.CalendarControl.Size = new System.Drawing.Size( 369, 355 );
            this.CalendarControl.TabIndex = 1;
            this.CalendarControl.ToolTip = null;

            // 
            // Picture
            // 
            this.Picture.Anchor =
                ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top
                        | System.Windows.Forms.AnchorStyles.Bottom )
                    | System.Windows.Forms.AnchorStyles.Left ) ) );

            this.Picture.BackColor = System.Drawing.Color.Transparent;
            this.Picture.BindingSource = null;
            this.Picture.ErrorImage = null;
            this.Picture.Field = Field.NS;
            this.Picture.DataFilter = null;
            this.Picture.HoverText = null;
            this.Picture.Image = ( (System.Drawing.Image)( resources.GetObject( "Picture.Image" ) ) );
            this.Picture.ImageList = null;

            this.Picture.InitialImage =
                ( (System.Drawing.Image)( resources.GetObject( "Picture.InitialImage" ) ) );

            this.Picture.Location = new System.Drawing.Point( 0, 1 );
            this.Picture.Name = "Picture";
            this.Picture.Padding = new System.Windows.Forms.Padding( 1 );
            this.Picture.Size = new System.Drawing.Size( 95, 25 );
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 2;
            this.Picture.TabStop = false;
            this.Picture.ToolTip = null;

            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 96F, 96F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;

            this.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.BorderColor = System.Drawing.Color.SteelBlue;

            this.CaptionBarColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.CaptionButtonColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.CaptionButtonHoverColor = System.Drawing.Color.White;

            this.CaptionFont = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

            this.CaptionForeColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size( 369, 387 );
            this.ControlBox = false;
            this.Controls.Add( this.Picture );
            this.Controls.Add( this.CalendarControl );
            this.Controls.Add( this.CloseBox );
            this.DoubleBuffered = true;

            this.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

            this.ForeColor = System.Drawing.Color.LightGray;
            this.Icon = ( (System.Drawing.Icon)( resources.GetObject( "$this.Icon" ) ) );

            this.MetroColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.Name = "CalendarForm";
            this.ShowIcon = false;
            ( (System.ComponentModel.ISupportInitialize)( this.Picture ) ).EndInit();
            this.ResumeLayout( false );

        }

        #endregion

        public ClosePanel CloseBox;

        public CalendarControl CalendarControl;

        public PicturePanel Picture;
    }

}