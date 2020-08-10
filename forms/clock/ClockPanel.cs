// <copyright file = "ClockPanel.cs" company = "Terry D. Eppler">
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
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.Tools.Clock" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class ClockPanel : Clock
    {
        // ***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ClockPanel" />
        /// class.
        /// </summary>
        public ClockPanel()
        {
            BackColor = ColorConfig.BackColorBlack;
            BorderColor = BackColor;
            ForeColor = ColorConfig.ForeColorGray;
            Font = FontConfig.FontSizeSmall;
            Margin = ControlConfig.Margin;
            Padding = ControlConfig.Padding;
            ClockShape = ClockShapes.Rectangle;
            ClockType = ClockTypes.Digital;
            DisplayDates = true;
            Now = DateTime.Now;
            ShowBorder = false;
            ShowClockFrame = false;
            ShowHourDesignator = true;
            ShowMinute = true;
            ShowSecondHand = true;
            HourHandColor = ColorConfig.ForeColorGray;
            MinuteColor = ColorConfig.ForeColorGray;
            SecondHandColor = ColorConfig.ForeColorGray;
            VisualStyle = ClockVisualStyle.None;
            Location = ControlConfig.GetLocation();
            Dock = ControlConfig.GetDockStyle();
            Anchor = ControlConfig.GetAnchorStyle();
            Visible = true;
            Enabled = true;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ClockPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public ClockPanel( Size size, Point location )
            : this()
        {
            Size = SizeConfig.GetSize( size.Width, size.Height );
            Location = ControlConfig.GetLocation( location.X, location.Y );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ClockPanel" />
        /// class.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <param name="size">The size.</param>
        /// <param name="parent">The parent.</param>
        public ClockPanel( Point location, Size size, Control parent )
            : this( size, location )
        {
            Parent = ControlConfig.GetParent( parent );
        }

        // **********************************************************************************************************************
        // *************************************************   PROPERTIES   *****************************************************
        // **********************************************************************************************************************

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public ToolTip ToolTip { get; set; }

        // ***************************************************************************************************************************
        // *******************************************************      METHODS        ***********************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the color of the hour.
        /// </summary>
        /// <param name="color">The color.</param>
        public void SetHourColor( Color color )
        {
            if( color != null )
            {
                try
                {
                    if( ShowHourDesignator == false )
                    {
                        ShowHourDesignator = true;
                    }

                    HourHandColor = color;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the color of the minute.
        /// </summary>
        /// <param name="color">The color.</param>
        public void SetMinuteColor( Color color )
        {
            if( color != null )
            {
                try
                {
                    if( ShowMinute == false )
                    {
                        ShowMinute = true;
                    }

                    MinuteColor = color;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the color of the second.
        /// </summary>
        /// <param name="color">The color.</param>
        public void SetSecondColor( Color color )
        {
            if( color != null )
            {
                try
                {
                    if( ShowSecondHand == false )
                    {
                        ShowSecondHand = true;
                    }

                    SecondHandColor = color;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the color of the border.
        /// </summary>
        /// <param name="color">The color.</param>
        public void SetBorderColor( Color color )
        {
            if( color != Color.Empty )
            {
                try
                {
                    if( ShowBorder == false )
                    {
                        ShowBorder = true;
                    }

                    BorderColor = color;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the clock frame.
        /// </summary>
        /// <param name="frame">The frame.</param>
        public void SetClockFrame( ClockFrames frame = ClockFrames.RectangularFrame )
        {
            if( Enum.IsDefined( typeof( ClockFrames ), frame ) )
            {
                try
                {
                    if( ShowClockFrame == false )
                    {
                        ShowClockFrame = true;
                    }

                    ClockFrame = frame;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the clock style.
        /// </summary>
        /// <param name="style">The style.</param>
        public void SetClockStyle( ClockVisualStyle style = ClockVisualStyle.OfficeBlack )
        {
            if( Enum.IsDefined( typeof( ClockVisualStyle ), style ) )
            {
                try
                {
                    VisualStyle = style;
                }
                catch( Exception e )
                {
                    Console.WriteLine( e );
                    throw;
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
