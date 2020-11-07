// <copyright file = "TabPanel.cs" company = "Terry D. Eppler">
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
    using System.Linq;
    using System.Windows.Forms;
    using MetroSet_UI.Enums;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ITabControl" />
    /// <seealso cref="Syncfusion.Windows.Forms.Tools.TabControlAdv" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public class TabPanel : TabControlAdv, ITabControl
    {
        // ***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="TabPanel" />
        /// class.
        /// </summary>
        /// <example>
        /// The following example creates a TabControlAdv with one TabPageAdv object. The constructor
        /// instantiates tabControl1. Use the Syncfusion.Windows.Forms.Tools namespace for this example.
        /// <code lang="C#">
        /// public Form1()
        /// {
        /// this.tabPage1 = new TabPageAdv();
        /// Invokes the TabControlAdv() constructor to create the tabControl1 object.
        /// this.tabControl1 = new TabControlAdv();
        /// this.tabControl1.Controls.Add(tabPage1);
        /// this.Controls.Add(tabControl1);
        /// }
        /// </code><code lang="VB">
        /// Public Sub New()
        /// Me.tabPage1 = New TabPageAdv()
        /// ' Invokes the TabControlAdv() constructor to create the tabControl1 object.
        /// Me.tabControl1 = New TabControlAdv()
        /// Me.tabControl1.Controls.Add(tabPage1)
        /// Me.Controls.Add(tabControl1)
        /// End Sub 'New
        /// </code></example>
        public TabPanel()
        {
            // Basic Properties
            Size = SizeConfig.GetSize( 600, 400 );
            Location = ControlConfig.GetLocation();
            Anchor = ControlConfig.GetAnchorStyle();
            Dock = ControlConfig.GetDockStyle();
            Visible = true;
            Enabled = true;
            BackColor = ColorConfig.FormDarkBackColor;
            ForeColor = ColorConfig.ForeGray;
            Font = FontConfig.FontSizeSmall;
            Margin = ControlConfig.Margin;

            // Style Configuration
            ItemSize = new Size( 120, 20 );
            TabPanelBackColor = ColorConfig.FormDarkBackColor;
            ActiveTabColor = ColorConfig.FormDarkBackColor;
            ActiveTabForeColor = ColorConfig.ForeGray;
            InactiveTabColor = ColorConfig.FormDarkBackColor;
            InActiveTabForeColor = ColorConfig.FormDarkBackColor;
            SeparatorColor = ColorConfig.FormDarkBackColor;
            FixedSingleBorderColor = ColorConfig.FormDarkBackColor;
            BorderColor = ColorConfig.FormDarkBackColor;
            BorderStyle = BorderStyle.None;
            BorderVisible = false;
            BorderWidth = 1;
            ActiveTabFont = FontConfig.FontSizeSmall;
            AdjustTopGap = 5;
            TabGap = 5;
            Alignment = TabAlignment.Top;
            ShowSeparator = false;
            ReserveTabSpace = true;
            ReservedSpace = 120;
            Multiline = false;
            MultilineText = false;
            TabStyle = typeof( TabRendererMetro );
            HotTrack = true;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="TabPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public TabPanel( Size size, Point location )
            : this()
        {
            Size = SizeConfig.GetSize( size );
            Location = ControlConfig.GetLocation( location );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="TabPanel" />
        /// class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public TabPanel( Control parent )
            : this()
        {
            Parent = ControlConfig.GetParent( parent );
            Parent.Controls.Add( this );
        }

        // ***************************************************************************************************************************
        // ******************************************************   PROPERTIES   *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Gets or sets the backcolor of the active tabs. Will be overridden by any individual Tab BackColor
        /// in the
        /// <see cref="T:Syncfusion.Windows.Forms.Tools.TabPageAdv" />
        /// instance, if any.
        /// </summary>
        /// <value>
        /// The Color value.
        /// </value>
        [ DefaultValue( typeof( Color ), "0F0F0F" ) ]
        public override Color ActiveTabColor { get; set; }

        /// <summary>
        /// Gets or sets the forecolor of the active tab page.
        /// </summary>
        /// <value>
        /// The default value is Color.Empty.
        /// </value>
        [ DefaultValue( typeof( Color ), "0F0F0F" ) ]
        public override Color ActiveTabForeColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the inactive Tabs. Will be overridden by any individual Tab BackColor in
        /// the
        /// <see cref="T:Syncfusion.Windows.Forms.Tools.TabPageAdv" />
        /// instance, if any.
        /// </summary>
        /// <value>
        /// The Color value.
        /// </value>
        [ DefaultValue( typeof( Color ), "0F0F0F" ) ]
        public override Color InactiveTabColor { get; set; }

        /// <summary>
        /// Gets or sets the forecolor of the inactive tab page.
        /// </summary>
        /// <value>
        /// The default value is Color.Empty.
        /// </value>
        [ DefaultValue( typeof( Color ), "0F0F0F" ) ]
        public override Color InActiveTabForeColor { get; set; }

        /// <summary>
        /// Gets or sets the background color for the control.
        /// </summary>
        [ DefaultValue( typeof( Color ), "0F0F0F" ) ]
        public override Color BackColor { get; set; }

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
        /// Gets or sets the children.
        /// </summary>
        /// <value>
        /// The children.
        /// </value>
        [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Local" ) ]
        private IList<Control> Children { get; } = new List<Control>();

        // ***************************************************************************************************************************
        // *******************************************************      METHODS        ***********************************************
        // ***************************************************************************************************************************

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
        /// Sets the border style.
        /// </summary>
        /// <param name="border">if set to
        /// <c> true </c>
        /// [border].</param>
        public void SetBorderStyle( bool border )
        {
            try
            {
                switch( border )
                {
                    case true:
                    {
                        BorderStyle = BorderStyle.FixedSingle;
                        BorderColor = ColorConfig.BorderYellow;
                        BorderVisible = true;
                        BorderWidth = BorderConfig.SizeThin;
                        break;
                    }

                    case false:
                    {
                        BorderStyle = BorderStyle.None;
                        BorderColor = ColorConfig.BorderYellow;
                        BorderVisible = false;
                        break;
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the table style.
        /// </summary>
        /// <param name="style">The style.</param>
        public void SetTabStyle( TabStyle style )
        {
            try
            {
                TabStyle = style.GetType();
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the size of the item.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public void SetItemSize( int width = 120, int height = 20 )
        {
            try
            {
                ItemSize = new Size( width, height );
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
            if( bindingsource.DataSource != null )
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
        /// Sets the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        public void SetTag( object tag )
        {
            try
            {
                Tag = ControlConfig.GetTag( tag );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Adds the tab.
        /// </summary>
        /// <param name="tab">The tab.</param>
        public void AddTab( TabPage tab )
        {
            if( tab != null )
            {
                try
                {
                    Controls.Add( tab );
                    TabPages.Add( tab );
                    Children.Add( tab );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Adds the tab.
        /// </summary>
        /// <param name="name">The name.</param>
        public void AddTab( string name )
        {
            if( Verify.Input( name ) )
            {
                try
                {
                    var tab = new TabPageAdv
                    {
                        Name = name,
                        Text = name
                    };

                    if( tab != null )
                    {
                        Controls.Add( tab );
                        TabPages.Add( tab );
                        Children.Add( tab );
                    }
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
        /// <returns></returns>
        public IEnumerable<Control> GetChildren()
        {
            try
            {
                return Children?.Any() == true
                    ? Children
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        // ***************************************************************************************************************************
        // ****************************************************   EVENTS/DELEGATES  **************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Called when [selected index changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        public void OnSelectedIndexChanged( object sender, EventArgs e )
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
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
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
