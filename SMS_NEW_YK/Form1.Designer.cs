
namespace SMS_NEW_YK
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
            this.grdvStudent = new System.Windows.Forms.DataGridView();
            this.btnallStudent = new System.Windows.Forms.Button();
            this.btnFaculty = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.btnGrade = new System.Windows.Forms.Button();
            this.btnSerach = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.comDepartment = new System.Windows.Forms.ComboBox();
            this.btnByDepartment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // grdvStudent
            // 
            this.grdvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdvStudent.Location = new System.Drawing.Point(2, 474);
            this.grdvStudent.Name = "grdvStudent";
            this.grdvStudent.RowHeadersWidth = 123;
            this.grdvStudent.RowTemplate.Height = 46;
            this.grdvStudent.Size = new System.Drawing.Size(2250, 936);
            this.grdvStudent.TabIndex = 0;
            // 
            // btnallStudent
            // 
            this.btnallStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnallStudent.Location = new System.Drawing.Point(12, 23);
            this.btnallStudent.Name = "btnallStudent";
            this.btnallStudent.Size = new System.Drawing.Size(306, 150);
            this.btnallStudent.TabIndex = 1;
            this.btnallStudent.Text = "Get All Student";
            this.btnallStudent.UseVisualStyleBackColor = true;
            this.btnallStudent.Click += new System.EventHandler(this.btnallStudent_Click);
            // 
            // btnFaculty
            // 
            this.btnFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaculty.Location = new System.Drawing.Point(354, 23);
            this.btnFaculty.Name = "btnFaculty";
            this.btnFaculty.Size = new System.Drawing.Size(312, 150);
            this.btnFaculty.TabIndex = 2;
            this.btnFaculty.Text = "Get All Faculty";
            this.btnFaculty.UseVisualStyleBackColor = true;
            this.btnFaculty.Click += new System.EventHandler(this.btnFaculty_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourse.Location = new System.Drawing.Point(1056, 23);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(339, 150);
            this.btnCourse.TabIndex = 3;
            this.btnCourse.Text = "Get All Course";
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnDepartment
            // 
            this.btnDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartment.Location = new System.Drawing.Point(688, 23);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(346, 150);
            this.btnDepartment.TabIndex = 4;
            this.btnDepartment.Text = "Get All Department";
            this.btnDepartment.UseVisualStyleBackColor = true;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // btnGrade
            // 
            this.btnGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrade.Location = new System.Drawing.Point(1421, 23);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(320, 150);
            this.btnGrade.TabIndex = 5;
            this.btnGrade.Text = "Get All Grade";
            this.btnGrade.UseVisualStyleBackColor = true;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // btnSerach
            // 
            this.btnSerach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerach.Location = new System.Drawing.Point(1020, 199);
            this.btnSerach.Name = "btnSerach";
            this.btnSerach.Size = new System.Drawing.Size(297, 123);
            this.btnSerach.TabIndex = 6;
            this.btnSerach.Text = "Serach by Name";
            this.btnSerach.UseVisualStyleBackColor = true;
            this.btnSerach.Click += new System.EventHandler(this.btnSerach_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 199);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(927, 123);
            this.txtName.TabIndex = 7;
            // 
            // comDepartment
            // 
            this.comDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comDepartment.FormattingEnabled = true;
            this.comDepartment.Location = new System.Drawing.Point(12, 367);
            this.comDepartment.Name = "comDepartment";
            this.comDepartment.Size = new System.Drawing.Size(927, 81);
            this.comDepartment.TabIndex = 8;
            this.comDepartment.SelectedIndexChanged += new System.EventHandler(this.comDepartment_SelectedIndexChanged);
            // 
            // btnByDepartment
            // 
            this.btnByDepartment.Location = new System.Drawing.Point(1020, 367);
            this.btnByDepartment.Name = "btnByDepartment";
            this.btnByDepartment.Size = new System.Drawing.Size(478, 81);
            this.btnByDepartment.TabIndex = 9;
            this.btnByDepartment.Text = "Search by Department";
            this.btnByDepartment.UseVisualStyleBackColor = true;
            this.btnByDepartment.Click += new System.EventHandler(this.btnByDepartment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2400, 1422);
            this.Controls.Add(this.btnByDepartment);
            this.Controls.Add(this.comDepartment);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSerach);
            this.Controls.Add(this.btnGrade);
            this.Controls.Add(this.btnDepartment);
            this.Controls.Add(this.btnCourse);
            this.Controls.Add(this.btnFaculty);
            this.Controls.Add(this.btnallStudent);
            this.Controls.Add(this.grdvStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdvStudent;
        private System.Windows.Forms.Button btnallStudent;
        private System.Windows.Forms.Button btnFaculty;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.Button btnSerach;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox comDepartment;
        private System.Windows.Forms.Button btnByDepartment;
    }
}

