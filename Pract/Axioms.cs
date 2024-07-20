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
    public partial class Axioms : Form
    {
        public Axioms()
        {
            InitializeComponent();
        }

        private void Axioms_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Axiom". При необходимости она может быть перемещена или удалена.
            this.axiomTableAdapter.Fill(this.dataSet1.Axiom);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                axiomTableAdapter.Update(dataSet1);
                MessageBox.Show("Данные успешно сохранены");
            }
            catch
            {
                MessageBox.Show("Нельзя удалить связанные данные");
            }
        }
    }
}
