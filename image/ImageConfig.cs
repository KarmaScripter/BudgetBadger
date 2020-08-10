// <copyright file = "ImageConfig.cs" company = "Terry D. Eppler">
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
    using System.IO;
    using System.Linq;
    using System.Threading;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    public abstract class ImageConfig
    {
        // ****************************************************************************************************************************
        // ****************************************************     FIELDS    *********************************************************
        // ****************************************************************************************************************************

        /// <summary>
        /// The image
        /// </summary>
        private protected Bitmap Image;

        /// <summary>
        /// The small
        /// </summary>
        private protected static readonly Size Small = new Size( 12, 12 );

        /// <summary>
        /// The medium
        /// </summary>
        private protected static readonly Size Medium = new Size( 16, 16 );

        /// <summary>
        /// The large
        /// </summary>
        private protected static readonly Size Large = new Size( 20, 20 );

        /// <summary>
        /// The largest
        /// </summary>
        private protected static readonly Size Largest = new Size( 250, 250 );

        // ****************************************************************************************************************************
        // *************************************************   PROPERTIES   ***********************************************************
        // ****************************************************************************************************************************

        /// <summary>
        /// Gets or sets the color of the back ground.
        /// </summary>
        /// <value>
        /// The color of the back ground.
        /// </value>
        private protected Color BackGroundColor { get; set; } = Color.Transparent;

        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        /// <value>
        /// The color.
        /// </value>
        private protected Color Color { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        private protected Size ImageSize { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        private protected string Name { get; set; }

        /// <summary>
        /// Gets or sets the extension.
        /// </summary>
        /// <value>
        /// The extension.
        /// </value>
        private protected string Extension { get; set; }

        // ****************************************************************************************************************************
        // ************************************************  METHODS   ****************************************************************
        // ****************************************************************************************************************************

        /// <summary>
        /// Gets the image source.
        /// </summary>
        /// <returns>
        /// </returns>
        public ImageSource GetImageSource( ImageSource source )
        {
            try
            {
                return Verify.ImageResource( source )
                    ? source
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Sets the name.
        /// </summary>
        /// <param name = "name" >
        /// The name.
        /// </param>
        /// <returns>
        /// </returns>
        public string GetName( string name )
        {
            try
            {
                return Verify.Input( name )
                    ? name
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Sets the extension.
        /// </summary>
        /// <param name = "resource" >
        /// The resource.
        /// </param>
        /// <param name = "filename" >
        /// </param>
        /// <returns>
        /// </returns>
        public string GetExtension( string filename, ImageSource resource = ImageSource.NS )
        {
            if( Verify.ImageResource( resource )
                && Verify.Input( filename )
                && resource != ImageSource.NS )
            {
                try
                {
                    var path = Directory.GetFiles( Resource.Settings[ resource.ToString() ] )
                        ?.Where( n => n.Contains( filename ) )
                        ?.Select( n => n )
                        ?.FirstOrDefault();

                    var extension = Path.GetExtension( path );

                    return Verify.Input( extension )
                        ? extension
                        : ImageFormat.PNG.ToString();
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }
            else
            {
                return Path.GetExtension( filename );
            }
        }

        /// <summary>
        /// Sets the extenstion.
        /// </summary>
        /// <param name = "extension" >
        /// The filepath.
        /// </param>
        /// <returns>
        /// </returns>
        public ImageFormat GetFormat( string extension )
        {
            if( Verify.Input( extension ) )
            {
                try
                {
                    if( extension.StartsWith( "." ) )
                    {
                        var ext = extension.TrimStart( '.' );
                        var format = (ImageFormat)Enum.Parse( typeof( ImageFormat ), ext.ToUpper() );

                        return Verify.ImageFormat( format )
                            ? format
                            : ImageFormat.PNG;
                    }
                    else
                    {
                        var format = (ImageFormat)Enum.Parse( typeof( ImageFormat ), extension.ToUpper() );

                        return Verify.ImageFormat( format )
                            ? format
                            : ImageFormat.PNG;
                    }
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
        /// Sets the size.
        /// </summary>
        /// <returns>
        /// </returns>
        public Size GetImageSize( Size size )
        {
            try
            {
                return SizeConfig.GetSize( size );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Size.Empty;
            }
        }

        /// <summary>
        /// Sets the size of the image.
        /// </summary>
        /// <param name = "width" >
        /// The width.
        /// </param>
        /// <param name = "height" >
        /// The height.
        /// </param>
        /// <returns>
        /// </returns>
        public Size GetImageSize( int width, int height )
        {
            try
            {
                return SizeConfig.GetSize( width, height );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Size.Empty;
            }
        }

        /// <summary>
        /// Sets the size.
        /// </summary>
        /// <returns>
        /// </returns>
        public Size GetImageSize( ImageSizer size )
        {
            try
            {
                return SizeConfig.GetSize( size );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Size.Empty;
            }
        }

        /// <summary>
        /// Res the color.
        /// </summary>
        /// <param name = "newcolor" >
        /// The newcolor.
        /// </param>
        public void ReColor( Color newcolor )
        {
            if( newcolor != Color.Empty )
            {
                try
                {
                    for( var i = 0; i < Image.Width; i++ )
                    {
                        for( var j = 0; j < Image.Height; j++ )
                        {
                            if( Image.GetPixel( i, j ) != Color.Transparent )
                            {
                                Image.SetPixel( i, j, newcolor );
                            }
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    Image.Dispose();
                }
            }
        }

        /// <summary>
        /// Sets the color of the back ground.
        /// </summary>
        /// <param name = "newcolor" >
        /// The newcolor.
        /// </param>
        /// <returns>
        /// </returns>
        public void SetBackGroundColor( Color newcolor )
        {
            if( newcolor != Color.Empty )
            {
                try
                {
                    BackGroundColor = newcolor;
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