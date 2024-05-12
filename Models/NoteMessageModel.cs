
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Notebook.Models;

public class NoteMessageModel:ObservableObject
{
    public Note? Note { get; set; }

    public ObservableCollection<Note>? Notes { get; set; }
    public string Task { get ; set; }
}
