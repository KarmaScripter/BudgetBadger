// // <copyright file = "MetricBase.cs" company = "Terry D. Eppler">
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
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public abstract class MetricBase : IMetric
    {
        // ***************************************************************************************************************************
        // ************************************************  PROPERTIES **************************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        private protected Field Field { get; set; }

        /// <summary>
        /// Gets or sets the numeric.
        /// </summary>
        /// <value>
        /// The numeric.
        /// </value>
        private protected Numeric Numeric { get; set; }

        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        private protected int Count { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        private protected IEnumerable<DataRow> Data { get; set; }

        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        /// <value>
        /// The total.
        /// </value>
        private protected double Total { get; set; }

        /// <summary>
        /// Gets or sets the average.
        /// </summary>
        /// <value>
        /// The average.
        /// </value>
        private protected double Average { get; set; }

        /// <summary>
        /// Gets or sets the statistics.
        /// </summary>
        /// <value>
        /// The statistics.
        /// </value>
        private protected IDictionary<string, IEnumerable<double>> Statistics { get; set; }

        // ***************************************************************************************************************************
        // ************************************************  METHODS   ***************************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Gets the field.
        /// </summary>
        /// <returns>
        /// </returns>
        public Field GetField()
        {
            try
            {
                return Field;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the numeric.
        /// </summary>
        /// <returns>
        /// </returns>
        public Numeric GetNumeric()
        {
            try
            {
                return Numeric;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns>
        /// </returns>
        public IEnumerable<DataRow> GetData()
        {
            try
            {
                return Data?.Any() == true
                    ? Data
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <param name = "field" >
        /// The field.
        /// </param>
        /// <param name = "filter" >
        /// </param>
        /// <returns>
        /// </returns>
        public IEnumerable<DataRow> FilterData( Field field, string filter )
        {
            if( GetData()?.Any() == true
                && Enum.IsDefined( typeof( Field ), field )
                && !string.IsNullOrEmpty( filter ) )
            {
                try
                {
                    var query = GetData()
                        ?.Where( p => p.Field<string>( $"{field}" ).Equals( filter ) )
                        ?.Select( p => p );

                    return query?.Any() == true
                        ? query.ToArray()
                        : default;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        /// <summary>
        /// Gets the codes.
        /// </summary>
        /// <param name = "data" >
        /// The data.
        /// </param>
        /// <param name = "field" >
        /// The field.
        /// </param>
        /// <returns>
        /// </returns>
        public IEnumerable<string> GetCodes( IEnumerable<DataRow> data, Field field )
        {
            if( data.Any()
                && !string.IsNullOrEmpty( $"{field}" ) )
            {
                try
                {
                    var query = data?.Select( p => p.Field<string>( $"{field}" ) )?.Distinct()?.ToArray();

                    return query?.Length > 0
                        ? query
                        : default;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <param name = "data" >
        /// The data.
        /// </param>
        /// <param name = "numeric" >
        /// The numeric.
        /// </param>
        /// <returns>
        /// </returns>
        public int GetCount( IEnumerable<DataRow> data, Numeric numeric = Numeric.Amount )
        {
            if( data.Any() )
            {
                try
                {
                    var query = data.Where( p => p.Field<double>( $"{numeric}" ) != 0.0D ).Select( p => p );

                    return query?.Any() == true
                        ? query.Count()
                        : default;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return 0;
                }
            }

            return 0;
        }

        /// <summary>
        /// Calculates the totals.
        /// </summary>
        /// <param name = "data" >
        /// The data.
        /// </param>
        /// <param name = "numeric" >
        /// The numeric.
        /// </param>
        /// <returns>
        /// </returns>
        public double CalculateTotals( IEnumerable<DataRow> data, Numeric numeric = Numeric.Amount )
        {
            if( data.Any() )
            {
                try
                {
                    var query = data.Select( p => p.Field<double>( $"{numeric}" ) );

                    return query?.Any() == true && query.Sum() > 0
                        ? query.Sum()
                        : 0.0d;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return default;
        }

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
        public IDictionary<string, double> CalculateTotals( IEnumerable<DataRow> data, Field field,
            Numeric numeric = Numeric.Amount )
        {
            if( data.Any()
                && Enum.IsDefined( typeof( Field ), field )
                && Enum.IsDefined( typeof( Numeric ), numeric ) )
            {
                try
                {
                    var dict = new Dictionary<string, double>();
                    var filters = GetCodes( data, field );

                    if( filters.Any() )
                    {
                        foreach( var filter in filters )
                        {
                            var query = data.Filter( field.ToString(), filter )
                                .Sum( p => p.Field<double>( $"{numeric}" ) );

                            if( query > 0.0d )
                            {
                                dict.Add( filter, double.Parse( query.ToString( "N" ) ) );
                            }
                        }

                        return dict?.Any() == true
                            ? dict
                            : default;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        /// <summary>
        /// Calculates the average.
        /// </summary>
        /// <param name = "data" >
        /// The data.
        /// </param>
        /// <param name = "numeric" >
        /// The numeric.
        /// </param>
        /// <returns>
        /// </returns>
        private protected double CalculateAverage( IEnumerable<DataRow> data,
            Numeric numeric = Numeric.Amount )
        {
            if( data.Any()
                && Enum.IsDefined( typeof( Numeric ), numeric ) )
            {
                try
                {
                    var query = data.Where( p => p.Field<double>( $"{numeric}" ) != 0.0 )
                        .Select( p => p.Field<double>( $"{numeric}" ) )
                        .Average();

                    return query > 0d
                        ? double.Parse( query.ToString( "N" ) )
                        : 0.0d;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return 0.0d;
                }
            }

            return 0.0d;
        }

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
        public IDictionary<string, double> CalculateAverages( IEnumerable<DataRow> data, Field field,
            Numeric numeric = Numeric.Amount )
        {
            if( data.Any()
                && Enum.IsDefined( typeof( Field ), field )
                && Enum.IsDefined( typeof( Numeric ), numeric ) )
            {
                try
                {
                    var dict = new Dictionary<string, double>();
                    var filters = GetCodes( data, field );

                    if( filters.Any() )
                    {
                        foreach( var filter in filters )
                        {
                            var query = data.Filter( field.ToString(), filter );

                            if( query.Any() )
                            {
                                var average = CalculateAverage( query, numeric );

                                if( average > 0.0d )
                                {
                                    dict.Add( filter, average );
                                }
                            }
                        }

                        return dict.Any()
                            ? dict
                            : default;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var error = new Error( ex );
            error?.SetText();
            error?.ShowDialog();
        }
    }
}