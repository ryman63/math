using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void дисциплиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Disciplines form = new Disciplines();
            form.Show();
        }

        private void ученыеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teachers form = new Teachers();
            form.Show();
        }

        private void теоремыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Theorems form = new Theorems();
            form.Show();
        }

        private void аксиомыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Axioms form = new Axioms();
            form.Show();
        }

        private void леммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lemmas form = new Lemmas();
            form.Show();
        }

        private void задачиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tasks form = new Tasks();
            form.Show();
        }

        private void формулыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulas form = new Formulas();
            form.Show();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Discipline". При необходимости она может быть перемещена или удалена.
            this.disciplineTableAdapter.Fill(this.dataSet1.Discipline);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Teacher". При необходимости она может быть перемещена или удалена.
            this.teacherTableAdapter.Fill(this.dataSet1.Teacher);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.findFromDisciplineTableAdapter.GetData(Convert.ToInt32(comboBox1.SelectedValue));
        }
    }
}
