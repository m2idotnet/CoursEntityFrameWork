using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace AgendaWpf.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ICommand listeContactsCommand { get; set; }
        public ICommand addContactCommand { get; set; }
        public Grid maGrille { get; set; }

        public MainWindowViewModel(Grid g)
        {
            maGrille = g;
            listeContactsCommand = new RelayCommand(ListeContact);
            addContactCommand = new RelayCommand(AddContact);
        }

        public void ListeContact()
        {
            Reset();
            GenerateRowsAndColumns(maGrille, 3, 1);
            maGrille.DataContext = new ListeContactsViewModel();
            ListView listView = new ListView();
            listView.SetBinding(ListView.ItemsSourceProperty, new Binding("contacts"));
            GridView g = new GridView();
            g.Columns.Add(new GridViewColumn
            {
                Header = "Nom",
                DisplayMemberBinding = new Binding("Nom"),
                Width = 200
            });
            g.Columns.Add(new GridViewColumn
            {
                Header = "Prénom",
                DisplayMemberBinding = new Binding("Prenom"),
                Width = 200
            });
            g.Columns.Add(new GridViewColumn
            {
                Header = "Téléphone",
                DisplayMemberBinding = new Binding("Tel"),
                Width = 200
            });
            GridViewColumn columnEmail = new GridViewColumn();
            columnEmail.Header = "Email";
            DataTemplate templateEmail = new DataTemplate();
            var listEmail = new FrameworkElementFactory(typeof(ComboBox));
            listEmail.SetBinding(ComboBox.ItemsSourceProperty, new Binding("emails"));
            templateEmail.VisualTree = listEmail;
            columnEmail.CellTemplate = templateEmail;
            g.Columns.Add(columnEmail);
            listView.View = g;
            maGrille.Children.Add(listView);
            Grid.SetColumn(listView, 0);
            Grid.SetRow(listView, 0);
        }

        public void AddContact()
        {
            Reset();
            GenerateRowsAndColumns(maGrille, 6, 2);
            maGrille.DataContext = new AddContactViewModel();
            string[] mesLabels = new string[] { "Nom", "Prénom", "Tel", "Emails" };
            for(int i=0; i < mesLabels.Length; i++)
            {
                Label l = new Label()
                {
                    Content = mesLabels[i]
                };
                maGrille.Children.Add(l);
                Grid.SetColumn(l, 0);
                Grid.SetRow(l, i);
            }
            string[] mesTextBox = new string[] { "Nom", "Prenom", "Tel" };
            for(int i = 0; i < mesTextBox.Length; i++)
            {
                TextBox t = new TextBox();
                t.SetBinding(TextBox.TextProperty, new Binding(mesTextBox[i]));
                maGrille.Children.Add(t);
                Grid.SetColumn(t, 1);
                Grid.SetRow(t, i);
            }
            DataGrid dGrid = new DataGrid();
            dGrid.AutoGenerateColumns = false;
            dGrid.Columns.Add(new DataGridTextColumn 
            {
                Header = "Email",
                Binding = new Binding("Email"),
                Width = 300
            });
            dGrid.SetBinding(DataGrid.ItemsSourceProperty, new Binding("emails"));
            maGrille.Children.Add(dGrid);
            Grid.SetColumn(dGrid, 0);
            Grid.SetRow(dGrid, 4);
            Grid.SetColumnSpan(dGrid, 2);
            Button bAdd = new Button()
            {
                Content = "Ajouter",
                
            };
            bAdd.SetBinding(Button.CommandProperty, new Binding("addCommand"));
            Grid.SetColumn(bAdd, 0);
            Grid.SetRow(bAdd, 5);
            Grid.SetColumnSpan(bAdd, 2);
            maGrille.Children.Add(bAdd);
        }

        private void Reset()
        {
            maGrille.Children.Clear();
            maGrille.RowDefinitions.Clear();
            maGrille.ColumnDefinitions.Clear();
        }

        private void GenerateRowsAndColumns(Grid g, int row, int col)
        {
            for(int i= 1; i <= row; i++)
            {
                g.RowDefinitions.Add(new RowDefinition
                {
                    Height = new GridLength(1, GridUnitType.Star)
                });
            }
            for (int i = 1; i <= col; i++)
            {
                g.ColumnDefinitions.Add(new ColumnDefinition
                {
                    Width = new GridLength(i, GridUnitType.Star)
                });
            }
        }
    }
}
