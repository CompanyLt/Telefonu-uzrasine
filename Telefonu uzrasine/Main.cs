using System.Data;
using System.Windows.Forms;
using Telefonu_uzrasine.DIalogai;


namespace Telefonu_uzrasine
{
    public partial class Main : Form
    {
        private Person person;
        private List<Person> personCollection;
        private readonly SqlAction sqlAction;
        private AddContactForm dialogForm;


        public Main(SqlAction _sql_veiksmai)
        {
            InitializeComponent();

            sqlAction = _sql_veiksmai;

            personCollection = new();
            dialogForm = new();
            person = new();
        }

        private void Main_Load(object sender, EventArgs e)
        {

            //surenkame duomenys is duombazes i konteineri
              sqlAction.getAllContacts(personCollection);


            contactsFill();

        }

        private void prideti_Click(object sender, EventArgs e)
        {

            AddContactForm f = new AddContactForm();
            
            //perduodam parametrus
            dialogForm.setEdit(false);
            dialogForm.setPerson(person);
            dialogForm.refill();

            dialogForm.StartPosition = FormStartPosition.CenterParent;

            DialogResult result = dialogForm.ShowDialog();
            //paduodame duomenys jei leidimas suteiktas
            if (dialogForm.premissionGet())
            {
                sqlAction.addContact(person);
            }

            //patikra ar leidimai suteikti prideti i lentele duomenis                   
            if (dialogForm.premissionGet() && person.getPremission())
            {

                personCollection.Add(person);
                person = personCollection.Last();


                contactsFill();
                dialogForm.premissionSet();
                person.setPremission(false);
            }


        }

        private void contactsFill()
        {
            try
            {
                    DataTable dataTable = new();
                    dataTable.Columns.Add(columnName:"Vardas",typeof(string));
                    dataTable.Columns.Add(columnName: "Pavarde", typeof(string));
                    dataTable.Columns.Add(columnName: "Telefono numeris", typeof(string));
                    dataTable.Columns.Add(columnName: "Gimimo data", typeof(string));

            
         
                    foreach (var temp in personCollection)
                    {
              
                        DataRow row = dataTable.NewRow();
                        row["Vardas"] = temp.getName();
                        row["Pavarde"] = temp.getSurnName();
                        row["Telefono numeris"] = temp.getPhoneNumber();
                        row["Gimimo data"] = temp.getBirthDate();
                        dataTable.Rows.Add(row);

               
                    }
            
                    lentele.DataSource = dataTable;
                    lentele.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



            }catch
            {
                MessageBox.Show("Nepavyko prideti", "Pranesimas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
            
        }

        private void redaguoti_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = lentele.SelectedRows[0].Index;
                person = personCollection[rowIndex];

                dialogForm.setEdit(true);
                dialogForm.setPerson(person);
                dialogForm.refill();
                dialogForm.StartPosition = FormStartPosition.CenterParent;
                DialogResult result = dialogForm.ShowDialog();
                //patikra ar leidimas suteiktas
                if (dialogForm.premissionGet())
                {

                    sqlAction.updateContact(person);
                    contactsFill();
                    dialogForm.premissionSet();
                }
            }
            catch
            {
                MessageBox.Show("Nepasirinkote laukelio", "Pranesimas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void istrinti_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = lentele.SelectedRows[0].Index;
                DialogResult result = MessageBox.Show("Ar tikrai norite ištrinti?", "Patvirtinimas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes && lentele.SelectedRows.Count > 0)
                {

                    person = personCollection[rowIndex];
                    sqlAction.deleteContact(person);
                    personCollection.RemoveAt(rowIndex);
                    contactsFill();


                }

            }
            catch
            {
                MessageBox.Show("Nepasirinkote laukelio", "Pranesimas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}
