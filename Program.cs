namespace BudgetExecution
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Program"/> class.
        /// </summary>
        public Program()
        {
        }

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        [ STAThread ]
        public static void Main()
        {
            Application.Run( new BadgerMain() );
        }
    }
}
