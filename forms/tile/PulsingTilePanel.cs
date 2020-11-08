// <copyright file = "PulsingTilePanel.cs" company = "Terry D. Eppler">
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
    public class PulsingPanel : TileConfig, IPulsingTile
    {
        // ***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="TileConfig" />
        /// class.
        /// </summary>
        public PulsingPanel()
        {
            // Basic Properties
            TileType = HubTileType.PulsingTile;
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
            ShowBanner = true;
            ShowBannerIcon = false;
            ShowRotateTileBanner = false;
            BannerHeight = 0;
            BannerColor = Color.Empty;
            Banner.TextColor = Color.Empty;
            Banner.Font = FontConfig.FontSizeSmall;
            PulseDuration = 1;
            PulseScale = 2;
            ExpandOnHover = false;
            EnableHoverColor = true;
            HoverBorderLength = BorderConfig.Thin;
            HoveredBorderColor = ColorConfig.FormDarkBackColor;
            EnableTileSlideEffect = true;
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
        /// <param name="postion">The postion.</param>
        public PulsingPanel( Size size, Point postion )
            : this()
        {
            Size = SizeConfig.GetSize( size );
            TileSize = Size;
            Location = ControlConfig.GetLocation( postion );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="TileConfig" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="position">The position.</param>
        /// <param name="parent">The parent.</param>
        public PulsingPanel( Size size, Point position, Control parent )
            : this()
        {
            Size = SizeConfig.GetSize( size );
            TileSize = Size;
            Location = ControlConfig.GetLocation( position );
            Parent = ControlConfig.GetParent( parent );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="PulsingPanel" />
        /// class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public PulsingPanel( Control parent )
            : this()
        {
            Parent = ControlConfig.GetParent( parent );
        }

        // ***************************************************************************************************************************
        // *******************************************************      METHODS        ***********************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the duration of the pulse.
        /// </summary>
        /// <param name="duration">The duration.</param>
        public void SetPulseDuration( int duration = 2 )
        {
            if( duration > -1
                && TileType == HubTileType.PulsingTile )
            {
                PulseDuration = duration;
            }
        }

        /// <summary>
        /// Sets the duration of the pulse.
        /// </summary>
        /// <param name="scale">The scale.</param>
        public void SetPulseScale( int scale = 2 )
        {
            if( scale > -1
                && TileType == HubTileType.PulsingTile )
            {
                PulseScale = scale;
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
        public void SetImageSpeed( int speed = 3 )
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
