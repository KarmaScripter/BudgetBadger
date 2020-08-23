// <copyright file = "BarComboBox.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ******************************************************************************************************************************
    // ******************************************************   ASSEMBLIES   ********************************************************
    // ******************************************************************************************************************************

    using System;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    public class BarComboBox : BarComboBase, IBarComboBox
    {
        // ***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        public BarComboBox()
        {
            Margin = new Padding( 5, 5, 5, 5 );
            Padding = new Padding( 0 );
            Size = new Size( 150, 23 );
            DropDownStyle = ComboBoxStyle.DropDownList;
            MaxDropDownItems = 30;
            DropDownHeight = 200;
            BackColor = ColorConfig.BackColorBlack;
            ForeColor = ColorConfig.ForeColorGray;
            Font = FontConfig.FontSizeSmall;
            Field = Field.NS;
            Tag = "Make Selection";
            ToolTipText = Tag.ToString();
            HoverText = ToolTipText;
            Text = string.Empty;
            Visible = true;
            Enabled = true;
            MouseHover += OnMouseOver;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BarComboBox"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public BarComboBox( IEnumerable<object> data )
            : this()
        {
            BindingSource.DataSource = data?.ToList();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BarComboBox"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="filter">The filter.</param>
        public BarComboBox( IEnumerable<object> data, string filter )
            : this( data )
        {
            BindingSource.Filter = filter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BarComboBox"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="filter">The filter.</param>
        public BarComboBox( IEnumerable<DataRow> data, string filter )
            : this()
        {
            BindingSource.DataSource = data.ToList();
            BindingSource.DataMember = filter;
        }

        // ***************************************************************************************************************************
        // *******************************************************      METHODS        ***********************************************
        // ***************************************************************************************************************************

        /// <summary> Sets the data source. </summary>
        /// <param name = "bindingsource" > The bindingsource. </param>
        public void SetDataSource( BindingSource bindingsource )
        {
            if( bindingsource?.DataSource != null )
            {
                try
                {
                    BindingSource.DataSource = bindingsource.DataSource;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        // ***************************************************************************************************************************
        // ****************************************************   EVENTS/DELEGATES  **************************************************
        // ***************************************************************************************************************************

        /// <summary> Called when [mouse over]. </summary>
        /// <param name = "sender" > The sender. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnMouseOver( object sender, EventArgs e )
        {
            var button = sender as ButtonPanel;

            try
            {
                if( Verify.Input( HoverText ) )
                {
                    var text = button?.HoverText;
                    ToolTip = new ToolTip( button, text );
                }
                else
                {
                    if( Verify.Input( Tag?.ToString() ) )
                    {
                        ToolTip = new ToolTip( button, Tag?.ToString().SplitPascal() );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [item selected]. </summary>
        /// <param name = "sender" > The sender. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnItemSelected( object sender, EventArgs e )
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
    }
}
