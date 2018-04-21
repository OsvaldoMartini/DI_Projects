using System;
using DI.WPF.One.Controls;
using DI.WPF.One.ViewModel;

namespace DI.WPF.One.Model
{
    public class StoreXML
    {
        public bool hasError = false;
        public string errorMessage;

        public bool DeleteUser(int p)
        {
            try
            {
                return new UserModel().WhitUserId(p).DeleteByXML();

            }
            catch (Exception ex)
            {
                errorMessage = "Update error, " + ex.Message;
                hasError = true;
            }

            return (!hasError);
        }//DeleteUserByXML


        public bool SaveUser(User DisplayedUser)
        {
            try
            {
                return new UserModel(DisplayedUser).AddByXML();

            }
            catch (Exception ex)
            {
                errorMessage = "Update error, " + ex.Message;
                hasError = true;
            }

            return (!hasError);
        }//SaveUserByXML

        public bool UpdateUser(User displayP)
        {

            try
            {
                return new UserModel(displayP).UpdateByXML();

            }
            catch (Exception ex)
            {
                errorMessage = "Update error, " + ex.Message;
                hasError = true;
            }

            return (!hasError);
        }//UpdateUserByXML


        public UserObservableCollection<User> GetUsers()
        {
            hasError = false;
            UserObservableCollection<User> Users = new UserObservableCollection<User>();
            try
            {
                //True: Check if File Exist
                Users = new UserModel().WhitCheckFileFirst(true);

            } //try
            catch (Exception ex)
            {
                errorMessage = "GetUsers() error, " + ex.Message;
                hasError = true;
            }

            return Users;
        }//GetUsersByXML

    }
} 

