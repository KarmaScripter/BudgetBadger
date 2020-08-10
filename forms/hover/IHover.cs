// <copyright file = "IHover.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Threading;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    public interface IHover
    {
        // ***************************************************************************************************************************
        // ****************************************************    MEMBERS    ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the fading.
        /// </summary>
        /// <param name="fade">The fade.</param>
        void SetFading( SuperToolTip.FadingType fade = SuperToolTip.FadingType.Blend );

        /// <summary>
        /// Sets the duration.
        /// </summary>
        /// <param name="seconds">The seconds.</param>
        void SetDuration( int seconds = 5 );

        /// <summary>
        /// Sets the tool tip style.
        /// </summary>
        /// <param name="style">The style.</param>
        void SetToolTipStyle( SuperToolTip.SuperToolTipStyle style = SuperToolTip.SuperToolTipStyle.Office2013Style );

        /// <summary>
        /// Gets the header information.
        /// </summary>
        /// <returns></returns>
        ToolTipInfo GetHeaderInfo();

        /// <summary>
        /// Adds the header item.
        /// </summary>
        /// <param name="item">The item.</param>
        void AddHeaderItem( string item );

        /// <summary>
        /// Gets the body information.
        /// </summary>
        /// <returns></returns>
        ToolTipInfo GetBodyInfo();

        /// <summary>
        /// Adds the body item.
        /// </summary>
        /// <param name="item">The item.</param>
        void AddBodyItem( string item );

        /// <summary>
        /// Gets the footer information.
        /// </summary>
        /// <returns></returns>
        ToolTipInfo GetFooterInfo();

        /// <summary>
        /// Adds the footer item.
        /// </summary>
        /// <param name="item">The item.</param>
        void AddFooterItem( string item );

        /// <summary>
        /// Sets the tool tip information.
        /// </summary>
        /// <param name="control">The control.</param>
        void SetText( Component control );

        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name="field">The field.</param>
        void SetField( Field field );

        /// <summary>
        /// Sets the maximum width.
        /// </summary>
        /// <param name="width">The width.</param>
        void SetMaxWidth( int width = 700 );

        /// <summary>
        /// Sets the initial delay.
        /// </summary>
        /// <param name="delay">The delay.</param>
        void SetInitialDelay( int delay = 750 );

        /// <summary>
        /// Uses the gradient background.
        /// </summary>
        /// <param name="gradient">if set to
        /// <c> true </c>
        /// [gradient].</param>
        void UseGradientBackground( bool gradient = true );

        /// <summary>
        /// Sets the color of the metro.
        /// </summary>
        /// <param name="color">The color.</param>
        void SetMetroColor( Color color );

        /// <summary>
        /// Shows the specified information.
        /// </summary>
        /// <param name="info">The information.</param>
        /// <param name="position">The position.</param>
        void Show( ToolTipInfo info, Point position );

        /// <summary>
        /// Shows the specified information.
        /// </summary>
        /// <param name="info">The information.</param>
        /// <param name="position">The position.</param>
        /// <param name="displaytime">The displaytime.</param>
        void Show( ToolTipInfo info, Point position, int displaytime );

        /// <summary>
        /// Hides this instance.
        /// </summary>
        void Hide();

        /// <summary>
        /// Hides the specified component.
        /// </summary>
        /// <param name="component">The component.</param>
        void Hide( Component component );
    }
}
