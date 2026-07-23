using System.ComponentModel;

namespace MainView
{
    public partial class Form1 : Form
    {
        BindingList<Coffee> coffees = new();
        public Form1()
        {
            InitializeComponent();

            coffees.Add(new Coffee(false, 2, "Espresso", "Large", false, 5));
            coffees.Add(new Coffee(true, 0, "Latte", "Small", false, 3));
            coffees.Add(new Coffee(false, 4, "Black Coffee", "X-Large", true, 9));

            bindingSource1.DataSource = coffees;
        }
    }
}
