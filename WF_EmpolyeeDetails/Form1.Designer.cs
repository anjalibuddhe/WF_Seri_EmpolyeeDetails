namespace WF_EmpolyeeDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Emp_ID = new System.Windows.Forms.TextBox();
            this.Emp_Name = new System.Windows.Forms.TextBox();
            this.EMp_Salary = new System.Windows.Forms.TextBox();
            this.Binary_Writer = new System.Windows.Forms.Button();
            this.Binary_Read = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emp_Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary";
            // 
            // Emp_ID
            // 
            this.Emp_ID.Location = new System.Drawing.Point(299, 72);
            this.Emp_ID.Multiline = true;
            this.Emp_ID.Name = "Emp_ID";
            this.Emp_ID.Size = new System.Drawing.Size(128, 31);
            this.Emp_ID.TabIndex = 3;
            // 
            // Emp_Name
            // 
            this.Emp_Name.Location = new System.Drawing.Point(299, 120);
            this.Emp_Name.Multiline = true;
            this.Emp_Name.Name = "Emp_Name";
            this.Emp_Name.Size = new System.Drawing.Size(128, 31);
            this.Emp_Name.TabIndex = 4;
            // 
            // EMp_Salary
            // 
            this.EMp_Salary.Location = new System.Drawing.Point(299, 169);
            this.EMp_Salary.Multiline = true;
            this.EMp_Salary.Name = "EMp_Salary";
            this.EMp_Salary.Size = new System.Drawing.Size(128, 31);
            this.EMp_Salary.TabIndex = 5;
            // 
            // Binary_Writer
            // 
            this.Binary_Writer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Binary_Writer.Location = new System.Drawing.Point(192, 247);
            this.Binary_Writer.Name = "Binary_Writer";
            this.Binary_Writer.Size = new System.Drawing.Size(141, 52);
            this.Binary_Writer.TabIndex = 6;
            this.Binary_Writer.Text = "Binary Writer";
            this.Binary_Writer.UseVisualStyleBackColor = true;
            this.Binary_Writer.Click += new System.EventHandler(this.Binary_Writer_Click);
            // 
            // Binary_Read
            // 
            this.Binary_Read.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Binary_Read.Location = new System.Drawing.Point(350, 247);
            this.Binary_Read.Name = "Binary_Read";
            this.Binary_Read.Size = new System.Drawing.Size(141, 52);
            this.Binary_Read.TabIndex = 7;
            this.Binary_Read.Text = "Binary Read";
            this.Binary_Read.UseVisualStyleBackColor = true;
            this.Binary_Read.Click += new System.EventHandler(this.Binary_Read_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Binary_Read);
            this.Controls.Add(this.Binary_Writer);
            this.Controls.Add(this.EMp_Salary);
            this.Controls.Add(this.Emp_Name);
            this.Controls.Add(this.Emp_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Emp_ID;
        private System.Windows.Forms.TextBox Emp_Name;
        private System.Windows.Forms.TextBox EMp_Salary;
        private System.Windows.Forms.Button Binary_Writer;
        private System.Windows.Forms.Button Binary_Read;
    }
}

