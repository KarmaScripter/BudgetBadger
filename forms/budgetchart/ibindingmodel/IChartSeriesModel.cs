// // <copyright file = "IChartSeriesModel.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

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
    public interface IChartSeriesModel
    {
        // **************************************************************************************************************************
        // ********************************************      PROPERTIES    **********************************************************
        // **************************************************************************************************************************

        /// <summary> Gets or sets the count. </summary>
        /// <value> The count. </value>
        int Count { get; set; }

        // **************************************************************************************************************************
        // ********************************************      METHODS    *************************************************************
        // **************************************************************************************************************************

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

        // **************************************************************************************************************************
        // ********************************************      EVENTS     *************************************************************
        // **************************************************************************************************************************

        /// <summary> Occurs when [changed]. </summary>
        event ListChangedEventHandler Changed;
    }
}