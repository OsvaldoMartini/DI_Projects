using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Input;
using MVVM_Checkbox.Command;
using System.Collections.ObjectModel;

namespace MVVM_Checkbox.ViewModel
{
    public class ViewModel:INotifyPropertyChanged
    {
        public ICommand MyCommand { get; set; }

        private ObservableCollection<string> _countries;
        public ObservableCollection<string> Countries
        {
            get { return _countries; ; }
            set
            {
                _countries = value;
                OnPropertyChange("Countries");
            }
        }


        private string _name;
        public string Name
        {
            get { return _name; }
            set 
            { 
                _name = value;
                OnPropertyChange("Name");
            }
        }
        



        public ViewModel()
        {
            MyCommand = new  RelayCommand(executemethod, canexecutemethod);

            Countries = new ObservableCollection<string>();
        }


        

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChange(string propertyname)
        {
            if (PropertyChanged !=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }



        private bool canexecutemethod(object parameter)
        {
            return true;
        }

        private void executemethod(object parameter)
        {
            var values = (object[])parameter;
            string name = (string)values[0];
            bool check = (bool)values[1];
            if (check)
            {
                Countries.Add(name);
            }
            else
            {
                Countries.Remove(name);
            }
            
            Name = "";
            foreach (string item in Countries)
            {
                Name = Name + item;
            }

        }
    }
}
