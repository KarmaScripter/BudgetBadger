// <copyright file = "IPictureBox.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public interface IPictureBox
    {
        // ***************************************************************************************************************************
        // ****************************************************    MEMBERS    ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the hover information.
        /// </summary>
        /// <param name="text">The text.</param>
        void SetHoverText( string text );

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
        /// Sets the image size mode.
        /// </summary>
        /// <param name="mode">The mode.</param>
        void SetImageSizeMode( PictureBoxSizeMode mode = PictureBoxSizeMode.Normal );

        /// <summary>
        /// Called when [mouse hover].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        void OnMouseHover( object sender, EventArgs e );
    }
}