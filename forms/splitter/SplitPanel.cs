// <copyright file = "SplitPanel.cs" company = "Terry D. Eppler">
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
    /// Defines the
    /// <see />
    /// </summary>
    /// <seealso cref="ISplitter" />
    [ SuppressMessage( "ReSharper", "HeuristicUnreachableCode" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public class SplitPanel : SplitBase, ISplitter
    {
        // ***************************************************************************************************************************
        // *********************************************   CONSTRUCTORS **************************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SplitPanel" />
        /// class.
        /// </summary>
        public SplitPanel()
        {
            // Basic Properties
            LeftPanel = Panel1;
            RightPanel = Panel2;
            Location = ControlConfig.GetLocation();
            BackColor = ColorConfig.BackDark;
            ForeColor = ColorConfig.ForeGray;
            Margin = ControlConfig.Margin;
            Padding = ControlConfig.Padding;
            Dock = ControlConfig.GetDockStyle( DockStyle.Fill );
            Enabled = true;
            Visible = true;

            // Panel Configuration
            IsSplitterFixed = false;
            SplitterWidth = 1;
            SplitterDistance = Size.Width / 2;
            Panel1MinSize = 0;
            Panel2MinSize = 0;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SplitPanel" />
        /// class.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="heigth">The heigth.</param>
        public SplitPanel( int width, int heigth )
            : this()
        {
            Size = SizeConfig.GetSize( width, heigth );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SplitPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public SplitPanel( Size size, Point location )
            : this()
        {
            Size = SizeConfig.GetSize( size );
            Location = location;
        }

        // ***************************************************************************************************************************
        // ****************************************************     METHODS   ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the size.
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
        /// Sets the location.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public void SetLocation( int x, int y )
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
        /// Sets the dock style.
        /// </summary>
        /// <param name="dock">The dock.</param>
        public void SetDockStyle( DockStyle dock = DockStyle.None )
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
        /// Sets the anchor style.
        /// </summary>
        /// <param name="anchor">The anchor.</param>
        public void SetAnchorStyle( AnchorStyles anchor = AnchorStyles.Top & AnchorStyles.Left )
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
    }
}
