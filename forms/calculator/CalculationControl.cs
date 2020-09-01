// <copyright file="CalculationControl.cs" company="Terry D. Eppler">
// Copyright (c) Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.ControlBase" />
    public partial class CalculationControl : ControlBase
    {
        // ***************************************************************************************************************************
        // ****************************************************  CONSTRUCTORS ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the <see cref="CalculationControl"/> class.
        /// </summary>
        public CalculationControl()
        {
            InitializeComponent();
            Label.Text = Calculator.DoubleValue.ToString( "C" );
            Calculator.ValueCalculated += OnCalculate;
        }

        // ***************************************************************************************************************************
        // ****************************************************     EVENTS    ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Called when [calculate].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnCalculate( object sender, EventArgs e )
        {
            try
            {
                var result = Calculator.DoubleValue;
                Label.Text = result.ToString( "c" );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
    }
}
