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
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
        }

        private void Tasks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Formula". При необходимости она может быть перемещена или удалена.
            this.formulaTableAdapter.Fill(this.dataSet1.Formula);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Task". При необходимости она может быть перемещена или удалена.
            this.taskTableAdapter.Fill(this.dataSet1.Task);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                taskTableAdapter.Update(dataSet1);
                MessageBox.Show("Данные успешно сохранены");
            }
            catch
            {
                MessageBox.Show("Нельзя удалить связанные данные");
            }
            
        }
    }
}
