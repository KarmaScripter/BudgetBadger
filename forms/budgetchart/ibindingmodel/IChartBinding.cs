// <copyright file="IChartBinding.cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // **************************************************************************************************************************
    // ********************************************      ASSEMBLIES    **********************************************************
    // **************************************************************************************************************************

    using System;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public interface IChartBinding : IBindingSource
    {
        // ***************************************************************************************************************************
        // ****************************************************               ********************************************************
        // ***************************************************************************************************************************

        /// <summary> Gets the empty. </summary>
        /// <param name = "xindex" > The xindex. </param>
        /// <returns> </returns>
        bool GetEmpty( int xindex );

        /// <summary> Gets the x. </summary>
        /// <param name = "xindex" > The xindex. </param>
        /// <returns> </returns>
        double GetX( int xindex );

        /// <summary> Gets the y. </summary>
        /// <param name = "xindex" > The xindex. </param>
        /// <returns> </returns>
        double GetY( int xindex );

        /// <summary> Occurs when [changed]. </summary>
        event ListChangedEventHandler Changed;

        /// <summary> Gets the count. </summary>
        /// <returns> </returns>
        int GetCount();

        /// <summary> Gets the series configuration. </summary>
        /// <returns> </returns>
        ISeriesConfig GetSeriesConfig();

        /// <summary> Gets the data metric. </summary>
        /// <returns> </returns>
        IDataMetric GetDataMetric();
    }
}