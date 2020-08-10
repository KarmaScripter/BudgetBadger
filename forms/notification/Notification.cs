// <copyright file = "Notification.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ******************************************************************************************************************************
    // ******************************************************   ASSEMBLIES   ********************************************************
    // ******************************************************************************************************************************

    using System;
    using System;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="SplashConfig" />
    /// <seealso />
    public class Notification : SplashConfig
    {
        // **************************************************************************************************************************
        // ********************************************   CONSTRUCTORS     **********************************************************
        // **************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Notification" />
        /// class.
        /// </summary>
        /// <remarks>
        /// The default value for the
        /// <see cref="P:Syncfusion.Windows.Forms.Tools.SplashPanel.TimerInterval" />
        /// is set to 5000 milli seconds. The splash panel has animation turned and by default will appear in
        /// the middle of the screen.
        /// </remarks>
        public Notification()
        {
            // Basic Properties
            TabIndex = 0;
            AllowMove = true;
            AllowResize = true;
            ShowInTaskbar = true;
            CloseOnClick = true;
            ShowAsTopMost = true;
            ShowAnimation = true;
            Font = FontConfig.GetFont();
            ForeColor = ColorConfig.GetColor( Color.White );
            Location = ControlConfig.GetLocation();
            TransparentColor = ColorConfig.GetColor( Color.White );

            // Color Configuration
            BackColor = ColorConfig.BackColorBlack;
            BackgroundColor = new BrushInfo( GradientStyle.PathRectangle, Color.AliceBlue, Color.SteelBlue );

            // Border COnfiguration
            BorderStyle = Border3DStyle.Flat;
            BorderType = SplashBorderType.Border3D;

            // Animation Configuration
            AnimationSpeed = 30;
            AnimationDirection = AnimationDirection.RightToLeft;
            SlideStyle = SlideStyle.FadeIn;
            TimerInterval = 7000;
            SuspendAutoCloseWhenMouseOver = false;
            DesktopAlignment = SplashAlignment.SystemTray;

            // Event Wiring
            SplashDisplayed += OnDisplayed;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Notification" />
        /// class.
        /// </summary>
        /// <param name="text">The text displayed by the control.</param>
        public Notification( string text )
            : this()
        {
            Text = text;
        }

        // ***************************************************************************************************************************
        // ****************************************************     METHODS   ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the color of the gradient.
        /// </summary>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        /// <param name="style">The style.</param>
        public void SetBackgroundGradient( Color start, Color end,
            GradientStyle style = GradientStyle.PathRectangle )
        {
            if( Enum.IsDefined( typeof( GradientStyle ), style )
                && start != Color.Empty
                && end != Color.Empty )
            {
                try
                {
                    BackgroundColor = new BrushInfo( GradientStyle.PathRectangle, Color.AliceBlue,
                        Color.SteelBlue );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
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
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the color of the back.
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
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the border configuration.
        /// </summary>
        /// <param name="style">The style.</param>
        /// <param name="type">The type.</param>
        public void SetBorderStyle( Border3DStyle style = Border3DStyle.Flat,
            SplashBorderType type = SplashBorderType.Border3D )
        {
            if( Enum.IsDefined( typeof( Border3DStyle ), style )
                && Enum.IsDefined( typeof( SplashBorderType ), type ) )
            {
                try
                {
                    BorderStyle = style;
                    BorderType = type;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the animation speed.
        /// </summary>
        /// <param name="speed">The speed.</param>
        public void SetAnimationSpeed( int speed = 30 )
        {
            if( speed > 0
                && speed < 100 )
            {
                try
                {
                    AnimationSpeed = speed;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the animation direction.
        /// </summary>
        /// <param name="direction">The direction.</param>
        public void SetAnimationDirection( AnimationDirection direction = AnimationDirection.RightToLeft )
        {
            if( Enum.IsDefined( typeof( AnimationDirection ), direction ) )
            {
                try
                {
                    AnimationDirection = direction;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the slide style.
        /// </summary>
        /// <param name="slidestyle">The slidestyle.</param>
        public void SetSlideStyle( SlideStyle slidestyle = SlideStyle.FadeIn )
        {
            if( Enum.IsDefined( typeof( SlideStyle ), slidestyle ) )
            {
                try
                {
                    SlideStyle = slidestyle;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the time interval.
        /// </summary>
        /// <param name="time">The time.</param>
        public void SetTimeInterval( int time = 7000 )
        {
            if( time > 0
                && time < 10000 )
            {
                try
                {
                    TimerInterval = time;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the desk top a lignment.
        /// </summary>
        /// <param name="alignment">The alignment.</param>
        public void SetDeskTopAlignment( SplashAlignment alignment = SplashAlignment.RightBottom )
        {
            if( Enum.IsDefined( typeof( SplashAlignment ), alignment ) )
            {
                try
                {
                    DesktopAlignment = alignment;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}
