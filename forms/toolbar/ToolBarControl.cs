// <copyright file="{ClassName}.cs" company="Terry D. Eppler">
// Copyright (c) Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.ControlBase" />
    [ SuppressMessage( "ReSharper", "UsePatternMatching" ) ]
    [ Serializable ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "PatternAlwaysOfType" ) ]
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
        public IDictionary<string, BarButton> ToolButtons { get; set; } 

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
                if( ToolBar?.Buttons != null )
                {
                    foreach( var item in ToolBar.Buttons )
                    {
                        if( item.Value is BarButton button )
                        {
                            ToolButtons.Add( button?.Name, button );
                        }
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
