using System;
using System.Windows.Forms;

namespace LABA2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Person new_person;

            if (NameBox.Text == "")
            {
                MessageBox.Show("Введите имя");
            }
            if (AgeBox.Text != "")
            {
                if (ProfessionBox.Text != "")
                {
                    new_person = new Person(NameBox.Text, Convert.ToInt32(AgeBox.Text), ProfessionBox.Text);
                }
                else
                {
                    new_person = new Person(NameBox.Text, Convert.ToInt32(AgeBox.Text));
                }
            }
            else
            {
                if (ProfessionBox.Text != "")
                {
                    new_person = new Person(NameBox.Text, 0, ProfessionBox.Text);
                }
                else
                {
                    new_person = new Person(NameBox.Text);
                }
            }
            ResultBox.Text = new_person.GetInformation();

        }
    }
}
