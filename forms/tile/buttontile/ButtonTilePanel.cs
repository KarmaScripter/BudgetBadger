// <copyright file = "ButtonTilePanel.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // **************************************************************************************************************************
    // ********************************************      ASSEMBLIES    **********************************************************
    // **************************************************************************************************************************

    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="TileConfig" />
    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    public class ButtonTilePanel : TileConfig, IButtonTile
    {
        // **************************************************************************************************************************
        // ********************************************   CONSTRUCTORS     **********************************************************
        // **************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ButtonTilePanel" />
        /// class.
        /// </summary>
        public ButtonTilePanel()
        {
            // Basic Properties
            TileType = HubTileType.DefaultTile;
            BackColor = ColorConfig.BackColorBlack;
            ForeColor = ColorConfig.ForeColorGray;
            Font = FontConfig.FontSizeSmall;
            Margin = ControlConfig.Margin;
            Padding = ControlConfig.Padding;
            Size = SizeConfig.GetSize( 200, 160 );
            TileSize = Size;
            Location = ControlConfig.GetLocation();
            Anchor = ControlConfig.GetAnchorStyle();
            Dock = ControlConfig.GetDockStyle();
            Title = new TextItem();
            Title.TextColor = ForeColor;
            Title.Font = FontConfig.FontSizeLarge;
            Footer = new TextItem();
            Footer.TextColor = ForeColor;
            Footer.Font = FontConfig.FontSizeMedium;
            Banner = new TextItem();
            ShowBanner = true;
            ShowBannerIcon = false;
            ShowRotateTileBanner = false;
            BannerHeight = 0;
            BannerColor = BackColor;
            Banner.TextColor = BackColor;
            Banner.Font = FontConfig.FontSizeSmall;
            EnableHoverColor = true;
            ExpandOnHover = true;
            HoverBorderLength = BorderConfig.SizeThin;
            HoveredBorderColor = ColorConfig.BackColorBlack;
            EnableTileSlideEffect = true;
            SlideTransition = TransitionDirection.RightToLeft;
            Visible = true;
            Enabled = true;

            // Event Wiring
            MouseHover += OnMouseHover;
            MouseLeave += OnMouseOut;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ButtonTilePanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="postion">The postion.</param>
        public ButtonTilePanel( Size size, Point postion )
            : this()
        {
            Size = SizeConfig.GetSize( size );
            TileSize = Size;
            Location = ControlConfig.GetLocation( postion );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ButtonTilePanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="postion">The postion.</param>
        /// <param name="parent">The parent.</param>
        public ButtonTilePanel( Size size, Point postion, Control parent )
            : this()
        {
            Parent = parent;
            Size = SizeConfig.GetSize( size );
            TileSize = Size;
            Location = ControlConfig.GetLocation( postion );
            Parent = ControlConfig.GetParent( parent );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ButtonTilePanel" />
        /// class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public ButtonTilePanel( Control parent )
            : this()
        {
            Parent = ControlConfig.GetParent( parent );
        }

        // **************************************************************************************************************************
        // ********************************************      METHODS    *************************************************************
        // **************************************************************************************************************************

        /// <summary>
        /// Activates the live tile.
        /// </summary>
        /// <param name="on">if set to
        /// <c> true </c>
        /// [on].</param>
        public void ActivateLiveTile( bool on )
        {
            if( TileType == HubTileType.DefaultTile )
            {
                try
                {
                    TurnLiveTileOn = on;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the slide transition.
        /// </summary>
        /// <param name="direction">The direction.</param>
        public void SetSlideDirection( TransitionDirection direction = TransitionDirection.RightToLeft )
        {
            if( Enum.IsDefined( typeof( TransitionDirection ), direction ) )
            {
                try
                {
                    EnableTileSlideEffect = true;
                    SlideTransition = direction;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the size of the banner.
        /// </summary>
        /// <param name="size">The size.</param>
        public void SetBannerSize( int size = 24 )
        {
            if( size > 0
                && ( TileType == HubTileType.DefaultTile || TileType == HubTileType.RotateTile ) )
            {
                try
                {
                    if( !ShowBanner )
                    {
                        ShowBanner = true;
                    }

                    BannerHeight = size;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the color of the banner.
        /// </summary>
        /// <param name="color">The color.</param>
        public void SetBannerColor( Color color )
        {
            if( color != Color.Empty
                && ( TileType == HubTileType.DefaultTile || TileType == HubTileType.RotateTile ) )
            {
                try
                {
                    if( !ShowBanner )
                    {
                        ShowBanner = true;
                    }

                    BannerColor = color;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the banner.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetBannerText( string text )
        {
            if( Verify.Input( text )
                && ( TileType == HubTileType.DefaultTile || TileType == HubTileType.RotateTile ) )
            {
                try
                {
                    if( !ShowBanner )
                    {
                        ShowBanner = true;
                    }

                    Banner = new TextItem
                    {
                        Text = text,
                        TextColor = Color.White,
                        Font = new Font( "Roboto", 8, FontStyle.Bold )
                    };

                    if( BannerIcon != null )
                    {
                        ShowBannerIcon = true;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the icon.
        /// </summary>
        /// <param name="imagepath">The imagepath.</param>
        /// <returns></returns>
        public Icon GetBannerIcon( string imagepath )
        {
            if( Verify.Input( imagepath )
                && TileType == HubTileType.DefaultTile )
            {
                try
                {
                    if( !ShowBanner )
                    {
                        ShowBanner = true;
                    }

                    if( !ShowBannerIcon )
                    {
                        ShowBannerIcon = true;
                    }

                    var image = new Icon( imagepath, 12, 12 );
                    Icon = image;
                    return Icon;
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
        /// Sets the image transition direction.
        /// </summary>
        /// <param name="slide">The slide.</param>
        public void SetImageDirection( TransitionDirection slide = TransitionDirection.RightToLeft )
        {
            if( Enum.IsDefined( typeof( TransitionDirection ), slide ) )
            {
                try
                {
                    SlideTransition = slide;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the image transition speed.
        /// </summary>
        /// <param name="speed">The speed.</param>
        public void SetImageSpeed( int speed = 1 )
        {
            if( speed > 0 )
            {
                try
                {
                    ImageTransitionSpeed = speed;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}
