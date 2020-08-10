// // <copyright file = "BudgetBinding.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    // **************************************************************************************************************************
    // ********************************************      ASSEMBLIES    **********************************************************
    // **************************************************************************************************************************

    using System;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Threading;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class BudgetBinding : BindingData, IBindingSource
    {
        // **************************************************************************************************************************
        // ********************************************   CONSTRUCTORS     **********************************************************
        // **************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the <see cref = "BudgetBinding"/> class.
        /// </summary>
        public BudgetBinding()
        {
        }

        [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
        public BudgetBinding( IEnumerable<DataRow> data )
        {
            DataTable = data?.CopyToDataTable();
            DataSet = DataTable?.DataSet;
            Source = (Source)Enum.Parse( typeof( Source ), DataTable?.TableName );
            DataSource = DataTable;
            Record = (DataRow)Current;
            Index = Position;
            AllowNew = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetBinding"/> class.
        /// </summary>
        /// <param name="datatable">The datatable.</param>
        [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
        public BudgetBinding( DataTable datatable )
        {
            DataTable = datatable;
            DataSet = DataTable?.DataSet;
            DataSource = DataTable;
            Source = (Source)Enum.Parse( typeof( Source ), DataTable?.TableName );
            Record = (DataRow)Current;
            Index = Position;
            AllowNew = false;
        }

        // **************************************************************************************************************************
        // ********************************************      METHODS    *************************************************************
        // **************************************************************************************************************************

        /// <summary>
        /// Sets the data filter.
        /// </summary>
        /// <param name="field">The field.</param>
        /// <param name="filter">The filter.</param>
        public void SetDataFilter( Field field, string filter )
        {
            if( Verify.Field( field )
                && Verify.Input( filter ) )
            {
                try
                {
                    var datafilter = new Dictionary<string, object>
                    {
                        {
                            $"{field}", filter
                        }
                    };

                    DataFilter = datafilter?.Any() == true
                        ? datafilter
                        : default;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the data filter.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        public void SetDataFilter( IDictionary<string, object> dict )
        {
            if( Verify.Map( dict ) )
            {
                try
                {
                    if( DataFilter?.Count > 0 )
                    {
                        DataFilter.Clear();
                    }

                    foreach( var kvp in dict )
                    {
                        if( Verify.Input( kvp.Key )
                            && kvp.Value != null )
                        {
                            DataFilter?.Add( kvp.Key, kvp.Value );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Gets the data set.
        /// </summary>
        /// <returns></returns>
        public DataSet GetDataSet()
        {
            try
            {
                return Verify.Table( DataSet )
                    ? DataSet
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }
    }
}