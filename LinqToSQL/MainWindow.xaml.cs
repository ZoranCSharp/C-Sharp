using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LinqToSQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LinqToSqlDataClassesDataContext dataContex;

        public MainWindow()
        {
            InitializeComponent();

            //import system.configuration from references
            string connectionstring = ConfigurationManager.ConnectionStrings["LinqToSQL.Properties.Settings.ZooConnectionString"].ConnectionString;
            dataContex = new LinqToSqlDataClassesDataContext(connectionstring);

            //InsertUniversities();

            InsertStudents();
        }



        public void InsertUniversities()
        {
            dataContex.ExecuteCommand("delete from University");

            University yale = new University();
            yale.Name = "Yale";            
            dataContex.Universities.InsertOnSubmit(yale);

            University bjgTech = new University();
            bjgTech.Name = "Beijing Tech";
            dataContex.Universities.InsertOnSubmit(bjgTech);

            dataContex.SubmitChanges();

            MainDataGrid.ItemsSource = dataContex.Universities;
        }

        public void InsertStudents()
        {
            //"from university in dataContent.University" + 
            //    "where university == "Yale" select university"
            University yale = dataContex.Universities.First(un => un.Name.Equals("Yale"));
            University beijingTech = dataContex.Universities.First(un => un.Name.Equals("Beijing Tech"));

            List<Student> students = new List<Student>();

            students.Add(new Student { Name = "Carla", Gender = "female", UniversityId = yale.Id });
            students.Add(new Student { Name = "Toni", Gender = "male", University = yale });
            students.Add(new Student { Name = "Leyle", Gender = "female", UniversityId = beijingTech.Id });
            students.Add(new Student { Name = "Jame", Gender = "trans-gender", University = beijingTech });

            dataContex.Students.InsertAllOnSubmit(students);
            dataContex.SubmitChanges();

            MainDataGrid.ItemsSource = dataContex.Students;
        }
    }
}
