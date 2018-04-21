using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.WPF.One.Controls;
using DI.WPF.One.ViewModel;

namespace DI.WPF.One.Model
{
    public class UserModel
    {
        public Guid Guid { get; set; }
        public int UserId { get; set; }
        public string ModelNumber { get; set; }
        public string ModelName { get; set; }
        public decimal UnitCost { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }

        #region Builder Fields
        private bool checkFileFirst = true;

        private UserObservableCollection<User> _User;
        public UserModel WhitCheckFileFirst(bool checkFileFirst)
        {
            this.checkFileFirst = checkFileFirst;
            return this;
        }

        public UserModel WhitUserId(int p)
        {
            this.UserId = p;
            return this;
        }

        public static implicit operator UserObservableCollection<User>(UserModel instance)
        {
            return instance.Build();
        }

        #endregion

        public UserModel()
        {
        }

        public bool DeleteByXML()
        {
            var filePath = String.Format("{0}{1}\\UserModel.xml", AppDomain.CurrentDomain.BaseDirectory,
                DBUtility.FilePath);

            return DBUtility.DeleteByXML(this.UserId, filePath);
        }

        public bool AddByXML()
        {
            var filePath = String.Format("{0}{1}\\UserModel.xml", AppDomain.CurrentDomain.BaseDirectory,
                DBUtility.FilePath);

            return DBUtility.AddByXML(this, filePath);

        }

        public bool UpdateByXML()
        {
            var filePath = String.Format("{0}{1}\\UserModel.xml", AppDomain.CurrentDomain.BaseDirectory,
                DBUtility.FilePath);

            return DBUtility.UpdateByXML(this, filePath);

        }

        public UserObservableCollection<User> Build()
        {
            UserObservableCollection<User> Users = new UserObservableCollection<User>();

            var filePath = String.Format("{0}{1}\\UserModel.xml", AppDomain.CurrentDomain.BaseDirectory,
                DBUtility.FilePath);

            List<UserModel> list = null;
            if (this.checkFileFirst)
                if (!File.Exists(filePath))
                {
                    list = DBUtility.CreateFile<UserModel>(DBUtility.MockUserModel());
                }
                else

                    list = DBUtility.DeserializeParamsListOf<UserModel>(filePath);

            if (list != null)
                foreach (UserModel sp in list)
                    Users.Add(sp.UserModel2User());


            return Users;
        }

        public UserModel(Guid id, int UserId, string modelNumber, string modelName,
            decimal unitCost, string description, string categoryName)
        {
            Guid = id;
            UserId = UserId;
            ModelNumber = modelNumber;
            ModelName = modelName;
            UnitCost = unitCost;
            Description = description;
            CategoryName = categoryName;
        }

        public UserModel(User p)
        {
            Guid = p._Guid;
            UserId = p._UserId;
            ModelNumber = p.ModelNumber;
            ModelName = p.ModelName;
            UnitCost = Convert.ToDecimal(p.UnitCost);
            Description = p.Description;
            CategoryName = p.CategoryName;
        }

        public User UserModel2User()
        {
            string unitCost = UnitCost.ToString();
            return new User(Guid, UserId, ModelNumber, ModelName, unitCost, Description, CategoryName);
        } //UserModel2User()



    }
}
