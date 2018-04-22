using System;
using System.ComponentModel;
using DI.WPF.One.Commons;
using DI.WPF.One.Interfaces;
using DI.WPF.One.Model;

namespace DI.WPF.One.ViewModel
{
   //Class for the GUI to display and modify products.
    //All product properties the GUI can touch are strings.
    //A single integer property, UserId, is for database use only.
    //It is assigned by the DB when it creates a new product.  It is used
    //to identify a product and must not be modified by the GUI.

    public class User:ViewModelBase
    {
       
        //For DB use only!
        private Guid _guiid;
        public Guid _Guid{ get { return _guiid; } }
        //For DB use only!
        private int _userId;
        public int _UserId { get { return _userId; } }

        private string modelNumber;
        public string ModelNumber
        {
            get { return modelNumber; }
            set { modelNumber = value; NotifyPropertyChanged(new PropertyChangedEventArgs("ModelNumber"));
                }
        }


        private string modelName;
        public string ModelName
        {
            get { return modelName; }
            set { modelName = value; NotifyPropertyChanged(new PropertyChangedEventArgs("ModelName")); }
        }

        private string unitCost;
        public string UnitCost
        {
            get { return unitCost; }
            set { unitCost = value; NotifyPropertyChanged(new PropertyChangedEventArgs("UnitCost")); }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; NotifyPropertyChanged(new PropertyChangedEventArgs("Description")); }
        }

        private string categoryName;
        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; NotifyPropertyChanged(new PropertyChangedEventArgs("CategoryName")); }
        }

        public User()
        {
        }

        public User(Guid id, int productId, string modelNumber, string modelName,
                       string unitCost, string description, string categoryName)
        {
            this._guiid = id;
            this._userId = productId;
            ModelNumber = modelNumber;
            ModelName = modelName;
            UnitCost = unitCost;
            Description = description;
            CategoryName = categoryName;
        }

        public void CopyUser(User p)
        {
            this._guiid = p._Guid;
            this._userId = p._UserId;
            this.ModelNumber = p.ModelNumber;
            this.ModelName = p.ModelName;
            this.UnitCost = p.UnitCost;
            this.CategoryName = p.CategoryName;
            this.Description = p.Description;
        }

        //Creating a new product in the DB assigns the UserId
        //Update the UserId from the value in the corresponding UserModel
        public void UserAdded2DB(UserModel productModel)
        {
            this._userId = productModel.UserId;
        }

    } //class User



    //Communiction to/from SQL uses this class for product
    //It has a decimal, not string, definition for UnitCost
    //Consversion routines UserModel <--> User provided

   

}


