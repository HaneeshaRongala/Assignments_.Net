using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CountryCollection countryCollection = new CountryCollection();
            cboCountry.DataSource = countryCollection.GetCountries();
            cboCountry.DisplayMember = "CountryName";
            cboCountry.ValueMember = "CountryId";


            StateCollections stateCollections = new StateCollections();
            cboState.DataSource = stateCollections.GetStates();
            cboState.DisplayMember = "StateName";
            cboState.ValueMember = "StateId";
        }

        private void CboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCountry.SelectedValue.ToString() != null)
            {
                List<State> states = new List<State>();
                states.Add(new State() { StateId = 0, StateName = "Select", CountryId = 0 });
                states.Add(new State() { StateId = 1, StateName = "Telangana", CountryId = 1 });
                states.Add(new State() { StateId = 2, StateName = "Maharastra", CountryId = 1 });
                states.Add(new State() { StateId = 3, StateName = "Kerala", CountryId = 1 });
                states.Add(new State() { StateId = 4, StateName = "Indore", CountryId = 1 });
                states.Add(new State() { StateId = 5, StateName = "Lasvegas", CountryId = 2 });
                states.Add(new State() { StateId = 6, StateName = "Texas", CountryId = 2 });
                states.Add(new State() { StateId = 7, StateName = "Dallas", CountryId = 2 });
                states.Add(new State() { StateId = 8, StateName = "California", CountryId = 2 });
                states.Add(new State() { StateId = 9, StateName = "Queensland", CountryId = 3 });
                states.Add(new State() { StateId = 10, StateName = "Victoria", CountryId = 3 });
                states.Add(new State() { StateId = 11, StateName = "New South wales", CountryId = 3 });
                states.Add(new State() { StateId = 12, StateName = "Tasmania", CountryId = 3 });

                var listOfStates = new List<State>();

                foreach (var item in states)
                {
                    if (item.CountryId == cboCountry.SelectedIndex)
                    {
                        listOfStates.Add(item);
                    }
                }

                cboState.DataSource = listOfStates;
                cboState.DisplayMember = "StateName";
                cboState.ValueMember = "StateId";
            }
        }
    }
}

