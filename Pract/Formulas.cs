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
    public partial class Formulas : Form
    {
        public Formulas()
        {
            InitializeComponent();
        }

        private void Formulas_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Formula". При необходимости она может быть перемещена или удалена.
            this.formulaTableAdapter.Fill(this.dataSet1.Formula);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                formulaTableAdapter.Update(dataSet1);
                MessageBox.Show("Данные успешно сохранены");
            }
            catch
            {
                MessageBox.Show("Нельзя удалить связанные данные");
            }
        }
    }
}
