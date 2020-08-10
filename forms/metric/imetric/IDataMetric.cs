// // <copyright file = "IDataMetric.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    // ******************************************************************************************************************************
    // ******************************************************   ASSEMBLIES   ********************************************************
    // ******************************************************************************************************************************

    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Threading;

    public interface IDataMetric : IMetric
    {
        // ***************************************************************************************************************************
        // ************************************************  METHODS   ***************************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Calculates the deviation.
        /// </summary>
        /// <param name = "data" >
        /// The data.
        /// </param>
        /// <param name = "numeric" >
        /// The numeric.
        /// </param>
        /// <returns>
        /// </returns>
        double CalculateDeviation( IEnumerable<DataRow> data, Numeric numeric );

        /// <summary>
        /// Calculates the standard deviations.
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
        double CalculateDeviations( IEnumerable<DataRow> data, Field field,
            Numeric numeric = Numeric.Amount );

        /// <summary>
        /// Calculates the variance.
        /// </summary>
        /// <param name = "data" >
        /// The data.
        /// </param>
        /// <param name = "numeric" >
        /// The numeric.
        /// </param>
        /// <returns>
        /// </returns>
        double CalculateVariance( IEnumerable<DataRow> data, Numeric numeric );

        /// <summary>
        /// Calculates the statistics.
        /// </summary>
        /// <returns>
        /// </returns>
        IDictionary<string, IEnumerable<double>> CalculateStatistics();

        /// <summary>
        /// Calculates the variances.
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
        double CalculateVariances( IEnumerable<DataRow> data, Field field, Numeric numeric = Numeric.Amount );

        /// <summary>
        /// Calculates the statistics.
        /// </summary>
        /// <param name = "data" >
        /// The data.
        /// </param>
        /// <param name = "numeric" >
        /// The numeric.
        /// </param>
        /// <returns>
        /// </returns>
        IEnumerable<double> CalculateStatistics( IEnumerable<DataRow> data, Numeric numeric );

        /// <summary>
        /// Calculates the statistics.
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
        IDictionary<string, IEnumerable<double>> CalculateStatistics( IEnumerable<DataRow> data, Field field,
            Numeric numeric = Numeric.Amount );
    }
}