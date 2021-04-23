using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.Helpers;

namespace WindowsForm.Forms
{
    public partial class PersonsInfo : Form
    {
        private string baseUrl = "https://localhost:44303/api/Persons/";
        public PersonsInfo()
        {
            InitializeComponent();
        }

        public async Task<List<Person>> GetPersonsAsync()
        {
            var persons = await ServiceHelper.GetDataAsync<List<Person>>(this.baseUrl + "all");
            return persons;
        }
        public async Task<bool> SavePersonsAsync(Person person)
        {
            return await ServiceHelper.PostDataAsync(this.baseUrl + "save",person);
        }
        public async Task<bool> UpdatePersonsAsync(Person person)
        {
            return await ServiceHelper.UpdateDataAsync(this.baseUrl + "update/"+ person.Id,person);
        }
        public async Task<bool> DeletePersonsAsync(int id)
        {
            return await ServiceHelper.DeleteDataAsync(this.baseUrl + "delete/" + id);
        }
        public async Task<List<Person>> SearchPersonsAsync(string name)
        {
            var persons = await ServiceHelper.GetDataAsync<List<Person>>(this.baseUrl + "search?name="+name);
            return persons;
        }
        private async void PersonsInfo_Load(object sender, EventArgs e)
        {
            await LoadPersons();
        }

        private async Task LoadPersons()
        {
            this.dgwPersons.DataSource = await this.GetPersonsAsync();
        }

        private void dgwPersons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwPersons.CurrentRow;
            if (row == null) return;
            tbxUpdateAge.Text = row.Cells[1].Value.ToString();
            tbxUpdateName.Text = row.Cells[2].Value.ToString();
            tbxUpdateSurname.Text = row.Cells[3].Value.ToString();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var person = new Person()
            {
                PersonName = tbxSaveName.Text,
                PersonSurname = tbxSaveSurname.Text,
                Age = Convert.ToInt32(tbxSaveAge.Text)
            };
            await SavePersonsAsync(person);
            await LoadPersons();
            MessageBox.Show(@"Added" +@" "+ person.PersonName);
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgwPersons.CurrentRow != null)
            {
                var person = new Person()
                {
                    Id = Convert.ToInt32(dgwPersons.CurrentRow.Cells[0].Value),
                    Age = Convert.ToInt32(tbxUpdateAge.Text),
                    PersonName = tbxUpdateName.Text,
                    PersonSurname = tbxUpdateSurname.Text
                };
                await UpdatePersonsAsync(person);
                await LoadPersons();
                MessageBox.Show(@"Updated"+ @" " + person.PersonName);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwPersons.CurrentRow != null)
            {
                var person = new Person()
                {
                    Id = Convert.ToInt32(dgwPersons.CurrentRow.Cells[0].Value),
                    PersonName = tbxUpdateName.Text
                };
                await DeletePersonsAsync(person.Id);
                await LoadPersons();
                MessageBox.Show(@"Deleted" + @" " + person.PersonName);
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var name = tbxSearchByName.Text;
            if (!string.IsNullOrEmpty(name))
            {
                dgwPersons.DataSource = await SearchPersonsAsync(name);
            }
            else
            {
                await LoadPersons();
            }
        }
    }
}
