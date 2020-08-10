// <copyright file = "DataMetric.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ******************************************************************************************************************************
    // ******************************************************   ASSEMBLIES   ********************************************************
    // ******************************************************************************************************************************

    using System;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Threading;
    using LinqStatistics;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public class DataMetric : MetricBase, IDataMetric
    {
        // ***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the <see cref = "DataMetric"/> class.
        /// </summary>
        public DataMetric()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "DataMetric"/> class.
        /// </summary>
        /// <param name = "data" >
        /// The data.
        /// </param>
        /// <param name = "numeric" >
        /// The numeric.
        /// </param>
        public DataMetric( IEnumerable<DataRow> data, Numeric numeric = Numeric.Amount )
        {
            Data = data;
            Field = Field.NS;
            Numeric = numeric;
            Count = Data.Count();
            Total = CalculateTotals( Data, Numeric );
            Average = CalculateAverage( Data, Numeric );
            Variance = CalculateVariance( Data, Numeric );
            Deviation = CalculateDeviation( Data, Numeric );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "DataMetric"/> class.
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
        public DataMetric( IEnumerable<DataRow> data, Field field, Numeric numeric = Numeric.Amount )
        {
            Field = field;
            Numeric = numeric;
            Data = data;
            Count = Data.Count();
            Total = CalculateTotals( Data, Numeric );
            Average = CalculateAverage( Data, Numeric );
            Variance = CalculateVariance( Data, Numeric );
            Deviation = CalculateDeviation( Data, Numeric );
            Statistics = CalculateStatistics( Data, Field, Numeric );
        }

        // ***************************************************************************************************************************
        // ************************************************  PROPERTIES **************************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Gets the variance.
        /// </summary>
        /// <value>
        /// The variance.
        /// </value>
        private double Variance { get; }

        /// <summary>
        /// Gets the deviation.
        /// </summary>
        /// <value>
        /// The deviation.
        /// </value>
        private double Deviation { get; }

        // ***************************************************************************************************************************
        // ************************************************  METHODS   ***************************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <returns>
        /// </returns>
        public Source GetSource()
        {
            try
            {
                var source = Data.Select( r => r ).FirstOrDefault();
                var tablename = source?.Table?.TableName;

                return !string.IsNullOrEmpty( tablename )
                    ? source != null
                        ? (Source)Enum.Parse( typeof( Source ), tablename )
                        : Source.NS
                    : Source.NS;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

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
        public double CalculateDeviation( IEnumerable<DataRow> data, Numeric numeric )
        {
            if( data.Any()
                && data.HasNumeric()
                && GetCount( data, numeric ) > 30 )
            {
                try
                {
                    var query = data.Where( p => p.Field<double>( $"{numeric}" ) != 0d )
                        .StandardDeviation( p => p.Field<double>( $"{numeric}" ) );

                    return query > 0.0d
                        ? double.Parse( query.ToString( "N" ) )
                        : 0.0d;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return 0.0d;
                }
            }

            return default;
        }

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
        public double CalculateDeviations( IEnumerable<DataRow> data, Field field,
            Numeric numeric = Numeric.Amount )
        {
            if( data.Any()
                && Enum.IsDefined( typeof( Field ), field )
                && Enum.IsDefined( typeof( Numeric ), numeric ) )
            {
                if( data.Count() < 30 )
                {
                    return 0.0d;
                }

                if( data.Count() > 30 )
                {
                    try
                    {
                        var query = data.Where( p => p.Field<double>( $"{numeric}" ) != 0d )
                            .StandardDeviation( p => p.Field<double>( $"{numeric}" ) );

                        return query > 0.0d
                            ? double.Parse( query.ToString( "N" ) )
                            : 0.0d;
                    }
                    catch( Exception ex )
                    {
                        Fail( ex );
                        return 0.0d;
                    }
                }
            }

            return default;
        }

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
        public double CalculateVariance( IEnumerable<DataRow> data, Numeric numeric )
        {
            if( data.Any()
                && data.HasNumeric()
                && GetCount( data, numeric ) > 30 )
            {
                var table = data.CopyToDataTable();

                try
                {
                    var query = table.AsEnumerable()
                        .Where( p => p.Field<double>( $"{numeric}" ) != 0d )
                        .Variance( p => p.Field<double>( $"{numeric}" ) );

                    return query > 0.0d
                        ? double.Parse( query.ToString( "N" ) )
                        : 0.0d;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return 0.0d;
                }
            }

            return default;
        }

        /// <summary>
        /// Calculates the statistics.
        /// </summary>
        /// <returns>
        /// </returns>
        public IDictionary<string, IEnumerable<double>> CalculateStatistics()
        {
            try
            {
                return Statistics;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

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
        public double CalculateVariances( IEnumerable<DataRow> data, Field field,
            Numeric numeric = Numeric.Amount )
        {
            if( data.Any()
                && Enum.IsDefined( typeof( Field ), field )
                && Enum.IsDefined( typeof( Numeric ), numeric ) )
            {
                var table = data.CopyToDataTable();

                try
                {
                    var query = table.AsEnumerable()
                        .Where( p => p.Field<double>( $"{numeric}" ) != 0d )
                        .Variance( p => p.Field<double>( $"{numeric}" ) );

                    return query > 0.0d
                        ? double.Parse( query.ToString( "N" ) )
                        : 0.0d;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return 0.0d;
                }
            }

            return default;
        }

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
        [ SuppressMessage( "ReSharper", "BadListLineBreaks" ) ]
        public IEnumerable<double> CalculateStatistics( IEnumerable<DataRow> data, Numeric numeric )
        {
            if( data.Any() )
            {
                try
                {
                    var metrics = new[]
                    {
                        GetCount( data, numeric ),
                        CalculateTotals( data, numeric ),
                        CalculateAverage( data, numeric ),
                        CalculateTotals( data, numeric ) / GetCount( data, numeric ),
                        CalculateDeviation( data, numeric ),
                        CalculateVariance( data, numeric )
                    };

                    return metrics.Any()
                        ? metrics
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
        public IDictionary<string, IEnumerable<double>> CalculateStatistics( IEnumerable<DataRow> data,
            Field field, Numeric numeric = Numeric.Amount )
        {
            if( data?.Any() == true
                && Enum.IsDefined( typeof( Field ), field )
                && Enum.IsDefined( typeof( Numeric ), numeric ) )
            {
                try
                {
                    var info = new Dictionary<string, IEnumerable<double>>();
                    var filters = GetCodes( data, field );

                    if( filters?.Any() == true )
                    {
                        foreach( var filter in filters )
                        {
                            var query = data.Where( p => p.Field<string>( $"{field}" ).Equals( filter ) )
                                .Select( p => p );

                            if( CalculateTotals( query, numeric ) > 0 )
                            {
                                info.Add( filter, CalculateStatistics( query, numeric ).ToArray() );
                            }
                        }

                        return info?.Count > 0.0
                            ? info
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
    }
}