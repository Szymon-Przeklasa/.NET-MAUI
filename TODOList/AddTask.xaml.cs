using System.Collections.ObjectModel;

namespace TODOList;

public partial class AddTask : ContentPage
{
	private ObservableCollection<Task> _tasks;
	public AddTask(ObservableCollection<Task> tasks)
	{
		InitializeComponent();
		_tasks = tasks;
	}

    private async void addBtn_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(task_entry.Text))
        {
            _tasks.Add(new Task { Name = task_entry.Text, Description = description.Text, Done = false, Data = DateTime.Now });
            await Navigation.PopAsync();
        }
    }
}