using Notebook.Views;

namespace Notebook


{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(NotesListPage), typeof(NotesListPage));
            Routing.RegisterRoute(nameof(NewNotePage), typeof(NewNotePage));
            Routing.RegisterRoute(nameof(EditNotePage), typeof(EditNotePage));
            
        }
    }
}
