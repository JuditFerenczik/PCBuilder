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
   
    public partial class FormAddPart : Form
    {
       
        public FormAddPart()
        {
            InitializeComponent();
        }

  
        private void button_partadd_Click(object sender, EventArgs e)
        {
            if (listBox_allPart.Items.Count < 10)
            {

            
                double price = 0;
            if (String.IsNullOrEmpty(textBox_Pname.Text))
            {
                MessageBox.Show("Name field cannot be empty!", "Error");
                return;
            }
            else if (String.IsNullOrEmpty(textBox_pproducer.Text))
            {
                MessageBox.Show("Producer field cannot be empty!", "Error");
                return;
            }
            else if (String.IsNullOrEmpty(textBox_pprice.Text) || !double.TryParse(textBox_pprice.Text, out price) || price < 10)
            {
                MessageBox.Show("Format of the price is not valid!Price cannot be less than 10", "Error");
                return;
            }else if(numericUpDown_pquant.Value == 0)
            {
                MessageBox.Show("Quantity must be greater than 0!");
                return;
            }
            /*
            string mymessage = "New part added with the values:\n";
            mymessage += $"Name: {textBox_Pname.Text}\n";
            mymessage += $"Producer: {textBox_pproducer.Text}\n";
            mymessage += $"Price: {price}\n";
            mymessage += $"Quantity: {numericUpDown_pquant.Value}\n";
            MessageBox.Show(mymessage);*/
            Parts mynewpart = new Parts(textBox_Pname.Text, textBox_pproducer.Text, price, (int)numericUpDown_pquant.Value);
            listBox_allPart.Items.Add(mynewpart);
            Program.allParts.Add(mynewpart);
            clearInputs();
            }
            else
            {
                MessageBox.Show("Already 10 parts in the list, you have to delete something if you would like to add something");
            }
        }

        private void FormAddPart_Load(object sender, EventArgs e)
        {

        }

        private void LoadParts()
        {
        
            foreach(Parts part in Program.allParts)
            {
                listBox_allPart.Items.Add(part);
            }

        }
        private void clearInputs()
        {
            textBox_Pname.Text = "";
            textBox_pproducer.Text = "";
            textBox_pprice.Text = "";
            numericUpDown_pquant.Value = numericUpDown_pquant.Minimum;
        }

        private void button_selectedPart_Click(object sender, EventArgs e)
        {
            if(listBox_allPart.SelectedIndex != -1) {

                Program.formEditComputer.listBox_partlist.Items.Add(listBox_allPart.SelectedItem);
            }
            else
            {
                MessageBox.Show("Nothing was selected, not added to your list!");
            }
           
            
            
        }

        private void button_deletePart_Click(object sender, EventArgs e)
        {
            if (listBox_allPart.SelectedIndex != -1)
            {
                listBox_allPart.Items.Remove(listBox_allPart.SelectedItem);
            }
            else
            {
                MessageBox.Show("Nothing was selected, nothing was deleted!");
            }

            }
        }
  
}
