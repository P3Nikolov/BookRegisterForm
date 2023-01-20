using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm2023
{
    public partial class Form1 : Form
    {
        List<Book> knigi = new List<Book>();
        string janr = "Неизвестен";
        string korica = "Твърда";
        string tematika = "Неизвестена";

        public Form1()
        {
            InitializeComponent();
        }

        private void lblAuthor_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Book b1 = new Book(tbAuthor.Text, tbTitle.Text, cbIzdatelstva.Text, janr, korica, tematika);
            knigi.Add(b1);

            tbAuthor.Text = string.Empty;
            tbTitle.Text = string.Empty;
            cbIzdatelstva.Text = string.Empty;
            rbAction.Checked = false;
            rbHistorical.Checked = false;
            rbScifi.Checked = false;
            rbRoman.Checked = false;
            rbPoezia.Checked = false;
            rbRazkaz.Checked = false;
            chcbKorica.Checked = false;
        }


        private void chcbKorica_CheckedChanged(object sender, EventArgs e)
        {
            if (chcbKorica.Checked)
            {
                korica = "Мека";
            }
        }

        private void rbRoman_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRoman.Checked)
            {
                janr = rbRoman.Text;
            }
        }

        private void rbRazkaz_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRazkaz.Checked)
            {
                janr = rbRazkaz.Text;
            }
        }

        private void rbPoezia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPoezia.Checked)
            {
                janr = rbPoezia.Text;
            }
        }

        private void rbScifi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbScifi.Checked)
            {
                tematika = rbScifi.Text;
            }
        }

        private void rbHistorical_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHistorical.Checked)
            {
                tematika = rbHistorical.Text;
            }
        }

        private void rbAction_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAction.Checked)
            {
                tematika = rbAction.Text;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < knigi.Count; i++)
            {
                MessageBox.Show($"Книга номер {i+1}. \n" +
                    $"Автор: {knigi[i].Author}. \n" +
                    $"Заглавие {knigi[i].Title}. \n" +
                    $"Жанр е {knigi[i].Janr} . \n" +
                    $"Тематиката е {knigi[i].Tematika}. \n" +
                    $"Издателството е {knigi[i].Izdatelstvo}. \n" +
                    $"Корицата е {knigi[i].Korica} \n");
            }
            
            
        }
    }
}
