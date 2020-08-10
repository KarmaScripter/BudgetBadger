// <copyright file = "ToolSeparator.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ******************************************************************************************************************************
    // ******************************************************   ASSEMBLIES   ********************************************************
    // ******************************************************************************************************************************

    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;
    using System.Windows.Forms;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    public class ToolSeparator : ToolStripSeparator
    {
        // ***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "BarLabel"/>
        /// class.
        /// </summary>
        public ToolSeparator()
        {
            Margin = new Padding( 3, 0, 3, 0 );
            Padding = new Padding( 0 );
            ForeColor = ColorConfig.ForeColorBlack;
            Font = FontConfig.FontSizeSmall;
            Width = 6;
        }

        // ***************************************************************************************************************************
        // ******************************************************   PROPERTIES   *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the width.
        /// </summary>
        /// <param name="width">The width.</param>
        public void SetWidth( int width = 3 )
        {
            if( width > 0
                && width < 10 )
            {
                try
                {
                    Width = width;
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