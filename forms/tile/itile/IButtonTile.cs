// <copyright file = "IButtonTile.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System.Drawing;
    using System.Threading;
    using Syncfusion.Windows.Forms.Tools;

    public interface IButtonTile : ITile
    {
        // ***************************************************************************************************************************
        // ****************************************************    MEMBERS    ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Activates the live tile.
        /// </summary>
        /// <param name="on">if set to
        /// <c> true </c>
        /// [on].</param>
        void ActivateLiveTile( bool on );

        /// <summary>
        /// Sets the slide transition.
        /// </summary>
        /// <param name="direction">The direction.</param>
        void SetSlideDirection( TransitionDirection direction = TransitionDirection.RightToLeft );

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
        /// Sets the icon.
        /// </summary>
        /// <param name="imagepath">The imagepath.</param>
        /// <returns></returns>
        Icon GetBannerIcon( string imagepath );

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
