using Notebook.ViewModels;

namespace Notebook.Views;

public partial class EditNotePage : ContentPage
{
	public EditNotePage(EditNotePageViewMode vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}