// // <copyright file = "IPulsingTile.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System.Threading;
    using Syncfusion.Windows.Forms.Tools;

    public interface IPulsingTile : ITile
    {
        // ***************************************************************************************************************************
        // ****************************************************    MEMBERS    ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the duration of the pulse.
        /// </summary>
        /// <param name="duration">The duration.</param>
        void SetPulseDuration( int duration = 2 );

        /// <summary>
        /// Sets the duration of the pulse.
        /// </summary>
        /// <param name="scale">The scale.</param>
        void SetPulseScale( int scale = 2 );

        /// <summary>
        /// Sets the image transition direction.
        /// </summary>
        /// <param name="slide">The slide.</param>
        void SetImageDirection( TransitionDirection slide = TransitionDirection.RightToLeft );

        /// <summary>
        /// Sets the image transition speed.
        /// </summary>
        /// <param name="speed">The speed.</param>
        void SetImageSpeed( int speed = 3 );
    }
}