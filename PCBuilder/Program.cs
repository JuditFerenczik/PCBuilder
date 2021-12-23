using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBuilder
{
    static class Program

    {
        public static List<Parts> allParts = null;
        public static Form1 form1 = null;
        public static FormAddPart formAddPart = null;
        public static FormEditComputer formEditComputer = null;
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form1 = new Form1();
            allParts = new List<Parts>();
            formAddPart = new FormAddPart();
            formEditComputer = new FormEditComputer();
            Application.Run(new Form1());
        }
    }
}
