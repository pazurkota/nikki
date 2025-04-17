using nikki.Model;
using nikki.ViewModel;

namespace nikki.View;

public partial class MainPage : ContentPage
{
    private MainPageViewModel viewModel;
    
    public MainPage()
    {
        InitializeComponent();

        viewModel = new MainPageViewModel(navigateToDetails: async (Note) =>
        {
            await Navigation.PushAsync(new NoteDetailsPage(Note));  
        });

        BindingContext = viewModel;
    }

    private void OnNoteSelected(object? sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Note selectedNote)
        {
            viewModel.NoteSelectedCommand.Execute(selectedNote);
            ((CollectionView)sender!).SelectedItem = null;
        }
    }

    private void OnNoteTapped(object? sender, TappedEventArgs e)
    {
        if (sender is Frame frame && frame.BindingContext is Note note)
        {
            viewModel.NoteSelectedCommand.Execute(note);
        }
    }
}