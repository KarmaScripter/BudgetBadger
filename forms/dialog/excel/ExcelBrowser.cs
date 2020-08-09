﻿// <copyright file = "ExcelBrowser.cs " company = "Terry D. Eppler">
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

    public partial class ExcelBrowser : MetroForm
    {
        public ExcelBrowser()
        {
            InitializeComponent();
            Dialog.CheckFileExists = true;
            Dialog.ShowDialog( this );
        }
    }
}