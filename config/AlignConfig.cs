// // <copyright file = "AlignConfig.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    // **************************************************************************************************************************
    // ********************************************      ASSEMBLIES    **********************************************************
    // **************************************************************************************************************************

    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using OfficeOpenXml.Style;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Global" ) ]
    public class AlignConfig
    {
        // **************************************************************************************************************************
        // ********************************************      FIELDS     *************************************************************
        // **************************************************************************************************************************

        /// <summary>
        /// Gets the left align.
        /// </summary>
        /// <value>
        /// The left align.
        /// </value>
        public static readonly HorizontalAlignment HorizontalLeft = HorizontalAlignment.Left;

        /// <summary>
        /// Gets the right align.
        /// </summary>
        /// <value>
        /// The right align.
        /// </value>
        public static readonly HorizontalAlignment HorizontalRight = HorizontalAlignment.Right;

        /// <summary>
        /// Gets the center align.
        /// </summary>
        /// <value>
        /// The center align.
        /// </value>
        public static readonly HorizontalAlignment HorizontalCenter = HorizontalAlignment.Center;

        /// <summary>
        /// Gets the center text.
        /// </summary>
        /// <value>
        /// The center text.
        /// </value>
        public static readonly StringAlignment StringCenter = StringAlignment.Center;

        /// <summary>
        /// Gets the far text.
        /// </summary>
        /// <value>
        /// The far text.
        /// </value>
        public static readonly StringAlignment StringFar = StringAlignment.Far;

        /// <summary>
        /// Gets the near text.
        /// </summary>
        /// <value>
        /// The near text.
        /// </value>
        public static readonly StringAlignment StringNear = StringAlignment.Near;

        /// <summary>
        /// The middle center
        /// </summary>
        public static readonly ContentAlignment ContentCenter = ContentAlignment.MiddleCenter;

        /// <summary>
        /// The content top
        /// </summary>
        public static readonly ContentAlignment ContentTop = ContentAlignment.TopCenter;

        /// <summary>
        /// The content left
        /// </summary>
        public static readonly ContentAlignment ContentLeft = ContentAlignment.MiddleLeft;

        /// <summary>
        /// The content right
        /// </summary>
        public static readonly ContentAlignment ContentRight = ContentAlignment.MiddleRight;

        /// <summary>
        /// The content bottom
        /// </summary>
        public static readonly ContentAlignment ContentBottom = ContentAlignment.BottomRight;

        // **************************************************************************************************************************
        // ********************************************   CONSTRUCTORS     **********************************************************
        // **************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the <see cref = "ColorConfig"/> class.
        /// </summary>
        public AlignConfig()
        {
        }

        // **************************************************************************************************************************
        // ********************************************      METHODS    *************************************************************
        // **************************************************************************************************************************

        /// <summary>
        /// Sets the color.
        /// </summary>
        /// <param name = "alignment" >
        /// The alignment.
        /// </param>
        /// <returns>
        /// </returns>
        public static StringAlignment GetStringAlignment( StringAlignment alignment )
        {
            try
            {
                return Enum.IsDefined( typeof( StringAlignment ), alignment )
                    ? alignment
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Sets the string alignment.
        /// </summary>
        /// <param name = "alignment" >
        /// The alignment.
        /// </param>
        /// <returns>
        /// </returns>
        public static HorizontalAlignment GetHorizontalAlignment( HorizontalAlignment alignment )
        {
            try
            {
                return Enum.IsDefined( typeof( HorizontalAlignment ), alignment )
                    ? alignment
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the excel vertical alignment.
        /// </summary>
        /// <param name="alignment">The alignment.</param>
        /// <returns></returns>
        public static ExcelVerticalAlignment GetExcelVerticalAlignment( ExcelVerticalAlignment alignment )
        {
            try
            {
                return Enum.IsDefined( typeof( ExcelVerticalAlignment ), alignment )
                    ? alignment
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the excel horizontal alignment.
        /// </summary>
        /// <param name="alignment">The alignment.</param>
        /// <returns></returns>
        public static ExcelHorizontalAlignment GetExcelHorizontalAlignment( ExcelHorizontalAlignment alignment )
        {
            try
            {
                return Enum.IsDefined( typeof( ExcelHorizontalAlignment ), alignment )
                    ? alignment
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        // **************************************************************************************************************************
        // ********************************************      EVENTS     *************************************************************
        // **************************************************************************************************************************

        /// <summary>
        /// Called when [color changed].
        /// </summary>
        /// <param name = "sender" >
        /// The sender.
        /// </param>
        /// <param name = "e" >
        /// The <see cref = "EventArgs"/> instance containing the event data.
        /// </param>
        public static void OnAlignmentChanged( object sender, EventArgs e )
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