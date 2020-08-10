// <copyright file = "BarTextBox.cs" company = "Terry D. Eppler">
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
    using System.Threading;
    using System.Windows.Forms;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public class BarTextBox : ToolStripTextBox
    {
        // ***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the <see cref="BarTextBox"/> class.
        /// </summary>
        public BarTextBox()
        {
            Margin = new Padding( 10, 5, 10, 0 );
            Padding = new Padding( 1 );
            Size = new Size( 150, 23 );
            BackColor = ColorConfig.BackColorBlack;
            ForeColor = ColorConfig.ForeColorGray;
            Font = FontConfig.FontSizeSmall;
            Visible = true;
            Enabled = true;
            Tag = Name;
            ToolTipText = Tag.ToString();
            HoverText = ToolTipText;
            MouseHover += OnMouseOver;
        }

        // ***************************************************************************************************************************
        // ******************************************************   PROPERTIES   *****************************************************
        // ***************************************************************************************************************************

        /// <summary> Gets or sets the binding source. </summary>
        /// <value> The binding source. </value>
        public BindingSource BindingSource { get; set; }

        /// <summary> Gets or sets the hover text. </summary>
        /// <value> The hover text. </value>
        public string HoverText { get; set; }

        /// <summary> Gets or sets the field. </summary>
        /// <value> The field. </value>
        public Field Field { get; set; }

        /// <summary> Gets or sets the tip. </summary>
        /// <value> The tip. </value>
        public ToolTip ToolTip { get; set; }

        // ***************************************************************************************************************************
        // *******************************************************      METHODS        ***********************************************
        // ***************************************************************************************************************************

        /// <summary> Sets the hover information. </summary>
        /// <param name = "text" > The text. </param>
        public void SetHoverText( string text )
        {
            if( Verify.Input( text ) )
            {
                try
                {
                    HoverText = text;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Sets the field. </summary>
        /// <param name = "field" > The field. </param>
        public void SetField( Field field )
        {
            if( Enum.IsDefined( typeof( Field ), field ) )
            {
                try
                {
                    if( field != Field.NS )
                    {
                        Field = field;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Sets the tag. </summary>
        /// <param name = "tag" > The tag. </param>
        public void SetTag( object tag )
        {
            if( tag != null )
            {
                try
                {
                    Tag = tag;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the hover text.
        /// </summary>
        /// <param name="item">The item.</param>
        public void SetHoverText( ToolStripItem item )
        {
            var text = item?.Tag?.ToString();

            if( Verify.Input( text ) )
            {
                try
                {
                    ToolTip = new ToolTip( item, text );
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
            if( sender is BarTextBox textbox
                && Verify.Input( textbox?.HoverText ) )
            {
                try
                {
                    if( Verify.Input( HoverText ) )
                    {
                        var text = textbox?.HoverText;
                        ToolTip = new ToolTip( this, text );
                    }
                    else
                    {
                        if( Verify.Input( Tag?.ToString() ) )
                        {
                            ToolTip = new ToolTip( this, Tag?.ToString()?.SplitPascal() );
                        }
                    }
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
