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
    public partial class Theorems : Form
    {
        public Theorems()
        {
            InitializeComponent();
        }

        private void Theorems_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Theorem". При необходимости она может быть перемещена или удалена.
            this.theoremTableAdapter.Fill(this.dataSet1.Theorem);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                theoremTableAdapter.Update(dataSet1);
                MessageBox.Show("Данные успешно сохранены");
            }
            catch
            {
                MessageBox.Show("Нельзя удалить связанные данные");
            }
            
        }
    }
}
