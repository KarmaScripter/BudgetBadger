// <copyright file = "TileBase.cs" company = "Terry D. Eppler">
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
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.Tools.HubTile" />
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    public class TileBase : HubTile
    {
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
        /// Gets or sets the footer text.
        /// </summary>
        /// <value>
        /// The footer text.
        /// </value>
        public string FooterText { get; set; }

        /// <summary>
        /// Gets or sets the body text.
        /// </summary>
        /// <value>
        /// The body text.
        /// </value>
        public string BodyText { get; set; }

        /// <summary>
        /// Gets or sets the title text.
        /// </summary>
        /// <value>
        /// The title text.
        /// </value>
        public string TitleText { get; set; }

        /// <summary>
        /// Gets or sets the icon.
        /// </summary>
        /// <value>
        /// The icon.
        /// </value>
        public Icon Icon { get; set; }

        /// <summary>
        /// Gets or sets the size of the tile.
        /// </summary>
        /// <value>
        /// The size of the tile.
        /// </value>
        public Size TileSize { get; set; }

        /// <summary>
        /// Gets or sets the image path.
        /// </summary>
        /// <value>
        /// The image path.
        /// </value>
        public string ImagePath { get; set; }

        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        /// <value>
        /// The images.
        /// </value>
        public IEnumerable<Image> Images { get; set; }

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

        // **************************************************************************************************************************
        // ********************************************      METHODS    *************************************************************
        // **************************************************************************************************************************

        /// <summary>
        /// Sets the size.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public void SetSize( int width, int height )
        {
            try
            {
                Size = SizeConfig.GetSize( width, height );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the size.
        /// </summary>
        /// <param name="size">The size.</param>
        public void SetSize( Size size )
        {
            try
            {
                Size = SizeConfig.GetSize( size );
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
        /// Sets the location.
        /// </summary>
        /// <param name="point">The point.</param>
        public void SetLocation( Point point )
        {
            try
            {
                Location = ControlConfig.GetLocation( point );
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
        /// Sets the title.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetTitleText( string text )
        {
            if( Verify.Input( text )
                && Title != null )
            {
                try
                {
                    Title.Text = text;
                    Title.TextColor = Color.LightGray;
                    Title.Font = new Font( "Roboto", 12, FontStyle.Regular );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the title text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="font">The font.</param>
        /// <param name="color">The color.</param>
        public void SetTitleText( string text, Font font, Color color )
        {
            if( Verify.Input( text )
                && Title != null
                && font != null
                && !color.IsEmpty )
            {
                try
                {
                    Title.Text = text;
                    Title.TextColor = color;
                    Title.Font = font;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the body.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="font">The font.</param>
        /// <param name="color">The color.</param>
        public void SetBodyText( string text, Font font, Color color )
        {
            if( Verify.Input( text )
                && Body != null
                && font != null
                && !color.IsEmpty )
            {
                try
                {
                    Body.Text = text;
                    Body.TextColor = color;
                    Body.Font = font;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the body text.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetBodyText( string text )
        {
            if( Verify.Input( text )
                && Body != null )
            {
                try
                {
                    Body.Text = text;
                    Body.TextColor = ColorConfig.ForeColorGray;
                    Body.Font = FontConfig.FontSizeLarge;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the footer text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="font">The font.</param>
        /// <param name="color">The color.</param>
        public void SetFooterText( string text, Font font, Color color )
        {
            if( Verify.Input( text )
                && Footer != null
                && font != null
                && !color.IsEmpty )
            {
                try
                {
                    Footer.Text = text;
                    Footer.TextColor = ColorConfig.ForeColorGray;
                    Footer.Font = FontConfig.FontSizeSmall;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the footer.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetFooterText( string text )
        {
            if( Verify.Input( text )
                && Footer != null )
            {
                try
                {
                    Footer.Text = text;
                    Footer.TextColor = ColorConfig.ForeColorGray;
                    Footer.Font = FontConfig.FontSizeSmall;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the image.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="source">The source.</param>
        /// <param name="size">The size.</param>
        public void SetImage( string name, ImageSource source, Size size )
        {
            if( Verify.Input( name )
                && Enum.IsDefined( typeof( ImageSource ), source ) )
            {
                try
                {
                    var builder = new ImageBuilder( name, source, size );
                    var budgetimage = new BudgetImage( builder );
                    var image = budgetimage?.GetBitmap();

                    if( image != null )
                    {
                        ImageSource = image;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
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
