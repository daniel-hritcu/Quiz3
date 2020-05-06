using Quiz3.Q1.Models;
using System.Collections.ObjectModel;

using System.Windows;


namespace Quiz3.Q1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Student> Students { get; set; }

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Students = new ObservableCollection<Student>();
            GetData();
            StudentListGrid.DataContext = Students;
        }

        private void AddStudentButton_Clicked(object sender, RoutedEventArgs e)
        {
            //TODO: Validation

          Student student = new Student()
            {
                Id = int.Parse(id.Text),
                FirstName = fName.Text,
                LastName = lName.Text,
                IsRegistered = isRegistered.IsChecked
            };
            Students.Add(student);
        }

        private void GetData() {
            Students.Add(new Student()
            {
                Id = 1,
                FirstName = "S1FN",
                LastName = "S1LN",
                IsRegistered = true
            });

            Students.Add(new Student()
            {
                Id = 2,
                FirstName = "S2FN",
                LastName = "S2LN",
                IsRegistered = false
            }); ;

            Students.Add(new Student()
            {
                Id = 3,
                FirstName = "S3FN",
                LastName = "S3LN",
                IsRegistered = true
            }); ;
        }
    }
}
