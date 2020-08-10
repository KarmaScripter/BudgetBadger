// // <copyright file = "HoverBase.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    // **************************************************************************************************************************
    // ********************************************      ASSEMBLIES    **********************************************************
    // **************************************************************************************************************************

    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.Tools.SuperToolTip" />
    public class HoverBase : SuperToolTip
    {
        // **************************************************************************************************************************
        // ********************************************      PROPERTIES    **********************************************************
        // **************************************************************************************************************************

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the tag.
        /// </summary>
        /// <value>
        /// The tag.
        /// </value>
        public object Tag { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public Field Field { get; set; }

        /// <summary>
        /// Gets or sets the header items.
        /// </summary>
        /// <value>
        /// The header items.
        /// </value>
        public IList<string> HeaderItems { get; set; }

        /// <summary>
        /// Gets or sets the body items.
        /// </summary>
        /// <value>
        /// The body items.
        /// </value>
        public IList<string> BodyItems { get; set; }

        /// <summary>
        /// Gets or sets the footer items.
        /// </summary>
        /// <value>
        /// The footer items.
        /// </value>
        public IList<string> FooterItems { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        // **************************************************************************************************************************
        // ********************************************      METHODS    *************************************************************
        // **************************************************************************************************************************

        /// <summary>
        /// Sets the maximum width.
        /// </summary>
        /// <param name="width">The width.</param>
        public void SetMaxWidth( int width = 700 )
        {
            if( width > 0 )
            {
                try
                {
                    MaxWidth = width;
                }
                catch( Exception ex )
                {
                    Console.WriteLine( ex );
                    throw;
                }
            }
        }

        /// <summary>
        /// Sets the initial delay.
        /// </summary>
        /// <param name="delay">The delay.</param>
        public void SetInitialDelay( int delay = 750 )
        {
            if( delay > 0 )
            {
                try
                {
                    InitialDelay = delay;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Uses the gradient background.
        /// </summary>
        /// <param name="gradient">if set to
        /// <c> true </c>
        /// [gradient].</param>
        public void UseGradientBackground( bool gradient = true )
        {
            try
            {
                GradientBackGround = gradient;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the color of the metro.
        /// </summary>
        /// <param name="color">The color.</param>
        public void SetMetroColor( Color color )
        {
            if( color != Color.Empty )
            {
                try
                {
                    MetroColor = color;
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