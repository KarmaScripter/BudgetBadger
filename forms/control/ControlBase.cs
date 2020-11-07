// <copyright file = "ControlBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ******************************************************************************************************************************
    // ******************************************************   ASSEMBLIES   ********************************************************
    // ******************************************************************************************************************************

    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class ControlBase : ControlData, IDataControl
    {
        // ***************************************************************************************************************************
        // *********************************************   CONSTRUCTORS **************************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the <see cref="ControlBase"/> class.
        /// </summary>
        public ControlBase()
        {
            BackColor = ColorConfig.FormDarkBackColor;
            ForeColor = ColorConfig.ForeGray;
            BorderStyle = BorderStyle.FixedSingle;
            DoubleBuffered = true;
            AutoScaleMode = AutoScaleMode.Dpi;
            Padding = ControlConfig.Padding;
            Margin = ControlConfig.Margin;
            Font = FontConfig.FontSizeSmall;
        }

        // **********************************************************************************************************************
        // *************************************************   PROPERTIES   *****************************************************
        // **********************************************************************************************************************

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public string HoverText { get; set; }

        // **************************************************************************************************************************
        // ********************************************      METHODS    *************************************************************
        // **************************************************************************************************************************

        /// <summary>
        /// Sets the parent.
        /// </summary>
        /// <param name="control">The control.</param>
        public void SetParent( Control control )
        {
            try
            {
                Parent = ControlConfig.GetParent( control );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public void SetSize( int width, int height )
        {
            try
            {
                Size = ControlConfig.GetSize( width, height );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Gets the location.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public void SetLocation( int x = 1, int y = 1 )
        {
            try
            {
                Location = ControlConfig.GetLocation( x, y );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the font.
        /// </summary>
        /// <param name="family">The family.</param>
        /// <param name="size">The size.</param>
        /// <param name="style">The style.</param>
        public void SetFont( string family = "Roboto", int size = 8, FontStyle style = FontStyle.Regular )
        {
            try
            {
                Font = FontConfig.GetFont( family, size, style );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the color of the back.
        /// </summary>
        /// <param name="color">The color.</param>
        public void SetBackColor( Color color )
        {
            try
            {
                BackColor = ColorConfig.GetColor( color );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the color of the fore.
        /// </summary>
        /// <param name="color">The color.</param>
        public void SetForeColor( Color color )
        {
            try
            {
                ForeColor = ColorConfig.GetColor( color );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetText( string text )
        {
            if( Verify.Input( text ) )
            {
                try
                {
                    Text = ControlConfig.GetText( text );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the anchor style.
        /// </summary>
        /// <param name="anchor">The anchor.</param>
        public void SetAnchorStyle( AnchorStyles anchor )
        {
            try
            {
                Anchor = ControlConfig.GetAnchorStyle( anchor );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the dock style.
        /// </summary>
        /// <param name="dock">The dock.</param>
        public void SetDockStyle( DockStyle dock )
        {
            try
            {
                Dock = ControlConfig.GetDockStyle( dock );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        public void SetTag( object tag )
        {
            try
            {
                Tag = ControlConfig.GetTag( tag );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the hover text.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetHoverText( string text )
        {
            try
            {
                HoverText = ControlConfig.GetText( text );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        // ***************************************************************************************************************************
        // ****************************************************     EVENTS    ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Called when [mouse over].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        public void OnMouseOver( object sender, EventArgs e )
        {
            if( sender is Control control
                && Verify.Input( control?.Tag?.ToString() ) )
            {
                try
                {
                    var _ = ControlConfig.GetToolTip( control, control?.Tag?.ToString() );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
            else if( Verify.Input( HoverText ) )
            {
                try
                {
                    var _ = ControlConfig.GetToolTip( this, HoverText );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}
