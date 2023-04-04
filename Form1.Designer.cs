
namespace Attendance
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.regNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.week1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.week2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.week3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.week4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.week5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.week6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.week7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIT405BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendance = new Attendance.attendance();
            this.sIT405TableAdapter = new Attendance.attendanceTableAdapters.SIT405TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIT405BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(743, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regNoDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.week1DataGridViewTextBoxColumn,
            this.week2DataGridViewTextBoxColumn,
            this.week3DataGridViewTextBoxColumn,
            this.week4DataGridViewTextBoxColumn,
            this.week5DataGridViewTextBoxColumn,
            this.week6DataGridViewTextBoxColumn,
            this.week7DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sIT405BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(46, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(818, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // regNoDataGridViewTextBoxColumn
            // 
            this.regNoDataGridViewTextBoxColumn.DataPropertyName = "RegNo";
            this.regNoDataGridViewTextBoxColumn.HeaderText = "RegNo";
            this.regNoDataGridViewTextBoxColumn.Name = "regNoDataGridViewTextBoxColumn";
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // week1DataGridViewTextBoxColumn
            // 
            this.week1DataGridViewTextBoxColumn.DataPropertyName = "Week1";
            this.week1DataGridViewTextBoxColumn.HeaderText = "Week1";
            this.week1DataGridViewTextBoxColumn.Name = "week1DataGridViewTextBoxColumn";
            // 
            // week2DataGridViewTextBoxColumn
            // 
            this.week2DataGridViewTextBoxColumn.DataPropertyName = "Week2";
            this.week2DataGridViewTextBoxColumn.HeaderText = "Week2";
            this.week2DataGridViewTextBoxColumn.Name = "week2DataGridViewTextBoxColumn";
            // 
            // week3DataGridViewTextBoxColumn
            // 
            this.week3DataGridViewTextBoxColumn.DataPropertyName = "Week3";
            this.week3DataGridViewTextBoxColumn.HeaderText = "Week3";
            this.week3DataGridViewTextBoxColumn.Name = "week3DataGridViewTextBoxColumn";
            // 
            // week4DataGridViewTextBoxColumn
            // 
            this.week4DataGridViewTextBoxColumn.DataPropertyName = "Week4";
            this.week4DataGridViewTextBoxColumn.HeaderText = "Week4";
            this.week4DataGridViewTextBoxColumn.Name = "week4DataGridViewTextBoxColumn";
            // 
            // week5DataGridViewTextBoxColumn
            // 
            this.week5DataGridViewTextBoxColumn.DataPropertyName = "Week5";
            this.week5DataGridViewTextBoxColumn.HeaderText = "Week5";
            this.week5DataGridViewTextBoxColumn.Name = "week5DataGridViewTextBoxColumn";
            // 
            // week6DataGridViewTextBoxColumn
            // 
            this.week6DataGridViewTextBoxColumn.DataPropertyName = "Week6";
            this.week6DataGridViewTextBoxColumn.HeaderText = "Week6";
            this.week6DataGridViewTextBoxColumn.Name = "week6DataGridViewTextBoxColumn";
            // 
            // week7DataGridViewTextBoxColumn
            // 
            this.week7DataGridViewTextBoxColumn.DataPropertyName = "Week7";
            this.week7DataGridViewTextBoxColumn.HeaderText = "Week7";
            this.week7DataGridViewTextBoxColumn.Name = "week7DataGridViewTextBoxColumn";
            // 
            // sIT405BindingSource
            // 
            this.sIT405BindingSource.DataMember = "SIT405";
            this.sIT405BindingSource.DataSource = this.attendance;
            // 
            // attendance
            // 
            this.attendance.DataSetName = "attendance";
            this.attendance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sIT405TableAdapter
            // 
            this.sIT405TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(897, 355);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIT405BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private attendance attendance;
        private System.Windows.Forms.BindingSource sIT405BindingSource;
        private attendanceTableAdapters.SIT405TableAdapter sIT405TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn regNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn week1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn week2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn week3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn week4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn week5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn week6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn week7DataGridViewTextBoxColumn;
    }
}

