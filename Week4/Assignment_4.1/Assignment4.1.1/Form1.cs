using Assignment4._1._1.Models;
using System.ComponentModel;

namespace Assignment4._1._1
{
    public partial class Form1 : Form
    {
        internal Dictionary<string, Person> PeopleDict = new();
        BindingList<Person> PeopleList = new();
        public Form1()
        {
            InitializeComponent();

            InitializeMockData();
            InitializeBinding();
        }

        public void InitializeMockData() 
        {
            Person JohnDoe = new Person("John", "Doe", "123-456-7890", "SumStreetInSumCity", "blahblah@outlook.com");
            Person JaneSmith = new("Jane", "Smith", "123-234-5678", "SumStreetInSumCity", "blah@outlook.com");
            Person JoeSmith = new("Joe", "Smith", "123-098-7654", "SumStreetInSumCity", "blahblahblah?@outlook.com");
            Person JackieChan = new("Jackie", "Chan", "543-876-6543", "DefinetelySomewhereNice", "JCEmail@Hotmail.com");

            PeopleList.Add(JohnDoe);
            PeopleList.Add(JoeSmith);
            PeopleList.Add(JaneSmith);
            PeopleList.Add(JackieChan);

            PeopleDict.Add(JohnDoe.FirstName, JohnDoe);
            PeopleDict.Add(JaneSmith.FirstName, JaneSmith);
            PeopleDict.Add(JoeSmith.FirstName, JoeSmith);
            PeopleDict.Add(JackieChan.FirstName, JackieChan);
        }

        private void InitializeBinding()
        {
            bindingSource1.DataSource = PeopleList;
        }

        private void SearchBoxHandling(string term)
        {
            if (string.IsNullOrWhiteSpace(term))
            {
                // Clear filter to show all records
                bindingSource1.Filter = null;
            }
            else
            {
                // Filter by FirstName or LastName containing the search term
                //Could not make it work
                //bindingSource1.Filter = $"FirstName LIKE '%{term}%' OR LastName LIKE '%{term}%'";

                //LINQ Approach as Recommended by Copilot
                var filtered = PeopleList.Where(p =>
                    p.SearchName.Contains(term, StringComparison.OrdinalIgnoreCase)).ToList();
                bindingSource1.DataSource = filtered;
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchBoxHandling(searchTextbox.Text);
        }
    }
}
