// // <copyright file = "ISpreadsheet.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System.IO;
    using System.Threading;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    public interface ISpreadsheet
    {
        // ***************************************************************************************************************************
        // ****************************************************     METHODS   ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Opens the file.
        /// </summary>
        /// <param name="file">The file.</param>
        void OpenFile( Stream file );

        /// <summary>
        /// Adds the sheet.
        /// </summary>
        void AddSheet();

        /// <summary>
        /// Adds the sheet.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="index">The index.</param>
        void AddSheet( string name, int index );

        /// <summary>
        /// Removes the sheet.
        /// </summary>
        /// <param name="name">The name.</param>
        void RemoveSheet( string name );

        /// <summary>
        /// Hides the sheet.
        /// </summary>
        /// <param name="name">The name.</param>
        void HideSheet( string name );

        /// <summary>
        /// Unhides the sheet.
        /// </summary>
        /// <param name="name">The name.</param>
        void UnhideSheet( string name );

        /// <summary>
        /// Opens the specified file.
        /// </summary>
        /// <param name="file">The file.</param>
        void Open( Stream file );

        /// <summary>
        /// Opens the specified file.
        /// </summary>
        /// <param name="file">The file.</param>
        void Open( string file );

        /// <summary>
        /// Saves as.
        /// </summary>
        /// <param name="filename">The filename.</param>
        void SaveAs( string filename );

        /// <summary>
        /// Saves as.
        /// </summary>
        /// <param name="stream">The stream.</param>
        void SaveAs( Stream stream );

        /// <summary>
        /// Saves this instance.
        /// </summary>
        void Save();

        /// <summary>
        /// Sets the zoom factor.
        /// </summary>
        /// <param name="sheetname">The sheetname.</param>
        /// <param name="zoomfactor">The zoomfactor.</param>
        void SetZoomFactor( string sheetname, int zoomfactor );

        /// <summary>
        /// Sets the grid lines visibility.
        /// </summary>
        /// <param name="isvisible">if set to
        /// <c> true </c>
        /// [isvisible].</param>
        void SetGridLinesVisibility( bool isvisible );

        /// <summary>
        /// Sets the active sheet.
        /// </summary>
        /// <param name="sheetname">The sheetname.</param>
        /// <returns></returns>
        bool SetActiveSheet( string sheetname );

        /// <summary>
        /// Displays the message box.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="button">The button.</param>
        /// <param name="icon">The icon.</param>
        /// <returns></returns>
        bool DisplayMessageBox( string text, string caption, MessageBoxButtons button,
            MessageBoxIcon icon );
    }
}