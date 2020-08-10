// // <copyright file = "ChartDataGrid.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ControlBase" />
    public partial class ChartDataGrid : ControlBase
    {
        // ***************************************************************************************************************************
        // ****************************************************  CONSTRUCTORS ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartDataGrid"/> class.
        /// </summary>
        public ChartDataGrid()
        {
            InitializeComponent();
            MaximumSize = SizeConfig.FormMaximum;
        }
    }
}