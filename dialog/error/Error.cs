// <copyright file = "Error.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;

    public partial class Error
    {
        public Error()
        {
            InitializeComponent();
        }

        public Error( Exception ext )
        {
            InitializeComponent();
            Exception = ext;
            Text = "Error!";
            Info.Text = Exception.Source;
        }

        public Error( string message )
        {
            InitializeComponent();
            Info.Text = Exception.Source;
            StackPanel.Text = message;
        }

        public Exception Exception { get; }

        public void SetText()
        {
            var tracemessage = Exception.ToLogString( "" );
            StackPanel.Text = tracemessage;
        }
    }
}
