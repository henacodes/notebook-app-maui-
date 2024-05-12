
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Notebook.Messages;
using Notebook.Models;
namespace Notebook.ViewModels;
public partial class NewNoteViewModel:ObservableObject
{
    [ObservableProperty]
    private string title;

    [ObservableProperty]
    private string content;


    [RelayCommand]

    async void AddNote()
    {
        if (title == string.Empty || content == string.Empty ) {
            await Application.Current.MainPage.DisplayAlert("Invalid input", "Please fill out all the input fields", "Ok");
            return;
        }
        WeakReferenceMessenger.Default.Send(new AddNoteMessage(new Note() { Title = title, Content = content }));
        await Shell.Current.GoToAsync("..");
    }

    
   
}

