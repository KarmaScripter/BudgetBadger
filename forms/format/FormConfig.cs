// <copyright file = "FormConfig.cs" company = "Terry D. Eppler">
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
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "AccessToStaticMemberViaDerivedType" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Global" ) ]
    public class FormConfig : ControlConfig
    {
        // ***************************************************************************************************************************
        // ****************************************************     FIELDS    ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Gets the minimum window.
        /// </summary>
        /// <value>
        /// The minimum window.
        /// </value>
        public static readonly FormWindowState MinimizedState = FormWindowState.Minimized;

        /// <summary>
        /// Gets the normal window.
        /// </summary>
        /// <value>
        /// The normal window.
        /// </value>
        public static readonly FormWindowState NormalState = FormWindowState.Normal;

        /// <summary>
        /// Gets the maximum window.
        /// </summary>
        /// <value>
        /// The maximum window.
        /// </value>
        public static readonly FormWindowState MaximizedState = FormWindowState.Maximized;

        /// <summary>
        /// Gets the center start.
        /// </summary>
        /// <value>
        /// The center start.
        /// </value>
        public static readonly FormStartPosition FormCentered = FormStartPosition.CenterScreen;

        /// <summary>
        /// The default location
        /// </summary>
        public static readonly FormStartPosition DefaultLocation = FormStartPosition.WindowsDefaultLocation;

        /// <summary>
        /// The form
        /// </summary>
        private protected static MetroForm Form;

        //***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the <see cref = "FormConfig"/> class.
        /// </summary>
        public FormConfig()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "FormConfig"/> class.
        /// </summary>
        /// <param name = "form" >
        /// The form.
        /// </param>
        public FormConfig( MetroForm form )
        {
            Form = form;
        }

        // ***************************************************************************************************************************
        // ******************************************************   PROPERTIES   *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Gets the height of the caption.
        /// </summary>
        /// <value>
        /// The height of the caption.
        /// </value>
        public static readonly int CaptionHeight = 26;

        /// <summary>
        /// Gets or sets the start position.
        /// </summary>
        /// <value>
        /// The start position.
        /// </value>
        public static readonly FormStartPosition StartPosition = FormStartPosition.CenterScreen;

        /// <summary>
        /// Gets or sets the tag.
        /// </summary>
        /// <value>
        /// The tag.
        /// </value>
        public object Tag { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        public Size Size { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public Field Field { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is visible.
        /// </summary>
        /// <value>
        /// <c>
        /// true
        /// </c>
        /// if this instance is visible; otherwise,
        /// <c>
        /// false
        /// </c>
        /// .
        /// </value>
        public virtual bool IsVisible { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether this instance is enabled.
        /// </summary>
        /// <value>
        /// <c>
        /// true
        /// </c>
        /// if this instance is enabled; otherwise,
        /// <c>
        /// false
        /// </c>
        /// .
        /// </value>
        public virtual bool IsEnabled { get; set; } = true;

        // ***************************************************************************************************************************
        // ************************************************  METHODS   ***************************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name = "field" >
        /// The field.
        /// </param>
        /// <returns>
        /// </returns>
        public static Field GetField( Field field )
        {
            if( Verify.Field( field ) )
            {
                try
                {
                    return field;
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
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name = "disposing" >
        /// <c>
        /// true
        /// </c>
        /// to release both managed and unmanaged resources;
        /// <c>
        /// false
        /// </c>
        /// to release only unmanaged resources.
        /// </param>
        protected void Dispose( bool disposing )
        {
            if( disposing )
            {
                try
                {
                    FontConfig.FontSizeSmall?.Dispose();
                    FontConfig.FontSizeMedium?.Dispose();
                    FontConfig.FontSizeLarge?.Dispose();
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or
        /// resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            try
            {
                Dispose( true );
                GC.SuppressFinalize( this );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
    }
}
