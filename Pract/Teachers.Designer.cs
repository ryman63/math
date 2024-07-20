namespace Pract
{
    partial class Teachers
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idaxiomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.axiomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Pract.DataSet1();
            this.idtheoremDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.theoremBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idlemmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lemmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idtaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.teacherTableAdapter = new Pract.DataSet1TableAdapters.TeacherTableAdapter();
            this.axiomTableAdapter = new Pract.DataSet1TableAdapters.AxiomTableAdapter();
            this.theoremTableAdapter = new Pract.DataSet1TableAdapters.TheoremTableAdapter();
            this.lemmaTableAdapter = new Pract.DataSet1TableAdapters.LemmaTableAdapter();
            this.taskTableAdapter = new Pract.DataSet1TableAdapters.TaskTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axiomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theoremBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lemmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.idaxiomDataGridViewTextBoxColumn,
            this.idtheoremDataGridViewTextBoxColumn,
            this.idlemmaDataGridViewTextBoxColumn,
            this.idtaskDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.teacherBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(33, 31);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(644, 388);
            this.dataGridView2.TabIndex = 3;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "Full Name";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Full Name";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // idaxiomDataGridViewTextBoxColumn
            // 
            this.idaxiomDataGridViewTextBoxColumn.DataPropertyName = "Id_axiom";
            this.idaxiomDataGridViewTextBoxColumn.DataSource = this.axiomBindingSource;
            this.idaxiomDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.idaxiomDataGridViewTextBoxColumn.HeaderText = "Axiom";
            this.idaxiomDataGridViewTextBoxColumn.Name = "idaxiomDataGridViewTextBoxColumn";
            this.idaxiomDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idaxiomDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idaxiomDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // axiomBindingSource
            // 
            this.axiomBindingSource.DataMember = "Axiom";
            this.axiomBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idtheoremDataGridViewTextBoxColumn
            // 
            this.idtheoremDataGridViewTextBoxColumn.DataPropertyName = "Id_theorem";
            this.idtheoremDataGridViewTextBoxColumn.DataSource = this.theoremBindingSource;
            this.idtheoremDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.idtheoremDataGridViewTextBoxColumn.HeaderText = "Theorem";
            this.idtheoremDataGridViewTextBoxColumn.Name = "idtheoremDataGridViewTextBoxColumn";
            this.idtheoremDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idtheoremDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idtheoremDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // theoremBindingSource
            // 
            this.theoremBindingSource.DataMember = "Theorem";
            this.theoremBindingSource.DataSource = this.dataSet1;
            // 
            // idlemmaDataGridViewTextBoxColumn
            // 
            this.idlemmaDataGridViewTextBoxColumn.DataPropertyName = "Id_lemma";
            this.idlemmaDataGridViewTextBoxColumn.DataSource = this.lemmaBindingSource;
            this.idlemmaDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.idlemmaDataGridViewTextBoxColumn.HeaderText = "Lemma";
            this.idlemmaDataGridViewTextBoxColumn.Name = "idlemmaDataGridViewTextBoxColumn";
            this.idlemmaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idlemmaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idlemmaDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // lemmaBindingSource
            // 
            this.lemmaBindingSource.DataMember = "Lemma";
            this.lemmaBindingSource.DataSource = this.dataSet1;
            // 
            // idtaskDataGridViewTextBoxColumn
            // 
            this.idtaskDataGridViewTextBoxColumn.DataPropertyName = "Id_task";
            this.idtaskDataGridViewTextBoxColumn.DataSource = this.taskBindingSource;
            this.idtaskDataGridViewTextBoxColumn.DisplayMember = "Text";
            this.idtaskDataGridViewTextBoxColumn.HeaderText = "Task";
            this.idtaskDataGridViewTextBoxColumn.Name = "idtaskDataGridViewTextBoxColumn";
            this.idtaskDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idtaskDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idtaskDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataMember = "Task";
            this.taskBindingSource.DataSource = this.dataSet1;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.dataSet1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(697, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 78);
            this.button2.TabIndex = 2;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // axiomTableAdapter
            // 
            this.axiomTableAdapter.ClearBeforeFill = true;
            // 
            // theoremTableAdapter
            // 
            this.theoremTableAdapter.ClearBeforeFill = true;
            // 
            // lemmaTableAdapter
            // 
            this.lemmaTableAdapter.ClearBeforeFill = true;
            // 
            // taskTableAdapter
            // 
            this.taskTableAdapter.ClearBeforeFill = true;
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Name = "Teachers";
            this.Text = "Teachers";
            this.Load += new System.EventHandler(this.Teachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axiomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theoremBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lemmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private DataSet1TableAdapters.TeacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.BindingSource axiomBindingSource;
        private DataSet1TableAdapters.AxiomTableAdapter axiomTableAdapter;
        private System.Windows.Forms.BindingSource theoremBindingSource;
        private DataSet1TableAdapters.TheoremTableAdapter theoremTableAdapter;
        private System.Windows.Forms.BindingSource lemmaBindingSource;
        private DataSet1TableAdapters.LemmaTableAdapter lemmaTableAdapter;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private DataSet1TableAdapters.TaskTableAdapter taskTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idaxiomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idtheoremDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idlemmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idtaskDataGridViewTextBoxColumn;
    }
}