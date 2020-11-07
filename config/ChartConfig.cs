// <copyright file = "ChartConfig.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ******************************************************************************************************************************
    // ******************************************************   ASSEMBLIES   ********************************************************
    // ******************************************************************************************************************************

    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms.Chart;

    /// <summary>
    /// This provides the basic application form settings.
    /// </summary>
    /// <seealso cref = "IDisposable"/>
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberInitializerValueIgnored" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    public class ChartConfig : ChartStyleInfo, IChartConfig
    {
        //***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the <see/> class.
        /// </summary>
        public ChartConfig()
        {
            DisplayText = true;
            TextColor = ColorConfig.ForeGray;
            Interior = new BrushInfo( Color.FromArgb( 5, 5, 5 ) );
            Border = SetBorderStyle( ColorConfig.BackDark, BorderConfig.SizeThin );
        }

        // ***************************************************************************************************************************
        // ************************************************  METHODS   ***************************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the font.
        /// </summary>
        /// <param name = "font" >
        /// The font.
        /// </param>
        /// <returns>
        /// </returns>
        public static ChartFontInfo SetFont( Font font )
        {
            if( font != null )
            {
                try
                {
                    var chart = new ChartFontInfo();
                    chart.FontStyle = font.Style;
                    chart.FontFamilyTemplate = font.FontFamily;
                    chart.Size = font.Size;
                    return chart;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return default;
        }

        /// <summary>
        /// Sets the font.
        /// </summary>
        /// <param name = "family" >
        /// The family.
        /// </param>
        /// <param name = "size" >
        /// The size.
        /// </param>
        /// <param name = "style" >
        /// The style.
        /// </param>
        /// <returns>
        /// </returns>
        public static ChartFontInfo SetFont( string family = "Roboto", int size = 8,
            FontStyle style = FontStyle.Regular )
        {
            if( Verify.Input( family ) )
            {
                try
                {
                    var chart = new ChartFontInfo();
                    chart.FontStyle = style;
                    chart.Facename = family;
                    chart.Size = size;
                    return chart;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return default;
        }

        /// <summary>
        /// Sets the anchor.
        /// </summary>
        /// <param name = "anchor" >
        /// The anchor.
        /// </param>
        /// <returns>
        /// </returns>
        public AnchorStyles SetAnchor( AnchorStyles anchor = AnchorStyles.Left & AnchorStyles.Top )
        {
            try
            {
                return anchor;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Sets the border style.
        /// </summary>
        /// <param name = "color" >
        /// The color.
        /// </param>
        /// <param name = "width" >
        /// The width.
        /// </param>
        /// <returns>
        /// </returns>
        public static ChartLineInfo SetBorderStyle( Color color, int width = 1 )
        {
            try
            {
                var style = new ChartLineInfo();
                style.Alignment = PenAlignment.Center;
                style.Width = width;
                style.Color = color;
                return style;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
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
