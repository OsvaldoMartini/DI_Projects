using System;
using System.ComponentModel;
using System.Windows.Input;
using DI.WPF.One.Foundation;
using DI.WPF.One.Interfaces;

namespace DI.WPF.One.ViewModel
{
      public class UserDisplayModel : ViewModelBase
    {
        private bool isSelected = false;


        //data checks and status indicators done in another class
        private readonly UserDisplayModelStatus _userStatus = new UserDisplayModelStatus();
        public UserDisplayModelStatus StatDisplay { get { return _userStatus; } }

        private User displayedUser = new User();
        public User DisplayedUser
        {
            get { return displayedUser; }
            set { displayedUser = value; NotifyPropertyChanged(new PropertyChangedEventArgs("DisplayedUser")); }
        }


        private RelayCommand getUsersCommand;
        public ICommand GetUsersCommand
        {
            get { return getUsersCommand ?? (getUsersCommand = new RelayCommand(() => GetUsers())); }
        }

        private void GetUsers()
        {
            isSelected = false;
            StatDisplay.NoError();
            DisplayedUser = new User();
            App.Messenger.NotifyColleagues("GetUsers");
        }

        private RelayCommand closeAppCommand;
        public ICommand CloseAppCommand
        {
            get { return closeAppCommand ?? (closeAppCommand = new RelayCommand(() => CloseApp()/*, ()=>isSelected*/)); }
        }

        private void CloseApp()
        {
            isSelected = false;
            StatDisplay.NoError();
            DisplayedUser = new User();
            App.Messenger.NotifyColleagues("UserCleared");
        } //ClearUserDisplay()

        #region AddNewUserCommand
        private RelayCommand addNewUserCommand;
        public ICommand AddNewUserCommand
        {
            get { return addNewUserCommand ?? (addNewUserCommand = new RelayCommand(() => AddNewUserDisplay()/*, ()=>isSelected*/)); }
        }

        private void AddNewUserDisplay()
        {
            isSelected = false;
            StatDisplay.NoError();
            DisplayedUser = new User();
            App.Messenger.NotifyColleagues("UserCleared");
        } //AddNewUserDisplay()
        #endregion

        #region ClearUserCommand
        private RelayCommand clearUserCommand;
        public ICommand ClearUserCommand
        {
            get { return clearUserCommand ?? (clearUserCommand = new RelayCommand(() => ClearUserDisplay()/*, ()=>isSelected*/)); }
        }

        private void ClearUserDisplay()
        {
            isSelected = false;
            StatDisplay.NoError();
            DisplayedUser = new User();
            App.Messenger.NotifyColleagues("UserCleared");
        } //ClearUserDisplay()
        #endregion

        #region UpdateCommand
        private RelayCommand updateCommand;
        public ICommand UpdateCommand
        {
            get { return updateCommand ?? (updateCommand = new RelayCommand(() => UpdateUser(), () => isSelected)); }
        }

        private void UpdateUser()
        {
            if (!StatDisplay.ChkUserForUpdate(DisplayedUser)) return;
                if(!App.StoreXML.UpdateUser(DisplayedUser))
                {
                    StatDisplay.Status = App.StoreXML.errorMessage;
                    return;
                }
                App.Messenger.NotifyColleagues("UpdateUser", DisplayedUser);
        } //UpdateUser()
        #endregion

        #region DeleteCommand
        private RelayCommand deleteCommand;
        public ICommand DeleteCommand
        {
            get { return deleteCommand ?? (deleteCommand = new RelayCommand(() => DeleteUser(), () => isSelected)); }
        }

        private void DeleteUser()
        {
            if (!App.StoreXML.DeleteUser(DisplayedUser._UserId))
            {
                StatDisplay.Status = App.StoreXML.errorMessage;
                return;
            }
            isSelected = false;
            App.Messenger.NotifyColleagues("DeleteUser");
        } //DeleteUser
        #endregion

        #region SaveCommand
        private RelayCommand saveCommand;
        public ICommand SaveCommand
        {
            get { return saveCommand ?? (saveCommand = new RelayCommand(() => SaveUser(), () => !isSelected)); }
        }

        private void SaveUser()
        {
            if (!StatDisplay.ChkUserForAdd(DisplayedUser)) return;
            if (!App.StoreXML.SaveUser(DisplayedUser))
            {
                StatDisplay.Status = App.StoreXML.errorMessage;
                return;
            }
            App.Messenger.NotifyColleagues("SaveUser", DisplayedUser);
        } //SaveUser()
        #endregion

        public UserDisplayModel()
        {
            Messenger messenger = App.Messenger;
            messenger.Register("UserSelectionChanged", (Action<User>)(param => ProcessUser(param)));
            messenger.Register("SetStatus", (Action<String>)(param => StatDisplay.Status = param));
        } //ctor

        public void ProcessUser(User p)
        {
            if (p == null) { /*DisplayedUser = null;*/  isSelected = false;  return; }
            User temp = new User();
            temp.CopyUser(p);
            DisplayedUser = temp;
            isSelected = true;
            StatDisplay.NoError();
        } // ProcessUser()
    }
}

