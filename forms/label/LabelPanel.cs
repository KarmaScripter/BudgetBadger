// <copyright file = "LabelPanel.cs" company = "Terry D. Eppler">
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
    using VisualPlus.Toolkit.Controls.Interactivity;

    /// <summary>
    /// Defines the
    /// <see cref="LabelPanel" />
    /// </summary>
    /// <seealso cref="VisualPlus.Toolkit.Controls.Interactivity.VisualLabel" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public class LabelPanel : LabelData, ILabel
    {
        // ***************************************************************************************************************************
        // *********************************************   CONSTRUCTORS **************************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="LabelPanel" />
        /// class.
        /// </summary>
        public LabelPanel()
        {
            Size = SizeConfig.GetSize( 165, 23 );
            Location = ControlConfig.GetLocation();
            BackColor = ColorConfig.BackColorBlack;
            ForeColor = ColorConfig.ForeColorGray;
            Font = FontConfig.FontSizeSmall;
            Margin = ControlConfig.Margin;
            Padding = ControlConfig.Padding;
            Anchor = ControlConfig.GetAnchorStyle();
            Dock = ControlConfig.GetDockStyle();
            Enabled = true;
            Visible = true;
            TextAlignment = AlignConfig.StringCenter;
            TextLineAlignment = AlignConfig.StringCenter;
            OutlineColor = ColorConfig.BackColorBlack;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="LabelPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public LabelPanel( Size size, Point location )
            : this()
        {
            Size = SizeConfig.GetSize( size );
            Location = ControlConfig.GetLocation( location );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="LabelPanel" />
        /// class.
        /// </summary>
        /// <param name="label">The label.</param>
        [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameter" ) ]
        public LabelPanel( VisualLabel label )
            : this( label.Size, label.Location )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="LabelPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public LabelPanel( Size size, Point location, Control parent )
            : this( size, location )
        {
            Parent = ControlConfig.GetParent( parent );
            Parent.Controls.Add( this );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="LabelPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        /// <param name="text">The text.</param>
        public LabelPanel( Size size, Point location, Control parent,
            string text )
            : this( size, location, parent )
        {
            Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="LabelPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        /// <param name="bindingsource">The bindingsource.</param>
        public LabelPanel( Size size, Point location, Control parent,
            BindingSource bindingsource )
            : this( size, location, parent )
        {
            BindingSource = bindingsource;
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
        /// Sets the color of the border.
        /// </summary>
        /// <param name="color">The color.</param>
        public void SetOutlineColor( Color color )
        {
            if( color != Color.Empty )
            {
                try
                {
                    OutlineColor = color;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the text alignment.
        /// </summary>
        /// <param name="alignment">The alignment.</param>
        public void SetTextAlignment( StringAlignment alignment )
        {
            if( Enum.IsDefined( typeof( StringAlignment ), alignment ) )
            {
                try
                {
                    TextAlignment = alignment;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the line alignment.
        /// </summary>
        /// <param name="alignment">The alignment.</param>
        public void SetLineAlignment( StringAlignment alignment )
        {
            if( Enum.IsDefined( typeof( StringAlignment ), alignment ) )
            {
                try
                {
                    TextLineAlignment = alignment;
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
    }
}
