
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Notebook.Messages;
using Notebook.Models;
using Notebook.Views;

namespace Notebook.ViewModels;


[QueryProperty("Notes","notes"), QueryProperty("Note", "note")]
public partial class EditNotePageViewMode:ObservableObject
{


    [ObservableProperty]
    string title;

    [ObservableProperty]
    Note note;

    [ObservableProperty]
    ObservableCollection<Note> notes;


    [ObservableProperty]
    string content;

    public EditNotePageViewMode()
    {
        
        /*WeakReferenceMessenger.Default.Register<NoteMessage>(this,  (receiver, message) =>
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                MainThread.BeginInvokeOnMainThread(() =>
                {
                    if (message.Value.Task == "edit")
                    {
                        
                        Console.WriteLine(message);
                        Title = message.Value.Note.Title;
                        Content = message.Value.Note.Content;
                    }

                });
            });
            
        }); */
    }

    [RelayCommand]
    async Task UpdateNote()
    {
        //await Application.Current.MainPage.DisplayAlert("somethin else", $"ayoo {note}", "ok");
        ObservableCollection<Note> updatedNotes = [];

        foreach (var item in Notes)
        {
            if (item.Id == Note.Id)
            {
                updatedNotes.Add(Note);
            }
            else
            {
                updatedNotes.Add(item);
            }
        }
        WeakReferenceMessenger.Default.Send(new NoteMessage(new NoteMessageModel() { Notes=updatedNotes, Task = "update" }));
       await Shell.Current.GoToAsync("..");
    }
}
