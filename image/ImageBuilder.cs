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
        private readonly string FullPath;

        /// <summary>
        /// The resource
        /// </summary>
        private readonly ImageSource Source;

        /// <summary>
        /// The format
        /// </summary>
        private readonly ImageFormat Format;

        // ****************************************************************************************************************************
        // *********************************************   CONSTRUCTORS ***************************************************************
        // ****************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the <see cref = "ImageBuilder"/> class.
        /// </summary>
        public ImageBuilder()
        {
        }

        public ImageBuilder( string fullfilepath )
        {
            Name = Path.GetFileNameWithoutExtension( fullfilepath );
            Source = ImageSource.NS;
            Extension = Path.GetExtension( fullfilepath );
            FullPath = Path.GetFullPath( fullfilepath );
            Format = GetFormat( Extension );
            ImageSize = Medium;
        }

        public ImageBuilder( ImageSource source )
        {
            Name = source.ToString();
            Source = GetImageSource( source );
            Extension = ImageFormat.PNG.ToString();
            FullPath = GetImageFilePath( Name, Source );
            Format = ImageFormat.PNG;
            ImageSize = SizeConfig.GetSize( ImageSizer.Medium );
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
            Name = GetName( name );
            Source = GetImageSource( source );
            Extension = GetExtension( Name, Source );
            FullPath = GetImageFilePath( Name, Source );
            Format = GetFormat( Extension );
            ImageSize = SizeConfig.GetSize( size );
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
            Name = GetName( name );
            Source = GetImageSource( source );
            Extension = GetExtension( Name, Source );
            FullPath = GetImageFilePath( Name, Source );
            Format = GetFormat( Extension );
            ImageSize = SizeConfig.GetSize( width, height );
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
            Name = GetName( name );
            Source = GetImageSource( source );
            Extension = GetExtension( Name, Source );
            FullPath = GetImageFilePath( Name, Source );
            Format = GetFormat( Extension );
            ImageSize = SizeConfig.GetSize( size );
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
        private protected string GetImageFilePath( string filepath, ImageSource imagesource )
        {
            if( Verify.ImageResource( imagesource )
                && Verify.Input( filepath )
                && imagesource != ImageSource.NS )
            {
                try
                {
                    var files = Directory.GetFiles( Resource.Settings[ imagesource.ToString() ] );
                    var path = files.Where( n => n.Contains( filepath ) )?.Select( n => n )?.FirstOrDefault();

                    if( Verify.Input( path ) )
                    {
                        return File.Exists( path )
                            ? path
                            : default;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }
            else
            {
                return GetImageFilePath( filepath );
            }

            return default;
        }

        /// <summary>
        /// Gets the image file path.
        /// </summary>
        /// <param name="filepath">The filepath.</param>
        /// <returns></returns>
        private protected string GetImageFilePath( string filepath )
        {
            if( Verify.Input( filepath ) )
            {
                try
                {
                    return File.Exists( filepath )
                        ? Path.GetFullPath( filepath )
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
        /// Gets the resource.
        /// </summary>
        /// <returns>
        /// </returns>
        public ImageSource GetImageSource()
        {
            try
            {
                return Enum.IsDefined( typeof( ImageSource ), Source )
                    ? Source
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
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
                return Verify.Input( Name )
                    ? Name
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
