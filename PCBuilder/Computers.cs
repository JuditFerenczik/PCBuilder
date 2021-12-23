using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder
{
    enum OPSystem { Windows, Linux, MacOS };
    class Computers
    {
        string konfigName;
        OPSystem opsystem;
        string ownerName;
        bool gamerConfig;
        List<Parts> computerParts = new List<Parts>();

        public Computers(string konfigName, OPSystem opsystem, string ownerName, bool gamerConfig, List<Parts> computerParts)
        {
            this.KonfigName = konfigName;
            this.Opsystem = opsystem;
            this.OwnerName = ownerName;
            this.GamerConfig = gamerConfig;
            this.ComputerParts = computerParts;
        }

        public string KonfigName { get => konfigName; set => konfigName = value; }
        public string OwnerName { get => ownerName; set => ownerName = value; }
        public bool GamerConfig { get => gamerConfig; set => gamerConfig = value; }
        internal OPSystem Opsystem { get => opsystem; set => opsystem = value; }
        internal List<Parts> ComputerParts { get => computerParts; set => computerParts = value; }

        public override string ToString()
        {
            string computertoS = $"{konfigName};  {opsystem}; {ownerName}; {gamerConfig}";
            for(int i = 0; i < ComputerParts.Count; i++)
            {
                computertoS += $"\t{ComputerParts[i].ToString()}";
            }

            return computertoS;
        }
    }
}
