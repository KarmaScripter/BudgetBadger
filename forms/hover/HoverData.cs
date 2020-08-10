// <copyright file = "HoverData.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ******************************************************************************************************************************
    // ******************************************************   ASSEMBLIES   ********************************************************
    // ******************************************************************************************************************************

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="HoverBase" />
    /// <seealso cref="IHover" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    public class HoverInfo : HoverBase, IHover
    {
        // ***************************************************************************************************************************
        // ****************************************************    FIELDS     ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// The header information
        /// </summary>
        public readonly ToolTipInfo HeaderInfo;

        /// <summary>
        /// The body information
        /// </summary>
        public readonly ToolTipInfo BodyInfo;

        /// <summary>
        /// The footer information
        /// </summary>
        public readonly ToolTipInfo FooterInfo;

        // ***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="HoverInfo" />
        /// class.
        /// </summary>
        public HoverInfo()
        {
            // Basic Control Properties
            InitialDelay = 750;
            MaxWidth = 700;
            ToolTipDuration = 5;
            Style = SuperToolTipStyle.Office2013Style;
            VisualStyle = Appearance.Metro;
            UseFading = FadingType.Blend;
            GradientBackGround = true;
            MetroColor = ColorConfig.BackColorBlack;

            // Header Properties
            HeaderInfo = new ToolTipInfo();
            HeaderInfo.BackColor = ColorConfig.BackColorBlack;
            HeaderInfo.BorderColor = ColorConfig.BorderColorBlue;
            HeaderInfo.ForeColor = ColorConfig.ForeColorGray;
            HeaderInfo.Separator = true;
            HeaderInfo.Header.ForeColor = ColorConfig.ForeColorGray;
            HeaderInfo.Header.Font = FontConfig.FontSizeMedium;
            HeaderInfo.Header.TextAlign = ContentAlignment.MiddleCenter;
            HeaderInfo.Header.TextMargin = ControlConfig.Margin;
            HeaderInfo.Header.ImageAlign = ContentAlignment.MiddleLeft;
            HeaderInfo.Header.TextImageRelation = ToolTipTextImageRelation.ImageBeforeText;
            HeaderItems = new List<string>();

            // Body Properties
            BodyInfo = new ToolTipInfo();
            BodyInfo.BackColor = ColorConfig.BackColorBlack;
            BodyInfo.BorderColor = ColorConfig.BorderColorBlue;
            BodyInfo.ForeColor = ColorConfig.ForeColorGray;
            BodyInfo.Separator = true;
            BodyInfo.Body.ForeColor = ColorConfig.ForeColorGray;
            BodyInfo.Body.Font = FontConfig.FontSizeMedium;
            BodyInfo.Body.TextAlign = ContentAlignment.MiddleCenter;
            BodyInfo.Body.TextMargin = ControlConfig.Margin;
            BodyItems = new List<string>();

            // Footer Properties
            FooterInfo = new ToolTipInfo();
            FooterInfo.BackColor = ColorConfig.BackColorBlack;
            FooterInfo.BorderColor = ColorConfig.BorderColorBlue;
            FooterInfo.ForeColor = ColorConfig.ForeColorGray;
            FooterInfo.Separator = true;
            FooterInfo.Footer.ForeColor = ColorConfig.ForeColorGray;
            FooterInfo.Footer.Font = FontConfig.FontSizeSmall;
            FooterInfo.Footer.TextAlign = ContentAlignment.MiddleCenter;
            FooterInfo.Footer.TextMargin = ControlConfig.Margin;
            FooterItems = new List<string>();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="HoverInfo" />
        /// class.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="info">The information.</param>
        public HoverInfo( Component control, Info info )
            : this()
        {
            HeaderInfo.Header.Text = ControlConfig.GetText( info.Header );
            BodyInfo.Body.Text = ControlConfig.GetText( info.Body );
            FooterInfo.Footer.Text = ControlConfig.GetText( info.Footer );
        }

        // ***************************************************************************************************************************
        // *******************************************************      METHODS        ***********************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the fading.
        /// </summary>
        /// <param name="fade">The fade.</param>
        public void SetFading( FadingType fade = FadingType.Blend )
        {
            if( Enum.IsDefined( typeof( FadingType ), fade ) )
            {
                try
                {
                    UseFading = fade;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the duration.
        /// </summary>
        /// <param name="seconds">The seconds.</param>
        public void SetDuration( int seconds = 5 )
        {
            if( seconds > 0 )
            {
                try
                {
                    ToolTipDuration = seconds;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the tool tip style.
        /// </summary>
        /// <param name="style">The style.</param>
        public void SetToolTipStyle( SuperToolTipStyle style = SuperToolTipStyle.Office2013Style )
        {
            if( Enum.IsDefined( typeof( SuperToolTipStyle ), style ) )
            {
                try
                {
                    Style = style;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the visual style.
        /// </summary>
        /// <param name="visualstyle">The visualstyle.</param>
        public void SetVisualStyle( Appearance visualstyle = Appearance.Metro )
        {
            if( Enum.IsDefined( typeof( Appearance ), visualstyle ) )
            {
                try
                {
                    VisualStyle = visualstyle;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Gets the header information.
        /// </summary>
        /// <returns></returns>
        public ToolTipInfo GetHeaderInfo()
        {
            try
            {
                return HeaderInfo;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Adds the header item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void AddHeaderItem( string item )
        {
            if( Verify.Input( item ) )
            {
                try
                {
                    HeaderItems?.Add( item );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Gets the body information.
        /// </summary>
        /// <returns></returns>
        public ToolTipInfo GetBodyInfo()
        {
            try
            {
                return BodyInfo;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Adds the body item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void AddBodyItem( string item )
        {
            if( Verify.Input( item ) )
            {
                try
                {
                    BodyItems?.Add( item );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Gets the footer information.
        /// </summary>
        /// <returns></returns>
        public ToolTipInfo GetFooterInfo()
        {
            try
            {
                return FooterInfo;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Adds the footer item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void AddFooterItem( string item )
        {
            if( Verify.Input( item ) )
            {
                try
                {
                    FooterItems?.Add( item );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the tool tip information.
        /// </summary>
        /// <param name="control">The control.</param>
        public void SetText( Component control )
        {
            if( control != null )
            {
                try
                {
                    if( Verify.Input( HeaderInfo?.Header?.Text ) )
                    {
                        SetToolTip( control, HeaderInfo );
                    }

                    if( Verify.Input( BodyInfo?.Body?.Text ) )
                    {
                        SetToolTip( control, BodyInfo );
                    }

                    if( Verify.Input( FooterInfo?.Footer?.Text ) )
                    {
                        SetToolTip( control, FooterInfo );
                    }
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
            if( Enum.IsDefined( typeof( Field ), field ) )
            {
                try
                {
                    Field = field;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}
