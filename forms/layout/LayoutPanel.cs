// <copyright file = "LayoutPanel.cs" company = "Terry D. Eppler">
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
    using VisualPlus.Toolkit.Controls.Layout;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="VisualPlus.Toolkit.Controls.Layout.VisualPanel" />
    /// <seealso cref="ILayout" />
    /// 
    [ SuppressMessage( "ReSharper", "HeuristicUnreachableCode" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public class LayoutPanel : VisualPanel, ILayout
    {
        // ***************************************************************************************************************************
        // *********************************************   CONSTRUCTORS **************************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="LayoutPanel" />
        /// class.
        /// </summary>
        public LayoutPanel()
        {
            // Basic Properties
            Size = SizeConfig.GetSize( 700, 428 );
            Location = ControlConfig.GetLocation();
            Anchor = ControlConfig.GetAnchorStyle();
            Dock = ControlConfig.GetDockStyle();
            Margin = ControlConfig.Margin;
            Padding = ControlConfig.Padding;
            Enabled = true;
            Visible = true;

            // Backcolor Configuration
            BackColor = ColorConfig.FormDarkBackColor;
            ForeColor = ColorConfig.ForeGray;
            BackColorState.Disabled = ColorConfig.FormDarkBackColor;
            BackColorState.Enabled = ColorConfig.FormDarkBackColor;

            // Border Configuration
            Border.Color = ColorConfig.FormDarkBackColor;
            Border.Thickness = BorderConfig.Thin;
            Border.HoverColor = ColorConfig.BorderYellow;
            Border.HoverVisible = false;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="LayoutPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public LayoutPanel( Size size, Point location )
            : this()
        {
            Size = SizeConfig.GetSize( size );
            Location = ControlConfig.GetLocation( location.X, location.Y );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="LayoutPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public LayoutPanel( Size size, Point location, Control parent )
            : this()
        {
            Size = SizeConfig.GetSize( size.Width, size.Height );
            Location = ControlConfig.GetLocation( location.X, location.Y );
            Parent = ControlConfig.GetParent( parent );
            Parent.Controls.Add( this );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="LayoutPanel" />
        /// class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public LayoutPanel( Control parent )
            : this()
        {
            Parent = ControlConfig.GetParent( parent );
            Parent.Controls.Add( this );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="LayoutPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        /// <param name="hover">if set to
        /// <c> true </c>
        /// [hover].</param>
        public LayoutPanel( Size size, Point location, Control parent,
            bool hover )
            : this()
        {
            Size = SizeConfig.GetSize( size );
            Location = ControlConfig.GetLocation( location );
            Parent = ControlConfig.GetParent( parent );
            Parent.Controls.Add( this );
            Border.HoverVisible = hover;
        }

        // **********************************************************************************************************************
        // *************************************************   PROPERTIES   *****************************************************
        // **********************************************************************************************************************

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public Field Field { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public ToolTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the children.
        /// </summary>
        /// <value>
        /// The children.
        /// </value>
        public IEnumerable<Control> Children { get; set; }

        // ***************************************************************************************************************************
        // ************************************************  METHODS   ***************************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the color of the border.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <param name="hover">if set to <c>true</c> [hover].</param>
        public void SetBorderColor( Color color, bool hover = true )
        {
            if( color != Color.Empty )
            {
                try
                {
                    Border.Color = color;
                    Border.HoverVisible = hover;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the color of the border.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <param name="hover">if set to <c>true</c> [hover].</param>
        public void SetBorderHoverColor( Color color, bool hover = true )
        {
            if( color != Color.Empty )
            {
                try
                {
                    Border.HoverColor = color;
                    Border.HoverVisible = hover;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the color of the back.
        /// </summary>
        /// <param name="color">The color.</param>
        public void SetBackColor( Color color )
        {
            if( color != Color.Empty )
            {
                try
                {
                    BackColor = color;
                    BackColorState.Enabled = BackColor;
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
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public IEnumerable<Control> AddChild( Control item )
        {
            if( item != null )
            {
                try
                {
                    var list = new List<Control>
                    {
                        item
                    };

                    return list?.Any() == true
                        ? list
                        : default;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return default;
        }

        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name="field">The field.</param>
        public void SetField( Field field )
        {
            if( Verify.Field( field ) )
            {
                try
                {
                    Field = field;
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
            try
            {
                return Children?.Any() == true
                    ? Children
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
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
    }
}
