using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Telefonu_uzrasine.DIalogai
{
    public partial class AddContactForm : Form
    {
        private int space;
        private bool isEdit;     
        private bool premission;
        Person person;

        public AddContactForm()
        {
            InitializeComponent();
           

        }


       



       

       
        

        //objekto geteris
        public Person getPerson()
        {

            return person;


        }
        //seteris
        public void setPerson(Person _asmuo)
        {
            person = _asmuo;

        }

        public void setEdit(bool _edit)
        {
            isEdit = _edit;
        }



        private void vardas_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isEdit && vardas.ForeColor != Color.Black)
            {
                vardas.ForeColor = Color.Black;
                vardas.Text = "";
            }

        }
        private void vardas_KeyPress(object sender, KeyPressEventArgs e)
        {
            int simbolis = (int)e.KeyChar;

            if (simbolis >= 65 && simbolis <= 90 || simbolis >= 97 && simbolis <= 122 || simbolis == 8 || simbolis == 32)
            {
                e.Handled = true;
                check(simbolis);
            }
            else
            {
                e.Handled = true;

            }
        }
        private void numeris_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isEdit && numeris.ForeColor != Color.Black)
            {
                numeris.Text = "+370";
                numeris.SelectionStart = numeris.Text.Length;
                numeris.ForeColor = Color.Black;
            }



        }
        private void numeris_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57 || (int)e.KeyChar == 8)
            {

            }
            else
            {
                e.Handled = true;

            }
        }

        private void data_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isEdit && data.ForeColor != Color.Black)
            {
                data.ForeColor = Color.Black;
                data.Text = "";

            }

        }
        private void data_KeyPress(object sender, KeyPressEventArgs e)
        {
            int simbolis = (int)e.KeyChar;

            if (simbolis >= 48 && simbolis <= 57 || simbolis == 8)
            {
                data.SelectionStart = data.TextLength;
            }
            else
            {
                e.Handled = true;
            }


            if (data.TextLength == 4 && simbolis != 8)
            {
                data.Text += "-";
                data.SelectionStart = data.TextLength;


            }
            else if (data.TextLength == 7 && simbolis != 8)
            {

                data.Text += "-";
                data.SelectionStart = data.TextLength;


            }
        }



        bool areaFillCheck(string name, string number, string data)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(number) || string.IsNullOrWhiteSpace(data))
            {
                return false;
            }
            else
                return true;


        }

        public void refill()
        {
            if (!isEdit)
            {
                label1.Text = "Kontakto pridėjimas";
                label1.Location = new Point(28, 9);
                vardas.Text = "\"Pavardenis Pavardenis\"";
                numeris.Text = "\"+370\"";
                data.Text = "\"YYYY-MM-DD\"";
                pranesimas.Text = "";
                vardas.ForeColor = Color.Gray;
                numeris.ForeColor = Color.Gray;
                data.ForeColor = Color.Gray;

            }
            else
            {
                label1.Text = "Kontakto redagavimas";
                label1.Location = new Point(10, 9);
                vardas.Text = $"{person.getName()} {person.getSurnName()}";
                numeris.Text = person.getPhoneNumber();
                data.Text = person.getBirthDate();
                pranesimas.Text = "";
                vardas.ForeColor = Color.Black;
                numeris.ForeColor = Color.Black;
                data.ForeColor = Color.Black;
            }

        }




        //Paprasta patikra ar pirmoji raide didzioji
        private void check(int simbolis)
        {
            int select = vardas.SelectionStart;
            if (simbolis >= 97 && simbolis != 8 && space == 0)
            {
                vardas.Text = vardas.Text.Insert(select, Convert.ToChar(simbolis - 32).ToString());
                vardas.SelectionStart = select + 1;
                space = 1;
            }

            else if (simbolis != 8)
            {
                vardas.Text = vardas.Text.Insert(select, Convert.ToChar(simbolis).ToString());
                vardas.SelectionStart = select + 1;
                space = 1;

            }
            else
            {
                //trynimas
                if (select > 0 && select <= vardas.Text.Length)
                {
                    vardas.Text = vardas.Text.Remove(select - 1, 1);
                    vardas.SelectionStart = select - 1;
                }
            }
            //spacebar numetimas...
            if (simbolis == 32)
            {
                space = 0;
            }
            if (vardas.Text.Length == 0)
            {
                space = 0;
            }
        }

        private void patvirtinimas_Click(object sender, EventArgs e)
        {
            
            if (vardo_patikra(vardas.Text, numeris.Text, data.Text))
            {
                this.Close();

            }


        }

        private bool vardo_patikra(string ivestis, string ivestis_2, string ivestis_3)
        {
            string[] dalys = ivestis.Split(' ');


            if (dalys.Length == 2 && ivestis_2.Length > 1 && ivestis_3.Length > 1)
            {
                person.setName(dalys[0]);
                person.setSurName(dalys[1]);
                person.setPhoneNumber(numeris.Text);
                person.setBirthDate(data.Text);
                //suteikiame leidima leidzianti atlikti tolimesni duomenu apdorojima
                premission = true;


                return true;
            }
            else
            {
                MessageBox.Show("Neivesti duomenys");
            }


            return false;
        }

        public bool premissionGet()
        {
            return premission;
        }

        public void premissionSet()
        {
            premission = false;
        }

        private void Prideti_kontakta_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void atsaukti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Prideti_kontakta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (1 == 0)
            {
                // MessageBox.Show("Klaida");
                e.Cancel = true;
                return;
            }
        }
    }
}
