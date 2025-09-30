using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace TODOList
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Task> Tasks { get; set; }
        public MainPage()
        {
            InitializeComponent();
            Tasks = new ObservableCollection<Task>();
            BindingContext = this;
        }

        private async void addBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddTask(Tasks));
            collectionview.ItemsSource = Tasks;
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            
        }

        private void collectionview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = collectionview.SelectedItem as Task;
            info.Text = "Name: " + selected.Name + "\nDescription: " + selected.Description + "\nAdded: " + selected.Data;
            
        }

        private void delBtn_Clicked(object sender, EventArgs e)
        {
            List<Task> selected = [];
            for(int i = 0; i < Tasks.Count; i++)
            {
                if (Tasks[i].Done == true)
                {
                    selected.Add(Tasks[i]);
                }
            }
            foreach (var task in selected)
            {
                Tasks.Remove(task);
                info.Text = "";
            }
        }
    }
}
