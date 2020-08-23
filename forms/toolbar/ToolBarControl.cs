﻿// <copyright file="{ClassName}.cs" company="Terry D. Eppler">
// Copyright (c) Eppler. All rights reserved.
// </copyright>

using VisualPlus.Extensibility;

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System.Collections.Generic;

    public partial class ToolBarControl : ControlBase
    {
        // ***************************************************************************************************************************
        // ****************************************************  CONSTRUCTORS ********************************************************
        // ***************************************************************************************************************************

        public ToolBarControl()
        {
            InitializeComponent();
            Load += OnLoad;
        }

        // ***************************************************************************************************************************
        // ****************************************************  PROPERTIES   ********************************************************
        // ***************************************************************************************************************************

        private protected IDictionary<string, IBarButton> ToolButton { get; set; }

        // ***************************************************************************************************************************
        // ****************************************************     METHODS   ********************************************************
        // ***************************************************************************************************************************

        private IDictionary<string, IBarButton> GetButtons()
        {
            var buttons = new SortedList<string, IBarButton>();

            if( Controls?.Count > 0 )
            {
                foreach( var control in ToolBar.Controls )
                {
                    if( control is IBarButton )
                    {
                        buttons.Add( control.GetName(), control as BarButton );
                    }
                }

                return buttons?.Count > 0
                    ? buttons
                    : default;
            }

            return default;
        }

        // ***************************************************************************************************************************
        // ****************************************************     EVENTS    ********************************************************
        // ***************************************************************************************************************************

        private protected void OnLoad( object sender, EventArgs e )
        {
            try
            {
                ToolButton = GetButtons();
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
    }
}
