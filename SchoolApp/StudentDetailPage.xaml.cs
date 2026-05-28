using System;
using System.Xml;

namespace SchoolApp;

[QueryProperty(nameof(StudentName), "name")]
public partial class StudentDetailPage : ContentPage
{
    public StudentDetailPage()
    {
        InitializeComponent();
    }

    public string StudentName
    {
        set
        {
            NameLabel.Text = value;
            DetailsLabel.Text = $"Name length: {value.Length}";
        }
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}