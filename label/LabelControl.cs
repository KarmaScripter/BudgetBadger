// <copyright file="{ClassName}.cs" company="Terry D. Eppler">
// Copyright (c) Eppler. All rights reserved.
// </copyright>

using System.Drawing;

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;

    public partial class LabelControl : ControlBase, ILabel
    {
        // ***************************************************************************************************************************
        // ****************************************************  CONSTRUCTORS ********************************************************
        // ***************************************************************************************************************************

        public LabelControl()
        {
            InitializeComponent();
        }

        // ***************************************************************************************************************************
        // ****************************************************     METHODS   ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the color of the border.
        /// </summary>
        /// <param name="color">The color.</param>
        public void SetOutlineColor( Color color )
        {
            Label.SetOutlineColor( color );
        }

        /// <summary>
        /// Sets the text alignment.
        /// </summary>
        /// <param name="alignment">The alignment.</param>
        public void SetTextAlignment( StringAlignment alignment )
        {
            Label.SetTextAlignment( alignment );
        }

        /// <summary>
        /// Sets the line alignment.
        /// </summary>
        /// <param name="alignment">The alignment.</param>
        public void SetLineAlignment( StringAlignment alignment )
        {
            Label.SetLineAlignment( alignment );
        }

        /// <summary>
        /// Sets the numeric.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        public void SetNumeric( Numeric numeric )
        {
            Label.SetNumeric( numeric );
        }
    }
}
