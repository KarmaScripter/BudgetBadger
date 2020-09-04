// <copyright file = "StreamerControl.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Drawing;
using Syncfusion.Windows.Forms.Tools;

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    public partial class StreamerControl : ControlBase, IStreamer
    {
        // ***************************************************************************************************************************
        // ****************************************************  CONSTRUCTORS ********************************************************
        // ***************************************************************************************************************************

        public StreamerControl()
        {
            InitializeComponent();
        }

        // ***************************************************************************************************************************
        // ****************************************************     METHODS   ********************************************************
        // ***************************************************************************************************************************

        /// <summary> Sets the animation speed. </summary>
        /// <param name = "speed" > The speed. </param>
        /// <returns> </returns>
        public int SetAnimationSpeed( int speed = 10 )
        {
            return ( (IStreamer)ImageStreamer ).SetAnimationSpeed( speed );
        }

        /// <summary> Sets the slider speed. </summary>
        /// <param name = "speed" > The speed. </param>
        /// <returns> </returns>
        public int SetSliderSpeed( int speed = 1000 )
        {
            return ( (IStreamer)ImageStreamer ).SetSliderSpeed( speed );
        }

        /// <summary> Sets the images. </summary>
        /// <param name = "images" > The images. </param>
        /// <returns> </returns>
        public List<Image> SetImages( IEnumerable<Image> images )
        {
            return ImageStreamer.SetImages( images );
        }

        /// <summary> Adds the image. </summary>
        /// <param name = "image" > The image. </param>
        public void AddImage( Bitmap image )
        {
            ImageStreamer.AddImage( image );
        }

        /// <summary> Sets the stream direction. </summary>
        /// <param name = "direction" > The direction. </param>
        /// <returns> </returns>
        public void SetImageSlideDirection( ImageStreamer.StreamDirection direction = Syncfusion.Windows.Forms.Tools.ImageStreamer.StreamDirection.RightToLeft )
        {
            ImageStreamer.SetImageSlideDirection( direction );
        }

        /// <summary> Sets the main text. </summary>
        /// <param name = "text" > The text. </param>
        /// <param name = "font" > The font. </param>
        public void SetMainText( string text, Font font )
        {
            ( (IStreamer)ImageStreamer ).SetMainText( text, font );
        }

        /// <summary> Sets the sub text. </summary>
        /// <param name = "text" > The text. </param>
        /// <param name = "font" > The font. </param>
        public void SetSubText( string text, Font font )
        {
            ( (IStreamer)ImageStreamer ).SetSubText( text, font );
        }

        /// <summary> Sets the navigator. </summary>
        /// <param name = "nav" >
        /// if set to
        /// <c> true </c>
        /// [nav].
        /// </param>
        /// <returns> </returns>
        public void DisplayNavigator( bool nav = true )
        {
            ( (IStreamer)ImageStreamer ).DisplayNavigator( nav );
        }

        /// <summary> Sets the slide show. </summary>
        /// <param name = "show" >
        /// if set to
        /// <c> true </c>
        /// [show].
        /// </param>
        /// <returns> </returns>
        public void SetSlideShow( bool show = true )
        {
            ( (IStreamer)ImageStreamer ).SetSlideShow( show );
        }

        /// <summary> Sets the text animation direction. </summary>
        /// <param name = "direction" > The direction. </param>
        /// <returns> </returns>
        public void SetTextAnimationDirection( ImageStreamer.TextStreamDirection direction = Syncfusion.Windows.Forms.Tools.ImageStreamer.TextStreamDirection.TopToBottom )
        {
            ImageStreamer.SetTextAnimationDirection( direction );
        }

        /// <summary> Sets the color of the internal back. </summary>
        /// <param name = "color" > The color. </param>
        /// <returns> </returns>
        public void SetInternalBackColor( Color color )
        {
            ( (IStreamer)ImageStreamer ).SetInternalBackColor( color );
        }

        // ***************************************************************************************************************************
        // ****************************************************     EVENTS    ********************************************************
        // ***************************************************************************************************************************

        /// <summary> Called when [hover]. </summary>
        /// <param name = "sender" > The sender. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnHover( object sender, EventArgs e )
        {
            ImageStreamer.OnHover( sender, e );
        }
    }
}
