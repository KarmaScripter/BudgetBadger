// <copyright file="{ClassName}.cs" company="Terry D. Eppler">
// Copyright (c) Eppler. All rights reserved.
// </copyright>

using System.Drawing;
using Syncfusion.Windows.Forms.Tools;

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;

    public partial class PulsingTileControl : ControlBase, IPulsingTile
    {
        // ***************************************************************************************************************************
        // ****************************************************  CONSTRUCTORS ********************************************************
        // ***************************************************************************************************************************

        public PulsingTileControl()
        {
            InitializeComponent();
        }

        // ***************************************************************************************************************************
        // ****************************************************     METHODS   ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the border configuration.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <param name="size">The size.</param>
        /// <param name="enablehover">if set to
        /// <c> true </c>
        /// [enablehover].</param>
        public void SetBorderStyle( Color color, int size = 1, bool enablehover = true )
        {
            Tile.SetBorderStyle( color, size, enablehover );
        }

        /// <summary>
        /// Sets the banner configuration.
        /// </summary>
        /// <param name="height">The height.</param>
        /// <param name="bannercolor">The bannercolor.</param>
        /// <param name="textcolor">The textcolor.</param>
        /// <param name="font">The font.</param>
        public void SetBannerStyle( int height, Color bannercolor, Color textcolor,
            Font font )
        {
            Tile.SetBannerStyle( height, bannercolor, textcolor, font );
        }

        /// <summary>
        /// Sets the tool tip.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetToolTip( string text )
        {
            Tile.SetToolTip( text );
        }

        /// <summary>
        /// Sets the title.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetTitleText( string text )
        {
            ( (ITile)Tile ).SetTitleText( text );
        }

        /// <summary>
        /// Sets the title text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="font">The font.</param>
        /// <param name="color">The color.</param>
        public void SetTitleText( string text, Font font, Color color )
        {
            ( (ITile)Tile ).SetTitleText( text, font, color );
        }

        /// <summary>
        /// Sets the body.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="font">The font.</param>
        /// <param name="color">The color.</param>
        public void SetBodyText( string text, Font font, Color color )
        {
            ( (ITile)Tile ).SetBodyText( text, font, color );
        }

        /// <summary>
        /// Sets the body text.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetBodyText( string text )
        {
            ( (ITile)Tile ).SetBodyText( text );
        }

        /// <summary>
        /// Sets the footer text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="font">The font.</param>
        /// <param name="color">The color.</param>
        public void SetFooterText( string text, Font font, Color color )
        {
            ( (ITile)Tile ).SetFooterText( text, font, color );
        }

        /// <summary>
        /// Sets the footer.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetFooterText( string text )
        {
            ( (ITile)Tile ).SetFooterText( text );
        }

        /// <summary>
        /// Sets the image.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="source">The source.</param>
        /// <param name="size">The size.</param>
        public void SetImage( string name, ImageSource source, Size size )
        {
            ( (ITile)Tile ).SetImage( name, source, size );
        }

        /// <summary>
        /// Sets the duration of the pulse.
        /// </summary>
        /// <param name="duration">The duration.</param>
        public void SetPulseDuration( int duration = 2 )
        {
            Tile.SetPulseDuration( duration );
        }

        /// <summary>
        /// Sets the duration of the pulse.
        /// </summary>
        /// <param name="scale">The scale.</param>
        public void SetPulseScale( int scale = 2 )
        {
            Tile.SetPulseScale( scale );
        }

        /// <summary>
        /// Sets the image transition direction.
        /// </summary>
        /// <param name="slide">The slide.</param>
        public void SetImageDirection( TransitionDirection slide = TransitionDirection.RightToLeft )
        {
            Tile.SetImageDirection( slide );
        }

        /// <summary>
        /// Sets the image transition speed.
        /// </summary>
        /// <param name="speed">The speed.</param>
        public void SetImageSpeed( int speed = 3 )
        {
            Tile.SetImageSpeed( speed );
        }

        // ***************************************************************************************************************************
        // ****************************************************     EVENTS    ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Called when [mouse hover].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        public void OnMouseHover( object sender, EventArgs e )
        {
            Tile.OnMouseHover( sender, e );
        }

        /// <summary>
        /// Called when [mouse out].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        public void OnMouseOut( object sender, EventArgs e )
        {
            Tile.OnMouseOut( sender, e );
        }
    }
}
