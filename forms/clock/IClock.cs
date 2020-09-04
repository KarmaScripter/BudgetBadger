// // <copyright file = "IClock.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

using System.Drawing;
using Syncfusion.Windows.Forms.Tools;

namespace BudgetExecution
{
    public interface IClock
    {
        /// <summary>
        /// Sets the color of the hour.
        /// </summary>
        /// <param name="color">The color.</param>
        void SetHourColor( Color color );

        /// <summary>
        /// Sets the color of the minute.
        /// </summary>
        /// <param name="color">The color.</param>
        void SetMinuteColor( Color color );

        /// <summary>
        /// Sets the color of the second.
        /// </summary>
        /// <param name="color">The color.</param>
        void SetSecondColor( Color color );

        /// <summary>
        /// Sets the color of the border.
        /// </summary>
        /// <param name="color">The color.</param>
        void SetBorderColor( Color color );

        /// <summary>
        /// Sets the clock frame.
        /// </summary>
        /// <param name="frame">The frame.</param>
        void SetClockFrame( ClockFrames frame = ClockFrames.RectangularFrame );

        /// <summary>
        /// Sets the clock style.
        /// </summary>
        /// <param name="style">The style.</param>
        void SetClockStyle( ClockVisualStyle style = ClockVisualStyle.OfficeBlack );

        void SetTime();
    }
}
