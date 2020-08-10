// // <copyright file = "PicturePanel.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    // ******************************************************************************************************************************
    // ******************************************************   ASSEMBLIES   ********************************************************
    // ******************************************************************************************************************************

    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="IPictureBox" />
    /// <seealso cref="System.Windows.Forms.PictureBox" />
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class PicturePanel : PictureBox, IPictureBox
    {
        // ***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="PicturePanel" />
        /// class.
        /// </summary>
        public PicturePanel()
        {
            Anchor = ControlConfig.GetAnchorStyle();
            Location = ControlConfig.GetLocation();
            BackColor = Color.Transparent;
            Margin = ControlConfig.Margin;
            Padding = ControlConfig.Padding;
            SizeMode = PictureBoxSizeMode.StretchImage;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="PicturePanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public PicturePanel( Size size, Point location )
            : this()
        {
            Size = SizeConfig.GetSize( size );
            Location = location;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="PicturePanel" />
        /// class.
        /// </summary>
        /// <param name="builder">The imagebuilder.</param>
        public PicturePanel( ImageBuilder builder )
            : this()
        {
            BudgetImage = new BudgetImage( builder );
            InitialImage = BudgetImage.GetBitmap();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="PicturePanel" />
        /// class.
        /// </summary>
        /// <param name="image">The image.</param>
        public PicturePanel( IBudgetImage image )
            : this()
        {
            BudgetImage = image;
            InitialImage = BudgetImage.GetBitmap();
        }

        // ***************************************************************************************************************************
        // ******************************************************   PROPERTIES   *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public ToolTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public Field Field { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Gets or sets the image list.
        /// </summary>
        /// <value>
        /// The image list.
        /// </value>
        public ImageList ImageList { get; set; }

        /// <summary>
        /// Gets or sets the budget image.
        /// </summary>
        /// <value>
        /// The budget image.
        /// </value>
        public IBudgetImage BudgetImage { get; }

        // ***************************************************************************************************************************
        // *******************************************************      METHODS        ***********************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the hover information.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetHoverText( string text )
        {
            if( Verify.Input( text ) )
            {
                try
                {
                    HoverText = text;
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

        /// <summary>
        /// Sets the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        public void SetTag( object tag )
        {
            if( tag != null )
            {
                try
                {
                    Tag = tag;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the image size mode.
        /// </summary>
        /// <param name="mode">The mode.</param>
        public void SetImageSizeMode( PictureBoxSizeMode mode = PictureBoxSizeMode.Normal )
        {
            try
            {
                SizeMode = mode;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        // ***************************************************************************************************************************
        // ****************************************************   EVENTS/DELEGATES  **************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Called when [mouse hover].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        [ SuppressMessage( "ReSharper", "UnusedVariable" ) ]
        public void OnMouseHover( object sender, EventArgs e )
        {
            try
            {
                var picturepanel = sender as PicturePanel;

                if( Verify.Input( HoverText ) )
                {
                    var text = picturepanel?.HoverText;
                    var _ = new ToolTip( picturepanel, HoverText );
                }
                else
                {
                    if( Verify.Input( Tag?.ToString() ) )
                    {
                        var _ = new ToolTip( picturepanel, Tag?.ToString().SplitPascal() );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
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