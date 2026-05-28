using System.Collections.Generic;
using System.Linq;

namespace SchoolApp;

public partial class StudentsPage : ContentPage
{
    List<string> students = new()
    {
        "Aruzhan",
        "Daniyar",
        "Symbat",
        "Aigerim",
        "John"
    };

    public StudentsPage()
    {
        InitializeComponent();

        StudentsCollection.ItemsSource = students;
    }

    private async void StudentsCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selectedStudent = e.CurrentSelection.FirstOrDefault()?.ToString();

        if (selectedStudent == null)
            return;

        await Shell.Current.GoToAsync($"{nameof(StudentDetailPage)}?name={selectedStudent}");

        StudentsCollection.SelectedItem = null;
    }
}