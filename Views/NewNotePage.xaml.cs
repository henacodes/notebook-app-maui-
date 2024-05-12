using Notebook.ViewModels;

namespace Notebook.Views;

public partial class NewNotePage : ContentPage
{
	public NewNotePage(NewNoteViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}