// // <copyright file = "IBudgetImage.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System.Drawing;

    public interface IBudgetImage
    {
        /// <summary>
        /// Gets the bitmap.
        /// </summary>
        /// <returns></returns>
        Image GetBitmap();

        /// <summary>
        /// Gets the image source.
        /// </summary>
        /// <returns></returns>
        ImageSource GetImageSource();

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns></returns>
        string GetName();

        /// <summary>
        /// Gets the extension.
        /// </summary>
        /// <returns></returns>
        string GetExtension();

        /// <summary>
        /// Gets the format.
        /// </summary>
        /// <returns></returns>
        ImageFormat GetFormat();

        /// <summary>
        /// Gets the size of the image.
        /// </summary>
        /// <returns></returns>
        Size GetImageSize();

        /// <summary>
        /// Res the color.
        /// </summary>
        /// <param name="newcolor">The newcolor.</param>
        void ReColor( Color newcolor );

        /// <summary>
        /// Sets the color of the back ground.
        /// </summary>
        /// <param name="newcolor">The newcolor.</param>
        void SetBackGroundColor( Color newcolor );
    }
}