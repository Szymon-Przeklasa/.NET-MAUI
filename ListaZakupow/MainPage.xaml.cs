using System.Collections.ObjectModel;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Item> Products { get; set; }
        public MainPage()
        {
            InitializeComponent();
            Products = new ObservableCollection<Item>();
            BindingContext = this;
        }

        private void AddBtn_Clicked(object sender, EventArgs e)
        {
            string itemname = additem.Text;
            if (string.IsNullOrEmpty(itemname))
                return;
            additem.Text = "";
            var existing = Products.FirstOrDefault(p => p.Name.Equals(itemname, StringComparison.OrdinalIgnoreCase));

            if (existing != null)
            {
                existing.Quantity++;
                Products.Remove(existing);
                Products.Add(existing);
            }
            else
            {
                Products.Add(new Item { Name = itemname, Quantity = 1 });
            }

            collectionview.ItemsSource = Products;
        }

        private void DelBtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}
