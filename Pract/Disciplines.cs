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
    public partial class Disciplines : Form
    {
        public Disciplines()
        {
            InitializeComponent();
        }

        private void Disciplines_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Teacher". При необходимости она может быть перемещена или удалена.
            this.teacherTableAdapter.Fill(this.dataSet1.Teacher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Discipline". При необходимости она может быть перемещена или удалена.
            this.disciplineTableAdapter.Fill(this.dataSet1.Discipline);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.disciplineTableAdapter.Update(dataSet1);
                MessageBox.Show("Данные успешно сохранены");
            }
            catch
            {
                MessageBox.Show("Нельзя удалить связанные данные");
            }
            
        }
    }
}
