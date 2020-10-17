// // <copyright file = "Notification.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

using System.ComponentModel;
using System.Drawing.Text;
using VisualPlus.Enumerators;
using VisualPlus.Toolkit.Controls.Layout;

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

    /// <summary> </summary>
    /// <seealso cref = "Syncfusion.Windows.Forms.MetroForm"/>
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "RedundantExtendsListEntry" ) ]
    [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameter" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "PartialTypeWithSinglePart" ) ]
    public partial class Notification : MetroForm
    {
        // ***************************************************************************************************************************
        // ****************************************************    FIELDS     ********************************************************
        // ***************************************************************************************************************************

        /// <summary> The wm mouseactivate </summary>
        private const int WM_MOUSEACTIVATE = 0x0021, MA_NOACTIVATE = 0x0003;

        /// <summary> The open notifications </summary>
        private static readonly List<Notification> OpenNotifications = new List<Notification>();

        /// <summary> The ws ex noactivate </summary>
        private const int WS_EX_NOACTIVATE = 0x08000000;

        /// <summary> The ws ex topmost </summary>
        private const int WS_EX_TOPMOST = 0x00000008;

        /// <summary> The effect </summary>
        private bool Effect;

        /// <summary> The footer </summary>
        public Label Footer;

        /// <summary> The PictureBox </summary>
        public PictureBox PictureBox;

        /// <summary> The title </summary>
        public Label Title;

        /// <summary> The body </summary>
        public Label Body;

        /// <summary> The timer </summary>
        public Timer Timer;

        /// <summary> The label </summary>
        public Label Label;

        /// <summary> The panel </summary>
        public VisualPanel Panel;

        /// <summary> The components </summary>
        private IContainer components;

        // ***************************************************************************************************************************
        // ****************************************************  CONSTRUCTORS ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "Notification"/>
        /// class.
        /// </summary>
        /// <param name = "icon" > The icon. </param>
        /// <param name = "title" > The title. </param>
        /// <param name = "body" > The body. </param>
        /// <param name = "time" > The time. </param>
        public Notification( Bitmap icon, string title, string body,
            int time )
        {
            InitializeComponent();

            var sound =
                new SoundPlayer( @"C:\Users\Daddy\source\repos\Badger\icons\notification\normal.wav" );

            sound.Play();
            PictureBox.Image = icon;
            Title.Text = title;
            Body.Text = body;
            Footer.Text = Assembly.GetExecutingAssembly().GetName().Name;
            Timer.Interval = time;
            Timer.Start();
        }

        /// <summary> Initializes the component. </summary>
        private void InitializeComponent()
        {
            components = new Container();
            Footer = new Label();
            PictureBox = new PictureBox();
            Title = new Label();
            Body = new Label();
            Timer = new Timer( components );
            Panel = new VisualPanel();
            Label = new Label();
            ( (ISupportInitialize)PictureBox ).BeginInit();
            Panel.SuspendLayout();
            SuspendLayout();

            // 
            // Footer
            // 
            Footer.AutoSize = true;
            Footer.BackColor = Color.FromArgb( 10, 10, 11 );

            Footer.Font = new Font( "Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point,
                204 );

            Footer.ForeColor = Color.DimGray;
            Footer.Location = new Point( 76, 78 );
            Footer.Name = "Footer";
            Footer.Size = new Size( 100, 13 );
            Footer.TabIndex = 6;
            Footer.Text = "App located name";

            // 
            // PictureBox
            // 
            PictureBox.BackColor = Color.FromArgb( 10, 10, 11 );
            PictureBox.Location = new Point( 13, 27 );
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size( 36, 36 );
            PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox.TabIndex = 5;
            PictureBox.TabStop = false;

            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.None;
            Title.AutoEllipsis = true;
            Title.AutoSize = true;
            Title.BackColor = Color.FromArgb( 10, 10, 11 );

            Title.Font = new Font( "Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point,
                204 );

            Title.ForeColor = Color.LightGray;
            Title.Location = new Point( 75, 9 );
            Title.Name = "Title";
            Title.Size = new Size( 142, 23 );
            Title.TabIndex = 3;
            Title.Text = "Title located here";
            Title.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // Body
            // 
            Body.Anchor = AnchorStyles.None;
            Body.AutoEllipsis = true;
            Body.BackColor = Color.FromArgb( 10, 10, 11 );

            Body.Font = new Font( "Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point,
                204 );

            Body.ForeColor = Color.DarkGray;
            Body.Location = new Point( 76, 34 );
            Body.Name = "Body";
            Body.Size = new Size( 262, 29 );
            Body.TabIndex = 4;
            Body.Text = "Body located here";

            // 
            // Panel
            // 
            Panel.BackColor = Color.FromArgb( 10, 10, 11 );
            Panel.BackColorState.Disabled = Color.FromArgb( 10, 10, 11 );
            Panel.BackColorState.Enabled = Color.FromArgb( 10, 10, 11 );
            Panel.Border.Color = Color.FromArgb( 128, 64, 0 );
            Panel.Border.HoverColor = Color.FromArgb( 128, 64, 0 );
            Panel.Border.HoverVisible = true;
            Panel.Border.Rounding = 6;
            Panel.Border.Thickness = 1;
            Panel.Border.Type = ShapeTypes.Rounded;
            Panel.Border.Visible = true;
            Panel.Controls.Add( Label );
            Panel.Controls.Add( PictureBox );
            Panel.Controls.Add( Footer );
            Panel.Controls.Add( Body );
            Panel.Controls.Add( Title );
            Panel.Dock = DockStyle.Fill;
            Panel.ForeColor = Color.FromArgb( 0, 0, 0 );
            Panel.Location = new Point( 0, 0 );
            Panel.MouseState = MouseStates.Normal;
            Panel.Name = "Panel";
            Panel.Padding = new Padding( 5 );
            Panel.Size = new Size( 360, 100 );
            Panel.TabIndex = 10;
            Panel.TextStyle.Disabled = Color.FromArgb( 131, 129, 129 );
            Panel.TextStyle.Enabled = Color.FromArgb( 0, 0, 0 );
            Panel.TextStyle.Hover = Color.FromArgb( 0, 0, 0 );
            Panel.TextStyle.Pressed = Color.FromArgb( 0, 0, 0 );
            Panel.TextStyle.TextAlignment = StringAlignment.Center;
            Panel.TextStyle.TextLineAlignment = StringAlignment.Center;
            Panel.TextStyle.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            // 
            // Label
            // 
            Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label.AutoSize = true;
            Label.BackColor = Color.FromArgb( 10, 10, 11 );
            Label.Cursor = Cursors.Hand;

            Label.Font = new Font( "Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point,
                204 );

            Label.ForeColor = Color.DimGray;
            Label.Location = new Point( 340, 5 );
            Label.Name = "Label";
            Label.Size = new Size( 17, 18 );
            Label.TabIndex = 8;
            Label.Text = "x";

            // 
            // Notification
            // 
            AutoScaleDimensions = new SizeF( 6F, 13F );
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb( 10, 10, 11 );
            ClientSize = new Size( 360, 100 );
            Controls.Add( Panel );
            FormBorderStyle = FormBorderStyle.None;
            Name = "Notification";
            Opacity = 0D;
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "ExNotify";
            ( (ISupportInitialize)PictureBox ).EndInit();
            Panel.ResumeLayout( false );
            Panel.PerformLayout();
            ResumeLayout( false );
        }

        /// <summary> Clean up any resources being used. </summary>
        /// <param name = "disposing" >
        /// true if managed resources should be disposed;
        /// otherwise, false.
        /// </param>
        protected override void Dispose( bool disposing )
        {
            if( disposing )
            {
                components?.Dispose();
            }

            base.Dispose( disposing );
        }

        /// <summary> Displays the control to the user. </summary>
        public new void Show()
        {
            base.Show();
            FadeIn( this, 20 );
        }

        /// <summary> Closes the notify. </summary>
        public void CloseNotify()
        {
            Effect = false;
            Timer.Stop();
            Close();
        }

        #region WinApi

        /// <summary> WNDs the proc. </summary>
        /// <param name = "m" > The m. </param>
        protected override void WndProc( ref System.Windows.Forms.Message m )
        {
            if( m.Msg == WM_MOUSEACTIVATE )
            {
                m.Result = (IntPtr)MA_NOACTIVATE;
                return;
            }

            base.WndProc( ref m );
        }

        /// <summary>
        /// Gets a value indicating whether the window will be activated when it
        /// is shown.
        /// </summary>
        protected override bool ShowWithoutActivation
        {
            get
            {
                return true;
            }
        }

        /// <summary> Gets the create parameters. </summary>
        /// <value> The create parameters. </value>
        protected override CreateParams CreateParams
        {
            get
            {
                var param = base.CreateParams;
                param.ExStyle |= WS_EX_TOPMOST;
                param.ExStyle |= WS_EX_NOACTIVATE;
                return param;
            }
        }

        #endregion

        #region Animations

        /// <summary> Fades the in. </summary>
        /// <param name = "o" > The o. </param>
        /// <param name = "interval" > The interval. </param>
        private async void FadeIn( Form o, int interval = 80 )
        {
            while( o.Opacity < 1.0 )
            {
                await Task.Delay( interval );
                o.Opacity += 0.05;
            }

            o.Opacity = 1;
        }

        /// <summary> Fades the out. </summary>
        /// <param name = "o" > The o. </param>
        /// <param name = "interval" > The interval. </param>
        private async void FadeOut( Form o, int interval = 80 )
        {
            while( o.Opacity > 0.0 )
            {
                if( Effect )
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

        /// <summary> Handles the Load event of the ExNotifyBalloon control. </summary>
        /// <param name = "sender" > The source of the event. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void ExNotifyBalloon_Load( object sender, EventArgs e )
        {
            Location = new Point( Screen.PrimaryScreen.WorkingArea.Width - Width - 20,
                Screen.PrimaryScreen.WorkingArea.Height - Height - 20 );

            foreach( var openForm in OpenNotifications )
            {
                openForm.Top -= Height;
            }

            OpenNotifications.Add( this );

            if( Body.PreferredWidth > Body.Width )
            {
                Title.Location = new Point( 77, 8 );
                Body.Location = new Point( 78, 32 );
                Body.Size = new Size( 262, 53 );
            }
        }

        /// <summary> Handles the FormClosed event of the ExNotifyBalloon control. </summary>
        /// <param name = "sender" > The source of the event. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "FormClosedEventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void ExNotifyBalloon_FormClosed( object sender, FormClosedEventArgs e )
        {
            foreach( var openForm in OpenNotifications )
            {
                if( openForm == this )
                {
                    break;
                }

                openForm.Top += Height;
            }

            OpenNotifications.Remove( this );
        }

        /// <summary> Handles the Tick event of the NotifyTimer control. </summary>
        /// <param name = "sender" > The source of the event. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void NotifyTimer_Tick( object sender, EventArgs e )
        {
            Effect = false;
            FadeOut( this, 40 );
            Timer.Stop();
        }

        /// <summary> Handles the Click event of the PictureBoxIcon control. </summary>
        /// <param name = "sender" > The source of the event. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void PictureBoxIcon_Click( object sender, EventArgs e )
        {
            CloseNotify();
        }

        /// <summary> Handles the Click event of the ExNotifyBalloon control. </summary>
        /// <param name = "sender" > The source of the event. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void ExNotifyBalloon_Click( object sender, EventArgs e )
        {
            CloseNotify();
        }

        /// <summary> Handles the Click event of the LabelTitle control. </summary>
        /// <param name = "sender" > The source of the event. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void LabelTitle_Click( object sender, EventArgs e )
        {
            CloseNotify();
        }

        /// <summary> Handles the Click event of the LabelBody control. </summary>
        /// <param name = "sender" > The source of the event. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void LabelBody_Click( object sender, EventArgs e )
        {
            CloseNotify();
        }

        /// <summary> Handles the Click event of the LabelApp control. </summary>
        /// <param name = "sender" > The source of the event. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void LabelApp_Click( object sender, EventArgs e )
        {
            CloseNotify();
        }

        /// <summary> Handles the Click event of the Panel1 control. </summary>
        /// <param name = "sender" > The source of the event. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void Panel1_Click( object sender, EventArgs e )
        {
            CloseNotify();
        }

        /// <summary> Handles the Click event of the LabelClose control. </summary>
        /// <param name = "sender" > The source of the event. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void LabelClose_Click( object sender, EventArgs e )
        {
            CloseNotify();
        }

        /// <summary> Handles the MouseEnter event of the LabelClose control. </summary>
        /// <param name = "sender" > The source of the event. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void LabelClose_MouseEnter( object sender, EventArgs e )
        {
            Label.ForeColor = Color.DarkGray;
            Timer.Stop();
            Effect = true;
            Opacity = 1;
        }

        /// <summary> Handles the MouseLeave event of the LabelClose control. </summary>
        /// <param name = "sender" > The source of the event. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void LabelClose_MouseLeave( object sender, EventArgs e )
        {
            Label.ForeColor = Color.DimGray;
        }

        /// <summary> Handles the MouseEnter event of the PictureBoxIcon control. </summary>
        /// <param name = "sender" > The source of the event. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void PictureBoxIcon_MouseEnter( object sender, EventArgs e )
        {
            Timer.Stop();
            Effect = true;
            Opacity = 1;
        }

        /// <summary> Handles the MouseEnter event of the LabelTitle control. </summary>
        /// <param name = "sender" > The source of the event. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void LabelTitle_MouseEnter( object sender, EventArgs e )
        {
            Timer.Stop();
            Effect = true;
            Opacity = 1;
        }

        /// <summary> Handles the MouseEnter event of the LabelBody control. </summary>
        /// <param name = "sender" > The source of the event. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void LabelBody_MouseEnter( object sender, EventArgs e )
        {
            Timer.Stop();
            Effect = true;
            Opacity = 1;
        }

        /// <summary> Handles the MouseEnter event of the LabelApp control. </summary>
        /// <param name = "sender" > The source of the event. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void LabelApp_MouseEnter( object sender, EventArgs e )
        {
            Timer.Stop();
            Effect = true;
            Opacity = 1;
        }

        /// <summary> Handles the MouseLeave event of the Panel1 control. </summary>
        /// <param name = "sender" > The source of the event. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void Panel1_MouseLeave( object sender, EventArgs e )
        {
            Timer.Start();
            Effect = false;
        }

        /// <summary> Handles the MouseEnter event of the Panel1 control. </summary>
        /// <param name = "sender" > The source of the event. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void Panel1_MouseEnter( object sender, EventArgs e )
        {
            Timer.Stop();
            Effect = true;
            Opacity = 1;
        }

        #endregion
    }
}