
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Notebook.ViewModels;
public partial class NewNoteViewModel:ObservableObject
{
    [ObservableProperty]
    private string title;

    [ObservableProperty]
    private string content;


    [RelayCommand]

    
   
}

