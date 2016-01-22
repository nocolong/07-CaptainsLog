using System;
using System.Collections.Generic;
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
using CaptainsLog.Core;
using System.Collections.ObjectModel;

namespace CaptainsLog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<LogEntry> logEntries;
       
        public MainWindow()
        {
            InitializeComponent();

            logEntries = new ObservableCollection<LogEntry>();

            gridLogEntries.ItemsSource = logEntries;
        }

        private void buttonAddEntry_Click(object sender, RoutedEventArgs e)
        {
            string title = "Seperation of Concerns?";
            string text = "Seperate a program into sections..";
            DateTime date = DateTime.Now;
            


            LogEntry log = new Core.LogEntry();
            log.Id = logEntries.Count + 1;
            log.Title = title;
            log.Text = text;
            log.EntryDate = date;

            logEntries.Add(log);


        }

        private void buttonDeleteLastEntry_Click(object sender, RoutedEventArgs e)
        {
            logEntries.Remove(logEntries[logEntries.Count - 1]);
        }
    }
}
