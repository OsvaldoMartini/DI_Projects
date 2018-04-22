using System.ComponentModel;

namespace DI.WPF.One.Commons
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