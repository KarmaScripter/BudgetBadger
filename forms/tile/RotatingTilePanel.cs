// <copyright file = "RotatingTilePanel.cs" company = "Terry D. Eppler">
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
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="TileConfig" />
    /// <seealso cref="HubTile" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Local" ) ]
    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    public class RotatingPanel : TileConfig, IRotatingTile
    {
        // ***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ButtonTilePanel" />
        /// class.
        /// </summary>
        public RotatingPanel()
        {
            TileType = HubTileType.RotateTile;
            BackColor = ColorConfig.FormDarkBackColor;
            ForeColor = ColorConfig.ForeGray;
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
            ShowRotateTileBanner = true;
            BannerHeight = 0;
            BannerColor = BackColor;
            Banner.TextColor = BackColor;
            Banner.Font = FontConfig.FontSizeSmall;
            RotationTransitionSpeed = 1;
            RotationTransition = TileFlipDirection.Horizontal;
            EnableHoverColor = true;
            ExpandOnHover = false;
            HoverBorderLength = BorderConfig.SizeThin;
            HoveredBorderColor = ColorConfig.FormDarkBackColor;
            EnableTileSlideEffect = false;
            SlideTransition = TransitionDirection.RightToLeft;
            TurnLiveTileOn = false;
            Visible = true;
            Enabled = true;
            MouseHover += OnMouseHover;
            MouseLeave += OnMouseOut;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="TileConfig" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="position">The position.</param>
        public RotatingPanel( Size size, Point position )
            : this()
        {
            Size = SizeConfig.GetSize( size );
            TileSize = Size;
            Location = ControlConfig.GetLocation( position );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="RotatingPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="position">The position.</param>
        /// <param name="parent">The parent.</param>
        public RotatingPanel( Size size, Point position, Control parent )
            : this()
        {
            Size = SizeConfig.GetSize( size );
            TileSize = Size;
            Location = ControlConfig.GetLocation( position );
            Parent = ControlConfig.GetParent( parent );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="RotatingPanel" />
        /// class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public RotatingPanel( Control parent )
            : this()
        {
            Parent = ControlConfig.GetParent( parent );
        }

        // ***************************************************************************************************************************
        // *******************************************************      METHODS        ***********************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the rotation speed.
        /// </summary>
        /// <param name="speed">The speed.</param>
        public void SetRotationSpeed( int speed = 0 )
        {
            if( speed > -1
                && TileType == HubTileType.RotateTile )
            {
                try
                {
                    RotationTransitionSpeed = speed;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the rotate flip direction.
        /// </summary>
        /// <param name="direction">The direction.</param>
        public void SetFlipDirection( TileFlipDirection direction = TileFlipDirection.Horizontal )
        {
            if( Enum.IsDefined( typeof( TileFlipDirection ), direction ) )
            {
                try
                {
                    RotationTransition = direction;
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
                    if( !ShowRotateTileBanner )
                    {
                        ShowRotateTileBanner = true;
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
                    if( !ShowRotateTileBanner )
                    {
                        ShowRotateTileBanner = true;
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
                    if( !ShowRotateTileBanner )
                    {
                        ShowRotateTileBanner = true;
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
