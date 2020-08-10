// <copyright file = "ToolTip.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;
    using System.Windows.Forms;
    using MetroSet_UI.Components;
    using MetroSet_UI.Design;

    // ******************************************************************************************************************************
    // ******************************************************   ASSEMBLIES   ********************************************************
    // ******************************************************************************************************************************

    /// <summary>
    /// Defines the
    /// <see cref = "ToolTip"/>
    /// </summary>
    /// <seealso cref = "MetroSet_UI.Components.MetroSetToolTip"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "PossibleNullReferenceException" ) ]
    public class ToolTip : MetroSetToolTip
    {
        // ***************************************************************************************************************************
        // *********************************************   CONSTRUCTORS **************************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "ToolTip"/>
        /// class.
        /// </summary>
        public ToolTip()
        {
            ThemeAuthor = "Terry D. Eppler";
            ThemeName = "Budget Execution";
            Style = Style.Custom;
            BackColor = ColorConfig.BackColorBlack;
            BorderColor = ColorConfig.BorderColorBlue;
            ForeColor = ColorConfig.ForeColorGray;
            UseAnimation = true;
            UseFading = true;
            AutomaticDelay = 500;
            InitialDelay = 500;
            AutoPopDelay = 5000;
            ReshowDelay = 100;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "ToolTip"/>
        /// class.
        /// </summary>
        /// <param name = "control" >
        /// The control
        /// <see cref = "Control"/>
        /// </param>
        /// <param name = "text" >
        /// The caption
        /// <see cref = "string"/>
        /// </param>
        public ToolTip( Control control, string text )
            : this()
        {
            SetToolTipText( control, text );
            AddTextItem( text );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolTip"/> class.
        /// </summary>
        /// <param name="component">The item.</param>
        /// <param name="text">The caption.</param>
        public ToolTip( Component component, string text )
            : this()
        {
            SetToolTipText( component, text );
            AddTextItem( text );
        }

        // **********************************************************************************************************************
        // *************************************************   PROPERTIES   *****************************************************
        // **********************************************************************************************************************

        /// <summary> Gets or sets the ToolTipIcon Gets the tool tip icon. </summary>
        /// <value> The tool tip icon. </value>
        public ToolTipIcon TipIcon { get; set; } = ToolTipIcon.None;

        /// <summary> Gets or sets the ToolTipTitle Gets the tool tip title. </summary>
        /// <value> The tool tip title. </value>
        public string TipTitle { get; set; } = string.Empty;

        /// <summary> Gets or sets the Name </summary>
        /// <value> The name. </value>
        public string Name { get; set; }

        /// <summary> Gets or sets the items. </summary>
        /// <value> The items. </value>
        public IEnumerable<string> Items { get; set; }

        /// <summary> Gets or sets the binding source. </summary>
        /// <value> The binding source. </value>
        public BindingSource BindingSource { get; set; }

        /// <summary> Gets or sets the field. </summary>
        /// <value> The field. </value>
        private Field Field { get; set; }

        // ***************************************************************************************************************************
        // ************************************************  METHODS   ***************************************************************
        // ***************************************************************************************************************************

        /// <summary> Sets the animation. </summary>
        /// <param name = "animate" >
        /// if set to
        /// <c> true </c>
        /// [animate].
        /// </param>
        public void SetAnimation( bool animate )
        {
            try
            {
                UseAnimation = animate;
                UseFading = animate;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Sets the automatic delay. </summary>
        /// <param name = "delay" > The delay. </param>
        public void SetAutomaticDelay( int delay = 500 )
        {
            if( delay > 0 )
            {
                try
                {
                    AutomaticDelay = delay;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Sets the duration. </summary>
        /// <param name = "time" > The time. </param>
        public void SetDuration( int time = 5000 )
        {
            if( time > 0 )
            {
                try
                {
                    AutoPopDelay = time;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Sets the initial delay. </summary>
        /// <param name = "delay" > The delay. </param>
        public void SetInitialDelay( int delay = 500 )
        {
            if( delay > 0 )
            {
                try
                {
                    InitialDelay = delay;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Sets the reshow delay. </summary>
        /// <param name = "reshow" > The reshow. </param>
        public void SetReshowDelay( int reshow = 100 )
        {
            if( reshow > 0 )
            {
                try
                {
                    ReshowDelay = reshow;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Adds the item. </summary>
        /// <param name = "data" > The data. </param>
        public void AddTextItem( string data )
        {
            if( Verify.Input( data ) )
            {
                try
                {
                    ( Items as List<string> )?.Add( data );
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
            if( Verify.Field( field ) )
            {
                try
                {
                    Field = field;
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
        /// Sets the tool tip.
        /// </summary>
        /// <param name="control">The control.</param>
        public void SetToolTipText( Control control )
        {
            if( Verify.Input( control?.Tag?.ToString() ) )
            {
                try
                {
                    var caption = control.Tag.ToString();
                    SetToolTip( control, caption );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> The ToolTip text to display when the pointer is on the control. </summary>
        /// <param name = "control" >
        /// The control
        /// <see cref = "Control"/>
        /// </param>
        /// <param name = "caption" >
        /// The caption
        /// <see cref = "string"/>
        /// </param>
        public void SetToolTipText( Control control, string caption )
        {
            if( control != null
                && Verify.Input( caption ) )
            {
                try
                {
                    SetToolTip( control, caption );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the tool tip.
        /// </summary>
        /// <param name="item">The item.</param>
        public void SetToolTipText( ToolStripItem item )
        {
            if( item.GetCurrentParent() != null
                && item is Component component )
            {
                try
                {
                    var caption = item?.Tag?.ToString();

                    if( Verify.Input( caption ) )
                    {
                        SetToolTipText( component, caption );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the tool tip.
        /// </summary>
        /// <param name="component">The item.</param>
        public void SetToolTipText( Component component )
        {
            if( component != null
                && component is Control control )
            {
                try
                {
                    if( Verify.Input( control?.Tag?.ToString() ) )
                    {
                        var caption = control.Tag.ToString();
                        SetToolTip( control, caption );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the tool tip.
        /// </summary>
        /// <param name="component">The item.</param>
        /// <param name="caption">The caption.</param>
        public void SetToolTipText( Component component, string caption )
        {
            if( component != null
                && Verify.Input( caption ) )
            {
                try
                {
                    if( component is Control control )
                    {
                        SetToolTip( control, caption );
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
