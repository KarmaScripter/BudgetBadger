// <copyright file = "BarLabel.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ******************************************************************************************************************************
    // ******************************************************   ASSEMBLIES   ********************************************************
    // ******************************************************************************************************************************

    using System;
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    public class BarLabel : BarLabelBase
    {
        // ***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "BarLabel"/>
        /// class.
        /// </summary>
        public BarLabel()
        {
            Margin = new Padding( 10, 5, 10, 0 );
            Size = new Size( 150, 23 );
            ForeColor = ColorConfig.ForeColorBlack;
            Font = FontConfig.FontSizeSmall;
            Visible = true;
            Enabled = true;
            Name = "Label";
            Tag = Name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BarLabel"/> class.
        /// </summary>
        /// <param name="text">The text to display on the <see cref="T:System.Windows.Forms.ToolStripLabel" />.</param>
        public BarLabel( string text )
            : this()
        {
            Text = ControlConfig.GetText( text );
            MouseHover += OnMouseHover;
        }

        // ***************************************************************************************************************************
        // ****************************************************  PROPERTIES   ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public ToolTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public string HoverText { get; set; }

        // ***************************************************************************************************************************
        // ******************************************************   METHODS      *****************************************************
        // ***************************************************************************************************************************

        /// <summary> Sets the text. </summary>
        /// <param name = "text" > The text. </param>
        /// <param name = "color" > The color. </param>
        public void SetText( string text, Color color )
        {
            try
            {
                ForeColor = ColorConfig.GetColor( color );
                Text = ControlConfig.GetText( text );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Sets the text. </summary>
        /// <param name = "text" > The text. </param>
        /// <param name = "color" > The color. </param>
        /// <param name = "font" > The font. </param>
        public void SetText( string text, Color color, Font font )
        {
            try
            {
                Font = FontConfig.GetFont( font );
                ForeColor = ColorConfig.GetColor( color );
                Text = ControlConfig.GetText( text );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        // ***************************************************************************************************************************
        // ****************************************************     EVENTS    ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Called when [mouse hover].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        public void OnMouseHover( object sender, EventArgs e )
        {
            if( sender is BarLabel label
                && Verify.Input( label?.HoverText ) )
            {
                try
                {
                    if( Verify.Input( HoverText ) )
                    {
                        var text = label?.HoverText;
                        ToolTip = new ToolTip( this, text );
                    }
                    else
                    {
                        if( Verify.Input( Tag?.ToString() ) )
                        {
                            ToolTip = new ToolTip( label, Tag?.ToString()?.SplitPascal() );
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
}
