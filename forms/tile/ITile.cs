// <copyright file = "ITile.cs" company = "Terry D. Eppler">
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

    public interface ITile
    {
        // ***************************************************************************************************************************
        // ****************************************************    MEMBERS    ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the border configuration.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <param name="size">The size.</param>
        /// <param name="enablehover">if set to
        /// <c> true </c>
        /// [enablehover].</param>
        void SetBorderStyle( Color color, int size = 1, bool enablehover = true );

        /// <summary>
        /// Sets the banner configuration.
        /// </summary>
        /// <param name="height">The height.</param>
        /// <param name="bannercolor">The bannercolor.</param>
        /// <param name="textcolor">The textcolor.</param>
        /// <param name="font">The font.</param>
        void SetBannerStyle( int height, Color bannercolor, Color textcolor,
            Font font );

        /// <summary>
        /// Sets the hover text.
        /// </summary>
        /// <param name="text">The text.</param>
        void SetHoverText( string text );

        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name="field">The field.</param>
        void SetField( Field field );

        /// <summary>
        /// Sets the tool tip.
        /// </summary>
        /// <param name="text">The text.</param>
        void SetToolTip( string text );

        /// <summary>
        /// Called when [mouse hover].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        void OnMouseHover( object sender, EventArgs e );

        /// <summary>
        /// Called when [mouse out].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        void OnMouseOut( object sender, EventArgs e );

        /// <summary>
        /// Sets the size.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        void SetSize( int width, int height );

        /// <summary>
        /// Sets the location.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        void SetLocation( int x, int y );

        /// <summary>
        /// Sets the color of the back.
        /// </summary>
        /// <param name="color">The color.</param>
        void SetBackColor( Color color );

        /// <summary>
        /// Sets the title.
        /// </summary>
        /// <param name="text">The text.</param>
        void SetTitleText( string text );

        /// <summary>
        /// Sets the title text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="font">The font.</param>
        /// <param name="color">The color.</param>
        void SetTitleText( string text, Font font, Color color );

        /// <summary>
        /// Sets the body.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="font">The font.</param>
        /// <param name="color">The color.</param>
        void SetBodyText( string text, Font font, Color color );

        /// <summary>
        /// Sets the body text.
        /// </summary>
        /// <param name="text">The text.</param>
        void SetBodyText( string text );

        /// <summary>
        /// Sets the footer text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="font">The font.</param>
        /// <param name="color">The color.</param>
        void SetFooterText( string text, Font font, Color color );

        /// <summary>
        /// Sets the footer.
        /// </summary>
        /// <param name="text">The text.</param>
        void SetFooterText( string text );

        /// <summary>
        /// Sets the image.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="source">The source.</param>
        /// <param name="size">The size.</param>
        void SetImage( string name, ImageSource source, Size size );
    }
}
