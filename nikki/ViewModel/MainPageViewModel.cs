﻿using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using nikki.Model;

namespace nikki.ViewModel;

public partial class MainPageViewModel(Action<Note> navigateToDetails) : ObservableObject
{
    public ObservableCollection<Note> Notes { get; set; } = new();
    
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
    
    [RelayCommand]
    private void NoteSelected(Note note)
    {
        if (note != null)
        {
            navigateToDetails.Invoke(note);
        }
    }
}