﻿// // <copyright file = "ToolBarBase.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary> </summary>
    /// <seealso cref = "Syncfusion.Windows.Forms.Tools.ToolStripEx"/>
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public class ToolBarBase : ToolBarData
    {
        // ***************************************************************************************************************************
        // ****************************************************    FIELDS     ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// The image path
        /// </summary>
        public static readonly string ImagePath = Resource.ToolBar;

        // ***************************************************************************************************************************
        // ****************************************************     METHODS   ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Creates the button.
        /// </summary>
        /// <param name = "imagename" >
        /// The name.
        /// </param>
        /// <returns>
        /// </returns>
        public BarButton CreateButton( string imagename )
        {
            if( Verify.Input( imagename ) )
            {
                try
                {
                    var image = new BudgetImage( imagename, ImageSource.ToolBar, ImageSizer.Small );
                    var barbutton = new BarButton( image );
                    Items?.Add( barbutton );

                    return Items?.Count > 0
                        ? barbutton
                        : default;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        /// <summary>
        /// Creates the label.
        /// </summary>
        /// <returns>
        /// </returns>
        public BarLabel CreateLabel()
        {
            try
            {
                var label = new BarLabel();
                Items?.Add( label );

                return label?.BindingSource != null && Items?.Count > 0
                    ? label
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Creates the ComboBox.
        /// </summary>
        /// <returns>
        /// </returns>
        public BarComboBox CreateComboBox()
        {
            try
            {
                var combobox = new BarComboBox();
                Items?.Add( combobox );

                return Items?.Count > 0
                    ? combobox
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Creates the text box.
        /// </summary>
        /// <returns>
        /// </returns>
        public BarTextBox CreateTextBox()
        {
            try
            {
                var textbox = new BarTextBox();
                Items?.Add( textbox );

                return Items?.Count > 0
                    ? textbox
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }
    }
}