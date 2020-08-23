// <copyright file = "ImageFactory.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;

    // ******************************************************************************************************************************
    // ******************************************************   ASSEMBLIES   ********************************************************
    // ******************************************************************************************************************************

    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Local" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "NotAccessedField.Local" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeMadeStatic.Local" ) ]
    public class ImageFactory : ImageConfig
    {
        // ****************************************************************************************************************************
        // *********************************************    FIELDS  *******************************************************************
        // ****************************************************************************************************************************

        /// <summary>
        /// The builder
        /// </summary>
        private readonly ImageBuilder Builder;

        /// <summary>
        /// The format
        /// </summary>
        private readonly ImageFormat Format;

        /// <summary>
        /// The stream data
        /// </summary>
        private readonly IDictionary<string, FileInfo> FileStreams;

        /// <summary>
        /// The file paths
        /// </summary>
        private readonly IEnumerable<string> Paths;

        /// <summary>
        /// The file names
        /// </summary>
        private readonly IEnumerable<string> Names;

        // ****************************************************************************************************************************
        // *********************************************   CONSTRUCTORS ***************************************************************
        // ****************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the <see cref = "ImageFactory"/> class.
        /// </summary>
        /// <param name = "imagebuilder" >
        /// The imagebuilder.
        /// </param>
        public ImageFactory( ImageBuilder imagebuilder )
        {
            Builder = imagebuilder;
            var imagesource = Builder.GetImageSource();
            Format = Builder.GetExtenstion();
            Paths = GetPaths( imagesource );
            Names = GetNames( Paths );
            FileStreams = GetFileStreams( imagesource );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ImageFactory"/> class.
        /// </summary>
        /// <param name = "imagesource" >
        /// The imagesource.
        /// </param>
        public ImageFactory( ImageSource imagesource )
        {
            Builder = new ImageBuilder( imagesource );
            var source = Builder.GetImageSource();
            Format = Builder.GetExtenstion();
            Paths = GetPaths( source );
            Names = GetNames( Paths );
            FileStreams = GetFileStreams( source );
        }

        // ****************************************************************************************************************************
        // ************************************************  METHODS   ****************************************************************
        // ****************************************************************************************************************************

        /// <summary>
        /// Sets the file paths.
        /// </summary>
        /// <param name = "resource" >
        /// The resource.
        /// </param>
        /// <returns>
        /// </returns>
        private IEnumerable<string> GetPaths( ImageSource resource )
        {
            try
            {
                return Verify.ImageResource( resource )
                    ? Directory.GetFiles( Resource.Settings[ resource.ToString() ] )
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Sets the file names.
        /// </summary>
        /// <returns>
        /// </returns>
        private IEnumerable<string> GetNames( IEnumerable<string> paths )
        {
            if( Verify.Input( paths ) )
            {
                try
                {
                    var filenames = new List<string>();

                    foreach( var path in paths )
                    {
                        if( Verify.Input( path ) )
                        {
                            var filename = Path.GetFileName( path );

                            if( File.Exists( filename ) )
                            {
                                filenames.Add( filename );
                            }
                        }
                    }

                    return filenames?.Any() == true
                        ? filenames
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
        /// Sets the file stream data.
        /// </summary>
        /// <param name = "resource" >
        /// The resource.
        /// </param>
        /// <returns>
        /// </returns>
        private IDictionary<string, FileInfo> GetFileStreams( ImageSource resource )
        {
            if( Verify.ImageResource( resource ) )
            {
                try
                {
                    var filedata = new Dictionary<string, FileInfo>();
                    var files = GetPaths( resource );

                    foreach( var image in files )
                    {
                        var stream = new FileInfo( image );
                        filedata.Add( stream.Name, stream );
                    }

                    return filedata?.Any() == true
                        ? filedata
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
        /// Gets the name.
        /// </summary>
        /// <returns>
        /// </returns>
        public IEnumerable<string> GetImageNames()
        {
            try
            {
                return Names?.Any() == true
                    ? Names
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the paths.
        /// </summary>
        /// <returns>
        /// </returns>
        public IEnumerable<string> GetImagePaths()
        {
            try
            {
                return Paths?.Any() == true
                    ? Paths
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the file stream data.
        /// </summary>
        /// <returns>
        /// </returns>
        public IDictionary<string, FileInfo> GetDataStreams()
        {
            try
            {
                return FileStreams?.Any() == true
                    ? FileStreams
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Creates the image.
        /// </summary>
        /// <returns>
        /// </returns>
        public Bitmap CreateImage()
        {
            if( Builder?.GetFileStream() != null )
            {
                try
                {
                    using var stream = Builder?.GetFileStream();

                    return stream != null
                        ? new Bitmap( stream )
                        : default( Bitmap );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( Bitmap );
                }
            }

            return default( Bitmap );
        }

        /// <summary>
        /// Creates the icon.
        /// </summary>
        /// <returns>
        /// </returns>
        public Icon CreateIcon()
        {
            if( !Builder.GetSize().IsEmpty )
            {
                try
                {
                    using var stream = Builder.GetFileStream();

                    return stream != null
                        ? new Icon( stream, Builder.GetSize() )
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
    }
}
