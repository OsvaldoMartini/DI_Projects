using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace UIAutomationController.Util
{
    public class NotifyObservableCollection<TItem> : ObservableCollection<TItem>
        where TItem : class, INotifyPropertyChanged, new()
    {
        
        private Action _itemPropertyChanged;

     
      

        public NotifyObservableCollection(Action itemPropertyChanged)
        {
            _itemPropertyChanged = itemPropertyChanged;
        }

        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (var item in e.NewItems)
                {
                    var notifyItem = item as INotifyPropertyChanged;
                    if (notifyItem != null)
                    {
                        notifyItem.PropertyChanged += ItemPropertyChanged;
                    }
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach (var item in e.OldItems)
                {
                    var notifyItem = item as INotifyPropertyChanged;
                    if (notifyItem != null)
                    {
                        notifyItem.PropertyChanged -= ItemPropertyChanged;
                    }
                }
            }

            base.OnCollectionChanged(e);
        }

   

        private void ItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (_itemPropertyChanged != null)
            {
                _itemPropertyChanged();
            }
        }

    }
}