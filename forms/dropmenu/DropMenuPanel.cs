// <copyright file = "DropMenuPanel.cs" company = "Terry D. Eppler">
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
    using Expander;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Expander.ucExpander" />
    /// <seealso cref="IDropMenu" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class DropMenuPanel : ucExpander, IDropMenu
    {
        // ***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DropMenuPanel" />
        /// class.
        /// </summary>
        public DropMenuPanel()
        {
            // Basic Properties
            Size = SizeConfig.GetSize( 180, 30 );
            Font = FontConfig.FontSizeMedium;
            Location = ControlConfig.GetLocation();
            Anchor = ControlConfig.GetAnchorStyle();
            Dock = ControlConfig.GetDockStyle();
            ForeColor = ColorConfig.ForeGray;
            Enabled = true;
            Visible = true;

            // Style Properties
            BackColor = ColorConfig.BackDark;
            BorderColor = ColorConfig.BackDark;
            HeaderBackColor = ColorConfig.BackDark;
            Margin = ControlConfig.Margin;
            Padding = ControlConfig.Padding;
            BorderStyle = BorderStyle.None;
            UseAnimation = true;
            IsExpanded = false;
            ExpandedHeight = 600;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DropMenuPanel" />
        /// class.
        /// </summary>
        /// <param name="header">The header.</param>
        public DropMenuPanel( string header )
            : this()
        {
            HeaderText = "  " + header;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DropMenuPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public DropMenuPanel( Size size, Point location )
            : this()
        {
            Size = SizeConfig.GetSize( size.Width, size.Height );
            Font = FontConfig.FontSizeMedium;
            Location = ControlConfig.GetLocation( location.X, location.Y );
        }

        // ***************************************************************************************************************************
        // ******************************************************   PROPERTIES   *****************************************************
        // ***************************************************************************************************************************

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
        /// Gets or sets the header text.
        /// </summary>
        /// <value>
        /// The header text.
        /// </value>
        public string HeaderText { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public ToolTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        // ***************************************************************************************************************************
        // *******************************************************      METHODS        ***********************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the border style.
        /// </summary>
        /// <param name="style">The style.</param>
        public void SetBorderStyle( BorderStyle style = BorderStyle.None )
        {
            if( Enum.IsDefined( typeof( BorderStyle ), style ) )
            {
                try
                {
                    BorderStyle = style;
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
        public void SetBorderColor( Color color )
        {
            if( color != Color.Empty )
            {
                try
                {
                    BorderColor = color;
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
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the expanded sized.
        /// </summary>
        /// <param name="height">The height.</param>
        public void SetExpandedSize( int height = 500 )
        {
            if( height >= Size.Height )
            {
                try
                {
                    ExpandedHeight = height;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Opens this instance.
        /// </summary>
        public void Open()
        {
            try
            {
                if( !IsExpanded )
                {
                    IsExpanded = true;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Closes this instance.
        /// </summary>
        public void Close()
        {
            try
            {
                if( IsExpanded )
                {
                    IsExpanded = false;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the header text.
        /// </summary>
        /// <param name="header">The header.</param>
        public void SetHeaderText( string header )
        {
            if( Verify.Input( header ) )
            {
                try
                {
                    HeaderText = "  " + header;
                    Text = HeaderText;
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
                    Controls.Add( item );
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
        /// Sets the field.
        /// </summary>
        /// <param name="field">The field.</param>
        public void SetField( Field field )
        {
            if( Enum.IsDefined( typeof( Field ), field ) )
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
