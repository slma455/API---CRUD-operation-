namespace APIDAY2
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
            dgv_student = new DataGridView();
            txt_Address = new TextBox();
            txt_age = new TextBox();
            txt_Fname = new TextBox();
            txt_Lname = new TextBox();
            cb_dept = new ComboBox();
            cb_super = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btn_delete = new Button();
            btn_add = new Button();
            btn_update = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_student).BeginInit();
            SuspendLayout();
            // 
            // dgv_student
            // 
            dgv_student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_student.Location = new Point(32, 319);
            dgv_student.Name = "dgv_student";
            dgv_student.RowHeadersWidth = 51;
            dgv_student.RowTemplate.Height = 29;
            dgv_student.Size = new Size(734, 292);
            dgv_student.TabIndex = 0;
            dgv_student.CellMouseDoubleClick += dgv_student_CellMouseDoubleClick;
            // 
            // txt_Address
            // 
            txt_Address.Location = new Point(573, 107);
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(125, 27);
            txt_Address.TabIndex = 1;
            // 
            // txt_age
            // 
            txt_age.Location = new Point(573, 191);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(125, 27);
            txt_age.TabIndex = 2;
            // 
            // txt_Fname
            // 
            txt_Fname.Location = new Point(214, 107);
            txt_Fname.Name = "txt_Fname";
            txt_Fname.Size = new Size(125, 27);
            txt_Fname.TabIndex = 3;
            // 
            // txt_Lname
            // 
            txt_Lname.Location = new Point(214, 200);
            txt_Lname.Name = "txt_Lname";
            txt_Lname.Size = new Size(125, 27);
            txt_Lname.TabIndex = 4;
            // 
            // cb_dept
            // 
            cb_dept.FormattingEnabled = true;
            cb_dept.Location = new Point(383, 135);
            cb_dept.Name = "cb_dept";
            cb_dept.Size = new Size(151, 28);
            cb_dept.TabIndex = 5;
            // 
            // cb_super
            // 
            cb_super.FormattingEnabled = true;
            cb_super.Location = new Point(383, 233);
            cb_super.Name = "cb_super";
            cb_super.Size = new Size(151, 28);
            cb_super.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 66);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 8;
            label1.Text = "FirstName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 163);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 9;
            label2.Text = "lastName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(577, 66);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 10;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(582, 159);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 11;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(419, 191);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 12;
            label5.Text = "Super";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(419, 96);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 13;
            label6.Text = "dept";
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(56, 96);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 14;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(56, 155);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 7;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(56, 210);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 15;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 644);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_add);
            Controls.Add(cb_super);
            Controls.Add(cb_dept);
            Controls.Add(txt_Lname);
            Controls.Add(txt_Fname);
            Controls.Add(txt_age);
            Controls.Add(txt_Address);
            Controls.Add(dgv_student);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_student).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_student;
        private TextBox txt_Address;
        private TextBox txt_age;
        private TextBox txt_Fname;
        private TextBox txt_Lname;
        private ComboBox cb_dept;
        private ComboBox cb_super;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btn_add;
        private Button btn_delete;
        private Button btn_update;
    }
}