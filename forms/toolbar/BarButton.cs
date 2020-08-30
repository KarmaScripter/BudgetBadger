// <copyright file = "BarButton.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ******************************************************************************************************************************
    // ******************************************************   ASSEMBLIES   ********************************************************
    // ******************************************************************************************************************************

    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    [ SuppressMessage( "ReSharper", "UsePatternMatching" ) ]
    [ Serializable ]
    public class BarButton : BarButtonBase
    {
        // ***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        public BarButton()
        {
            Margin = new Padding( 5, 5, 5, 5 );
            Padding = new Padding( 0 );
            DisplayStyle = ToolStripItemDisplayStyle.Image;
            BackColor = ColorConfig.BackColorBlack;
            ForeColor = ColorConfig.ForeColorGray;
            Font = FontConfig.FontSizeSmall;
            HoverText = Tag?.ToString();
            Text = string.Empty;
            Visible = true;
            Enabled = true;
            MouseHover += OnMouseHover;
            MouseLeave += OnMouseLeave;
            Click += OnClick;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BarButton"/> class.
        /// </summary>
        /// <param name="tool">The tool.</param>
        public BarButton( Tool tool )
            : this()
        {
            Image = new BudgetImage( tool.ToString(), ImageSource.ToolBar )?.GetBitmap();
            Bar = tool;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BarButton"/> class.
        /// </summary>
        /// <param name="image">The image.</param>
        public BarButton( IBudgetImage image )
            : this()
        {
            Image = image.GetBitmap();
            Bar = (Tool)Enum.Parse( typeof( Tool ), image.GetName() );
        }

        // ***************************************************************************************************************************
        // ******************************************************   PROPERTIES   *****************************************************
        // ***************************************************************************************************************************

        /// <summary> Gets or sets the binding source. </summary>
        /// <value> The binding source. </value>
        public BindingSource BindingSource { get; set; }

        public ToolTip ToolTip { get; set; }

        // ***************************************************************************************************************************
        // *******************************************************      METHODS        ***********************************************
        // ***************************************************************************************************************************

        /// <summary> Sets the image.
        /// </summary>
        /// <param name = "tool" > 
        /// </param>
        public void SetImage( Tool tool )
        {
            if( Enum.IsDefined( typeof( Tool ), tool ) )
            {
                try
                {
                    var image = new BudgetImage( tool.ToString(), ImageSource.ToolBar );
                    Image = image?.GetBitmap();
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        // ***************************************************************************************************************************
        // ****************************************************   EVENTS/DELEGATES  **************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Called when [mouse over].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnMouseHover( object sender, EventArgs e )
        {
            try
            {
                var button = sender as BarButton;

                if( button != null
                    && !string.IsNullOrEmpty( HoverText ) )
                {
                    button.Tag = HoverText;
                    var tip = new ToolTip( button );
                    ToolTip = tip;
                }
                else
                {
                    if( !string.IsNullOrEmpty( Tag?.ToString() ) )
                    {
                        var tool = new ToolTip( button );
                        ToolTip = tool;
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        public void OnMouseLeave( object sender, EventArgs e )
        {
            try
            {
                if( ToolTip?.Active == true )
                {
                    ToolTip.RemoveAll();
                    ToolTip = null;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [click]. </summary>
        /// <param name = "sender" > The sender. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnClick( object sender, EventArgs e )
        {
            if( sender is BarButton button )
            {
                try
                {
                    switch( button.Bar )
                    {
                        case Tool.FirstButton:
                        {
                            using var message = new Message( "NOT YET IMPLEMENTED!" );
                            message?.ShowDialog();
                            break;
                        }

                        case Tool.PreviousButton:
                        {
                            using var message = new Message( "NOT YET IMPLEMENTED!" );
                            message?.ShowDialog();
                            break;
                        }

                        case Tool.NextButton:
                        {
                            using var message = new Message( "NOT YET IMPLEMENTED!" );
                            message?.ShowDialog();
                            break;
                        }

                        case Tool.LastButton:
                        {
                            using var message = new Message( "NOT YET IMPLEMENTED!" );
                            message?.ShowDialog();
                            break;
                        }

                        case Tool.ExcelButton:
                        {
                            using var message = new Message( "NOT YET IMPLEMENTED!" );
                            message?.ShowDialog();
                            break;
                        }

                        case Tool.PdfButton:
                        {
                            using var message = new Message( "NOT YET IMPLEMENTED!" );
                            message?.ShowDialog();
                            break;
                        }

                        case Tool.AddButton:
                        {
                            using var message = new Message( "NOT YET IMPLEMENTED!" );
                            message?.ShowDialog();
                            break;
                        }

                        case Tool.DeleteButton:
                        {
                            using var message = new Message( "NOT YET IMPLEMENTED!" );
                            message?.ShowDialog();
                            break;
                        }

                        case Tool.RefreshButton:
                        {
                            using var message = new Message( "NOT YET IMPLEMENTED!" );
                            message?.ShowDialog();
                            break;
                        }

                        case Tool.EditButton:
                        {
                            using var message = new Message( "NOT YET IMPLEMENTED!" );
                            message?.ShowDialog();
                            break;
                        }

                        case Tool.ExitButton:
                        {
                            using var message = new Message( "NOT YET IMPLEMENTED!" );
                            message?.ShowDialog();
                            break;
                        }

                        case Tool.ExportButton:
                        {
                            using var message = new Message( "NOT YET IMPLEMENTED!" );
                            message?.ShowDialog();
                            break;
                        }

                        case Tool.ImportButton:
                        {
                            using var message = new Message( "NOT YET IMPLEMENTED!" );
                            message?.ShowDialog();
                            break;
                        }

                        case Tool.InsertButton:
                        {
                            using var message = new Message( "NOT YET IMPLEMENTED!" );
                            message?.ShowDialog();
                            break;
                        }

                        default:
                        {
                            using var message = new Message( "NOT YET IMPLEMENTED!" );
                            message?.ShowDialog();
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
    }
}
