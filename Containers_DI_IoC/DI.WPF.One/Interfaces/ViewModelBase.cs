using DI.WPF.One.Mediators;
using System.ComponentModel;
using System.Diagnostics;
using DI.WPF.One.Model;

namespace DI.WPF.One.Interfaces
{

    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        #region Property Changed Event Handler
        public void SetPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion Property Changed Event Handler

    }
}