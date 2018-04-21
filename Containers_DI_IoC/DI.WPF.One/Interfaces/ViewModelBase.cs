using System.ComponentModel;
using DI.WPF.One.MediatorVM;

namespace DI.WPF.One.Interfaces
{

    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        #region Property Changed Event Handler
        
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)PropertyChanged(this, e);
        }
        #endregion Property Changed Event Handler




    }
}