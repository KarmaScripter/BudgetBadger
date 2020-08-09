// <copyright file="SizeFomat.cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // **************************************************************************************************************************
    // ********************************************      ASSEMBLIES    **********************************************************
    // **************************************************************************************************************************

    using System;
    using System.Drawing;
    using System.Threading;

    public class SizeFormat
    {
        // **************************************************************************************************************************
        // ********************************************   CONSTRUCTORS     **********************************************************
        // **************************************************************************************************************************

        public SizeFormat()
        {
        }

        // ***************************************************************************************************************************
        // ****************************************************  PROPERTIES   ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Gets or sets the size of the client.
        /// </summary>
        /// <value>
        /// The size of the client.
        /// </value>
        public Size ClientSize { get; set; }

        /// <summary>
        /// Gets or sets the size of the image.
        /// </summary>
        /// <value>
        /// The size of the image.
        /// </value>
        public Size ImageSize { get; set; }

        /// <summary>
        /// Gets or sets the context menu.
        /// </summary>
        /// <value>
        /// The context menu.
        /// </value>
        public Size ContextMenu { get; set; }

        /// <summary>
        /// Gets or sets the form maximum.
        /// </summary>
        /// <value>
        /// The form maximum.
        /// </value>
        public Size FormMaximum { get; set; }

        /// <summary>
        /// Gets or sets the form minimum.
        /// </summary>
        /// <value>
        /// The form minimum.
        /// </value>
        public Size FormMinimum { get; set; }

        /// <summary>
        /// Gets or sets the form nomral.
        /// </summary>
        /// <value>
        /// The form nomral.
        /// </value>
        public Size FormNomral { get; set; }

        /// <summary>
        /// Gets or sets the dialog maximum.
        /// </summary>
        /// <value>
        /// The dialog maximum.
        /// </value>
        public Size DialogMaximum { get; set; }

        /// <summary>
        /// Gets or sets the dialog minimum.
        /// </summary>
        /// <value>
        /// The dialog minimum.
        /// </value>
        public Size DialogMinimum { get; set; }

        /// <summary>
        /// Gets or sets the dialog normal.
        /// </summary>
        /// <value>
        /// The dialog normal.
        /// </value>
        public Size DialogNormal { get; set; }

        /// <summary>
        /// Gets or sets the image small.
        /// </summary>
        /// <value>
        /// The image small.
        /// </value>
        public Size ImageSmall { get; set; }

        /// <summary>
        /// Gets or sets the image medium.
        /// </summary>
        /// <value>
        /// The image medium.
        /// </value>
        public Size ImageMedium { get; set; }

        /// <summary>
        /// Gets or sets the image large.
        /// </summary>
        /// <value>
        /// The image large.
        /// </value>
        public Size ImageLarge { get; set; }

        /// <summary>
        /// Gets or sets the image huge.
        /// </summary>
        /// <value>
        /// The image huge.
        /// </value>
        public Size ImageHuge { get; set; }

        /// <summary>
        /// Gets or sets the bounds.
        /// </summary>
        /// <value>
        /// The bounds.
        /// </value>
        public Size Bounds { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        public int Height { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        public int Width { get; set; }
    }
}