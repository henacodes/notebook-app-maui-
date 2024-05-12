
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Notebook.Messages;
using Notebook.Models;
using Notebook.Views;

namespace Notebook.ViewModels;

public partial class NotesListViewModel:ObservableObject
{
    [ObservableProperty]
    ObservableCollection<Note> notes;


    public NotesListViewModel() {
        Notes = new ObservableCollection<Note>()
                                        {
                                            new Note()
                                            {
                                                Title = "Meeting Notes",
                                                Content = "During the meeting, we discussed the project timeline and deliverables. We reviewed the progress made so far and identified any potential roadblocks. It was a productive discussion, and we agreed on the next steps to move the project forward."
                                            },
                                            new Note()
                                            {
                                                Title = "Shopping List",
                                                Content = "I need to buy a few items from the grocery store. The list includes milk, eggs, bread, fruits, and vegetables. I also need to pick up some cleaning supplies such as dish soap and laundry detergent."
                                            },
                                            new Note()
                                            {
                                                Title = "Travel Itinerary",
                                                Content = "I have planned a trip to Paris next month. The flight details are as follows: Departure - 10 AM from JFK International Airport. The estimated flight duration is 8 hours. Upon arrival, I will be staying at a hotel near the city center. I have also booked tickets for a few popular attractions and planned some sightseeing activities."
                                            },
                                            new Note()
                                            {
                                                Title = "Project Update",
                                                Content = "In the latest project update, we completed the development of the login functionality. We conducted thorough testing and resolved any bugs or issues that were identified. The next phase of the project involves implementing the user profile management module, which is scheduled to start next week."
                                            },
                                            new Note()
                                            {
                                                Title = "Recipe Ideas",
                                                Content = "I've been exploring some new recipes recently. One idea is to try a Mediterranean-inspired salad with fresh vegetables, feta cheese, and a tangy vinaigrette dressing. Another recipe I'm considering is a spicy Thai curry with coconut milk, vegetables, and tofu. I'm excited to experiment with these dishes and discover new flavors."
                                            }
                                        
                                        
                                        };

        WeakReferenceMessenger.Default.Register<AddNoteMessage>(this, (receiver, message) =>
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                Notes.Add(message.Value);
            });
        });
    }

    [RelayCommand]
      async Task   GoToAddNotePage()
    {
        await Shell.Current.GoToAsync(nameof(NewNotePage));
        //await Application.Current.MainPage.DisplayAlert("Alert", "You have been alerted", "OK");
    }
}

