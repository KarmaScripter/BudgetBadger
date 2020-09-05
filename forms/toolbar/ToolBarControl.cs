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
    public partial class ToolBarControl : ControlBase, IToolBar
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

        /// <summary>
        /// Gets the buttons.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, BarButton> GetButtons()
        {
            return ToolBar.GetButtons();
        }

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
            return ( (IToolBar)ToolBar ).CreateButton( imagename );
        }

        /// <summary>
        /// Creates the label.
        /// </summary>
        /// <returns>
        /// </returns>
        public BarLabel CreateLabel()
        {
            return ( (IToolBar)ToolBar ).CreateLabel();
        }

        /// <summary>
        /// Creates the ComboBox.
        /// </summary>
        /// <returns>
        /// </returns>
        public BarComboBox CreateComboBox()
        {
            return ( (IToolBar)ToolBar ).CreateComboBox();
        }

        /// <summary>
        /// Creates the text box.
        /// </summary>
        /// <returns>
        /// </returns>
        public BarTextBox CreateTextBox()
        {
            return ( (IToolBar)ToolBar ).CreateTextBox();
        }

        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <returns></returns>
        public ToolStripItemCollection GetItems()
        {
            return ( (IToolBar)ToolBar ).GetItems();
        }
    }
}
