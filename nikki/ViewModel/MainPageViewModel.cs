using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using nikki.Model;

namespace nikki.ViewModel;

public partial class MainPageViewModel : ObservableObject
{
    public ObservableCollection<Note> Notes { get; } = new();
    
    [ObservableProperty] private string _noteText;

    [RelayCommand]
    private void AddNote()
    {
        if (!string.IsNullOrWhiteSpace(NoteText))
        {
            Notes.Add(new Note { Text = NoteText});
            NoteText = string.Empty;
        }
    }
}