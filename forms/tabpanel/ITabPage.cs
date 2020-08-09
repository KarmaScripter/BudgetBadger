// // <copyright file = "ITabPage.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public interface ITabPage
    {
        // ***************************************************************************************************************************
        // ****************************************************    MEMBERS    ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the parent.
        /// </summary>
        /// <param name="tabcontrol">The tabcontrol.</param>
        /// <returns></returns>
        Control Add( TabControlAdv tabcontrol );

        /// <summary>
        /// Sets the color of the back.
        /// </summary>
        /// <param name="color">The color.</param>
        void SetBackColor( Color color );

        /// <summary>
        /// Sets the color of the fore.
        /// </summary>
        /// <param name="color">The color.</param>
        void SetForeColor( Color color );

        /// <summary>
        /// Sets the font.
        /// </summary>
        /// <param name="font">The font.</param>
        void SetFont( Font font );

        /// <summary>
        /// Sets the border style.
        /// </summary>
        /// <param name="border">if set to
        /// <c> true </c>
        /// [border].</param>
        void SetBorderStyle( bool border );

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="text">The text.</param>
        void SetText( string text );

        /// <summary>
        /// Sets the data source.
        /// </summary>
        /// <param name="bindingsource">The bindingsource.</param>
        void SetBindingSource( BindingSource bindingsource );

        /// <summary>
        /// Sets the hover information.
        /// </summary>
        /// <param name="text">The text.</param>
        void SetHoverText( string text );

        /// <summary>
        /// Adds the control item.
        /// </summary>
        /// <param name="item">The item.</param>
        void AddControl( Control item );

        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name="field">The field.</param>
        void SetField( Field field );

        /// <summary>
        /// Sets the anchor.
        /// </summary>
        /// <param name="anchor">The anchor.</param>
        void SetAnchor( AnchorStyles anchor = AnchorStyles.Left & AnchorStyles.Top );

        /// <summary>
        /// Sets the dock style.
        /// </summary>
        /// <param name="doc">The document.</param>
        void SetDockStyle( DockStyle doc = DockStyle.None );

        /// <summary>
        /// Called when [right click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        void OnRightClick( object sender, MouseEventArgs e );

        /// <summary>
        /// Called when [current changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        void OnCurrentChanged( object sender, EventArgs e );

        /// <summary>
        /// Called when [hover].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        void OnHover( object sender, EventArgs e );
    }
}