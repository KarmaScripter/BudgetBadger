// <copyright file = "TabControl.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
using MetroSet_UI.Enums;
using Syncfusion.Windows.Forms.Tools;

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class TabControl : ControlBase, ITabControl
    {
        // ***************************************************************************************************************************
        // ****************************************************  CONSTRUCTORS ********************************************************
        // ***************************************************************************************************************************

        public TabControl()
        {
            InitializeComponent();
            ActiveTab = Tab.TabPages[ 0 ];
            TabPages = Tab.TabPages;
        }

        // ***************************************************************************************************************************
        // ****************************************************  PROPERTIES   ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Gets or sets the active tab.
        /// </summary>
        /// <value>
        /// The active tab.
        /// </value>
        public TabPageAdv ActiveTab { get; set; }

        public TabPageAdvCollection TabPages { get; set; }

        // ***************************************************************************************************************************
        // ****************************************************     METHODS   ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the border style.
        /// </summary>
        /// <param name="border">if set to
        /// <c> true </c>
        /// [border].</param>
        public void SetBorderStyle( bool border )
        {
            Tab.SetBorderStyle( border );
        }

        /// <summary>
        /// Sets the table style.
        /// </summary>
        /// <param name="style">The style.</param>
        public void SetTabStyle( TabStyle style )
        {
            Tab.SetTabStyle( style );
        }

        /// <summary>
        /// Sets the size of the item.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public void SetItemSize( int width = 120, int height = 20 )
        {
            Tab.SetItemSize( width, height );
        }

        /// <summary>
        /// Sets the data source.
        /// </summary>
        /// <param name="bindingsource">The bindingsource.</param>
        public void SetBindingSource( BindingSource bindingsource )
        {
            Tab.SetBindingSource( bindingsource );
        }

        /// <summary>
        /// Adds the tab.
        /// </summary>
        /// <param name="tab">The tab.</param>
        public void AddTab( TabPage tab )
        {
            Tab.AddTab( tab );
        }

        /// <summary>
        /// Adds the tab.
        /// </summary>
        /// <param name="name">The name.</param>
        public void AddTab( string name )
        {
            Tab.AddTab( name );
        }

        /// <summary>
        /// Adds the control item.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Control> GetChildren()
        {
            return Tab.GetChildren();
        }

        /// <summary>
        /// Called when [selected index changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        public void OnSelectedIndexChanged( object sender, EventArgs e )
        {
            Tab.OnSelectedIndexChanged( sender, e );
        }

        /// <summary>
        /// Called when [current changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        public void OnCurrentChanged( object sender, EventArgs e )
        {
            Tab.OnCurrentChanged( sender, e );
        }
    }
}
