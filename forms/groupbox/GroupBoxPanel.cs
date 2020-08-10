// // <copyright file = "GroupBoxPanel.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    // ******************************************************************************************************************************
    // ******************************************************   ASSEMBLIES   ********************************************************
    // ******************************************************************************************************************************

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;
    using VisualPlus.Enumerators;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="VisualPlus.Toolkit.Controls.Layout.VisualGroupBox" />
    /// <seealso cref="IGroupBox" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class GroupBoxPanel : GroupBoxData, IGroupBox
    {
        // ***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="GroupBoxPanel" />
        /// class.
        /// </summary>
        public GroupBoxPanel()
        {
            // Basic Property Configuration.
            Size = SizeConfig.GetSize( 700, 431 );
            Location = ControlConfig.GetLocation();
            Anchor = ControlConfig.GetAnchorStyle();
            Dock = ControlConfig.GetDockStyle();
            Visible = true;
            Enabled = true;
            BackColor = ColorConfig.ControlInteriorBlack;
            ForeColor = ColorConfig.ForeColorGray;
            Font = FontConfig.FontSizeSmall;
            Margin = ControlConfig.Margin;
            Padding = ControlConfig.Padding;

            // Border Configuration.
            Border.Type = ShapeTypes.Rounded;
            Border.Color = ColorConfig.BorderColorGray;
            Border.Thickness = BorderConfig.SizeThin;
            Border.HoverColor = ColorConfig.BorderColorBlue;
            Border.HoverVisible = true;

            // BackColor Configuration.
            BackColorState.Disabled = ColorConfig.BackColorBlack;
            BackColorState.Enabled = ColorConfig.ControlInteriorBlack;

            // Text Configuration.
            TextAlignment = AlignConfig.StringCenter;
            TextLineAlignment = AlignConfig.StringCenter;
            TitleBoxHeight = 30;

            // Style Configuration.
            BoxStyle = GroupBoxStyle.Default;
            SeparatorColor = ColorConfig.BorderColorGray;
            Separate = true;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="GroupBoxPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public GroupBoxPanel( Size size, Point location )
            : this()
        {
            Size = SizeConfig.GetSize( size );
            Location = ControlConfig.GetLocation( location );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="GroupBoxPanel" />
        /// class.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public GroupBoxPanel( Point location, Control parent = null )
            : this()
        {
            Location = ControlConfig.GetLocation( location );

            if( parent != null )
            {
                Parent = ControlConfig.GetParent( parent );
                Parent.Controls.Add( this );
            }
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="GroupBoxPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="parent">The parent.</param>
        public GroupBoxPanel( Size size, Control parent = null )
            : this()
        {
            Size = SizeConfig.GetSize( size );

            if( parent != null )
            {
                Parent = ControlConfig.GetParent( parent );
                Parent.Controls.Add( this );
            }
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="GroupBoxPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public GroupBoxPanel( Size size, Point location, Control parent )
            : this()
        {
            Size = SizeConfig.GetSize( size );
            Location = ControlConfig.GetLocation( location );
            Parent = ControlConfig.GetParent( parent );
            Parent.Controls.Add( this );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="GroupBoxPanel" />
        /// class.
        /// </summary>
        /// <param name="title">The title.</param>
        public GroupBoxPanel( string title )
            : this()
        {
            Text = title;
        }

        // **********************************************************************************************************************
        // *************************************************   PROPERTIES   *****************************************************
        // **********************************************************************************************************************

        /// <summary>
        /// Gets or sets the header text.
        /// </summary>
        /// <value>
        /// The header text.
        /// </value>
        public string HeaderText { get; set; }

        /// <summary>
        /// Gets or sets the tip.
        /// </summary>
        /// <value>
        /// The tip.
        /// </value>
        public ToolTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="GroupBoxPanel"/> is separator.
        /// </summary>
        /// <value>
        ///   <c>true</c> if separator; otherwise, <c>false</c>.
        /// </value>
        [ DefaultValue( true ) ]
        public bool Separate { get; set; }

        // ***************************************************************************************************************************
        // *******************************************************      METHODS        ***********************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the color of the border.
        /// </summary>
        /// <param name="color">The color.</param>
        public void SetBorderColor( Color color )
        {
            if( color != Color.Empty )
            {
                try
                {
                    Border.Color = color;
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
        public void SetHoverBorderColor( Color color )
        {
            if( color != Color.Empty )
            {
                try
                {
                    Border.HoverColor = color;
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
        /// <param name="hovercolor">if set to <c>true</c> [hovercolor].</param>
        public void SetBorderConfiguration( bool hovercolor )
        {
            try
            {
                switch( hovercolor )
                {
                    case true:
                    {
                        Border.Color = Color.FromArgb( 64, 64, 64 );
                        Border.Thickness = BorderConfig.SizeThin;
                        Border.HoverColor = ColorConfig.BorderColorBlue;
                        Border.HoverVisible = true;
                        SeparatorColor = Color.FromArgb( 64, 64, 64 );
                        Separate = true;
                        Border.Type = ShapeTypes.Rounded;
                        break;
                    }

                    case false:
                    {
                        Border.Color = ColorConfig.BackColorBlack;
                        Border.Thickness = BorderConfig.SizeThin;
                        Border.HoverColor = ColorConfig.BackColorBlack;
                        Border.HoverVisible = false;
                        SeparatorColor = ColorConfig.BackColorBlack;
                        Separate = false;
                        Border.Type = ShapeTypes.Rounded;
                        break;
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the text alignment.
        /// </summary>
        /// <param name="alignment">The alignment.</param>
        public void SetTextAlignment( StringAlignment alignment = StringAlignment.Center )
        {
            if( Enum.IsDefined( typeof( StringAlignment ), alignment ) )
            {
                try
                {
                    TextAlignment = alignment;
                    TextLineAlignment = alignment;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the height of the title box.
        /// </summary>
        /// <param name="height">The height.</param>
        public void SetTitleBoxHeight( int height = 30 )
        {
            if( height > 0 )
            {
                try
                {
                    TitleBoxHeight = height;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the header text.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetHeaderText( string text )
        {
            if( Verify.Input( text ) )
            {
                try
                {
                    HeaderText = text;
                    Text = HeaderText;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the box style.
        /// </summary>
        /// <param name="style">The style.</param>
        public void SetBoxStyle( GroupBoxStyle style = GroupBoxStyle.Default )
        {
            if( Enum.IsDefined( typeof( GroupBoxStyle ), style ) )
            {
                try
                {
                    BoxStyle = style;
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
        public void AddControl( Control item )
        {
            if( item != null )
            {
                try
                {
                    Controls?.Add( item );
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

                    foreach( Control item in Controls )
                    {
                        if( item != null )
                        {
                            children.Add( item );
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
                    ToolTip = new ToolTip( this, text );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}