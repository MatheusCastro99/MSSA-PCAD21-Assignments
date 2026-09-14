using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System.ComponentModel;

namespace Assignments_10._3
{
    public partial class Form1 : Form
    {
        AutoShopContext myDb;
        BindingList<Car> carListBinding = new();

        public Form1()
        {
            InitializeComponent();

            myDb = new();
            myDb.Database.EnsureCreated();

            UpdateTable();
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            myDb.Add(
                new Car
                {
                    VIN = vinRichTextBox.Text,
                    Maker = makeRichTextBox.Text,
                    Model = modelRichTextBox.Text,
                    Year = Convert.ToInt32(yearRichTextBox.Text),
                    Price = Convert.ToDouble(priceRichTextBox.Text),
                    IsAvailable = true
                });
            await myDb.SaveChangesAsync();

            UpdateTable();

            ResetFields();
        }

        private async void delCarButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select exactly 1 car to delete");
                return;
            }

            Car selectedCar = (Car)dataGridView1.SelectedRows[0].DataBoundItem!;

            myDb.Cars.Remove(selectedCar);
            await myDb.SaveChangesAsync();

            UpdateTable();
        }

        private void searchRichTextBox_Changed(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchRichTextBox.Text))
            {
                UpdateTable();
                return;
            }

            var selectedCars = myDb.Cars
                .Where(c => c.VIN.Contains(searchRichTextBox.Text))
                .ToList();

            carListBinding = new(selectedCars);
            dataGridView1.DataSource = carListBinding;
        }

        private void UpdateTable()
        {
            carListBinding = new(myDb.Cars.ToList());
            dataGridView1.DataSource = carListBinding;
        }

        private void ResetFields()
        {
            vinRichTextBox.Text = "";
            makeRichTextBox.Text = "";
            modelRichTextBox.Text = "";
            yearRichTextBox.Text = "";
            priceRichTextBox.Text = "";
        }
    }
}
