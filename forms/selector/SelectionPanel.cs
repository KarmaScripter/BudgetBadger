// <copyright file = "SelectionPanel.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // **************************************************************************************************************************
    // ********************************************      ASSEMBLIES    **********************************************************
    // **************************************************************************************************************************

    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.Tools.Carousel" />
    public class SelectionPanel : Carousel
    {
        // **************************************************************************************************************************
        // ********************************************      FIELDS     *************************************************************
        // **************************************************************************************************************************

        /// <summary>
        /// Defines the AppSettings
        /// </summary>
        private readonly NameValueCollection Settings = ConfigurationManager.AppSettings;

        // **************************************************************************************************************************
        // ********************************************   CONSTRUCTORS     **********************************************************
        // **************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SelectionPanel" />
        /// class.
        /// </summary>
        public SelectionPanel()
        {
            Size = new Size( 1200, 750 );
            BackColor = ColorConfig.BackColorBlack;
            MaximumSize = Size;
            MinimumSize = Size;
            Font = FontConfig.FontSizeSmall;
            ForeColor = ColorConfig.ForeColorGray;
            HighlightColor = ColorConfig.BorderColorBlue;
            ImageSlides = true;
            Margin = new Padding( 10 );
            Padding = ControlConfig.Padding;
            ImageshadeColor = ColorConfig.BackColorBlack;
            Perspective = 6;
            ShowImagePreview = true;
            ShowImageShadow = true;
            CarouselPath = CarouselPath.Default;
            Perspective = 4;
            RotateAlways = false;
            TransitionSpeed = 2;
            UseCustomBounds = false;
            UseOriginalImageinPreview = false;
            VisualStyle = CarouselVisualStyle.Metro;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SelectionPanel" />
        /// class.
        /// </summary>
        /// <param name="path">The path.</param>
        public SelectionPanel( string path )
            : this()
        {
            FilePath = path;
            GetImageList( path );
            OnCarouselItemFocused += OnImageSelected;
        }

        // **************************************************************************************************************************
        // ********************************************      PROPERTIES    **********************************************************
        // **************************************************************************************************************************

        /// <summary>
        /// Gets or sets the Images
        /// </summary>
        /// <value>
        /// The selection images.
        /// </value>
        public IEnumerable<CarouselImage> SelectionImages { get; set; }

        /// <summary>
        /// Gets or sets the budget images.
        /// </summary>
        /// <value>
        /// The budget images.
        /// </value>
        public IEnumerable<BudgetImage> BudgetImages { get; set; }

        /// <summary>
        /// Gets or sets the Source
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        private Source Source { get; set; }

        // **************************************************************************************************************************
        // ********************************************      METHODS    *************************************************************
        // **************************************************************************************************************************

        /// <summary>
        /// The SetSource
        /// </summary>
        /// <param name="input">The input
        /// <see cref="string" /></param>
        /// <returns>
        /// The
        /// <see cref="Source" />
        /// </returns>
        private Source SetSource( string input )
        {
            try
            {
                return Verify.Input( input ) && Resource.Sources.Contains( input )
                    ? (Source)Enum.Parse( typeof( Source ), input )
                    : default( Source );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <returns></returns>
        public Source GetSource()
        {
            try
            {
                return Verify.Source( Source )
                    ? Source
                    : Source.NS;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// The GetCarouselImageList
        /// </summary>
        /// <param name="imagepath">The imagepath
        /// <see cref="string" /></param>
        private void GetImageList( string imagepath )
        {
            if( Verify.Input( imagepath ) )
            {
                try
                {
                    using var imagelist = new ImageList();
                    ImageSlides = true;
                    UseOriginalImageinPreview = true;
                    var images = Directory.GetFiles( imagepath );

                    if( ImageListCollection.Count > 0 )
                    {
                        ImageListCollection.Clear();
                    }

                    foreach( var image in images )
                    {
                        var filename = Path.GetFileNameWithoutExtension( image );

                        var bitmap = new Bitmap( image )
                        {
                            Tag = filename
                        };

                        var carouselimage = new CarouselImage
                        {
                            ItemImage = bitmap
                        };

                        carouselimage.ItemImage.Tag = bitmap.Tag;
                        imagelist.Images.Add( bitmap );
                        ImageListCollection.Add( carouselimage );
                    }

                    ImageList = (System.Windows.Forms.ImageList)imagelist;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    Dispose();
                }
            }
        }

        /// <summary>
        /// The GetSourceSelector
        /// </summary>
        /// <param name="image">The image
        /// <see cref="Image" /></param>
        private void GetSourceSelector( Image image )
        {
            if( Verify.Input( image?.Tag.ToString() ) )
            {
                try
                {
                    using( image )
                    {
                        Source = SetSource( $"{image?.Tag}" );

                        switch( Source )
                        {
                            case Source.ARD:
                            case Source.ECAD:
                            case Source.EJ:
                            case Source.LCARD:
                            case Source.LSASD:
                            case Source.MDR:
                            case Source.MSD:
                            case Source.ORA:
                            case Source.ORC:
                            case Source.WCF:
                            case Source.WD:
                            case Source.WSA:
                            case Source.XA:
                            case Source.SEMD:
                            {
                                using var form = new Message()
                                {
                                    StartPosition = FormStartPosition.CenterScreen
                                };

                                form.ShowDialog();
                                return;
                            }

                            case Source.EPM:
                            case Source.Contracts:
                            case Source.Expenses:
                            case Source.FTE:
                            case Source.Grants:
                            case Source.LUST:
                            case Source.Payroll:
                            case Source.SF6A:
                            case Source.LustSupplemental:
                            case Source.OilSpill:
                            case Source.STAG:
                            case Source.SiteTravel:
                            case Source.Travel:
                            case Source.Supplemental:
                            case Source.Awards:
                            case Source.Overtime:
                            case Source.TimeOff:
                            case Source.RegionAuthority:
                            case Source.DivisionAuthority:
                            case Source.TravelObligations:
                            case Source.PayrollHours:
                            case Source.Reimbursables:
                            case Source.Utilization:
                            case Source.SpecialAccounts:
                            case Source.PRC:
                            {
                                using var summary = new Message();
                                summary.ShowDialog();
                                return;
                            }

                            case Source.Allocations:
                            case Source.Accounts:
                            case Source.ControlNumbers:
                            case Source.WorkforceData:
                            case Source.BudgetObjectClass:
                            case Source.Activity:
                            case Source.InformationTechnology:
                            case Source.FinanceObjectClass:
                                break;
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// The GetNonSourceSelector
        /// </summary>
        /// <param name="image">The image
        /// <see cref="Image" /></param>
        private void GetNonSourceSelector( Image image )
        {
            try
            {
                if( Verify.Input( image?.Tag?.ToString() ) )
                {
                    using var message = new Message( "NOT YET IMPLEMENTED!" );
                    message.ShowDialog();
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        // **************************************************************************************************************************
        // ********************************************      EVENTS     *************************************************************
        // **************************************************************************************************************************

        /// <summary>
        /// The OnLoad
        /// </summary>
        /// <param name="sender">The sender
        /// <see cref="object" /></param>
        /// <param name="e">The e
        /// <see cref="EventArgs" /></param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                using var message = new Message( "Not Yet Implemented!" );
                message?.ShowDialog();
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// The OnCarouselImageSelected
        /// </summary>
        /// <param name="sender">The sender
        /// <see cref="object" /></param>
        /// <param name="e">The e
        /// <see cref="EventArgs" /></param>
        private void OnImageSelected( object sender, EventArgs e )
        {
            try
            {
                var carousel = sender as Carousel;

                if( !Resource.Sources.Contains( carousel?.ActiveImage.Tag.ToString() ) )
                {
                    GetNonSourceSelector( carousel?.ActiveImage );
                }

                if( Resource.Sources.Contains( carousel?.ActiveImage.Tag.ToString() ) )
                {
                    GetSourceSelector( carousel?.ActiveImage );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
                Dispose();
            }
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var error = new Error( ex );
            error?.SetText();
            error?.ShowDialog();
        }
    }
}