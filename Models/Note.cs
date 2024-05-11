
using CommunityToolkit.Mvvm.ComponentModel;

namespace Notebook.Models;
public  class Note
{
    public int Id { get; set; }
    public string Title { get; set; }

    public string Content { get; set; }

    public DateTime DateCreated { get; set; }


    public Note()
    {
        DateCreated = DateTime.Now;

        Random random = new Random();
        Id = random.Next(1, 2000);
    }
    

}

