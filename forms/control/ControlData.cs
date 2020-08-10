// <copyright file = "ControlData.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ******************************************************************************************************************************
    // ******************************************************   ASSEMBLIES   ********************************************************
    // ******************************************************************************************************************************

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;

    public class ControlData : UserControl, IDataSource
    {
        // ***************************************************************************************************************************
        // *********************************************   CONSTRUCTORS **************************************************************
        // ***************************************************************************************************************************

        public ControlData()
        {
        }

        // **********************************************************************************************************************
        // *************************************************   PROPERTIES   *****************************************************
        // **********************************************************************************************************************

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public Field Field { get; set; }

        /// <summary>
        /// Gets or sets the numeric.
        /// </summary>
        /// <value>
        /// The numeric.
        /// </value>
        public Numeric Numeric { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public IDictionary<string, object> DataFilter { get; set; }

        // ***************************************************************************************************************************
        // ************************************************  METHODS   ***************************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name="field">The field.</param>
        public void SetField( Field field )
        {
            try
            {
                Field = FormConfig.GetField( field );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="bindingsource">The bindingsource.</param>
        public void SetDataSource<T>( T bindingsource ) where T : IBindingList
        {
            try
            {
                if( bindingsource is BindingSource binder
                    && binder?.DataSource != null )
                {
                    try
                    {
                        BindingSource.DataSource = binder.DataSource;
                    }
                    catch( Exception ex )
                    {
                        Fail( ex );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <param name="bindinglist">The bindingsource.</param>
        /// <param name="dict">The dictionary.</param>
        public void SetDataSource<T, T2>( T bindinglist, T2 dict )
            where T : IBindingList where T2 : IDictionary<string, object>
        {
            try
            {
                if( Verify.IsBindable( bindinglist )
                    && Verify.Map( dict ) )
                {
                    try
                    {
                        var list = bindinglist as BindingSource;
                        var filter = string.Empty;

                        foreach( var kvp in dict )
                        {
                            if( Verify.Input( kvp.Key )
                                && Verify.Ref( kvp.Value ) )
                            {
                                filter += $"{kvp.Key} = {kvp.Value} AND";
                            }
                        }

                        if( filter?.Length > 0
                            && list?.DataSource != null )
                        {
                            BindingSource.DataSource = list?.DataSource;
                            BindingSource.Filter = filter?.TrimEnd( " AND".ToCharArray() );
                        }
                    }
                    catch( Exception ex )
                    {
                        Fail( ex );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="data">The data.</param>
        public void SetDataSource<T>( IEnumerable<T> data ) where T : IEnumerable<DataRow>
        {
            if( Verify.Sequence( data ) )
            {
                try
                {
                    BindingSource.DataSource = data?.ToList();
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="dict">The dictionary.</param>
        public void SetDataSource<T1>( IEnumerable<T1> data, IDictionary<string, object> dict )
            where T1 : IEnumerable<DataRow>
        {
            if( Verify.Sequence( data ) )
            {
                try
                {
                    var filter = string.Empty;

                    foreach( var kvp in dict )
                    {
                        if( Verify.Input( kvp.Key )
                            && kvp.Value != null )
                        {
                            filter += $"{kvp.Key} = {kvp.Value} AND";
                        }
                    }

                    BindingSource.DataSource = data?.ToList();
                    BindingSource.Filter = filter.TrimEnd( " AND".ToCharArray() );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <typeparam name="T3">The type of the 3.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        /// <param name="filter">The dictionary.</param>
        public void SetDataSource<T1, T2, T3>( IEnumerable<T1> data, T2 field, T3 filter )
            where T1 : IEnumerable<DataRow> where T2 : struct
        {
            if( Verify.Sequence( data )
                && Verify.Field( field ) )
            {
                try
                {
                    if( Verify.Input( filter?.ToString() ) )
                    {
                        BindingSource.DataSource = data.ToList();
                        BindingSource.DataMember = field.ToString();
                        BindingSource.Filter = $"{field} = {filter}";
                    }
                    else
                    {
                        BindingSource.DataSource = data.ToList();
                        BindingSource.DataMember = field.ToString();
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        public void SetDataSource<T1>( IEnumerable<T1> data, object field = null )
            where T1 : IEnumerable<DataRow>
        {
            if( Verify.Input( data ) )
            {
                try
                {
                    if( Verify.Input( field?.ToString() ) )
                    {
                        BindingSource.DataSource = data.ToList();
                        BindingSource.DataMember = field?.ToString();
                    }
                    else
                    {
                        BindingSource.DataSource = data.ToList();
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the bindings.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param>The numeric.</param>
        /// <param name = "dict" > </param>
        public void SetDataSource<T1, T2>( IEnumerable<T1> data, T2 dict )
            where T1 : IEnumerable<DataRow> where T2 : IDictionary<string, object>
        {
            if( Verify.Sequence( data )
                && Verify.Map( dict ) )
            {
                try
                {
                    var filter = string.Empty;

                    foreach( var kvp in dict )
                    {
                        if( Verify.Input( kvp.Key )
                            && kvp.Value != null )
                        {
                            filter += $"{kvp.Key} = {kvp.Value} AND";
                        }
                    }

                    BindingSource.DataSource = data?.ToList();
                    BindingSource.Filter = filter?.TrimEnd( " AND".ToCharArray() );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        /// <param name="filter">The filter.</param>
        public void SetDataSource<T1, T2>( IEnumerable<T1> data, T2 field, object filter = null )
            where T1 : IEnumerable<DataRow> where T2 : struct
        {
            if( Verify.Sequence( data )
                && Verify.Field( field ) )
            {
                try
                {
                    if( Verify.Input( filter?.ToString() ) )
                    {
                        BindingSource.DataSource = data.ToList();
                        BindingSource.DataMember = field.ToString();
                        BindingSource.Filter = $"{field} = {filter}";
                    }
                    else
                    {
                        BindingSource.DataSource = data.ToList();
                        BindingSource.DataMember = field.ToString();
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
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