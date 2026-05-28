namespace SchoolApp;

public partial class StudentsPage : ContentPage
{
    List<string> students = new List<string>
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
}