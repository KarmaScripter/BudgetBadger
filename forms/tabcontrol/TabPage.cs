// <copyright file = "TabPage.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ******************************************************************************************************************************
    // ******************************************************   ASSEMBLIES   ********************************************************
    // ******************************************************************************************************************************

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.Tools.TabPageAdv" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public class TabPage : TabPageAdv, ITabPage
    {
        // ***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the <see cref="TabPage"/> class.
        /// </summary>
        public TabPage()
        {
            Size = SizeConfig.GetSize( 600, 400 );
            Location = ControlConfig.GetLocation();
            BackColor = ColorConfig.BackColorBlack;
            TabBackColor = ColorConfig.BackColorBlack;
            ForeColor = ColorConfig.ForeColorGray;
            TabForeColor = ColorConfig.BackColorBlack;
            Font = FontConfig.FontSizeSmall;
            TabFont = FontConfig.FontSizeSmall;
            ImageSize = new Size( 12, 12 );
            Margin = ControlConfig.Margin;
            Padding = ControlConfig.Padding;
            BorderStyle = BorderStyle.None;
            ShowCloseButton = false;
            UseActiveTabColor = true;
            Anchor = ControlConfig.GetAnchorStyle();
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowOnly;
            Dock = ControlConfig.GetDockStyle();
            Visible = true;
            TabVisible = false;
            Enabled = true;
            TabEnabled = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TabPage"/> class.
        /// </summary>
        /// <param name="title">The title.</param>
        public TabPage( string title )
            : this()
        {
            Name = title;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="TabPage" />
        /// class.
        /// </summary>
        /// <param name="tab">The tab.</param>
        public TabPage( TabControlAdv tab )
        {
            Parent = Add( tab );
            Dock = ControlConfig.GetDockStyle( DockStyle.Fill );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="TabPage" />
        /// class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameter" ) ]
        public TabPage( Control parent )
            : this()
        {
            if( parent is TabControlAdv tab )
            {
                Parent = ControlConfig.GetParent( tab );
                Dock = ControlConfig.GetDockStyle( DockStyle.Fill );
            }
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="TabPage" />
        /// class.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="parent">The parent.</param>
        public TabPage( string title, Control parent )
            : this( parent )
        {
            Name = title;
            Text = Name;
        }

        // ***************************************************************************************************************************
        // ******************************************************   PROPERTIES   *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public Field Field { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Gets or sets the tip.
        /// </summary>
        /// <value>
        /// The tip.
        /// </value>
        public ToolTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the background color for the control.
        /// </summary>
        [ DefaultValue( typeof( Color ), "0F0F0F" ) ]
        public override Color BackColor { get; set; }

        // ***************************************************************************************************************************
        // *******************************************************      METHODS        ***********************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the parent.
        /// </summary>
        /// <param name="tabcontrol">The tabcontrol.</param>
        /// <returns></returns>
        [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameter" ) ]
        public Control Add( TabControlAdv tabcontrol )
        {
            if( tabcontrol != null )
            {
                try
                {
                    Parent = ControlConfig.GetParent( tabcontrol );
                    Parent.Controls.Add( this );
                    ( (TabPanel)Parent ).TabPages.Add( this );
                    return Parent;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return default;
        }

        /// <summary>
        /// Sets the color of the back.
        /// </summary>
        /// <param name="color">The color.</param>
        public void SetBackColor( Color color )
        {
            try
            {
                BackColor = ColorConfig.GetColor( color );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the color of the fore.
        /// </summary>
        /// <param name="color">The color.</param>
        public void SetForeColor( Color color )
        {
            if( color != Color.Empty )
            {
                try
                {
                    ForeColor = color;
                    TabForeColor = color;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the font.
        /// </summary>
        /// <param name="font">The font.</param>
        public void SetFont( Font font )
        {
            if( font != null )
            {
                try
                {
                    TabFont = font;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the border style.
        /// </summary>
        /// <param name="border">if set to
        /// <c> true </c>
        /// [border].</param>
        public void SetBorderStyle( bool border )
        {
            try
            {
                BorderStyle = border switch
                {
                    true => BorderStyle.FixedSingle,
                    false => BorderStyle.None
                };
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetText( string text )
        {
            try
            {
                Text = ControlConfig.GetText( text );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the data source.
        /// </summary>
        /// <param name="bindingsource">The bindingsource.</param>
        public void SetBindingSource( BindingSource bindingsource )
        {
            if( bindingsource?.DataSource != null )
            {
                try
                {
                    BindingSource = bindingsource;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the hover information.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetHoverText( string text )
        {
            if( Verify.Input( text ) )
            {
                try
                {
                    var _ = new ToolTip( this, text );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Adds the control item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void AddControl( Control item )
        {
            if( item != null )
            {
                try
                {
                    Controls?.Add( item );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name="field">The field.</param>
        public void SetField( Field field )
        {
            try
            {
                Field = FormConfig.GetField( field );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the anchor.
        /// </summary>
        /// <param name="anchor">The anchor.</param>
        public void SetAnchor( AnchorStyles anchor = AnchorStyles.Left & AnchorStyles.Top )
        {
            try
            {
                Anchor = ControlConfig.GetAnchorStyle( anchor );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the dock style.
        /// </summary>
        /// <param name="doc">The document.</param>
        public void SetDockStyle( DockStyle doc = DockStyle.None )
        {
            try
            {
                Dock = ControlConfig.GetDockStyle( doc );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        // ***************************************************************************************************************************
        // ****************************************************   EVENTS/DELEGATES  **************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Called when [right click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        public void OnRightClick( object sender, MouseEventArgs e )
        {
            try
            {
                using var message = new Message( "Not Yet Implemented." );
                message?.ShowDialog();
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [current changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnCurrentChanged( object sender, EventArgs e )
        {
            try
            {
                using var message = new Message( "Not Yet Implemented." );
                message?.ShowDialog();
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [hover].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnHover( object sender, EventArgs e )
        {
            try
            {
                if( Verify.Input( Text ) )
                {
                    SetHoverText( Text );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
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
