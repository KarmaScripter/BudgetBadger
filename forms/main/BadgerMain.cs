// <copyright file = "Main.cs " company = "Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading;
    using Syncfusion.Windows.Forms;

    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    public partial class BadgerMain : MetroForm
    {
        // ***************************************************************************************************************************
        // ****************************************************  CONSTRUCTORS ********************************************************
        // ***************************************************************************************************************************

        public BadgerMain()
        {
            InitializeComponent();
            ToolControl.ExcelButton.Click += OnExcelButtonClick;
            FormClosing += OnClose;
        }

        // ***************************************************************************************************************************
        // ****************************************************     METHODS   ********************************************************
        // ***************************************************************************************************************************

        private Image GetImage()
        {
            try
            {
                var img = new BudgetImage( "SqlCe", ImageSource.Databases );
                Label.Text = img?.GetBuilder()?.GetFilePath();
                return img?.GetBitmap();
            }
            catch( Exception ex )
            {
                using var error = new Error( ex );
                error?.SetText();
                error?.ShowDialog();
                return default;
            }
        }

        // ***************************************************************************************************************************
        // ****************************************************     EVENTS    ********************************************************
        // ***************************************************************************************************************************

        private void OnExcelButtonClick( object sender, EventArgs e )
        {
            var path = Resource.Settings[ "Report" ];
            using var excel = new ExcelDocument( path );
            excel?.ShowDialog();
        }

        private void OnClose( object sender, EventArgs e )
        {
            Picture?.Image?.Dispose();
            Picture?.InitialImage?.Dispose();
        }
    }
}