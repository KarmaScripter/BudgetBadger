// <copyright file="GalleryBase.cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // **************************************************************************************************************************
    // ********************************************      ASSEMBLIES    **********************************************************
    // **************************************************************************************************************************

    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.Tools.ImageStreamer" />
    public class StreamerBase : ImageStreamer
    {
        // **************************************************************************************************************************
        // ********************************************      PROPERTIES    **********************************************************
        // **************************************************************************************************************************

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

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public Field Field { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public IDictionary<string, object> DataFilter { get; set; }

        // **************************************************************************************************************************
        // ********************************************      METHODS    *************************************************************
        // **************************************************************************************************************************

        /// <summary>
        /// Sets the color of the internal back.
        /// </summary>
        /// <param name="color">The color.</param>
        public void SetInternalBackColor( Color color )
        {
            if( color != Color.Empty )
            {
                try
                {
                    InternalBackColor = color;
                }
                catch( Exception ex )
                {
                    using var error = new Error( ex );
                    error?.SetText();
                    error?.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Sets the back color configuration.
        /// </summary>
        /// <param name="color">The color.</param>
        public void SetBackColor( Color color )
        {
            if( color != Color.Empty )
            {
                try
                {
                    BackColor = color;
                }
                catch( Exception ex )
                {
                    using var error = new Error( ex );
                    error?.SetText();
                    error?.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Sets the animation speed.
        /// </summary>
        /// <param name="speed">The speed.</param>
        /// <returns></returns>
        public int SetAnimationSpeed( int speed = 10 )
        {
            if( speed > -1 )
            {
                try
                {
                    return speed;
                }
                catch( Exception ex )
                {
                    using var error = new Error( ex );
                    error?.SetText();
                    error?.ShowDialog();
                }
            }

            return -1;
        }

        /// <summary>
        /// Sets the slider speed.
        /// </summary>
        /// <param name="speed">The speed.</param>
        /// <returns></returns>
        public int SetSliderSpeed( int speed = 1000 )
        {
            if( speed > -1 )
            {
                try
                {
                    return speed;
                }
                catch( Exception ex )
                {
                    using var error = new Error( ex );
                    error?.SetText();
                    error?.ShowDialog();
                }
            }

            return -1;
        }

        /// <summary>
        /// Sets the main text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="font">The font.</param>
        public void SetMainText( string text, Font font )
        {
            if( Verify.Input( text )
                && font != null )
            {
                try
                {
                    MainText.BorderStyle = BorderStyle.None;
                    MainText.FlatStyle = FlatStyle.Flat;
                    MainText.TextAlign = ContentAlignment.TopLeft;
                    MainText.Font = font;
                    MainText.Text = text;
                }
                catch( Exception ex )
                {
                    using var error = new Error( ex );
                    error?.SetText();
                    error?.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Sets the sub text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="font">The font.</param>
        public void SetSubText( string text, Font font )
        {
            if( Verify.Input( text )
                && font != null )
            {
                try
                {
                    SubText.BorderStyle = BorderStyle.None;
                    SubText.FlatStyle = FlatStyle.Flat;
                    SubText.TextAlign = ContentAlignment.TopLeft;
                    SubText.Font = font;
                    SubText.Text = text;
                }
                catch( Exception ex )
                {
                    using var error = new Error( ex );
                    error?.SetText();
                    error?.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Sets the navigator.
        /// </summary>
        /// <param name="nav">if set to
        /// <c> true </c>
        /// [nav].</param>
        public void DisplayNavigator( bool nav = true )
        {
            if( true )
            {
                try
                {
                    ShowNavigator = nav;
                }
                catch( Exception ex )
                {
                    using var error = new Error( ex );
                    error?.SetText();
                    error?.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Sets the slide show.
        /// </summary>
        /// <param name="show">if set to
        /// <c> true </c>
        /// [show].</param>
        public void SetSlideShow( bool show = true )
        {
            if( true )
            {
                try
                {
                    SlideShow = true;
                }
                catch( Exception ex )
                {
                    using var error = new Error( ex );
                    error?.SetText();
                    error?.ShowDialog();
                }
            }
        }
    }
}