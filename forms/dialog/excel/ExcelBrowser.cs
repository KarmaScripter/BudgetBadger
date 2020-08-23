// <copyright file = "ExcelBrowser.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

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
