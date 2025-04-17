# nikki

A minimal cross-platform notes viewer built with .NET MAUI. The app demonstrates the use of the MVVM architectural pattern and delegate-based navigation using `Action<T>` in C#.

---

## 🚀 Features

- View a list of predefined or loaded notes.
- Navigate to a detailed view of a selected note.
- Built using clean MVVM architecture.
- Uses `Action<T>` delegate to decouple navigation logic from the ViewModel.

---

## 🛠️ How It Works

### MVVM Pattern

- **Model:** `NoteModel` contains fields like `Text` and `CreatedAt`.
- **ViewModel:** `MainViewModel` holds the observable list of notes and exposes a command to handle note selection.
- **View:** `MainPage.xaml` binds to the ViewModel. On tapping a note, it invokes a delegate to trigger navigation.

---

### Delegate-based Navigation

Instead of tightly coupling navigation into the ViewModel, the app passes in a delegate from the view:

```csharp
new MainViewModel(async (note) =>
{
    await Navigation.PushAsync(new NoteDetailsPage(note));
});
```

---

## 🧰 Requirements
- .NET 8 SDK
- .NET MAUI workload installed:
```bash
 dotnet workload install maui
```

---

## ▶️ Getting Started
- Clone the repo
```bash
git clone https://github.com/pazurkota/nikki
```
- Run the app
```bash
dotnet build
dotnet maui run
```

---

## 📄 License

This project is licensed under the [MIT License](LICENSE.md).