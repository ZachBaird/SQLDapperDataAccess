using FormUI.DAL;
using FormUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        private List<Person> people = new List<Person>();
        public Dashboard()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            peopleFoundListbox.DataSource = people;
            peopleFoundListbox.DisplayMember = "FullInfo";
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var db = new DataAccess();

            // Pass in the LastName textbox value.
            people = db.GetPeople(LastNameTxt.Text);

            UpdateBinding();
        }

        private void findAllBtn_Click(object sender, EventArgs e)
        {
            var db = new DataAccess();

            // Get all people.
            people = db.GetAllPeople();

            UpdateBinding();

            LastNameTxt.Text = string.Empty;
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            var db = new DataAccess();

            // Insert the person.
            db.AddPerson(firstNameEntryTxt.Text, lastNameEntryTxt.Text);

            people = db.GetAllPeople();

            UpdateBinding();
        }
    }
}
