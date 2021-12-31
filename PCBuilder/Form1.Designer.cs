
namespace PCBuilder
{
    partial class Form1
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
            this.button_new = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.label_konf = new System.Windows.Forms.Label();
            this.label2_price = new System.Windows.Forms.Label();
            this.listBox_SUM = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_new
            // 
            this.button_new.Location = new System.Drawing.Point(6, 364);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(126, 38);
            this.button_new.TabIndex = 1;
            this.button_new.Text = "NEW";
            this.button_new.UseVisualStyleBackColor = true;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(263, 364);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(126, 38);
            this.button_edit.TabIndex = 2;
            this.button_edit.Text = "EDIT";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(541, 364);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(126, 38);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label_konf
            // 
            this.label_konf.AutoSize = true;
            this.label_konf.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_konf.Location = new System.Drawing.Point(12, 331);
            this.label_konf.Name = "label_konf";
            this.label_konf.Size = new System.Drawing.Size(129, 21);
            this.label_konf.TabIndex = 4;
            this.label_konf.Text = "Konfiguration:";
            // 
            // label2_price
            // 
            this.label2_price.AutoSize = true;
            this.label2_price.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_price.Location = new System.Drawing.Point(184, 331);
            this.label2_price.Name = "label2_price";
            this.label2_price.Size = new System.Drawing.Size(52, 21);
            this.label2_price.TabIndex = 5;
            this.label2_price.Text = "Price";
            // 
            // listBox_SUM
            // 
            this.listBox_SUM.FormattingEnabled = true;
            this.listBox_SUM.Location = new System.Drawing.Point(5, 14);
            this.listBox_SUM.Name = "listBox_SUM";
            this.listBox_SUM.Size = new System.Drawing.Size(662, 264);
            this.listBox_SUM.TabIndex = 6;
            this.listBox_SUM.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_SUM_MouseDoubleClick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.listBox_SUM);
            this.Controls.Add(this.label2_price);
            this.Controls.Add(this.label_konf);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_new);
            this.Name = "Form1";
            this.Text = "List of all recorder computers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label_konf;
        private System.Windows.Forms.Label label2_price;
        public System.Windows.Forms.ListBox listBox_SUM;
        public System.Windows.Forms.Button button_new;
    }
}

