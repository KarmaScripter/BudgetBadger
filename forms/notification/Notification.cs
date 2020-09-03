// // <copyright file = "ExNotifyBalloon.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System.Diagnostics.CodeAnalysis;
    using System.Media;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Reflection;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameter" ) ]
    public partial class Notification : MetroForm
    {
        // ***************************************************************************************************************************
        // ****************************************************    FIELDS     ********************************************************
        // ***************************************************************************************************************************

        private const int WM_MOUSEACTIVATE = 0x0021, MA_NOACTIVATE = 0x0003;

        private static readonly List<Notification> OpenNotifications = new List<Notification>();

        private const int WS_EX_NOACTIVATE = 0x08000000;

        private const int WS_EX_TOPMOST = 0x00000008;

        private bool stopFadeOut;

        // ***************************************************************************************************************************
        // ****************************************************  CONSTRUCTORS ********************************************************
        // ***************************************************************************************************************************

        public Notification( Bitmap notifyIcon,
            string notifyTitle,
            string notifyBody,
            int notifyTimeout )
        {
            InitializeComponent();
            var notifySound = new SoundPlayer( @"C:\Users\Daddy\source\repos\Badger\icons\notification\normal.wav" );
            notifySound.Play();
            PictureBox.Image = notifyIcon;
            Title.Text = notifyTitle;
            Body.Text = notifyBody;
            Footer.Text = Assembly.GetExecutingAssembly().GetName().Name;
            notifyTimer.Interval = notifyTimeout;
            notifyTimer.Start();
        }

        public new void Show()
        {
            base.Show();
            FadeIn( this, 20 );
        }

        public void CloseNotify()
        {
            stopFadeOut = false;
            notifyTimer.Stop();
            Close();
        }

        #region WinApi

        protected override void WndProc( ref System.Windows.Forms.Message m )
        {
            if( m.Msg == Notification.WM_MOUSEACTIVATE )
            {
                m.Result = (IntPtr)Notification.MA_NOACTIVATE;
                return;
            }

            base.WndProc( ref m );
        }

        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var param = base.CreateParams;
                param.ExStyle |= Notification.WS_EX_TOPMOST;
                param.ExStyle |= Notification.WS_EX_NOACTIVATE;
                return param;
            }
        }

        #endregion

        #region Animations

        private async void FadeIn( Form o,
            int interval = 80 )
        {
            while( o.Opacity < 1.0 )
            {
                await Task.Delay( interval );
                o.Opacity += 0.05;
            }

            o.Opacity = 1;
        }

        private async void FadeOut( Form o,
            int interval = 80 )
        {
            while( o.Opacity > 0.0 )
            {
                if( stopFadeOut )
                {
                    return;
                }

                await Task.Delay( interval );
                o.Opacity -= 0.05;
            }

            o.Opacity = 0;
            Close();
        }

        #endregion

        #region Event Handlers

        private void ExNotifyBalloon_Load( object sender,
            EventArgs e )
        {
            Location = new Point( Screen.PrimaryScreen.WorkingArea.Width - Width - 20, Screen.PrimaryScreen.WorkingArea.Height - Height - 20 );

            foreach( var openForm in Notification.OpenNotifications )
            {
                openForm.Top -= Height;
            }

            Notification.OpenNotifications.Add( this );

            if( Body.PreferredWidth > Body.Width )
            {
                Title.Location = new Point( 77, 8 );
                Body.Location = new Point( 78, 32 );
                Body.Size = new Size( 262, 53 );
            }
        }

        private void ExNotifyBalloon_FormClosed( object sender,
            FormClosedEventArgs e )
        {
            foreach( var openForm in Notification.OpenNotifications )
            {
                if( openForm == this )
                {
                    break;
                }

                openForm.Top += Height;
            }

            Notification.OpenNotifications.Remove( this );
        }

        private void NotifyTimer_Tick( object sender,
            EventArgs e )
        {
            stopFadeOut = false;
            FadeOut( this, 40 );
            notifyTimer.Stop();
        }

        private void PictureBoxIcon_Click( object sender,
            EventArgs e )
        {
            CloseNotify();
        }

        private void ExNotifyBalloon_Click( object sender,
            EventArgs e )
        {
            CloseNotify();
        }

        private void LabelTitle_Click( object sender,
            EventArgs e )
        {
            CloseNotify();
        }

        private void LabelBody_Click( object sender,
            EventArgs e )
        {
            CloseNotify();
        }

        private void LabelApp_Click( object sender,
            EventArgs e )
        {
            CloseNotify();
        }

        private void Panel1_Click( object sender,
            EventArgs e )
        {
            CloseNotify();
        }

        private void LabelClose_Click( object sender,
            EventArgs e )
        {
            CloseNotify();
        }

        private void LabelClose_MouseEnter( object sender,
            EventArgs e )
        {
            labelClose.ForeColor = Color.DarkGray;
            notifyTimer.Stop();
            stopFadeOut = true;
            Opacity = 1;
        }

        private void LabelClose_MouseLeave( object sender,
            EventArgs e )
        {
            labelClose.ForeColor = Color.DimGray;
        }

        private void PictureBoxIcon_MouseEnter( object sender,
            EventArgs e )
        {
            notifyTimer.Stop();
            stopFadeOut = true;
            Opacity = 1;
        }

        private void LabelTitle_MouseEnter( object sender,
            EventArgs e )
        {
            notifyTimer.Stop();
            stopFadeOut = true;
            Opacity = 1;
        }

        private void LabelBody_MouseEnter( object sender,
            EventArgs e )
        {
            notifyTimer.Stop();
            stopFadeOut = true;
            Opacity = 1;
        }

        private void LabelApp_MouseEnter( object sender,
            EventArgs e )
        {
            notifyTimer.Stop();
            stopFadeOut = true;
            Opacity = 1;
        }

        private void Panel1_MouseLeave( object sender,
            EventArgs e )
        {
            notifyTimer.Start();
            stopFadeOut = false;
        }

        private void Panel1_MouseEnter( object sender,
            EventArgs e )
        {
            notifyTimer.Stop();
            stopFadeOut = true;
            Opacity = 1;
        }

        #endregion
    }
}
