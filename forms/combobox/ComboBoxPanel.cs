// <copyright file = "ComboBoxPanel.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ******************************************************************************************************************************
    // ******************************************************   ASSEMBLIES   ********************************************************
    // ******************************************************************************************************************************

    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Drawing.Text;
    using System.Threading;
    using System.Windows.Forms;
    using VisualPlus.Enumerators;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox" />
    /// <seealso cref="IComboBox" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class ComboBoxPanel : ComboBoxData, IComboBox
    {
        // ***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ComboBoxPanel" />
        /// class.
        /// </summary>
        public ComboBoxPanel()
        {
            // Basic Property Configuration
            Size = SizeConfig.GetSize( 180, 22 );
            Location = ControlConfig.GetLocation();
            Font = FontConfig.FontSizeSmall;
            Margin = ControlConfig.Margin;
            ForeColor = ColorConfig.ForeColorGray;
            BackColor = ColorConfig.ControlInteriorBlack;
            BackColorState.Disabled = ColorConfig.BackColorBlack;
            BackColorState.Enabled = ColorConfig.ControlInteriorBlack;
            Dock = ControlConfig.GetDockStyle();
            Anchor = ControlConfig.GetAnchorStyle();
            Visible = true;
            Enabled = true;

            // Border Configuration
            Border.Visible = true;
            Border.Color = ColorConfig.BorderColorGray;
            Border.HoverVisible = true;
            Border.HoverColor = ColorConfig.BorderColorBlue;
            Border.Type = ShapeTypes.Rounded;
            Border.Rounding = 1;
            Border.Thickness = 1;

            // Menu Item Configuration.
            MenuItemHover = ColorConfig.ControlHoverGray;
            MenuItemNormal = ColorConfig.BackColorBlack;
            ItemHeight = 24;
            DropDownStyle = ComboBoxStyle.DropDownList;
            DropDownHeight = 100;
            DropDownWidth = 200;
            MaxDropDownItems = 100;
            MenuTextColor = ColorConfig.ForeColorGray;

            // Style Configuration
            DrawMode = DrawMode.OwnerDrawVariable;
            ButtonStyle = ButtonStyles.Arrow;
            ButtonColor = ColorConfig.ForeColorGray;
            ButtonWidth = 22;
            SeparatorVisible = false;
            FlatStyle = FlatStyle.Flat;
            Enabled = true;
            TextAlignment = AlignConfig.StringCenter;
            TextLineAlignment = AlignConfig.StringCenter;
            TextRendering = TextRenderingHint.ClearTypeGridFit;
            TextImageRelation = TextImageRelation.ImageBeforeText;
            MouseHover += OnMouseHover;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ComboBoxPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public ComboBoxPanel( Size size, Point location )
            : this()
        {
            Size = SizeConfig.GetSize( size.Width, size.Height );
            Location = ControlConfig.GetLocation( location.X, location.Y );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ComboBoxPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public ComboBoxPanel( Size size, Point location, Control parent )
            : this( size, location )
        {
            Parent = ControlConfig.GetParent( parent );
            Parent.Controls.Add( this );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ComboBoxPanel" />
        /// class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public ComboBoxPanel( Control parent )
            : this()
        {
            Parent = ControlConfig.GetParent( parent );
            Parent.Controls.Add( this );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ComboBoxPanel" />
        /// class.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="filter">The column.</param>
        public ComboBoxPanel( IEnumerable<DataRow> data, string filter )
            : this()
        {
            DisplayMember = filter;
            DataSource = BindingSource.DataSource;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ComboBoxPanel" />
        /// class.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        public ComboBoxPanel( IEnumerable<DataRow> data, Field field )
            : this()
        {
            Field = field;
            DisplayMember = Field.ToString();
            DataSource = BindingSource.DataSource;
        }

        // **********************************************************************************************************************
        // *************************************************   PROPERTIES   *****************************************************
        // **********************************************************************************************************************

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
        // *******************************************************      METHODS        ***********************************************
        // ***************************************************************************************************************************

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
                    HoverText = text;
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
        /// <param name="text">The text.</param>
        public void SetToolTip( string text )
        {
            try
            {
                ToolTip = ControlConfig.GetToolTip( this, text );
                MouseHover += OnMouseHover;
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

        // ***************************************************************************************************************************
        // ****************************************************   EVENTS/DELEGATES  **************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Called when [hover].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        public void OnMouseHover( object sender, EventArgs e )
        {
            if( sender is ComboBoxPanel combobox )
            {
                try
                {
                    if( Verify.Input( HoverText ) )
                    {
                        var _ = new ToolTip( combobox, HoverText );
                    }
                    else
                    {
                        if( Verify.Input( Tag?.ToString() ) )
                        {
                            var _ = new ToolTip( combobox, Tag?.ToString().SplitPascal() );
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