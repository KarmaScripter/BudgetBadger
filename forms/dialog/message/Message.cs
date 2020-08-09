// <copyright file = "Message.cs " company = "Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System;
    using System.Threading;
    using Syncfusion.Windows.Forms;

    public partial class Message : MetroForm
    {
        // ***************************************************************************************************************************
        // ****************************************************  CONSTRUCTORS ********************************************************
        // ***************************************************************************************************************************

        public Message()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Message"/> class.
        /// </summary>
        /// <param name = "message" >
        /// The message.
        /// </param>
        public Message( string message )
            : this()
        {
            Text = message;
            Info.Text = "\n\n\n    " + Text;
        }

        // **********************************************************************************************************************
        // *************************************************   PROPERTIES   *****************************************************
        // **********************************************************************************************************************

        /// <summary>
        /// Gets the stack.
        /// </summary>
        /// <value>
        /// The stack.
        /// </value>
        private string Stack { get; set; }

        /// <summary>
        /// Gets the target.
        /// </summary>
        /// <value>
        /// The target.
        /// </value>
        private string Target { get; set; }

        // ***************************************************************************************************************************
        // ************************************************  METHODS   ***************************************************************
        // ***************************************************************************************************************************

        // **********************************************************************************************************************
        // *************************************************   EVENTS    ********************************************************
        // **********************************************************************************************************************

        /// <summary>
        /// Called when [ok button clicked].
        /// </summary>
        /// <param name = "sender" >
        /// The sender.
        /// </param>
        /// <param name = "e" >
        /// The <see cref = "EventArgs"/> instance containing the event data.
        /// </param>
        private void OnOkButtonClicked( object sender, EventArgs e )
        {
            if( IsDisposed == false )
            {
                Dispose();
            }

            Close();
        }

        /// <summary>
        /// Called when [stack button clicked].
        /// </summary>
        /// <param name = "sender" >
        /// The sender.
        /// </param>
        /// <param name = "e" >
        /// The <see cref = "EventArgs"/> instance containing the event data.
        /// </param>
        private void OnStackButtonClicked( object sender, EventArgs e )
        {
            Info.Text = "Call Stack: \n\n" + Stack;
        }

        /// <summary>
        /// Called when [target button clicked].
        /// </summary>
        /// <param name = "sender" >
        /// The sender.
        /// </param>
        /// <param name = "e" >
        /// The <see cref = "EventArgs"/> instance containing the event data.
        /// </param>
        private void OnTargetButtonClicked( object sender, EventArgs e )
        {
            Info.Text = "Target Site: \n\n" + Target;
        }

        /// <summary>
        /// Called when [closing].
        /// </summary>
        /// <param name = "sender" >
        /// The sender.
        /// </param>
        /// <param name = "e" >
        /// The <see cref = "EventArgs"/> instance containing the event data.
        /// </param>
        private void OnClosing( object sender, EventArgs e )
        {
            if( !IsDisposed )
            {
                Dispose();
            }
        }

        /// <summary>
        /// Handles the Load event of the Message control.
        /// </summary>
        /// <param name = "sender" >
        /// The source of the event.
        /// </param>
        /// <param name = "e" >
        /// The <see cref = "EventArgs"/> instance containing the event data.
        /// </param>
        private void OnLoad( object sender, EventArgs e )
        {
        }
    }
}