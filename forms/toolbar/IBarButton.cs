// // <copyright file = "IBarButton.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System.Windows.Forms;

    public interface IBarButton
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns></returns>
        string GetName();

        /// <summary> Sets the image.
        /// </summary>
        /// <param name = "tool" > 
        /// </param>
        void SetImage( Tool tool );

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
