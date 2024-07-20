namespace Pract
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.дисциплиныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ученыеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.теоремыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аксиомыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.леммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.формулыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.disciplineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Pract.DataSet1();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter = new Pract.DataSet1TableAdapters.TeacherTableAdapter();
            this.disciplineTableAdapter = new Pract.DataSet1TableAdapters.DisciplineTableAdapter();
            this.findFromDisciplineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.findFromDisciplineTableAdapter = new Pract.DataSet1TableAdapters.FindFromDisciplineTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findFromDisciplineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // дисциплиныToolStripMenuItem
            // 
            this.дисциплиныToolStripMenuItem.Name = "дисциплиныToolStripMenuItem";
            this.дисциплиныToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.дисциплиныToolStripMenuItem.Text = "Дисциплины";
            this.дисциплиныToolStripMenuItem.Click += new System.EventHandler(this.дисциплиныToolStripMenuItem_Click);
            // 
            // ученыеToolStripMenuItem
            // 
            this.ученыеToolStripMenuItem.Name = "ученыеToolStripMenuItem";
            this.ученыеToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ученыеToolStripMenuItem.Text = "Ученые";
            this.ученыеToolStripMenuItem.Click += new System.EventHandler(this.ученыеToolStripMenuItem_Click);
            // 
            // теоремыToolStripMenuItem
            // 
            this.теоремыToolStripMenuItem.Name = "теоремыToolStripMenuItem";
            this.теоремыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.теоремыToolStripMenuItem.Text = "Теоремы";
            this.теоремыToolStripMenuItem.Click += new System.EventHandler(this.теоремыToolStripMenuItem_Click);
            // 
            // аксиомыToolStripMenuItem
            // 
            this.аксиомыToolStripMenuItem.Name = "аксиомыToolStripMenuItem";
            this.аксиомыToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.аксиомыToolStripMenuItem.Text = "Аксиомы";
            this.аксиомыToolStripMenuItem.Click += new System.EventHandler(this.аксиомыToolStripMenuItem_Click);
            // 
            // леммыToolStripMenuItem
            // 
            this.леммыToolStripMenuItem.Name = "леммыToolStripMenuItem";
            this.леммыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.леммыToolStripMenuItem.Text = "Леммы";
            this.леммыToolStripMenuItem.Click += new System.EventHandler(this.леммыToolStripMenuItem_Click);
            // 
            // задачиToolStripMenuItem
            // 
            this.задачиToolStripMenuItem.Name = "задачиToolStripMenuItem";
            this.задачиToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.задачиToolStripMenuItem.Text = "Задачи";
            this.задачиToolStripMenuItem.Click += new System.EventHandler(this.задачиToolStripMenuItem_Click);
            // 
            // формулыToolStripMenuItem
            // 
            this.формулыToolStripMenuItem.Name = "формулыToolStripMenuItem";
            this.формулыToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.формулыToolStripMenuItem.Text = "Формулы";
            this.формулыToolStripMenuItem.Click += new System.EventHandler(this.формулыToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дисциплиныToolStripMenuItem,
            this.ученыеToolStripMenuItem,
            this.теоремыToolStripMenuItem,
            this.аксиомыToolStripMenuItem,
            this.леммыToolStripMenuItem,
            this.задачиToolStripMenuItem,
            this.формулыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(708, 284);
            this.dataGridView1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(600, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "Найти ученого по дисциплине";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.disciplineBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(453, 371);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "Id";
            // 
            // disciplineBindingSource
            // 
            this.disciplineBindingSource.DataMember = "Discipline";
            this.disciplineBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.dataSet1;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // disciplineTableAdapter
            // 
            this.disciplineTableAdapter.ClearBeforeFill = true;
            // 
            // findFromDisciplineBindingSource
            // 
            this.findFromDisciplineBindingSource.DataMember = "FindFromDiscipline";
            this.findFromDisciplineBindingSource.DataSource = this.dataSet1;
            // 
            // findFromDisciplineTableAdapter
            // 
            this.findFromDisciplineTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 423);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findFromDisciplineBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem дисциплиныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ученыеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem теоремыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аксиомыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem леммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem формулыToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private DataSet1TableAdapters.TeacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.BindingSource disciplineBindingSource;
        private DataSet1TableAdapters.DisciplineTableAdapter disciplineTableAdapter;
        private System.Windows.Forms.BindingSource findFromDisciplineBindingSource;
        private DataSet1TableAdapters.FindFromDisciplineTableAdapter findFromDisciplineTableAdapter;
    }
}

