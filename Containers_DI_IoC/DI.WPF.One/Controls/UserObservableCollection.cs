using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace DI.WPF.One.Controls
{
    public class UserObservableCollection<User> : ObservableCollection<User>
    {
        public void UpdateCollection()
        {
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(
                NotifyCollectionChangedAction.Reset));
        }


        public void ReplaceItem(int index, User item)
        {
            base.SetItem(index, item);
        }

    } // class UserObservableCollection
}
