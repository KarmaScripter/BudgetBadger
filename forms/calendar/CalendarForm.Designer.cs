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
