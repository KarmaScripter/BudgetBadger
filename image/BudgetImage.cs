// <copyright file = "BudgetImage.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
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
    using System.IO;
    using System.Threading;

    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class BudgetImage : ImageConfig, IBudgetImage
    {
        // ***************************************************************************************************************************
        // ****************************************************     FIELDS    ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// The builder
        /// </summary>
        private readonly ImageBuilder Builder;

        /// <summary>
        /// The factory
        /// </summary>
        private readonly ImageFactory Factory;

        // ****************************************************************************************************************************
        // *********************************************   CONSTRUCTORS ***************************************************************
        // ****************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the <see cref = "BudgetImage"/> class.
        /// </summary>
        public BudgetImage()
        {
        }

        public BudgetImage( string path )
        {
            Name = Path.GetFileNameWithoutExtension( path );
            Builder = new ImageBuilder( Path.GetFullPath( path ) );
            Image = new Bitmap( Builder.GetFilePath() );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetImage"/> class.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name = "source" > </param>
        public BudgetImage( string path, ImageSource source = ImageSource.NS )
        {
            Name = Path.GetFileNameWithoutExtension( path );
            Builder = new ImageBuilder( Name, source, ImageSizer.Medium );
            Factory = new ImageFactory( Builder );
            Image = Factory.CreateImage();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "BudgetImage"/> class.
        /// </summary>
        /// <param name = "imagebuilder" >
        /// The imagebuilder.
        /// </param>
        public BudgetImage( ImageBuilder imagebuilder )
        {
            Builder = imagebuilder;
            Name = Builder.GetImageName();
            Factory = new ImageFactory( Builder );
            Image = Factory.CreateImage();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "BudgetImage"/> class.
        /// </summary>
        /// <param name = "name" >
        /// The name.
        /// </param>
        /// <param name = "resource" >
        /// The resource.
        /// </param>
        /// <param name = "size" >
        /// </param>
        public BudgetImage( string name, ImageSource resource, ImageSizer size = ImageSizer.Medium )
        {
            Builder = new ImageBuilder( name, resource, size );
            Name = Builder.GetImageName();
            Factory = new ImageFactory( Builder );
            Image = Factory.CreateImage();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "BudgetImage"/> class.
        /// </summary>
        /// <param name = "name" >
        /// The name.
        /// </param>
        /// <param name = "size" >
        /// The size.
        /// </param>
        /// <param name = "resource" >
        /// The resource.
        /// </param>
        public BudgetImage( string name, ImageSource resource, Size size )
        {
            Builder = new ImageBuilder( name, resource, size );
            Name = Builder.GetImageName();
            Factory = new ImageFactory( Builder );
            Image = Factory.CreateImage();
        }

        // ****************************************************************************************************************************
        // ************************************************  METHODS   ****************************************************************
        // ****************************************************************************************************************************

        /// <summary>
        /// Gets the builder.
        /// </summary>
        /// <returns>
        /// </returns>
        public ImageBuilder GetBuilder()
        {
            try
            {
                return Verify.Ref( Builder )
                    ? Builder
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the factory.
        /// </summary>
        /// <returns>
        /// </returns>
        public ImageFactory GetFactory()
        {
            try
            {
                return Verify.Ref( Factory )
                    ? Factory
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns>
        /// </returns>
        public string GetName()
        {
            if( Verify.Input( Name ) )
            {
                try
                {
                    return Path.HasExtension( Name )
                        ? Path.GetFileNameWithoutExtension( Name )
                        : Name;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Sets the tag.
        /// </summary>
        /// <param name = "tag" >
        /// The tag.
        /// </param>
        public void SetTag( object tag )
        {
            if( Verify.Ref( Image )
                && Verify.Ref( tag ) )
            {
                try
                {
                    Image.Tag = tag;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    Image?.Dispose();
                }
            }
        }

        /// <summary>
        /// Gets the image.
        /// </summary>
        /// <returns>
        /// </returns>
        public Image GetBitmap()
        {
            try
            {
                return Verify.Ref( Image )
                    ? Image
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the attributes.
        /// </summary>
        /// <returns>
        /// </returns>
        public Color GetColor( Color newcolor )
        {
            try
            {
                return newcolor != Color.Empty
                    ? ColorConfig.GetColor( newcolor )
                    : Color.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }
    }
}