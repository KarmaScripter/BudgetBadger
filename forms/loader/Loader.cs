﻿// <copyright file = "Loader.cs " company = "Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Threading;
    using Syncfusion.Windows.Forms;

    public partial class Loader : MetroForm
    {
        public Loader()
        {
            InitializeComponent();
            FormClosing += OnClose;
        }

        public void OnClose( object sender, EventArgs e )
        {
            Kill();
        }

        public void Kill()
        {
            if( PictureBox?.Image != null )
            {
                PictureBox.Image.Dispose();
                PictureBox.Dispose();
            }
        }
    }
}