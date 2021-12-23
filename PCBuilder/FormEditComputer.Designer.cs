
namespace PCBuilder
{
    partial class FormEditComputer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_konf = new System.Windows.Forms.TextBox();
            this.checkBox_gamer = new System.Windows.Forms.CheckBox();
            this.comboBox_opsys = new System.Windows.Forms.ComboBox();
            this.textBox_owner = new System.Windows.Forms.TextBox();
            this.listBox_partlist = new System.Windows.Forms.ListBox();
            this.button_cpAdd = new System.Windows.Forms.Button();
            this.button_cpDelete = new System.Windows.Forms.Button();
            this.button_cNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Properties of the computer you would like to add:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "OPERATING SYSTEM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "KONFIGURATION:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "PARTLIST:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "GAMER SPEC.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "OWNER\'S NAME:";
            // 
            // textBox_konf
            // 
            this.textBox_konf.Location = new System.Drawing.Point(169, 66);
            this.textBox_konf.Name = "textBox_konf";
            this.textBox_konf.Size = new System.Drawing.Size(239, 20);
            this.textBox_konf.TabIndex = 6;
            // 
            // checkBox_gamer
            // 
            this.checkBox_gamer.AutoSize = true;
            this.checkBox_gamer.Location = new System.Drawing.Point(169, 175);
            this.checkBox_gamer.Name = "checkBox_gamer";
            this.checkBox_gamer.Size = new System.Drawing.Size(47, 17);
            this.checkBox_gamer.TabIndex = 7;
            this.checkBox_gamer.Text = "YES";
            this.checkBox_gamer.UseVisualStyleBackColor = true;
            // 
            // comboBox_opsys
            // 
            this.comboBox_opsys.FormattingEnabled = true;
            this.comboBox_opsys.Location = new System.Drawing.Point(169, 99);
            this.comboBox_opsys.Name = "comboBox_opsys";
            this.comboBox_opsys.Size = new System.Drawing.Size(239, 21);
            this.comboBox_opsys.TabIndex = 8;
            // 
            // textBox_owner
            // 
            this.textBox_owner.Location = new System.Drawing.Point(169, 134);
            this.textBox_owner.Name = "textBox_owner";
            this.textBox_owner.Size = new System.Drawing.Size(239, 20);
            this.textBox_owner.TabIndex = 9;
            // 
            // listBox_partlist
            // 
            this.listBox_partlist.FormattingEnabled = true;
            this.listBox_partlist.Location = new System.Drawing.Point(169, 212);
            this.listBox_partlist.Name = "listBox_partlist";
            this.listBox_partlist.Size = new System.Drawing.Size(248, 95);
            this.listBox_partlist.TabIndex = 10;
            // 
            // button_cpAdd
            // 
            this.button_cpAdd.Location = new System.Drawing.Point(423, 230);
            this.button_cpAdd.Name = "button_cpAdd";
            this.button_cpAdd.Size = new System.Drawing.Size(75, 23);
            this.button_cpAdd.TabIndex = 11;
            this.button_cpAdd.Text = "NEW PART";
            this.button_cpAdd.UseVisualStyleBackColor = true;
            this.button_cpAdd.Click += new System.EventHandler(this.button_cpAdd_Click);
            // 
            // button_cpDelete
            // 
            this.button_cpDelete.Location = new System.Drawing.Point(421, 272);
            this.button_cpDelete.Name = "button_cpDelete";
            this.button_cpDelete.Size = new System.Drawing.Size(75, 23);
            this.button_cpDelete.TabIndex = 13;
            this.button_cpDelete.Text = "DELETE";
            this.button_cpDelete.UseVisualStyleBackColor = true;
            this.button_cpDelete.Click += new System.EventHandler(this.button_cpDelete_Click);
            // 
            // button_cNew
            // 
            this.button_cNew.Location = new System.Drawing.Point(54, 344);
            this.button_cNew.Name = "button_cNew";
            this.button_cNew.Size = new System.Drawing.Size(195, 45);
            this.button_cNew.TabIndex = 14;
            this.button_cNew.Text = "ADD NEW COMPUTER";
            this.button_cNew.UseVisualStyleBackColor = true;
            this.button_cNew.Click += new System.EventHandler(this.button_cNew_Click);
            // 
            // FormEditComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 450);
            this.Controls.Add(this.button_cNew);
            this.Controls.Add(this.button_cpDelete);
            this.Controls.Add(this.button_cpAdd);
            this.Controls.Add(this.listBox_partlist);
            this.Controls.Add(this.textBox_owner);
            this.Controls.Add(this.comboBox_opsys);
            this.Controls.Add(this.checkBox_gamer);
            this.Controls.Add(this.textBox_konf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEditComputer";
            this.Text = "ADD NEW COMPUTER";
            this.Load += new System.EventHandler(this.FormEditComputer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_cpAdd;
        private System.Windows.Forms.Button button_cpDelete;
        public System.Windows.Forms.ListBox listBox_partlist;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button_cNew;
        public System.Windows.Forms.TextBox textBox_konf;
        public System.Windows.Forms.CheckBox checkBox_gamer;
        public System.Windows.Forms.ComboBox comboBox_opsys;
        public System.Windows.Forms.TextBox textBox_owner;
    }
}