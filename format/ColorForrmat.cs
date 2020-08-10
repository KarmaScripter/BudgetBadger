// <copyright file = "ColorForrmat.cs" company = "Terry D. Eppler">
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
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public class ColorFormat
    {
        // **************************************************************************************************************************
        // ********************************************   CONSTRUCTORS     **********************************************************
        // **************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the <see cref = "ColorFormat"/> class.
        /// </summary>
        public ColorFormat()
        {
        }

        // ***************************************************************************************************************************
        // ****************************************************  PROPERTIES   ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Gets or sets the font.
        /// </summary>
        /// <value>
        /// The font.
        /// </value>
        public IEnumerable<Font> Font { get; set; }

        /// <summary>
        /// Gets or sets the color of the hover.
        /// </summary>
        /// <value>
        /// The color of the hover.
        /// </value>
        public Color HoverColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the back.
        /// </summary>
        /// <value>
        /// The color of the back.
        /// </value>
        public Color BackColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the fore.
        /// </summary>
        /// <value>
        /// The color of the fore.
        /// </value>
        public Color ForeColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the border.
        /// </summary>
        /// <value>
        /// The color of the border.
        /// </value>
        public Color BorderColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the border hover.
        /// </summary>
        /// <value>
        /// The color of the border hover.
        /// </value>
        public Color BorderHoverColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the item.
        /// </summary>
        /// <value>
        /// The color of the item.
        /// </value>
        public Color ItemColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the hovered item back.
        /// </summary>
        /// <value>
        /// The color of the hovered item back.
        /// </value>
        public Color HoveredItemBackColor { get; set; }

        /// <summary>
        /// Gets or sets the hovered item colorv.
        /// </summary>
        /// <value>
        /// The hovered item colorv.
        /// </value>
        public Color HoveredItemColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the selected item back.
        /// </summary>
        /// <value>
        /// The color of the selected item back.
        /// </value>
        public Color SelectedItemBackColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the selected item.
        /// </summary>
        /// <value>
        /// The color of the selected item.
        /// </value>
        public Color SelectedItemColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the enabled.
        /// </summary>
        /// <value>
        /// The color of the enabled.
        /// </value>
        public Color EnabledColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the disabled.
        /// </summary>
        /// <value>
        /// The color of the disabled.
        /// </value>
        public Color DisabledColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the pressed.
        /// </summary>
        /// <value>
        /// The color of the pressed.
        /// </value>
        public Color PressedColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the font.
        /// </summary>
        /// <value>
        /// The color of the font.
        /// </value>
        public Color FontColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the text.
        /// </summary>
        /// <value>
        /// The color of the text.
        /// </value>
        public Color TextColor { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        public IEnumerable<Size> Size { get; set; }
    }
}