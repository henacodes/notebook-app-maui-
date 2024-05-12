
using CommunityToolkit.Mvvm.Messaging.Messages;
using Notebook.Models;
namespace Notebook.Messages;

public class NoteMessage : ValueChangedMessage<NoteMessageModel>
{
    public NoteMessage(NoteMessageModel msg) : base(msg)
    {
    }
}

