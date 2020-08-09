// <copyright file="AlignFormat.cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // **************************************************************************************************************************
    // ********************************************      ASSEMBLIES    **********************************************************
    // **************************************************************************************************************************

    using System;
    using System.Drawing;
    using System.Threading;
    using DocumentFormat.OpenXml.Spreadsheet;
    using OfficeOpenXml.Style;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    public class AlignFormat
    {
        // ***************************************************************************************************************************
        // ****************************************************  CONSTRUCTORS ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the <see cref = "AlignFormat"/> class.
        /// </summary>
        public AlignFormat()
        {
        }

        // ***************************************************************************************************************************
        // ****************************************************  PROPERTIES   ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        public TextAlignment Text { get; set; }

        /// <summary>
        /// Gets or sets the string.
        /// </summary>
        /// <value>
        /// The string.
        /// </value>
        public StringAlignment Data { get; set; }

        /// <summary>
        /// Gets or sets the cell aligment.
        /// </summary>
        /// <value>
        /// The cell aligment.
        /// </value>
        public TextVerticalAlignmentValues CellContent { get; set; }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
        public ContentAlignment Content { get; set; }

        /// <summary>
        /// Gets or sets the excel vertical.
        /// </summary>
        /// <value>
        /// The excel vertical.
        /// </value>
        public ExcelVerticalAlignment ExcelVertical { get; set; }

        /// <summary>
        /// Gets or sets the excel horizontal.
        /// </summary>
        /// <value>
        /// The excel horizontal.
        /// </value>
        public ExcelHorizontalAlignment ExcelHorizontal { get; set; }
    }
}