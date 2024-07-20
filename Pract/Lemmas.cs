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
    public partial class Lemmas : Form
    {
        public Lemmas()
        {
            InitializeComponent();
        }

        private void Lemmas_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Lemma". При необходимости она может быть перемещена или удалена.
            this.lemmaTableAdapter.Fill(this.dataSet1.Lemma);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                lemmaTableAdapter.Update(dataSet1);
                MessageBox.Show("Данные успешно сохранены");
            }
            catch
            {
                MessageBox.Show("Нельзя удалить связанные данные");
            }
            
        }
    }
}
