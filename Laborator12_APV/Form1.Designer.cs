namespace Laborator12_APV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewEmployeeList = new DataGridView();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            delete_btn = new Button();
            update_btn = new Button();
            save_btn = new Button();
            textBoxSalariu = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPrenume = new TextBox();
            textBoxName = new TextBox();
            textBoxID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployeeList).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewEmployeeList
            // 
            dataGridViewEmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployeeList.Location = new Point(27, 12);
            dataGridViewEmployeeList.Margin = new Padding(4, 3, 4, 3);
            dataGridViewEmployeeList.Name = "dataGridViewEmployeeList";
            dataGridViewEmployeeList.Size = new Size(747, 166);
            dataGridViewEmployeeList.TabIndex = 4;
            dataGridViewEmployeeList.CellClick += dataGridViewEmployeeList_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(56, 18);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(26, 20);
            label5.TabIndex = 4;
            label5.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(56, 95);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Prenume";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(56, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Nume";
            // 
            // panel1
            // 
            panel1.Controls.Add(delete_btn);
            panel1.Controls.Add(update_btn);
            panel1.Controls.Add(save_btn);
            panel1.Controls.Add(textBoxSalariu);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(textBoxPrenume);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(textBoxID);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(27, 193);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(747, 285);
            panel1.TabIndex = 5;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(322, 227);
            delete_btn.Margin = new Padding(4, 3, 4, 3);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(124, 43);
            delete_btn.TabIndex = 12;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // update_btn
            // 
            update_btn.Location = new Point(191, 227);
            update_btn.Margin = new Padding(4, 3, 4, 3);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(124, 43);
            update_btn.TabIndex = 11;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = true;
            update_btn.Click += update_btn_Click;
            // 
            // save_btn
            // 
            save_btn.Location = new Point(61, 227);
            save_btn.Margin = new Padding(4, 3, 4, 3);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(124, 43);
            save_btn.TabIndex = 10;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // textBoxSalariu
            // 
            textBoxSalariu.Location = new Point(166, 179);
            textBoxSalariu.Margin = new Padding(4, 3, 4, 3);
            textBoxSalariu.Name = "textBoxSalariu";
            textBoxSalariu.Size = new Size(172, 23);
            textBoxSalariu.TabIndex = 9;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(166, 138);
            textBoxEmail.Margin = new Padding(4, 3, 4, 3);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(172, 23);
            textBoxEmail.TabIndex = 8;
            // 
            // textBoxPrenume
            // 
            textBoxPrenume.Location = new Point(166, 97);
            textBoxPrenume.Margin = new Padding(4, 3, 4, 3);
            textBoxPrenume.Name = "textBoxPrenume";
            textBoxPrenume.Size = new Size(172, 23);
            textBoxPrenume.TabIndex = 7;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(166, 60);
            textBoxName.Margin = new Padding(4, 3, 4, 3);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(172, 23);
            textBoxName.TabIndex = 6;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(166, 22);
            textBoxID.Margin = new Padding(4, 3, 4, 3);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(172, 23);
            textBoxID.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(56, 177);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 3;
            label4.Text = "Salariu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(56, 136);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 490);
            Controls.Add(dataGridViewEmployeeList);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployeeList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewEmployeeList;
        private Label label5;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button delete_btn;
        private Button update_btn;
        private Button save_btn;
        private TextBox textBoxSalariu;
        private TextBox textBoxEmail;
        private TextBox textBoxPrenume;
        private TextBox textBoxName;
        private TextBox textBoxID;
        private Label label4;
        private Label label3;
    }
}