
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace Notebook.Messages;
using Notebook.Models;
public class AddNoteMessage : ValueChangedMessage<Note>
{
    public AddNoteMessage(Note note) : base(note)
    {
    }
}

