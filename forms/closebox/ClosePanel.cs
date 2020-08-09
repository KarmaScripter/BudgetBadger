// <copyright file="CloseModel.cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ******************************************************************************************************************************
    // ******************************************************   ASSEMBLIES   ********************************************************
    // ******************************************************************************************************************************

    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using VisualPlus.Models;
    using VisualPlus.Toolkit.Controls.Interactivity;
    using VisualPlus.Toolkit.VisualBase;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="VisualPlus.Toolkit.Controls.Interactivity.VisualControlBox" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "PossibleNullReferenceException" ) ]
    public class ClosePanel : VisualControlBox
    {
        // ***************************************************************************************************************************
        // ****************************************************    FIELDS     ********************************************************
        // ***************************************************************************************************************************

        private readonly string HelpPath =
            @"C:\Users\Daddy\source\repos\BudgetBadger\resources\image\closebox\HelpButton.png";

        private readonly string MaxPath =
            @"C:\Users\Daddy\source\repos\BudgetBadger\resources\image\closebox\MaximizeButton.png";

        private readonly string MinPath =
            @"C:\Users\Daddy\source\repos\BudgetBadger\resources\image\closebox\MinimizeButton.png";

        private readonly string ClosePath =
            @"C:\Users\Daddy\source\repos\BudgetBadger\resources\image\closebox\CloseButton.png";

        // ***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ButtonPanel" />
        /// class.
        /// </summary>
        public ClosePanel()
        {
            // Prologue
            ForeColor = ColorConfig.ForeColorGray;
            Font = FontConfig.FontSizeSmall;
            Margin = new Padding( 3 );
            Padding = new Padding( 0 );
            Size = SizeConfig.GetSize( 200, 25 );
            Anchor = AnchorStyles.Top & AnchorStyles.Right;
            Visible = true;
            Enabled = true;

            // Set Button Properties
            HelpButton.Image = new Bitmap( HelpPath );
            HelpButton.Size = new Size( 50, 25 );
            HelpButton.Margin = new Padding( 3 );
            HelpButton.Tag = "Documentation";
            HelpButton.Visible = true;
            HelpButton.Enabled = true;

            // Help Button BackColor Configuration
            HelpButton.BackColor = ColorConfig.BackColorBlack;
            HelpButton.BackColorState.Disabled = ColorConfig.BackColorBlack;
            HelpButton.BackColorState.Enabled = ColorConfig.BackColorBlack;
            HelpButton.BackColorState.Hover = ColorConfig.BorderColorBlue;
            HelpButton.BackColorState.Pressed = ColorConfig.BorderColorBlue;

            // HelpButton ForeColor Configuration
            HelpButton.ForeColor = ColorConfig.BackColorBlack;
            HelpButton.ForeColorState.Disabled = ColorConfig.BackColorBlack;
            HelpButton.ForeColorState.Enabled = ColorConfig.BackColorBlack;
            HelpButton.ForeColorState.Hover = Color.White;
            HelpButton.ForeColorState.Pressed = Color.White;

            // Minimize Button Properties
            MinimizeButton.Image = new Bitmap( MinPath );
            MinimizeButton.Size = new Size( 50, 25 );
            MinimizeButton.Margin = new Padding( 3 );
            MinimizeButton.Tag = "Minimize";
            MinimizeButton.Visible = true;
            MinimizeButton.Enabled = true;

            // MinimizeButton BackColor Configuration
            MinimizeButton.BackColor = ColorConfig.BackColorBlack;
            MinimizeButton.BackColorState.Disabled = ColorConfig.BackColorBlack;
            MinimizeButton.BackColorState.Enabled = ColorConfig.BackColorBlack;
            MinimizeButton.BackColorState.Hover = ColorConfig.ControlHoverBlue;
            MinimizeButton.BackColorState.Pressed = ColorConfig.BorderColorBlue;

            // MinimizeButton ForeColor Configuration
            MinimizeButton.ForeColor = ColorConfig.BackColorBlack;
            MinimizeButton.ForeColorState.Disabled = ColorConfig.BackColorBlack;
            MinimizeButton.ForeColorState.Enabled = ColorConfig.BackColorBlack;
            MinimizeButton.ForeColorState.Hover = Color.White;
            MinimizeButton.ForeColorState.Pressed = Color.White;

            // Maximize Button Properties
            MaximizeButton.Image = new Bitmap( MaxPath );
            MaximizeButton.Size = new Size( 50, 25 );
            MaximizeButton.Margin = new Padding( 3 );
            MaximizeButton.Tag = "Maximize";
            MaximizeButton.Visible = true;
            MaximizeButton.Enabled = true;

            // Maximize Button BackColor Configuration
            MaximizeButton.BackColor = ColorConfig.BackColorBlack;
            MaximizeButton.BackColorState.Disabled = ColorConfig.BackColorBlack;
            MaximizeButton.BackColorState.Enabled = ColorConfig.BackColorBlack;
            MaximizeButton.BackColorState.Hover = ColorConfig.ControlHoverBlue;
            MaximizeButton.BackColorState.Pressed = ColorConfig.ControlHoverBlue;

            // Maximize Button ForeColor Configuration
            MaximizeButton.ForeColor = ColorConfig.BackColorBlack;
            MaximizeButton.ForeColorState.Disabled = ColorConfig.BackColorBlack;
            MaximizeButton.ForeColorState.Enabled = ColorConfig.BackColorBlack;
            MaximizeButton.ForeColorState.Hover = Color.White;
            MaximizeButton.ForeColorState.Pressed = Color.White;

            // Close Button Properties
            CloseButton.Image = new Bitmap( ClosePath );
            CloseButton.Size = new Size( 50, 25 );
            CloseButton.Margin = new Padding( 3 );
            CloseButton.Tag = "Exit | Close";
            CloseButton.Visible = true;
            CloseButton.Enabled = true;

            // Close Button BackColor Configuration
            CloseButton.BackColor = ColorConfig.BackColorBlack;
            CloseButton.BackColorState.Disabled = ColorConfig.BackColorBlack;
            CloseButton.BackColorState.Enabled = ColorConfig.BackColorBlack;
            CloseButton.BackColorState.Hover = ColorConfig.ForeColorRed;
            CloseButton.BackColorState.Pressed = ColorConfig.BorderColorBlue;

            // Close Button ForeColor Configuration
            CloseButton.ForeColor = ColorConfig.BackColorBlack;
            CloseButton.ForeColorState.Disabled = ColorConfig.BackColorBlack;
            CloseButton.ForeColorState.Enabled = ColorConfig.BackColorBlack;
            CloseButton.ForeColorState.Hover = Color.White;
            CloseButton.ForeColorState.Pressed = Color.White;

            // Event Wiring
            HelpButton.MouseHover += OnMouseHover;
            MinimizeButton.MouseHover += OnMouseHover;
            MaximizeButton.MouseHover += OnMouseHover;
            CloseButton.MouseHover += OnMouseHover;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ButtonPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public ClosePanel( Size size, Point location )
            : this()
        {
            Size = SizeConfig.GetSize( size.Width, size.Height );
            Location = ControlConfig.GetLocation( location.X, location.Y );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ButtonPanel" />
        /// class.
        /// </summary>
        /// <param name="location">The location.</param>
        public ClosePanel( Point location )
            : this()
        {
            Location = ControlConfig.GetLocation( location.X, location.Y );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ButtonPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public ClosePanel( Size size, Point location, Control parent )
            : this( size, location )
        {
            Parent = ControlConfig.GetParent( parent );
            Parent.Controls.Add( this );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ButtonPanel" />
        /// class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public ClosePanel( Control parent )
            : this()
        {
            Parent = ControlConfig.GetParent( parent );
            Parent.Controls.Add( this );
        }

        // **********************************************************************************************************************
        // *************************************************   PROPERTIES   *****************************************************
        // **********************************************************************************************************************

        /// <summary>
        /// Gets or sets the tip.
        /// </summary>
        /// <value>
        /// The tip.
        /// </value>
        public ToolTip ToolTip { get; set; }

        // ***************************************************************************************************************************
        // *******************************************************      METHODS        ***********************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the state of the back color.
        /// </summary>
        /// <param name="button">The button.</param>
        public void SetBackColorConfiguration( ControlBoxButton button )
        {
            try
            {
                button.BackColor = ColorConfig.BackColorBlack;
                button.BackColorState.Disabled = ColorConfig.BackColorBlack;
                button.BackColorState.Enabled = ColorConfig.BackColorBlack;
                button.BackColorState.Hover = ColorConfig.ControlHoverGray;
                button.BackColorState.Pressed = ColorConfig.BorderColorBlue;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the text style configuration.
        /// </summary>
        /// <param name="button">The button.</param>
        public void SetForeColorConfiguration( ControlBoxButton button )
        {
            try
            {
                button.ForeColor = Color.DimGray;

                switch( button.Name )
                {
                    case nameof( HelpButton ):
                    {
                        button.ForeColorState = new ControlColorState();
                        button.ForeColorState.Hover = Color.Yellow;
                        button.ForeColorState.Disabled = ColorConfig.BackColorBlack;
                        button.ForeColorState.Enabled = Color.DimGray;
                        button.ForeColorState.Pressed = ColorConfig.BorderColorBlue;
                        return;
                    }

                    case nameof( CloseButton ):
                    {
                        button.ForeColorState = new ControlColorState();
                        button.ForeColorState.Hover = Color.Red;
                        button.ForeColorState.Disabled = ColorConfig.BackColorBlack;
                        button.ForeColorState.Enabled = Color.DimGray;
                        button.ForeColorState.Pressed = ColorConfig.BorderColorBlue;
                        return;
                    }

                    default:
                    {
                        button.ForeColorState = new ControlColorState();
                        button.ForeColorState.Hover = Color.White;
                        button.ForeColorState.Disabled = ColorConfig.BackColorBlack;
                        button.ForeColorState.Enabled = Color.DimGray;
                        button.ForeColorState.Pressed = ColorConfig.BorderColorBlue;
                        break;
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the control button information.
        /// </summary>
        private void SetControlButtonInfo()
        {
            try
            {
                HelpButton.Tag = "Need Help?";
                MaximizeButton.Tag = "Set Maximum Size";
                MinimizeButton.Tag = "Set Minimum Size";
                CloseButton.Tag = "Close Form";
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the hover information.
        /// </summary>
        /// <param name="button">The button.</param>
        public void SetToolTip( Control button )
        {
            if( Verify.Ref( button )
                && Verify.Input( button?.Tag?.ToString() ) )
            {
                try
                {
                    ToolTip = new ToolTip( button, button.Tag.ToString() );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
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
        private void OnMouseHover( object sender, EventArgs e )
        {
            var button = sender as ControlBoxButton;

            try
            {
                if( button?.Tag != null )
                {
                    SetToolTip( button );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
    }
}