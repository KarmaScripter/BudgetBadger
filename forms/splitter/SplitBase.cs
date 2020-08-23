// <copyright file = "SplitBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // **************************************************************************************************************************
    // ********************************************      ASSEMBLIES    **********************************************************
    // **************************************************************************************************************************

    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.SplitContainer" />
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public class SplitBase : SplitContainer
    {
        // **********************************************************************************************************************
        // *************************************************   PROPERTIES   *****************************************************
        // **********************************************************************************************************************

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
        /// Gets or sets the left panel.
        /// </summary>
        /// <value>
        /// The left panel.
        /// </value>
        public SplitterPanel LeftPanel { get; set; }

        /// <summary>
        /// Gets or sets the right panel.
        /// </summary>
        /// <value>
        /// The right panel.
        /// </value>
        public SplitterPanel RightPanel { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public ToolTip ToolTip { get; set; }

        // ***************************************************************************************************************************
        // ************************************************  METHODS   ***************************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Adds the control item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void AddLeftPanelChild( Control item )
        {
            if( item != null
                && item.GetType() == typeof( LayoutPanel ) )
            {
                try
                {
                    Panel1?.Controls?.Add( item );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Adds the right panel child.
        /// </summary>
        /// <param name="item">The item.</param>
        public void AddRightPanelChild( Control item )
        {
            if( item != null
                && item.GetType() == typeof( LayoutPanel ) )
            {
                try
                {
                    Panel2?.Controls?.Add( item );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the splitter distance.
        /// </summary>
        /// <param name="distance">The distance.</param>
        public void SetSplitterDistance( int distance )
        {
            if( distance > 0
                && distance <= Size.Width )
            {
                try
                {
                    SplitterDistance = distance;
                    Panel2.Size = new Size( Size.Width / 4, Height );
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
        /// Adds the control item.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Control> GetChildren()
        {
            if( Controls?.Count > 0 )
            {
                try
                {
                    var children = new List<Control>();

                    foreach( var item in Controls )
                    {
                        if( item != null )
                        {
                            children.Add( item as Control );
                        }
                    }

                    return children.Any()
                        ? children
                        : default;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
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
