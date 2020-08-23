// <copyright file="{ClassName}.cs" company="Terry D. Eppler">
// Copyright (c) Eppler. All rights reserved.
// </copyright>

using System.Diagnostics.CodeAnalysis;

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.ControlBase" />
    [ SuppressMessage( "ReSharper", "UsePatternMatching" ) ]
    public partial class ToolBarControl : ControlBase
    {
        // ***************************************************************************************************************************
        // ****************************************************  CONSTRUCTORS ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolBarControl"/> class.
        /// </summary>
        public ToolBarControl()
        {
            InitializeComponent();
            Margin = new Padding( 5, 5, 5, 0 );
            Padding = new Padding( 1, 1, 1, 0 );
            Dock = ControlConfig.GetDockStyle( DockStyle.Bottom );
            Anchor = ControlConfig.GetAnchorStyle();
            BorderStyle = BorderStyle.None;
            AutoScaleMode = AutoScaleMode.Dpi;
            DoubleBuffered = true;
            Load += OnLoad;
        }

        // ***************************************************************************************************************************
        // ****************************************************  PROPERTIES   ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Gets or sets the tool button.
        /// </summary>
        /// <value>
        /// The tool button.
        /// </value>
        public IDictionary<string, BarButton> ToolButton { get; set; } = new SortedList<string, BarButton>();

        // ***************************************************************************************************************************
        // ****************************************************     METHODS   ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Gets the buttons.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, BarButton> GetButtons()
        {
            if( ToolBar?.Items?.Count > 0 )
            {
                var buttons = ToolBar.GetButtons();

                return buttons?.Count > 0
                    ? buttons
                    : default;
            }

            return default;
        }

        // ***************************************************************************************************************************
        // ****************************************************   EVENTS/DELEGATES  **************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private protected void OnLoad( object sender, EventArgs e )
        {
            try
            {
                foreach( var item in ToolBar.Items )
                {
                    var button = item as BarButton;

                    if( button != null )
                    {
                        ToolButton = ToolBar.GetButtons();
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
    }
}
