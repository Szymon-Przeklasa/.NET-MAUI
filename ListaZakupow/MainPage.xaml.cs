namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        List<string> shoppinglist = new List<string>();

        public MainPage()
        {
            InitializeComponent();
        }

        private void AddBtn_Clicked(object sender, EventArgs e)
        {
            String item = additem.Text;
            additem.Text = "";
            shoppinglist.Add(item);
            listview.ItemsSource = shoppinglist;
        }

        private void DelBtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}
