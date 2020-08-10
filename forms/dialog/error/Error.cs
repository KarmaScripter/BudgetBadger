// // <copyright file = "Error.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System;
    using System.Threading;

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
        }

        public Error( string message )
        {
            InitializeComponent();
            Text = message;
        }

        public Exception Exception { get; }

        public new string Text { get; set; }

        public void SetText()
        {
        }
    }
}