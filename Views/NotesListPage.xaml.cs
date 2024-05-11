using Notebook.ViewModels;

namespace Notebook.Views;

public partial class NotesListPage : ContentPage
{
	public NotesListPage(NotesListViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}