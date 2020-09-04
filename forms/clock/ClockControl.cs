// <copyright file="{ClassName}.cs" company="Terry D. Eppler">
// Copyright (c) Eppler. All rights reserved.
// </copyright>

using System.Drawing;
using Syncfusion.Windows.Forms.Tools;

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;

    public partial class ClockControl : ControlBase, IClock
    {
        // ***************************************************************************************************************************
        // ****************************************************  CONSTRUCTORS ********************************************************
        // ***************************************************************************************************************************

        public ClockControl()
        {
            InitializeComponent();
        }

        // ***************************************************************************************************************************
        // ****************************************************    METHODS    ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the color of the hour.
        /// </summary>
        /// <param name="color">The color.</param>
        public void SetHourColor( Color color )
        {
            Clock.SetHourColor( color );
        }

        /// <summary>
        /// Sets the color of the minute.
        /// </summary>
        /// <param name="color">The color.</param>
        public void SetMinuteColor( Color color )
        {
            Clock.SetMinuteColor( color );
        }

        /// <summary>
        /// Sets the color of the second.
        /// </summary>
        /// <param name="color">The color.</param>
        public void SetSecondColor( Color color )
        {
            Clock.SetSecondColor( color );
        }

        /// <summary>
        /// Sets the color of the border.
        /// </summary>
        /// <param name="color">The color.</param>
        public void SetBorderColor( Color color )
        {
            Clock.SetBorderColor( color );
        }

        /// <summary>
        /// Sets the clock frame.
        /// </summary>
        /// <param name="frame">The frame.</param>
        public void SetClockFrame( ClockFrames frame = ClockFrames.RectangularFrame )
        {
            Clock.SetClockFrame( frame );
        }

        /// <summary>
        /// Sets the clock style.
        /// </summary>
        /// <param name="style">The style.</param>
        public void SetClockStyle( ClockVisualStyle style = ClockVisualStyle.OfficeBlack )
        {
            Clock.SetClockStyle( style );
        }

        /// <summary>
        /// Sets the time.
        /// </summary>
        public void SetTime()
        {
            Clock.SetTime();
        }
    }
}
