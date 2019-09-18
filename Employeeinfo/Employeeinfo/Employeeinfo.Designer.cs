namespace Employeeinfo
{
    partial class Employeeinfo
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
            this.Employeeinfo_grid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmployeeName = new System.Windows.Forms.TextBox();
            this.EmployeeSalary = new System.Windows.Forms.TextBox();
            this.EmployeeId = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Employeeinfo_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkViolet;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic Semilight", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMPLOYEE INFORMATION";
            // 
            // Employeeinfo_grid
            // 
            this.Employeeinfo_grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Employeeinfo_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Employeeinfo_grid.Location = new System.Drawing.Point(120, 230);
            this.Employeeinfo_grid.Name = "Employeeinfo_grid";
            this.Employeeinfo_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Employeeinfo_grid.Size = new System.Drawing.Size(619, 263);
            this.Employeeinfo_grid.TabIndex = 1;
            this.Employeeinfo_grid.SelectionChanged += new System.EventHandler(this.Employeeinfo_grid_SelectionChanged_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkViolet;
            this.button1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(778, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Click here to view Employee info";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.BlueViolet;
            this.button2.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(778, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Insert Employee info";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.BlueViolet;
            this.button3.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(778, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 32);
            this.button3.TabIndex = 4;
            this.button3.Text = "Update Employee info";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.BlueViolet;
            this.button4.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(778, 389);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(201, 32);
            this.button4.TabIndex = 5;
            this.button4.Text = "Delete Employee info";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BlueViolet;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Employee Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BlueViolet;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(129, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Employee Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.BlueViolet;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Employee Salary:";
            // 
            // EmployeeName
            // 
            this.EmployeeName.Location = new System.Drawing.Point(408, 139);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(165, 20);
            this.EmployeeName.TabIndex = 10;
            // 
            // EmployeeSalary
            // 
            this.EmployeeSalary.Location = new System.Drawing.Point(408, 187);
            this.EmployeeSalary.Name = "EmployeeSalary";
            this.EmployeeSalary.Size = new System.Drawing.Size(165, 20);
            this.EmployeeSalary.TabIndex = 11;
            // 
            // EmployeeId
            // 
            this.EmployeeId.Location = new System.Drawing.Point(408, 94);
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.Size = new System.Drawing.Size(165, 20);
            this.EmployeeId.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.BlueViolet;
            this.button5.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(778, 446);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(201, 31);
            this.button5.TabIndex = 13;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click_1);
            // 
            // Employeeinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(1013, 546);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.EmployeeId);
            this.Controls.Add(this.EmployeeSalary);
            this.Controls.Add(this.EmployeeName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Employeeinfo_grid);
            this.Controls.Add(this.label1);
            this.Name = "Employeeinfo";
            this.Text = "Employeeinfo";
            ((System.ComponentModel.ISupportInitialize)(this.Employeeinfo_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Employeeinfo_grid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmployeeName;
        private System.Windows.Forms.TextBox EmployeeSalary;
        private System.Windows.Forms.TextBox EmployeeId;
        private System.Windows.Forms.Button button5;
    }
}