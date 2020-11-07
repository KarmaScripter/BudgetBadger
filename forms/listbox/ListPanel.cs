// <copyright file = "ListPanel.cs" company = "Terry D. Eppler">
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
    using MetroSet_UI.Design;

    /// <summary>
    /// Defines the
    /// <see cref="ListPanel" />
    /// </summary>
    /// <seealso cref="MetroSet_UI.Controls.MetroSetListBox" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedVariable" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public class ListPanel : ListBoxData, IListBox
    {
        // ***************************************************************************************************************************
        // *********************************************   CONSTRUCTORS **************************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ListPanel" />
        /// class.
        /// </summary>
        public ListPanel()
        {
            // Basic Control Properties
            ThemeAuthor = "Terry D. Eppler";
            ThemeName = "Budget Execution";
            Font = FontConfig.FontSizeSmall;
            ForeColor = ColorConfig.ForeGray;
            Margin = ControlConfig.Margin;
            Padding = ControlConfig.Padding;
            Size = SizeConfig.GetSize( 180, 220 );
            Location = ControlConfig.GetLocation();
            Dock = ControlConfig.GetDockStyle();
            Anchor = ControlConfig.GetAnchorStyle();
            Style = Style.Custom;
            ShowBorder = false;
            ShowScrollBar = false;
            Visible = true;
            Enabled = true;

            // BackColor Configuration
            BackColor = ColorConfig.ControlDarkInterior;
            BorderColor = ColorConfig.BorderDark;
            DisabledBackColor = ColorConfig.FormDarkBackColor;
            DisabledForeColor = ColorConfig.FormDarkBackColor;

            // Item Configuration
            ItemHeight = 30;
            HoveredItemBackColor = ColorConfig.HoverGray;
            HoveredItemColor = Color.White;
            SelectedItemBackColor = ColorConfig.BorderYellow;
            SelectedItemColor = Color.White;

            // Event Wiring
            MouseHover += OnMouseHover;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ListPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public ListPanel( Size size, Point location )
            : this()
        {
            Size = SizeConfig.GetSize( size );
            Location = ControlConfig.GetLocation( location.X, location.Y );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ListPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public ListPanel( Size size, Point location, Control parent )
            : this( size, location )
        {
            Parent = parent;
            Parent.Controls.Add( this );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ListPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location
        /// <see cref="Point" /></param>
        /// <param name="parent">The parent.</param>
        /// <param name="text">The items.</param>
        public ListPanel( Size size, Point location, Control parent,
            string text )
            : this( size, location, parent )
        {
            Text = text;
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

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public string HoverText { get; set; }

        // ***************************************************************************************************************************
        // ************************************************  METHODS   ***************************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the color of the border.
        /// </summary>
        /// <param name="format">The format.</param>
        public void SetBorderColor( ColorFormat format )
        {
            if( format != null
                && format?.BorderColor != Color.Empty )
            {
                try
                {
                    ShowBorder = true;
                    BorderColor = format.BorderColor;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the height of the item.
        /// </summary>
        /// <param name="height">The height.</param>
        public void SetItemHeight( int height )
        {
            if( height > -1 )
            {
                try
                {
                    ItemHeight = height;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the item color configuration.
        /// </summary>
        /// <param name="format">The format.</param>
        public void SetItemColorStyle( ColorFormat format )
        {
            if( format != null
                && format?.HoveredItemColor != Color.Empty
                && format?.HoveredItemColor != Color.Empty
                && format?.SelectedItemBackColor != Color.Empty
                && format?.SelectedItemColor != Color.Empty )
            {
                try
                {
                    HoveredItemBackColor = format.HoveredItemBackColor;
                    HoveredItemColor = format.HoveredItemColor;
                    SelectedItemBackColor = format.SelectedItemBackColor;
                    SelectedItemColor = format.SelectedItemColor;
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
                    HoverText = text;
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
        /// Called when [mouse hover].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        public void OnMouseHover( object sender, EventArgs e )
        {
            var listbox = sender as ListPanel;

            try
            {
                if( Verify.Input( HoverText ) )
                {
                    var _ = new ToolTip( listbox, HoverText );
                }
                else
                {
                    if( Verify.Input( Tag?.ToString() ) )
                    {
                        var _ = new ToolTip( listbox, Tag?.ToString().SplitPascal() );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
    }
}
