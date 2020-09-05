// <copyright file = "RichTextPanel.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ******************************************************************************************************************************
    // ******************************************************   ASSEMBLIES   ********************************************************
    // ******************************************************************************************************************************

    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using VisualPlus.Enumerators;

    /// <summary>
    /// Defines the
    /// <see cref="RichTextPanel" />
    /// </summary>
    /// <seealso cref="VisualPlus.Toolkit.Controls.Editors.VisualRichTextBox" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class RichTextPanel : RichTextData, IRichTextBox
    {
        // ***************************************************************************************************************************
        // *********************************************   CONSTRUCTORS **************************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="RichTextPanel" />
        /// class.
        /// </summary>
        public RichTextPanel()
        {
            // Basic Properties
            ForeColor = ColorConfig.ForeColorGray;
            Margin = ControlConfig.Margin;
            Font = FontConfig.FontSizeSmall;
            Padding = ControlConfig.Padding;
            Size = SizeConfig.GetSize( 160, 23 );
            Location = ControlConfig.GetLocation();
            Dock = ControlConfig.GetDockStyle();
            Anchor = ControlConfig.GetAnchorStyle();
            Visible = true;
            Enabled = true;

            // Style Configuration
            BackColorState.Disabled = ColorConfig.BackColorBlack;
            BackColorState.Enabled = ColorConfig.ControlInteriorBlack;
            BackColor = ColorConfig.ControlInteriorBlack;
            Border.Type = ShapeTypes.Rounded;
            Border.Color = ColorConfig.ControlHoverGray;
            Border.HoverVisible = true;
            Border.HoverColor = ColorConfig.BorderColorLight;
            Border.Thickness = BorderConfig.SizeThin;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="RichTextPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="point">The point.</param>
        public RichTextPanel( Size size, Point point )
            : this()
        {
            Size = SizeConfig.GetSize( size );
            Location = ControlConfig.GetLocation( point.X, point.Y );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="RichTextPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="point">The point.</param>
        /// <param name="parent">The parent.</param>
        public RichTextPanel( Size size, Point point, Control parent )
            : this( size, point )
        {
            Parent = ControlConfig.GetParent( parent );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="RichTextPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="parent">The parent.</param>
        public RichTextPanel( Size size, Control parent )
            : this()
        {
            Size = SizeConfig.GetSize( size );
            Parent = ControlConfig.GetParent( parent );
            Parent.Controls.Add( this );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="RichTextPanel" />
        /// class.
        /// </summary>
        /// <param name="location">The location
        /// <see cref="Point" /></param>
        /// <param name="parent">The parent.</param>
        public RichTextPanel( Point location, Control parent )
            : this()
        {
            Location = ControlConfig.GetLocation( location.X, location.Y );
            Parent = ControlConfig.GetParent( parent );
            Parent.Controls.Add( this );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="RichTextPanel" />
        /// class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public RichTextPanel( Control parent )
            : this()
        {
            Parent = ControlConfig.GetParent( parent );
            Parent.Controls.Add( this );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="RichTextPanel" />
        /// class.
        /// </summary>
        /// <param name="parent">The
        /// <see cref="T:System.Windows.Forms.Control" />
        /// to be the parent of the control.</param>
        /// <param name="text">The text displayed by the control.</param>
        public RichTextPanel( Control parent, string text )
            : this( parent )
        {
            SetText( text );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="RichTextPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location
        /// <see cref="Point" /></param>
        /// <param name="parent">The parent.</param>
        /// <param name="text">The items.</param>
        public RichTextPanel( Size size, Point location, Control parent,
            string text )
            : this( size, location, parent )
        {
            SetText( text );
        }

        // **********************************************************************************************************************
        // *************************************************   PROPERTIES   *****************************************************
        // **********************************************************************************************************************

        /// <summary>
        /// Gets or sets the tip.
        /// </summary>
        /// <value>
        /// The tip.
        /// </value>
        public ToolTip ToolTip { get; set; }

        // ***************************************************************************************************************************
        // ************************************************  METHODS   ***************************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the numeric.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        public void SetNumeric( Numeric numeric )
        {
            if( Enum.IsDefined( typeof( Numeric ), numeric ) )
            {
                try
                {
                    Numeric = numeric;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
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
                    Text = text;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the hover information.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetHoverText( string text )
        {
            if( Verify.Input( text ) )
            {
                try
                {
                    var _ = new ToolTip( this, text );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        public void SetTag( object tag )
        {
            if( tag != null )
            {
                try
                {
                    Tag = tag;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Adds the control item.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Control> GetChildren()
        {
            if( Controls?.Count > 0 )
            {
                try
                {
                    var children = new List<Control>();

                    foreach( var item in Controls )
                    {
                        if( item != null )
                        {
                            children.Add( item as Control );
                        }
                    }

                    return children.Any()
                        ? children
                        : default;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        // ***************************************************************************************************************************
        // ****************************************************   EVENTS/DELEGATES  **************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Called when [mouse hover].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnMouseHover( object sender, EventArgs e )
        {
            if( sender is RichTextPanel textbox )
            {
                try
                {
                    SetHoverText( textbox.Tag.ToString() );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}
