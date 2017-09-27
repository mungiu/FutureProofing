using PersonLibrary;
using System.Collections;
using System.Collections.Generic;
using System.Windows;

namespace PeopleViewer
{
    public partial class MainWindow : Window
    {
        PeopleRepository peopleRepo = new PeopleRepository();

        public MainWindow()
        {
            InitializeComponent();
        }

       //concrete type
        private void ConcreteFetchButton_Click(object sender, RoutedEventArgs e)
        {
            //"clrscr"
            ClearListBox();
            List<Person> people = peopleRepo.GetPeople();
            //assigning source
            PersonListBox.ItemsSource = people;

            ////alternative: looping through and adding each to "PersonListBox"
            //foreach (var person in people)
            //    PersonListBox.Items.Add(person);
        }

        //interfaces make the code usable by all implementing the same interface
        //non-generic = type "object", Eg of generic type: "IEnumerable<person>"
        //where "person" is the type
        private void InterfaceFetchButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
            IEnumerable people = peopleRepo.GetPeople();
            //assigning source
            PersonListBox.ItemsSource = people;

            //foreach (var person in people)
            //    PersonListBox.Items.Add(person);
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void ClearListBox()
        {
            //removing source
            PersonListBox.ItemsSource = null;

            //PersonListBox.Items.Clear();
        }
    }
}
