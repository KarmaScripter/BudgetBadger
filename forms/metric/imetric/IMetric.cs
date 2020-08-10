// <copyright file = "IMetric.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ******************************************************************************************************************************
    // ******************************************************   ASSEMBLIES   ********************************************************
    // ******************************************************************************************************************************

    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    public interface IMetric
    {
        // ***************************************************************************************************************************
        // ************************************************  METHODS   ***************************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns>
        /// </returns>
        IEnumerable<DataRow> GetData();

        /// <summary>
        /// Calculates the totals.
        /// </summary>
        /// <param name = "data" >
        /// The data.
        /// </param>
        /// <param name = "field" >
        /// The field.
        /// </param>
        /// <param name = "numeric" >
        /// The numeric.
        /// </param>
        /// <returns>
        /// </returns>
        IDictionary<string, double> CalculateTotals( IEnumerable<DataRow> data, Field field,
            Numeric numeric = Numeric.Amount );

        /// <summary>
        /// Calculates the averages.
        /// </summary>
        /// <param name = "data" >
        /// The data.
        /// </param>
        /// <param name = "field" >
        /// The field.
        /// </param>
        /// <param name = "numeric" >
        /// The numeric.
        /// </param>
        /// <returns>
        /// </returns>
        IDictionary<string, double> CalculateAverages( IEnumerable<DataRow> data, Field field,
            Numeric numeric = Numeric.Amount );
    }
}
