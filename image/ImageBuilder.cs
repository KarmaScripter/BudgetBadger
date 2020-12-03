// <copyright file = "ImageBuilder.cs" company = "Terry D. Eppler">
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

    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class ImageBuilder : ImageConfig
    {
        // ***************************************************************************************************************************
        // ****************************************************     FIELDS    ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// The file path
        /// </summary>
        private protected string FullPath;

        // ****************************************************************************************************************************
        // *********************************************   CONSTRUCTORS ***************************************************************
        // ****************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the <see cref = "ImageBuilder"/> class.
        /// </summary>
        public ImageBuilder()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageBuilder"/> class.
        /// </summary>
        /// <param name="fullfilepath">The fullfilepath.</param>
        public ImageBuilder( string fullfilepath )
        {
            SetName( Path.GetFileNameWithoutExtension( fullfilepath ) );
            Source = ImageSource.NS;
            SetFileExtension( Path.GetExtension( fullfilepath ) );
            SetImageFilePath( fullfilepath, Source );
            SetImageFormat( FileExtension );
            SetImageFilePath( ImageName, Source );
            SetImageSize( Medium );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageBuilder"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        public ImageBuilder( ImageSource source )
        {
            SetName( source.ToString() );
            SetImageSource( source );
            SetFileExtension( ImageFormat.PNG.ToString() );
            SetImageFormat( FileExtension );
            SetImageFilePath( ImageName, Source );
            SetImageFormat( Format );
            SetImageSize( ImageSizer.Medium );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ImageBuilder"/> class.
        /// </summary>
        /// <param name = "name" >
        /// The name.
        /// </param>
        /// <param name = "source" >
        /// The resource.
        /// </param>
        /// <param name = "size" >
        /// The size.
        /// </param>
        public ImageBuilder( string name, ImageSource source, ImageSizer size = ImageSizer.Medium )
        {
            SetName( name );
            SetImageSource( source );
            SetFileExtension( ImageName, Source );
            SetImageFormat( FileExtension );
            SetImageFilePath( ImageName, Source );
            SetImageFormat( FileExtension );
            SetImageSize( ImageSizer.Medium );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ImageBuilder"/> class.
        /// </summary>
        /// <param name = "name" >
        /// The name.
        /// </param>
        /// <param name = "source" >
        /// The resource.
        /// </param>
        /// <param name = "width" >
        /// The width.
        /// </param>
        /// <param name = "height" >
        /// The height.
        /// </param>
        public ImageBuilder( string name, ImageSource source, int width = 16,
            int height = 16 )
        {
            SetName( name );
            SetImageSource( source );
            SetFileExtension( ImageName, Source );
            SetImageFormat( FileExtension );
            SetImageFilePath( ImageName, Source );
            SetImageFormat( FileExtension );
            SetImageSize( width, height );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ImageBuilder"/> class.
        /// </summary>
        /// <param name = "name" >
        /// The name.
        /// </param>
        /// <param name = "source" >
        /// The resource.
        /// </param>
        /// <param name = "size" >
        /// The size.
        /// </param>
        public ImageBuilder( string name, ImageSource source, Size size )
        {
            SetName( name );
            SetImageSource( source );
            SetFileExtension( ImageName, Source );
            SetImageFormat( FileExtension );
            SetImageFilePath( ImageName, Source );
            SetImageFormat( FileExtension );
            SetImageSize( size );
        }

        // ****************************************************************************************************************************
        // ************************************************  METHODS   ****************************************************************
        // ****************************************************************************************************************************

        /// <summary>
        /// Sets the file path.
        /// </summary>
        /// <param name = "imagesource" >
        /// The imagesource.
        /// </param>
        /// <param name = "filepath" >
        /// </param>
        /// <returns>
        /// </returns>
        private protected void SetImageFilePath( string filepath, ImageSource imagesource )
        {
            if( Verify.ImageResource( imagesource )
                && Verify.Input( filepath )
                && imagesource != ImageSource.NS )
            {
                try
                {
                    var files = Directory.GetFiles( Resource.Settings[ imagesource.ToString() ] );
                    
                    var path = files
                        ?.Where( n => n.Contains( filepath ) )
                        ?.Select( n => n )
                        ?.FirstOrDefault();

                    if( Verify.Input( path ) )
                    {
                        FullPath = File.Exists( path )
                            ? path
                            : default;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Gets the image file path.
        /// </summary>
        /// <param name="filepath">The filepath.</param>
        /// <returns></returns>
        private protected void GetImageFilePath( string filepath )
        {
            if( Verify.Input( filepath ) )
            {
                try
                {
                    FullPath = File.Exists( filepath )
                        ? Path.GetFullPath( filepath )
                        : default;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Gets the resource path.
        /// </summary>
        /// <returns>
        /// </returns>
        public string GetDirectoryPath()
        {
            try
            {
                return Verify.ImageResource( Source ) && Verify.Input( Resource.Settings[ $"{Source}" ] )
                    ? Resource.Settings[ $"{Source}" ]
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the path.
        /// </summary>
        /// <returns>
        /// </returns>
        public string GetFilePath()
        {
            try
            {
                return Verify.Input( FullPath )
                    ? FullPath
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }

            return default;
        }

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <returns>
        /// </returns>
        public Size GetSize()
        {
            try
            {
                return ImageSize;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }

            return default;
        }

        /// <summary>
        /// Gets the name of the image.
        /// </summary>
        /// <returns>
        /// </returns>
        public string GetImageName()
        {
            try
            {
                return Verify.Input( ImageName )
                    ? ImageName
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the extenstion.
        /// </summary>
        /// <returns>
        /// </returns>
        public ImageFormat GetExtenstion()
        {
            try
            {
                return Enum.IsDefined( typeof( ImageFormat ), Format )
                    ? Format
                    : ImageFormat.PNG;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the resource manager.
        /// </summary>
        /// <returns>
        /// </returns>
        public FileStream GetFileStream()
        {
            try
            {
                return Verify.Input( FullPath ) && File.Exists( FullPath )
                    ? File.OpenRead( FullPath )
                    : default( FileStream );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( FileStream );
            }
        }
    }
}
