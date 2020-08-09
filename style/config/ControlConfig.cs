// <copyright file = "ControlConfig.cs " company = "Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ******************************************************************************************************************************
    // ******************************************************   ASSEMBLIES   ********************************************************
    // ******************************************************************************************************************************

    using System;
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class ControlConfig
    {
        // ***************************************************************************************************************************
        // ****************************************************     FIELDS    ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// The margin
        /// </summary>
        public static readonly Padding Margin = new Padding( 3 );

        /// <summary>
        /// The padding
        /// </summary>
        public static readonly Padding Padding = new Padding( 1 );

        // ***************************************************************************************************************************
        // ******************************************************   PROPERTIES   *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Gets or sets the parent.
        /// </summary>
        /// <value>
        /// The parent.
        /// </value>
        public static Control Parent { get; set; }

        // ***************************************************************************************************************************
        // ****************************************************  CONSTRUCTORS ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the <see cref = "ControlConfig"/> class.
        /// </summary>
        public ControlConfig()
        {
        }

        // ***************************************************************************************************************************
        // ************************************************  METHODS   ***************************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the tag.
        /// </summary>
        /// <param name = "tag" >
        /// The tag.
        /// </param>
        /// <returns>
        /// </returns>
        public static object GetTag( object tag )
        {
            if( tag != null )
            {
                try
                {
                    return Verify.Input( tag.ToString() )
                        ? tag
                        : default;
                }
                catch( Exception ex )
                {
                    using var error = new Error( ex );
                    error?.SetText();
                    error?.ShowDialog();
                    return default;
                }
            }

            return default;
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name = "text" >
        /// The text.
        /// </param>
        public static string GetText( string text )
        {
            if( Verify.Input( text ) )
            {
                try
                {
                    return text;
                }
                catch( Exception ex )
                {
                    using var error = new Error( ex );
                    error?.SetText();
                    error?.ShowDialog();
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Sets the anchor.
        /// </summary>
        /// <param name = "anchor" >
        /// The anchor.
        /// </param>
        /// <returns>
        /// </returns>
        public static AnchorStyles GetAnchorStyle( AnchorStyles anchor = AnchorStyles.Left & AnchorStyles.Top & AnchorStyles.Right )
        {
            try
            {
                return Enum.IsDefined( typeof( AnchorStyles ), anchor )
                    ? anchor
                    : AnchorStyles.None;
            }
            catch( Exception ex )
            {
                using var error = new Error( ex );
                error?.SetText();
                error?.ShowDialog();
                return default;
            }
        }

        /// <summary>
        /// Sets the dock style.
        /// </summary>
        /// <param name = "doc" >
        /// The document.
        /// </param>
        /// <returns>
        /// </returns>
        public static DockStyle GetDockStyle( DockStyle doc = DockStyle.None )
        {
            if( Enum.IsDefined( typeof( DockStyle ), doc ) )
            {
                try
                {
                    return Enum.IsDefined( typeof( DockStyle ), doc )
                        ? doc
                        : DockStyle.None;
                }
                catch( Exception ex )
                {
                    using var error = new Error( ex );
                    error?.SetText();
                    error?.ShowDialog();
                    return default;
                }
            }

            return default;
        }

        /// <summary>
        /// Sets the parent.
        /// </summary>
        /// <param name = "control" >
        /// The control.
        /// </param>
        /// <returns>
        /// </returns>
        public static Control GetParent( Control control )
        {
            if( control != null )
            {
                try
                {
                    Parent = control;
                    Parent.Controls.Add( control );

                    return Parent.Controls.Contains( control )
                        ? Parent
                        : default;
                }
                catch( Exception ex )
                {
                    using var error = new Error( ex );
                    error?.SetText();
                    error?.ShowDialog();
                    return default;
                }
            }

            return default;
        }

        /// <summary>
        /// Sets the location.
        /// </summary>
        /// <param name = "x" >
        /// The x.
        /// </param>
        /// <param name = "y" >
        /// The y.
        /// </param>
        /// <returns>
        /// </returns>
        public static Point GetLocation( int x = 1, int y = 1 )
        {
            if( x > -1
                && y > -1 )
            {
                try
                {
                    return new Point( x, y );
                }
                catch( Exception ex )
                {
                    using var error = new Error( ex );
                    error?.SetText();
                    error?.ShowDialog();
                }
            }

            return default;
        }

        /// <summary>
        /// Sets the location.
        /// </summary>
        /// <param name = "point" >
        /// The point.
        /// </param>
        /// <returns>
        /// </returns>
        public static Point GetLocation( Point point )
        {
            if( point.X > -1
                && point.Y > -1 )
            {
                try
                {
                    return point;
                }
                catch( Exception ex )
                {
                    using var error = new Error( ex );
                    error?.SetText();
                    error?.ShowDialog();
                    return default;
                }
            }

            return default;
        }

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <param name = "size" >
        /// The size.
        /// </param>
        /// <returns>
        /// </returns>
        public static Size GetSize( Size size )
        {
            if( size.Width > 0
                && size.Width < SizeConfig.FormMaximum.Width
                && size.Height > 0
                && size.Height < SizeConfig.FormMaximum.Height )
            {
                try
                {
                    return size;
                }
                catch( Exception ex )
                {
                    using var error = new Error( ex );
                    error?.SetText();
                    error?.ShowDialog();
                    return Size.Empty;
                }
            }

            return Size.Empty;
        }

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <param name = "width" >
        /// The width.
        /// </param>
        /// <param name = "height" >
        /// The height.
        /// </param>
        /// <returns>
        /// </returns>
        public static Size GetSize( int width, int height )
        {
            if( width > 0
                && width < SizeConfig.FormMaximum.Width
                && height > 0
                && height < SizeConfig.FormMaximum.Height )
            {
                try
                {
                    return new Size( width, height );
                }
                catch( Exception ex )
                {
                    using var error = new Error( ex );
                    error?.SetText();
                    error?.ShowDialog();
                    return Size.Empty;
                }
            }

            return Size.Empty;
        }

        /// <summary>
        /// Sets the tool tip.
        /// </summary>
        /// <param name = "control" >
        /// </param>
        /// <param name = "text" >
        /// The text.
        /// </param>
        public static ToolTip GetToolTip( Control control, string text )
        {
            if( control != null
                && Verify.Input( text ) )
            {
                try
                {
                    return new ToolTip( control, text );
                }
                catch( Exception ex )
                {
                    using var error = new Error( ex );
                    error?.SetText();
                    error?.ShowDialog();
                    return default;
                }
            }

            return default;
        }
    }
}