// <copyright file = "ButtonPanel.cs" company = "Terry D. Eppler">
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
    using System.Threading;
    using System.Windows.Forms;
    using VisualPlus.Enumerators;
    using VisualPlus.Models;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ButtonBase" />
    /// <seealso cref="IButton" />
    /// <seealso cref="VisualPlus.Toolkit.Controls.Interactivity.VisualButton" />
    /// <seealso cref="System.IDisposable" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public class ButtonPanel : ButtonBase, IButton
    {
        // ***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ButtonPanel" />
        /// class.
        /// </summary>
        public ButtonPanel()
        {
            // Basic Configuration
            ForeColor = ColorConfig.ForeColorGray;
            Font = FontConfig.FontSizeSmall;
            ForeColor = ColorConfig.ForeColorGray;
            Margin = ControlConfig.Margin;
            Padding = ControlConfig.Padding;
            Size = SizeConfig.GetSize( 160, 80 );
            Location = ControlConfig.GetLocation();
            Dock = ControlConfig.GetDockStyle();
            Anchor = ControlConfig.GetAnchorStyle();
            Animation = true;
            Visible = true;
            Enabled = true;

            // BackColor Configuration
            BackColor = ColorConfig.BackColorBlack;
            BackColorState.Disabled = ColorConfig.BackColorBlack;
            BackColorState.Enabled = ColorConfig.BackColorBlack;
            BackColorState.Hover = ColorConfig.ControlHoverGray;
            BackColorState.Pressed = ColorConfig.BorderColorBlue;

            // BorderColor Configuration
            Border.Color = ColorConfig.BackColorBlack;
            Border.HoverColor = ColorConfig.ControlHoverGray;
            Border.HoverVisible = true;
            Border.Type = ShapeTypes.Rounded;
            Border.Thickness = 1;

            // Image Configuration
            TextImageRelation = TextImageRelation.Overlay;

            // Text Configuration
            TextStyle.Pressed = Color.White;
            TextStyle.Disabled = ColorConfig.BackColorBlack;
            TextStyle.Enabled = ColorConfig.ForeColorGray;
            TextStyle.Hover = ColorConfig.ForeColorGray;
            TextStyle.TextAlignment = AlignConfig.StringCenter;
            TextStyle.TextLineAlignment = AlignConfig.StringCenter;
            MouseHover += OnMouseOver;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ButtonPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public ButtonPanel( Size size, Point location )
            : this()
        {
            Size = SizeConfig.GetSize( size.Width, size.Height );
            Location = ControlConfig.GetLocation( location.X, location.Y );
            Field = Field.NS;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ButtonPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public ButtonPanel( Size size, Point location, Control parent )
            : this( size, location )
        {
            Parent = ControlConfig.GetParent( parent );
            Field = Field.NS;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ButtonPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        /// <param name="text">The text.</param>
        public ButtonPanel( Size size, Point location, Control parent,
            string text )
            : this( size, location, parent )
        {
            Text = text;
            Field = Field.NS;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ButtonPanel" />
        /// class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="text">The text displayed by the control.</param>
        public ButtonPanel( Control parent, string text )
            : this()
        {
            Parent = ControlConfig.GetParent( parent );
            Text = text;
            Field = Field.NS;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ButtonPanel" />
        /// class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public ButtonPanel( Control parent )
            : this()
        {
            Parent = ControlConfig.GetParent( parent );
            Field = Field.NS;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ButtonPanel" />
        /// class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="field">The field.</param>
        public ButtonPanel( Control parent, Field field )
            : this()
        {
            Parent = ControlConfig.GetParent( parent );
            Field = field;
            Tag = Field;
        }

        // ***************************************************************************************************************************
        // *******************************************************      METHODS        ***********************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the color of the fore. Required Attributes: ForeColor
        /// </summary>
        /// <param name="format">The format.</param>
        public void SetForeColor( ColorFormat format )
        {
            try
            {
                ForeColor = ColorConfig.GetColor( format.ForeColor );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the state of the back color. Required Attributes: BackColor, DisableColor,
        /// EnabledColor, HoverColor, and PressedColor
        /// </summary>
        /// <param name="format">The format.</param>
        public void SetBackColorStyle( ColorFormat format )
        {
            try
            {
                BackColor = ColorConfig.GetColor( format.BackColor );
                BackColorState.Disabled = ColorConfig.GetColor( format.DisabledColor );
                BackColorState.Enabled = ColorConfig.GetColor( format.EnabledColor );
                BackColorState.Hover = ColorConfig.GetColor( format.HoverColor );
                BackColorState.Pressed = ColorConfig.GetColor( format.PressedColor );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the border configuration. Required Attributes: BorderColor, and HoverColor
        /// </summary>
        /// <param name="format">The format.</param>
        public void SetBorderStyle( ColorFormat format )
        {
            try
            {
                Border.Color = ColorConfig.GetColor( format.BorderColor );
                Border.HoverColor = ColorConfig.GetColor( format.HoverColor );
                Border.HoverVisible = true;
                Border.Type = ShapeTypes.Rounded;
                Border.Thickness = 1;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the text style configuration. Required Attributes: PressedColor,
        /// DisabledColor, EnabledColor, and HoverColor
        /// </summary>
        /// <param name="format">The format.</param>
        public void SetTextStyle( ColorFormat format )
        {
            try
            {
                TextImageRelation = TextImageRelation.ImageBeforeText;
                TextStyle = new TextStyle();
                TextStyle.TextLineAlignment = StringAlignment.Center;
                TextStyle.TextAlignment = StringAlignment.Center;
                TextStyle.Hover = ColorConfig.GetColor( format.HoverColor );
                TextStyle.Enabled = ColorConfig.GetColor( format.EnabledColor );
                TextStyle.Disabled = ColorConfig.GetColor( format.DisabledColor );
                TextStyle.Pressed = ColorConfig.GetColor( format.PressedColor );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the image.
        /// </summary>
        /// <param name="image">The image.</param>
        public void SetImage( Image image )
        {
            if( image != null )
            {
                try
                {
                    Image = image;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        // ***************************************************************************************************************************
        // ****************************************************   EVENTS/DELEGATES  **************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Called when [mouse over].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        public void OnMouseOver( object sender, EventArgs e )
        {
            var button = sender as ButtonPanel;

            try
            {
                if( Verify.Input( HoverText ) )
                {
                    var text = button?.HoverText;
                    var _ = new ToolTip( button, text );
                }
                else
                {
                    if( Verify.Input( Tag?.ToString() ) )
                    {
                        var _ = new ToolTip( button, Tag?.ToString()?.SplitPascal() );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        public void OnClick( object sender, EventArgs e )
        {
            try
            {
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
    }
}