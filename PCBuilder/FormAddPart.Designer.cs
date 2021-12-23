
namespace PCBuilder
{
    partial class FormAddPart
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
            this.textBox_Pname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_pprice = new System.Windows.Forms.TextBox();
            this.textBox_pproducer = new System.Windows.Forms.TextBox();
            this.numericUpDown_pquant = new System.Windows.Forms.NumericUpDown();
            this.button_partadd = new System.Windows.Forms.Button();
            this.listBox_allPart = new System.Windows.Forms.ListBox();
            this.button_selectedPart = new System.Windows.Forms.Button();
            this.button_deletePart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pquant)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME:";
            // 
            // textBox_Pname
            // 
            this.textBox_Pname.Location = new System.Drawing.Point(125, 79);
            this.textBox_Pname.Name = "textBox_Pname";
            this.textBox_Pname.Size = new System.Drawing.Size(180, 20);
            this.textBox_Pname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "QUANTITY:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "PRICE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "PRODUCER:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Proprties of the new part you would like to add:";
            // 
            // textBox_pprice
            // 
            this.textBox_pprice.Location = new System.Drawing.Point(125, 145);
            this.textBox_pprice.Name = "textBox_pprice";
            this.textBox_pprice.Size = new System.Drawing.Size(180, 20);
            this.textBox_pprice.TabIndex = 7;
            // 
            // textBox_pproducer
            // 
            this.textBox_pproducer.Location = new System.Drawing.Point(125, 113);
            this.textBox_pproducer.Name = "textBox_pproducer";
            this.textBox_pproducer.Size = new System.Drawing.Size(180, 20);
            this.textBox_pproducer.TabIndex = 8;
            // 
            // numericUpDown_pquant
            // 
            this.numericUpDown_pquant.Location = new System.Drawing.Point(125, 179);
            this.numericUpDown_pquant.Name = "numericUpDown_pquant";
            this.numericUpDown_pquant.Size = new System.Drawing.Size(180, 20);
            this.numericUpDown_pquant.TabIndex = 9;
            // 
            // button_partadd
            // 
            this.button_partadd.Location = new System.Drawing.Point(134, 225);
            this.button_partadd.Name = "button_partadd";
            this.button_partadd.Size = new System.Drawing.Size(159, 23);
            this.button_partadd.TabIndex = 10;
            this.button_partadd.Text = "ADD TO THE LIST";
            this.button_partadd.UseVisualStyleBackColor = true;
            this.button_partadd.Click += new System.EventHandler(this.button_partadd_Click);
            // 
            // listBox_allPart
            // 
            this.listBox_allPart.FormattingEnabled = true;
            this.listBox_allPart.Location = new System.Drawing.Point(329, 80);
            this.listBox_allPart.Name = "listBox_allPart";
            this.listBox_allPart.Size = new System.Drawing.Size(247, 160);
            this.listBox_allPart.TabIndex = 11;
            // 
            // button_selectedPart
            // 
            this.button_selectedPart.Location = new System.Drawing.Point(366, 246);
            this.button_selectedPart.Name = "button_selectedPart";
            this.button_selectedPart.Size = new System.Drawing.Size(159, 23);
            this.button_selectedPart.TabIndex = 12;
            this.button_selectedPart.Text = "ADD TO MY LIST";
            this.button_selectedPart.UseVisualStyleBackColor = true;
            this.button_selectedPart.Click += new System.EventHandler(this.button_selectedPart_Click);
            // 
            // button_deletePart
            // 
            this.button_deletePart.Location = new System.Drawing.Point(366, 275);
            this.button_deletePart.Name = "button_deletePart";
            this.button_deletePart.Size = new System.Drawing.Size(159, 23);
            this.button_deletePart.TabIndex = 14;
            this.button_deletePart.Text = "DELETE FROM LIST";
            this.button_deletePart.UseVisualStyleBackColor = true;
            this.button_deletePart.Click += new System.EventHandler(this.button_deletePart_Click);
            // 
            // FormAddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 334);
            this.Controls.Add(this.button_deletePart);
            this.Controls.Add(this.button_selectedPart);
            this.Controls.Add(this.listBox_allPart);
            this.Controls.Add(this.button_partadd);
            this.Controls.Add(this.numericUpDown_pquant);
            this.Controls.Add(this.textBox_pproducer);
            this.Controls.Add(this.textBox_pprice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Pname);
            this.Controls.Add(this.label1);
            this.Name = "FormAddPart";
            this.Text = "FormAddPart";
            this.Load += new System.EventHandler(this.FormAddPart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pquant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Pname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_pprice;
        private System.Windows.Forms.TextBox textBox_pproducer;
        private System.Windows.Forms.NumericUpDown numericUpDown_pquant;
        private System.Windows.Forms.Button button_partadd;
        private System.Windows.Forms.Button button_selectedPart;
        private System.Windows.Forms.Button button_deletePart;
        public System.Windows.Forms.ListBox listBox_allPart;
    }
}