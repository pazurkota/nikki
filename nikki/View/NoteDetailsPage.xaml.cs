using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nikki.Model;

namespace nikki.View;

public partial class NoteDetailsPage : ContentPage
{
    public NoteDetailsPage(Note note)
    {
        InitializeComponent();
        BindingContext = note;
    }
}