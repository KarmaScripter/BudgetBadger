// <copyright file = "IRotatingTile.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System.Drawing;
    using Syncfusion.Windows.Forms.Tools;

    public interface IRotatingTile : ITile
    {
        // ***************************************************************************************************************************
        // ****************************************************    MEMBERS    ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the rotation speed.
        /// </summary>
        /// <param name="speed">The speed.</param>
        void SetRotationSpeed( int speed = 0 );

        /// <summary>
        /// Sets the rotate flip direction.
        /// </summary>
        /// <param name="direction">The direction.</param>
        void SetFlipDirection( TileFlipDirection direction = TileFlipDirection.Horizontal );

        /// <summary>
        /// Sets the size of the banner.
        /// </summary>
        /// <param name="size">The size.</param>
        void SetBannerSize( int size = 24 );

        /// <summary>
        /// Sets the color of the banner.
        /// </summary>
        /// <param name="color">The color.</param>
        void SetBannerColor( Color color );

        /// <summary>
        /// Sets the banner.
        /// </summary>
        /// <param name="text">The text.</param>
        void SetBannerText( string text );

        /// <summary>
        /// Sets the image transition direction.
        /// </summary>
        /// <param name="slide">The slide.</param>
        void SetImageDirection( TransitionDirection slide = TransitionDirection.RightToLeft );

        /// <summary>
        /// Sets the image transition speed.
        /// </summary>
        /// <param name="speed">The speed.</param>
        void SetImageSpeed( int speed = 1 );
    }
}
