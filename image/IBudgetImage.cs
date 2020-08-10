// // <copyright file = "IBudgetImage.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Threading;

    public interface IBudgetImage
    {
        /// <summary>
        /// Gets the builder.
        /// </summary>
        /// <returns>
        /// </returns>
        ImageBuilder GetBuilder();

        /// <summary>
        /// Gets the factory.
        /// </summary>
        /// <returns>
        /// </returns>
        ImageFactory GetFactory();

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns>
        /// </returns>
        string GetName();

        /// <summary>
        /// Sets the tag.
        /// </summary>
        /// <param name = "tag" >
        /// The tag.
        /// </param>
        void SetTag( object tag );

        /// <summary>
        /// Gets the image.
        /// </summary>
        /// <returns>
        /// </returns>
        Image GetBitmap();

        /// <summary>
        /// Gets the image source.
        /// </summary>
        /// <returns>
        /// </returns>
        ImageSource GetImageSource( ImageSource source );

        /// <summary>
        /// Sets the name.
        /// </summary>
        /// <param name = "name" >
        /// The name.
        /// </param>
        /// <returns>
        /// </returns>
        string GetName( string name );

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
        string GetExtension( string filename, ImageSource resource );

        /// <summary>
        /// Sets the extenstion.
        /// </summary>
        /// <param name = "extension" >
        /// The filepath.
        /// </param>
        /// <returns>
        /// </returns>
        ImageFormat GetFormat( string extension );

        /// <summary>
        /// Sets the size.
        /// </summary>
        /// <returns>
        /// </returns>
        Size GetImageSize( Size size );

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
        Size GetImageSize( int width, int height );

        /// <summary>
        /// Sets the size.
        /// </summary>
        /// <returns>
        /// </returns>
        Size GetImageSize( ImageSizer size );

        /// <summary>
        /// Gets the attributes.
        /// </summary>
        /// <returns>
        /// </returns>
        Color GetColor( Color newcolor );

        /// <summary>
        /// Res the color.
        /// </summary>
        /// <param name = "newcolor" >
        /// The newcolor.
        /// </param>
        void ReColor( Color newcolor );

        /// <summary>
        /// Sets the color of the back ground.
        /// </summary>
        /// <param name = "newcolor" >
        /// The newcolor.
        /// </param>
        /// <returns>
        /// </returns>
        void SetBackGroundColor( Color newcolor );
    }
}