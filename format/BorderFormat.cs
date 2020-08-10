// <copyright file = "BorderFormat.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // **************************************************************************************************************************
    // ********************************************      ASSEMBLIES    **********************************************************
    // **************************************************************************************************************************

    using System;
    using System.Threading;
    using System.Windows.Forms;
    using OfficeOpenXml.Style;

    /// <summary>
    /// 
    /// </summary>
    public class BorderFormat
    {
        // **************************************************************************************************************************
        // ********************************************   CONSTRUCTORS     **********************************************************
        // **************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the <see cref = "BorderFormat"/> class.
        /// </summary>
        public BorderFormat()
        {
        }

        // ***************************************************************************************************************************
        // ******************************************************   PROPERTIES   *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Gets or sets the excel top border.
        /// </summary>
        /// <value>
        /// The excel top border.
        /// </value>
        public ExcelBorderStyle ExcelTopBorder { get; set; }

        /// <summary>
        /// Gets or sets the excel bottom border.
        /// </summary>
        /// <value>
        /// The excel bottom border.
        /// </value>
        public ExcelBorderStyle ExcelBottomBorder { get; set; }

        /// <summary>
        /// Gets or sets the excel left border.
        /// </summary>
        /// <value>
        /// The excel left border.
        /// </value>
        public ExcelBorderStyle ExcelLeftBorder { get; set; }

        /// <summary>
        /// Gets or sets the excel right border.
        /// </summary>
        /// <value>
        /// The excel right border.
        /// </value>
        public ExcelBorderStyle ExcelRightBorder { get; set; }

        /// <summary>
        /// Gets or sets the border3 d side.
        /// </summary>
        /// <value>
        /// The border3 d side.
        /// </value>
        public Border3DSide Border3DSide { get; set; }

        /// <summary>
        /// Gets or sets the border3 d style.
        /// </summary>
        /// <value>
        /// The border3 d style.
        /// </value>
        public Border3DStyle Border3DStyle { get; set; }

        /// <summary>
        /// Gets or sets the border style.
        /// </summary>
        /// <value>
        /// The border style.
        /// </value>
        public BorderStyle BorderStyle { get; set; }
    }
}