// // <copyright file = "ImageConfig.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

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

    /// <summary>
    /// 
    /// </summary>
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
        /// The source
        /// </summary>
        private protected ImageSource Source;

        /// <summary>
        /// The format
        /// </summary>
        private protected ImageFormat Format;

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
        /// The huge
        /// </summary>
        private protected static readonly Size Huge = new Size( 250, 250 );

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
        /// Gets or sets the size of the image.
        /// </summary>
        /// <value>
        /// The size of the image.
        /// </value>
        private protected Size ImageSize { get; set; }

        /// <summary>
        /// Gets or sets the name of the image.
        /// </summary>
        /// <value>
        /// The name of the image.
        /// </value>
        private protected string ImageName { get; set; }

        /// <summary>
        /// Gets or sets the file extension.
        /// </summary>
        /// <value>
        /// The file extension.
        /// </value>
        private protected string FileExtension { get; set; }

        // ****************************************************************************************************************************
        // ************************************************  METHODS   ****************************************************************
        // ****************************************************************************************************************************

        /// <summary>
        /// Sets the image source.
        /// </summary>
        /// <param name="source">The source.</param>
        private protected void SetImageSource( ImageSource source )
        {
            try
            {
                Source = Verify.ImageResource( source )
                    ? source
                    : ImageSource.NS;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Gets the image source.
        /// </summary>
        /// <returns></returns>
        public ImageSource GetImageSource()
        {
            try
            {
                return Enum.IsDefined( typeof( ImageSource ), Source )
                    ? Source
                    : ImageSource.NS;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return ImageSource.NS;
            }
        }

        /// <summary>
        /// Sets the name.
        /// </summary>
        /// <param name="name">The name.</param>
        private protected void SetName( string name )
        {
            try
            {
                ImageName = Verify.Input( name )
                    ? name
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            try
            {
                return Verify.Input( ImageName )
                    ? ImageName
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Sets the file extension.
        /// </summary>
        /// <param name="filepath">The filepath.</param>
        /// <param name="resource">The resource.</param>
        private protected void SetFileExtension( string filepath, ImageSource resource = ImageSource.NS )
        {
            try
            {
                FileExtension = Verify.ImageResource( resource )
                    && Verify.Input( filepath )
                    && File.Exists( filepath )
                    && resource != ImageSource.NS
                        ? filepath
                        : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Gets the extension.
        /// </summary>
        /// <returns></returns>
        public string GetExtension()
        {
            try
            {
                return Verify.Input( FileExtension )
                    ? FileExtension
                    : ImageFormat.PNG.ToString();
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Sets the image format.
        /// </summary>
        /// <param name="format">The format.</param>
        private protected void SetImageFormat( ImageFormat format )
        {
            try
            {
                Format = Enum.IsDefined( typeof( ImageFormat ), format )
                    ? format
                    : ImageFormat.NS;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the image format.
        /// </summary>
        /// <param name="extension">The extension.</param>
        private protected void SetImageFormat( string extension )
        {
            try
            {
                var names = Enum.GetNames( typeof( ImageFormat ) );

                if( names.Contains( extension ) )
                {
                    Format = (ImageFormat)Enum.Parse( typeof( ImageFormat ), extension );
                }
                else
                {
                    Format = ImageFormat.PNG;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Gets the format.
        /// </summary>
        /// <returns></returns>
        public ImageFormat GetFormat()
        {
            try
            {
                return Enum.IsDefined( typeof( ImageFormat ), Format )
                    ? Format
                    : ImageFormat.NS;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return ImageFormat.NS;
            }
        }

        /// <summary>
        /// Sets the size of the image.
        /// </summary>
        /// <param name="size">The size.</param>
        private protected void SetImageSize( Size size )
        {
            try
            {
                ImageSize = size != Size.Empty
                    ? SizeConfig.GetSize( size )
                    : Size.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the size of the image.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        private protected void SetImageSize( int width, int height )
        {
            try
            {
                ImageSize = width > -1 && height > -1
                    ? SizeConfig.GetSize( width, height )
                    : Size.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the size of the image.
        /// </summary>
        /// <param name="sizer">The sizer.</param>
        private protected void SetImageSize( ImageSizer sizer )
        {
            try
            {
                ImageSize = Enum.IsDefined( typeof( ImageSizer ), sizer )
                    ? SizeConfig.GetSize( sizer )
                    : Size.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Gets the size of the image.
        /// </summary>
        /// <returns></returns>
        public Size GetImageSize()
        {
            try
            {
                return ImageSize != Size.Empty
                    ? ImageSize
                    : Size.Empty;
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
        /// <param name="newcolor">The newcolor.</param>
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
        /// <param name="newcolor">The newcolor.</param>
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
        /// Fails the specified ex.
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