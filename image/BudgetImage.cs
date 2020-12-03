// <copyright file = "BudgetImage.cs" company = "Terry D. Eppler">
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

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.ImageConfig" />
    /// <seealso cref="BudgetExecution.IBudgetImage" />
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
        /// Initializes a new instance of the <see cref="BudgetImage"/> class.
        /// </summary>
        public BudgetImage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetImage"/> class.
        /// </summary>
        /// <param name="path">The path.</param>
        public BudgetImage( string path )
        {
            SetName( Path.GetFileNameWithoutExtension( path ) );
            Builder = new ImageBuilder( Path.GetFullPath( path ) );
            SetImageSize( Builder.GetSize() );
            SetImageSource( Builder.GetImageSource() );
            SetImageFormat( Builder.GetFormat() );
            Factory = new ImageFactory( Builder );
            Image = new Bitmap( Builder.GetFilePath() );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetImage"/> class.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="source">The source.</param>
        public BudgetImage( string path, ImageSource source = ImageSource.NS )
        {
            SetName( Path.GetFileNameWithoutExtension( path ) );
            Builder = new ImageBuilder( ImageName, source, ImageSizer.Medium );
            SetImageSize( Builder.GetSize() );
            SetImageSource( Builder.GetImageSource() );
            SetImageFormat( Builder.GetFormat() );
            Factory = new ImageFactory( Builder );
            Image = Factory.CreateImage();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetImage"/> class.
        /// </summary>
        /// <param name="imagebuilder">The imagebuilder.</param>
        public BudgetImage( ImageBuilder imagebuilder )
        {
            SetName( imagebuilder.GetImageName() );
            SetImageSize( imagebuilder.GetSize() );
            SetImageSource( imagebuilder.GetImageSource() );
            SetImageFormat( imagebuilder.GetFormat() );
            Builder = imagebuilder;
            Factory = new ImageFactory( Builder );
            Image = Factory.CreateImage();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetImage"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="resource">The resource.</param>
        /// <param name="size">The size.</param>
        public BudgetImage( string name, ImageSource resource, ImageSizer size = ImageSizer.Medium )
        {
            SetName( name );
            SetImageSize( size );
            SetImageSource( resource );
            Builder = new ImageBuilder( name, resource, size );
            SetImageFormat( Builder.GetFormat() );
            Factory = new ImageFactory( Builder );
            Image = Factory.CreateImage();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetImage"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="resource">The resource.</param>
        /// <param name="size">The size.</param>
        public BudgetImage( string name, ImageSource resource, Size size )
        {
            SetName( name );
            SetImageSize( size );
            SetImageSource( resource );
            Builder = new ImageBuilder( name, resource, size );
            SetImageFormat( Builder.GetFormat() );
            Factory = new ImageFactory( Builder );
            Image = Factory.CreateImage();
        }

        // ****************************************************************************************************************************
        // ************************************************  METHODS   ****************************************************************
        // ****************************************************************************************************************************

        /// <summary>
        /// Gets the builder.
        /// </summary>
        /// <returns></returns>
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
        /// <returns></returns>
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
        /// Sets the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
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
        /// Gets the bitmap.
        /// </summary>
        /// <returns></returns>
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
        /// Gets the color.
        /// </summary>
        /// <param name="newcolor">The newcolor.</param>
        /// <returns></returns>
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
