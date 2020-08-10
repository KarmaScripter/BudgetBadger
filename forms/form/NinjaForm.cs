// <copyright file = "NinjaForm.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    public partial class NinjaForm : MetroForm
    {
        public NinjaForm()
        {
            InitializeComponent();
            Size = SizeConfig.FormNormal;
            Anchor = ControlConfig.GetAnchorStyle();
            Dock = ControlConfig.GetDockStyle();
            BackColor = ColorConfig.BackColorBlack;
            FormBorderStyle = BorderConfig.FormFixed;
            BorderColor = ColorConfig.BorderColorBlue;
            BorderThickness = BorderConfig.SizeThin;
            MaximumSize = SizeConfig.FormMaximum;
            MinimumSize = SizeConfig.FormMinimum;
            Size = SizeConfig.FormNormal;
            WindowState = FormConfig.NormalState;
            StartPosition = FormConfig.FormCentered;
            CaptionBarColor = ColorConfig.BackColorBlack;
            CaptionBarHeight = FormConfig.CaptionHeight;
            CaptionButtonColor = ColorConfig.BackColorBlack;
            CaptionForeColor = ColorConfig.BackColorBlack;
            CaptionVerticalAlignment = VerticalAlignment.Center;
            ShowMouseOver = true;
            CaptionButtonHoverColor = Color.White;
            Font = FontConfig.FontSizeSmall;
            ForeColor = ColorConfig.ForeColorGray;
            Margin = ControlConfig.Margin;
            Padding = ControlConfig.Padding;
            ShowIcon = false;
            ShowInTaskbar = true;
            MetroColor = ColorConfig.BackColorBlack;
            SizeGripStyle = SizeGripStyle.Auto;
            Visible = true;
            MaximizeBox = false;
            ShowMaximizeBox = false;
            MinimizeBox = false;
            ShowMinimizeBox = false;
        }

        // ***************************************************************************************************************************
        // ****************************************************     METHODS   ********************************************************
        // ***************************************************************************************************************************

        /// <summary> Sets the caption properties. </summary>
        /// <param name = "color" > The color. </param>
        /// <param name = "align" > The align. </param>
        public void SetCaptionFormat( Color color, HorizontalAlignment align = HorizontalAlignment.Center )
        {
            try
            {
                CaptionForeColor = ColorConfig.GetColor( color );
                CaptionAlign = AlignConfig.GetHorizontalAlignment( align );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Sets the color of the border. </summary>
        /// <param name = "color" > The color. </param>
        public void SetBorderColor( Color color )
        {
            try
            {
                BorderColor = ColorConfig.GetColor( color );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Sets the color of the back. </summary>
        /// <param name = "color" > The color. </param>
        public void SetBackColor( Color color )
        {
            try
            {
                BackColor = ColorConfig.GetColor( color );
                CaptionBarColor = ColorConfig.GetColor( color );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var error = new Error( ex );
            error?.SetText();
            error?.ShowDialog();
        }

        /// <summary>
        /// Called when [minimize clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnMinimizeClicked( object sender, EventArgs e )
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Called when [maximize clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnMaximizeClicked( object sender, EventArgs e )
        {
            Size = SizeConfig.FormNormal;
            WindowState = FormWindowState.Normal;
            Location = new Point( 50, 50 );
        }
    }
}
