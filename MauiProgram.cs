using Microsoft.Extensions.Logging;
using Notebook.ViewModels;
using Notebook.Views;

namespace Notebook
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddTransient<NotesListPage>();
            builder.Services.AddTransient<NotesListViewModel>();

            builder.Services.AddTransient<NewNotePage>();
            builder.Services.AddTransient<NewNoteViewModel>();

            builder.Services.AddTransient<EditNotePage>();
            builder.Services.AddTransient<EditNotePageViewMode>();




#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
