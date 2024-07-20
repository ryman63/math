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
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Task". При необходимости она может быть перемещена или удалена.
            this.taskTableAdapter.Fill(this.dataSet1.Task);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Lemma". При необходимости она может быть перемещена или удалена.
            this.lemmaTableAdapter.Fill(this.dataSet1.Lemma);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Theorem". При необходимости она может быть перемещена или удалена.
            this.theoremTableAdapter.Fill(this.dataSet1.Theorem);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Axiom". При необходимости она может быть перемещена или удалена.
            this.axiomTableAdapter.Fill(this.dataSet1.Axiom);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Teacher". При необходимости она может быть перемещена или удалена.
            this.teacherTableAdapter.Fill(this.dataSet1.Teacher);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                teacherTableAdapter.Update(dataSet1);
                MessageBox.Show("Данные успешно сохранены");
            }
            catch
            {
                MessageBox.Show("Нельзя удалить связанные данные");
            }
            
        }
    }
}
