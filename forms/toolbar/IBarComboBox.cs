// // <copyright file = "IBarComboBox.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

using System;
using System.Drawing;
using System.Windows.Forms;

namespace BudgetExecution
{
    public interface IBarComboBox
    {
        /// <summary> Sets the data source. </summary>
        /// <param name = "bindingsource" > The bindingsource. </param>
        void SetDataSource( BindingSource bindingsource );

        /// <summary> Called when [mouse over]. </summary>
        /// <param name = "sender" > The sender. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        void OnMouseOver( object sender, EventArgs e );

        /// <summary> Called when [item selected]. </summary>
        /// <param name = "sender" > The sender. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        void OnItemSelected( object sender, EventArgs e );

        /// <summary>
        /// Sets the font.
        /// </summary>
        /// <param name="font">The font.</param>
        void SetFont( Font font );

        /// <summary>
        /// Sets the color of the fore.
        /// </summary>
        /// <param name="color">The color.</param>
        void SetForeColor( Color color );

        /// <summary>
        /// Sets the color of the back.
        /// </summary>
        /// <param name="color">The color.</param>
        void SetBackColor( Color color );

        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name="field">The field.</param>
        void SetField( Field field );

        /// <summary>
        /// Sets the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        void SetTag( object tag );

        /// <summary>
        /// Sets the hover text.
        /// </summary>
        /// <param name="item">The item.</param>
        void SetHoverText( ToolStripItem item );

        /// <summary>
        /// Sets the hover text.
        /// </summary>
        /// <param name="text">The text.</param>
        void SetHoverText( string text );
    }
}
