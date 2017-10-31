using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicStoreSYS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSuppReg());
            Application.Run(new frmUpdSupp());
            Application.Run(new frmDeregSupp());
            Application.Run(new frmSuppList());
            Application.Run(new frmProSales());
            Application.Run(new frmTotRev());
            Application.Run(new frmInsNewCD());
            Application.Run(new frmUpdCD());
            Application.Run(new frmDisCD());               
            Application.Run(new frmPreordCD());
            Application.Run(new frmRecCD());
            Application.Run(new frmPayment());
            Application.Run(new frmAnalyCDSales());
            Application.Run(new frmAnalyCDStock());
        }
    }
}
