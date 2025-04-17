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
            await Navigation.PushAsync() // @TODO 
        });
    }

    private void OnNoteSelected(object? sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Note selectedNote)
        {
            
        }
    }
}