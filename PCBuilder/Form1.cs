using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void button_new_Click(object sender, EventArgs e)
        {
        
            Program.formEditComputer.textBox_konf.ReadOnly = false;
            Program.formEditComputer.listBox_partlist.Enabled = true;
            Program.formEditComputer.label1.Text = "Properties of the computer you would like to add";
            Program.formEditComputer.button_cNew.Text = "ADD NEW COMPUTER";
            Program.formEditComputer.textBox_konf.Text = "";
            Program.formEditComputer.textBox_owner.Text = "";
            Program.formEditComputer.comboBox_opsys.SelectedIndex = -1;
            Program.formEditComputer.checkBox_gamer.Checked = false;
            Program.formEditComputer.textBox_owner.Text = "";
            Program.formEditComputer.listBox_partlist.Items.Clear();
            Program.formEditComputer.ShowDialog();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {

            if (listBox_SUM.SelectedIndex < 0)
            {
                MessageBox.Show("Nothing was selected so nothing was deleted");
                return;
            }
            if (MessageBox.Show("Do you really want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                listBox_SUM.Items.Remove(listBox_SUM.SelectedItem);
            }
            
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if(listBox_SUM.SelectedIndex > -1)
            {
                Computers selectedComp = (Computers)listBox_SUM.SelectedItem;
                Program.formEditComputer.listBox_partlist.Items.Clear();
                Program.formEditComputer.label1.Text = "Properties of the computer you would like to change";
                Program.formEditComputer.button_cNew.Text = "CHANGE THE COMPUTER";
                Program.formEditComputer.textBox_konf.Text = selectedComp.KonfigName;
                Program.formEditComputer.textBox_konf.ReadOnly = true;
              
                for (int i = 0; i < selectedComp.ComputerParts.Count; i++)
                {
                    Parts subparts = (Parts)selectedComp.ComputerParts[i];
                    Program.formEditComputer.listBox_partlist.Items.Add(subparts);


                }
                if (Program.formEditComputer.comboBox_opsys.Items.Count < 1)
                {
                    foreach (string item in Enum.GetNames(typeof(OPSystem)))
                    {
                        Program.formEditComputer.comboBox_opsys.Items.Add(item);
                    }
                }

                for (int i = 0; i < Program.formEditComputer.comboBox_opsys.Items.Count; i++)
                {
                    if (selectedComp.Opsystem.ToString() == Program.formEditComputer.comboBox_opsys.Items[i].ToString())
                    {
                        Program.formEditComputer.comboBox_opsys.SelectedIndex = i;
                    }

                }
              
                Program.formEditComputer.textBox_owner.Text = selectedComp.OwnerName;
                Program.formEditComputer.checkBox_gamer.Checked = selectedComp.GamerConfig;
            
                Program.formEditComputer.listBox_partlist.Enabled = false;
                Program.formEditComputer.ShowDialog();
              

            }
            else
            {
                MessageBox.Show("Nothing was selected to change!");
            }
       

        }
        private void LoadAllData()
        {
            if (File.Exists("szamitogepek.csv") && File.Exists("alkatreszek.csv"))
            {
              //  MessageBox.Show("Loading data");

                using (StreamReader sr = new StreamReader("szamitogepek.csv"))
                {
                    while (!sr.EndOfStream)
                    {
                        List<Parts> tmp = new List<Parts>();
                        string[] rowComp = sr.ReadLine().Split(';');


                        using (StreamReader sr2 = new StreamReader("alkatreszek.csv"))
                        {
                            while (!sr2.EndOfStream)
                            {
                                string[] rowPart = sr2.ReadLine().Split(';');

                                if(rowComp[0] == rowPart[0])
                                {
                                  //  MessageBox.Show("In the second loop");
                                    Parts partTmp = new Parts(rowPart[1], rowPart[2], double.Parse( rowPart[3]),int.Parse(rowPart[4]));
                                    tmp.Add(partTmp);
                                    Program.formAddPart.listBox_allPart.Items.Add(partTmp);
                                   // MessageBox.Show(partTmp.ToString());
                                }
                                
                            }
                          /*  MessageBox.Show(rowComp[0]);
                            MessageBox.Show(rowComp[1]);
                            MessageBox.Show(rowComp[2]);
                            MessageBox.Show(rowComp[3]);*/
                            Computers newComputer = new Computers(rowComp[0], (OPSystem)Enum.Parse(typeof(OPSystem), rowComp[1]), rowComp[2], bool.Parse(rowComp[3]), tmp);
                            listBox_SUM.Items.Add(newComputer);
                        }
                    }
            }   }

        }
  
            private void listBox_SUM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }
        private double priceCalculation(Computers CompPrice)
        {
            double money = 0;
            for(int i = 0; i < CompPrice.ComputerParts.Count; i++)
            {
                Parts partCalc = (Parts)CompPrice.ComputerParts[i];
                money += partCalc.Price *(double) partCalc.Quantity;
            }
            if(CompPrice.Opsystem.ToString() == "Windows")
            {
                money += 40;
            }else if(CompPrice.Opsystem.ToString() == "MacOS")
            {
                money += 100;
            }

            if (CompPrice.GamerConfig)
            {
                money *= 1.3;
            }
            return money;

            
        }

        private void listBox_SUM_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            Computers selectedComp = (Computers)listBox_SUM.SelectedItem;
            label_konf.Text = selectedComp.KonfigName;
            double calculatedPrice = priceCalculation(selectedComp);
            label2_price.Text = calculatedPrice.ToString();

            MessageBox.Show(listBox_SUM.SelectedItem.ToString());

        }
    }
}
