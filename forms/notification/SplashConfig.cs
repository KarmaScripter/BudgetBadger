// <copyright file = "SplashConfig.cs" company = "Terry D. Eppler">
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
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.Tools.SplashPanel" />
    [ SuppressMessage( "ReSharper", "StringLiteralAsInterpolationArgument" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public class SplashConfig : SplashPanel
    {
        // **********************************************************************************************************************
        // *************************************************   PROPERTIES   *****************************************************
        // **********************************************************************************************************************

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public Field Field { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        // ***************************************************************************************************************************
        // ************************************************  METHODS   ***************************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetText( string text )
        {
            if( Verify.Input( text ) )
            {
                try
                {
                    Text = text;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the size.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public void SetSize( int width, int height )
        {
            try
            {
                Size = SizeConfig.GetSize( width, height );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name="field">The field.</param>
        public void SetField( Field field )
        {
            try
            {
                Field = FormConfig.GetField( field );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        public void SetTag( object tag )
        {
            try
            {
                Tag = ControlConfig.GetTag( tag );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the location.
        /// </summary>
        /// <param name="point">The point.</param>
        public void SetLocation( Point point )
        {
            try
            {
                Location = ControlConfig.GetLocation( point );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the discrete location.
        /// </summary>
        /// <param name="point">The point.</param>
        public void SetDiscreteLocation( Point point )
        {
            try
            {
                DiscreetLocation = ControlConfig.GetLocation( point );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Notifies this instance.
        /// </summary>
        public void Notify()
        {
            try
            {
                if( !IsShowing() )
                {
                    ShowSplash();
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Notifies the specified text.
        /// </summary>
        /// <param name="text">The text.</param>
        public void Notify( string text )
        {
            if( Verify.Input( text ) )
            {
                try
                {
                    if( !IsShowing() )
                    {
                        Text = text;
                        ShowSplash();
                    }
                    else
                    {
                        ResetText();
                        Text = text;
                    }
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
        /// Called when [displayed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        public void OnDisplayed( object sender, EventArgs e )
        {
            try
            {
                var message = $"Event: {"SplashDisplayed"} Object: {( (Control)sender ).Name}\r\n";

                if( InvokeRequired )
                {
                    Invoke( new Action<string>( SetText ), message );
                }
                else
                {
                    Text = message;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Befores the splash.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="CancelEventArgs" />
        /// instance containing the event data.</param>
        public new void BeforeSplash( object sender, CancelEventArgs e )
        {
            try
            {
                var message = $"Event: {"BeforeSplash"} Object: {( (Control)sender ).Name}\r\n";
                Text = message;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [closing].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The
        /// <see cref="SplashClosedEventArgs" />
        /// instance containing the event data.</param>
        public void OnClosing( object sender, SplashClosedEventArgs args )
        {
            try
            {
                var message = $"Event: {"SplashClosing"} Object: {( (Control)sender ).Name}\r\n";

                if( InvokeRequired )
                {
                    Invoke( new Action<string>( SetText ), message );
                }
                else
                {
                    SetText( message );
                }

                Visible = true;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [closed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The
        /// <see cref="SplashClosedEventArgs" />
        /// instance containing the event data.</param>
        public void OnClosed( object sender, SplashClosedEventArgs args )
        {
            try
            {
                var message = $"Event: {"SplashClosing"} Object: {( (Control)sender ).Name}\r\n";

                if( InvokeRequired )
                {
                    Invoke( new Action<string>( SetText ), message );
                }
                else
                {
                    SetText( message );
                }

                Visible = true;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [mouse enter].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        public void OnMouseEnter( object sender, EventArgs e )
        {
            try
            {
                var message = $"Event: {"SplashMouseEnter"} Object: {( (Control)sender ).Name}\r\n";

                if( InvokeRequired )
                {
                    Invoke( new Action<string>( SetText ), message );
                }
                else
                {
                    SetText( message );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [mouse leave].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        public void OnMouseLeave( object sender, EventArgs e )
        {
            try
            {
                var message = $"Event: {"SplashMouseLeave"} Object: {( (Control)sender ).Name}\r\n";

                if( InvokeRequired )
                {
                    Invoke( new Action<string>( SetText ), message );
                }
                else
                {
                    var text = message;
                    Text = text;
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
