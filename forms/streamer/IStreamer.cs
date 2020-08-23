// <copyright file = "IStreamer.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using Syncfusion.Windows.Forms.Tools;

    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public interface IStreamer
    {
        // ***************************************************************************************************************************
        // ****************************************************    MEMBERS    ********************************************************
        // ***************************************************************************************************************************

        /// <summary> Sets the animation speed. </summary>
        /// <param name = "speed" > The speed. </param>
        /// <returns> </returns>
        int SetAnimationSpeed( int speed = 10 );

        /// <summary> Sets the slider speed. </summary>
        /// <param name = "speed" > The speed. </param>
        /// <returns> </returns>
        int SetSliderSpeed( int speed = 1000 );

        /// <summary> Sets the images. </summary>
        /// <param name = "images" > The images. </param>
        /// <returns> </returns>
        List<Image> SetImages( IEnumerable<Image> images );

        /// <summary> Adds the image. </summary>
        /// <param name = "image" > The image. </param>
        void AddImage( Bitmap image );

        /// <summary> Sets the stream direction. </summary>
        /// <param name = "direction" > The direction. </param>
        /// <returns> </returns>
        void SetImageSlideDirection( ImageStreamer.StreamDirection direction = ImageStreamer.StreamDirection.RightToLeft );

        /// <summary> Sets the main text. </summary>
        /// <param name = "text" > The text. </param>
        /// <param name = "font" > The font. </param>
        void SetMainText( string text, Font font );

        /// <summary> Sets the sub text. </summary>
        /// <param name = "text" > The text. </param>
        /// <param name = "font" > The font. </param>
        void SetSubText( string text, Font font );

        /// <summary> Sets the navigator. </summary>
        /// <param name = "nav" >
        /// if set to
        /// <c> true </c>
        /// [nav].
        /// </param>
        /// <returns> </returns>
        void DisplayNavigator( bool nav = true );

        /// <summary> Sets the slide show. </summary>
        /// <param name = "show" >
        /// if set to
        /// <c> true </c>
        /// [show].
        /// </param>
        /// <returns> </returns>
        void SetSlideShow( bool show = true );

        /// <summary> Sets the text animation direction. </summary>
        /// <param name = "direction" > The direction. </param>
        /// <returns> </returns>
        void SetTextAnimationDirection( ImageStreamer.TextStreamDirection direction = ImageStreamer.TextStreamDirection.TopToBottom );

        /// <summary> Sets the color of the internal back. </summary>
        /// <param name = "color" > The color. </param>
        /// <returns> </returns>
        void SetInternalBackColor( Color color );

        /// <summary> Sets the hover information. </summary>
        /// <param name = "text" > The text. </param>
        void SetHoverText( string text );

        /// <summary> Called when [hover]. </summary>
        /// <param name = "sender" > The sender. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        void OnHover( object sender, EventArgs e );
    }
}
