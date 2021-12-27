using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBuilder
{
    public partial class FormEditComputer : Form
    {
        private bool firstLoad = true;
        public FormEditComputer()
        {
            InitializeComponent();
        }

        private void button_cpAdd_Click(object sender, EventArgs e)
        {
            Program.formAddPart.ShowDialog();
        }

        private void button_cpDelete_Click(object sender, EventArgs e)
        {
            if (listBox_partlist.SelectedIndex != -1)
            {
                listBox_partlist.Items.Remove(listBox_partlist.SelectedItem);
            }
            else
            {
                MessageBox.Show("Nothing was selected, nothing was deleted");
            }
        }

        private void FormEditComputer_Load(object sender, EventArgs e)
        {
            if (comboBox_opsys.Items.Count < 1)
            {
                foreach (string item in Enum.GetNames(typeof(OPSystem)))
                {
                    comboBox_opsys.Items.Add(item);
                }
            }
            
        }

        private void clearInputs()
        {
            textBox_konf.Text = "";
            comboBox_opsys.SelectedIndex = -1;
            textBox_owner.Text = "";
            listBox_partlist.Items.Clear();
        }
        private void button_cNew_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textBox_konf.Text))
            {
                MessageBox.Show("Konfiguration field cannot be empty!", "Error");
                return;
            }
            else if (comboBox_opsys.SelectedIndex == -1)
            {
                MessageBox.Show("You must choose an oparating system!", "Error");
                return;
            }
            else if (String.IsNullOrEmpty(textBox_owner.Text))
            {
                MessageBox.Show("Owner field cnnot be empty!", "Error");
                return;
            }
            else if (listBox_partlist.Items.Count > 10 || listBox_partlist.Items.Count < 1)
            {
                MessageBox.Show("Your Computer must contain at least one and at most 10 parts!");
                return;
            }

            if (button_cNew.Text == "ADD NEW COMPUTER")
            {
                string mymessage = "New computer added with the values:\n";
                mymessage += $"KOnfiguration: {textBox_konf.Text}\n";
                mymessage += $"Operating system: {comboBox_opsys.SelectedItem}\n";
                mymessage += $"Owner: {textBox_owner.Text}\n";
                string isGamer = checkBox_gamer.Checked ? "Gamer" : "Not Gamer";
                mymessage += $" {isGamer}\n";
                List<Parts> myPartList = new List<Parts>();
                for (int i = 0; i < listBox_partlist.Items.Count; i++)
                {

                    Parts myPart = (Parts)(listBox_partlist.Items[i]);
                    myPartList.Add(myPart);
                    mymessage += $"Part {i + 1}: {listBox_partlist.Items[i]}\n";

                }

                MessageBox.Show(mymessage);
                OPSystem opSystem = (OPSystem)Enum.Parse(typeof(OPSystem), comboBox_opsys.SelectedIndex.ToString());
                Computers mynewcomp = new Computers(textBox_konf.Text, opSystem, textBox_owner.Text, checkBox_gamer.Checked, myPartList);
                MessageBox.Show(mynewcomp.ToString());
                Program.form1.listBox_SUM.Items.Add("2");
                Program.form1.listBox_SUM.Items.Add("3");
                clearInputs();

            }
            else
            {
                Computers selectedComp = (Computers)Program.form1.listBox_SUM.SelectedItem;
                MessageBox.Show(Program.form1.listBox_SUM.SelectedIndex.ToString());
                OPSystem opSystem = (OPSystem)Enum.Parse(typeof(OPSystem), comboBox_opsys.SelectedIndex.ToString());
            
               
                    selectedComp.Opsystem = opSystem;
                selectedComp.OwnerName = textBox_owner.Text;
                selectedComp.GamerConfig = checkBox_gamer.Checked;
                textBox_konf.ReadOnly = false;
                listBox_partlist.Enabled = true;
                label1.Text = "Properties of the computer you would like to add";
                button_cNew.Text = "ADD NEW COMPUTER";
                clearInputs();
                Program.form1.ShowDialog();


            }



        }
    }
}
