using System;

namespace BudgetExecution
{
    public class Program
    {
        public Program()
        {
        }

        [ STAThread ]
        public static void Main()
        {
            System.Windows.Forms.Application.Run( new BadgerMain() );
        }
    }
}
