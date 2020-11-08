// // <copyright file = "BorderConfig.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using OfficeOpenXml.Style;
    using Syncfusion.XlsIO;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Global" ) ]
    public class BorderConfig
    {
        // ***************************************************************************************************************************
        // ****************************************************    FIELDS     ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// The fixed
        /// </summary>
        public static readonly FormBorderStyle Fixed = FormBorderStyle.FixedSingle;

        /// <summary>
        /// The none
        /// </summary>
        public static readonly FormBorderStyle None = FormBorderStyle.None;

        /// <summary>
        /// The sizeable
        /// </summary>
        public static readonly FormBorderStyle Sizeable = FormBorderStyle.Sizable;

        /// <summary>
        /// The thin
        /// </summary>
        public static readonly int Thin = 1;

        // ***************************************************************************************************************************
        // ****************************************************  CONSTRUCTORS ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the <see cref="BorderConfig"/> class.
        /// </summary>
        public BorderConfig()
        {
        }

        // ***************************************************************************************************************************
        // ****************************************************  PROPERTIES   ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Gets or sets a value indicating whether this instance is hoverable.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is hoverable; otherwise, <c>false</c>.
        /// </value>
        public bool IsHoverable { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether this instance has color.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has color; otherwise, <c>false</c>.
        /// </value>
        public bool HasColor { get; set; } = false;

        // ***************************************************************************************************************************
        // ****************************************************     METHODS   ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Gets the thickness.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <returns></returns>
        public static int GetThickness( int size = 1 )
        {
            try
            {
                return size > 0
                    ? size
                    : 1;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return 1;
            }
        }

        /// <summary>
        /// Gets the style.
        /// </summary>
        /// <param name="style">The style.</param>
        /// <returns></returns>
        public static BorderStyle GetStyle( BorderStyle style = BorderStyle.None )
        {
            try
            {
                return Enum.IsDefined( typeof( BorderStyle ), style )
                    ? style
                    : BorderStyle.None;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return BorderStyle.None;
            }
        }

        /// <summary>
        /// Gets the color.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <returns></returns>
        public static Color GetColor( Color color )
        {
            try
            {
                return color != Color.Empty
                    ? color
                    : Color.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Color.Empty;
            }
        }

        /// <summary>
        /// Gets the excel border style.
        /// </summary>
        /// <param name="border">The border.</param>
        /// <returns></returns>
        public static ExcelBorderStyle GetExcelBorderStyle( ExcelBorderStyle border )
        {
            try
            {
                return Enum.IsDefined( typeof( ExcelBorderStyle ), border )
                    ? border
                    : ExcelBorderStyle.None;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return ExcelBorderStyle.None;
            }
        }

        /// <summary>
        /// Gets the type of the excel underline.
        /// </summary>
        /// <param name="underline">The underline.</param>
        /// <returns></returns>
        public static eUnderLineType GetExcelUnderlineType( eUnderLineType underline )
        {
            try
            {
                return Enum.IsDefined( typeof( eUnderLineType ), underline )
                    ? underline
                    : eUnderLineType.None;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return eUnderLineType.None;
            }
        }

        /// <summary>
        /// Gets the excel border weight.
        /// </summary>
        /// <param name="weight">The weight.</param>
        /// <returns></returns>
        public static ExcelBorderWeight GetExcelBorderWeight( ExcelBorderWeight weight )
        {
            try
            {
                return Enum.IsDefined( typeof( ExcelBorderWeight ), weight )
                    ? weight
                    : ExcelBorderWeight.None;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return ExcelBorderWeight.None;
            }
        }

        /// <summary>
        /// Gets the excel line style.
        /// </summary>
        /// <param name="style">The style.</param>
        /// <returns></returns>
        public static ExcelLineStyle GetExcelLineStyle( ExcelLineStyle style )
        {
            try
            {
                return Enum.IsDefined( typeof( ExcelLineStyle ), style )
                    ? style
                    : ExcelLineStyle.None;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return ExcelLineStyle.None;
            }
        }

        // **************************************************************************************************************************
        // ********************************************      EVENTS     *************************************************************
        // **************************************************************************************************************************

        /// <summary>
        /// Called when [mouse hover].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public static void OnMouseHover( object sender, EventArgs e )
        {
            if( sender != null
                && e != null )
            {
                try
                {
                    using var message = new Message( "NOT YET IMPLEMENTED" );
                    message?.ShowDialog();
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [border changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public static void OnBorderChanged( object sender, EventArgs e )
        {
            if( sender != null
                && e != null )
            {
                try
                {
                    using var message = new Message( "NOT YET IMPLEMENTED" );
                    message?.ShowDialog();
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Fails the specified ex.
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