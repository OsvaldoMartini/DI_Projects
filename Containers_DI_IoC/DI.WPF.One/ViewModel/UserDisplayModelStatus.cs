using System;
using System.ComponentModel;
using System.Windows.Media;
using DI.WPF.One.Commons;
using DI.WPF.One.Interfaces;

namespace DI.WPF.One.ViewModel
{
    public class UserDisplayModelStatus:ViewModelBase
    {
     //Error status msg and field Brushes to indicate product field errors
        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; NotifyPropertyChanged(new PropertyChangedEventArgs("Status")); }
        }
        private static SolidColorBrush errorBrush = new SolidColorBrush(Colors.Red);
        private static SolidColorBrush okBrush = new SolidColorBrush(Colors.Black);

        private SolidColorBrush modelNumberBrush = okBrush;
        public SolidColorBrush ModelNumberBrush
        {
            get { return modelNumberBrush; }
            set { modelNumberBrush = value; NotifyPropertyChanged(new PropertyChangedEventArgs("ModelNumberBrush")); }
        }

        private SolidColorBrush modelNameBrush = okBrush;
        public SolidColorBrush ModelNameBrush
        {
            get { return modelNameBrush; }
            set { modelNameBrush = value; NotifyPropertyChanged(new PropertyChangedEventArgs("ModelNameBrush")); }
        }

        private SolidColorBrush categoryNameBrush = okBrush;
        public SolidColorBrush CategoryNameBrush
        {
            get { return categoryNameBrush; }
            set { categoryNameBrush = value; NotifyPropertyChanged(new PropertyChangedEventArgs("CategoryNameBrush")); }
        }

        private SolidColorBrush unitCostBrush = okBrush;
        public SolidColorBrush UnitCostBrush
        {
            get { return unitCostBrush; }
            set { unitCostBrush = value; NotifyPropertyChanged(new PropertyChangedEventArgs("UnitCostBrush")); }
        }


        //set error field brushes to OKBrush and status msg to OK
        public void NoError()
        {
            ModelNumberBrush = ModelNameBrush = CategoryNameBrush = UnitCostBrush = okBrush;
            Status = "OK";
        } //NoError()


        public UserDisplayModelStatus()
        {
            NoError();
        } //ctor


        //verify the User's unitcost is a decimal number > 0
        private bool ChkUnitCost(string costString)
        {
            if (String.IsNullOrEmpty(costString))
                return false;
            else
            {
                decimal unitCost;
                try
                {
                    unitCost = Decimal.Parse(costString);
                }
                catch
                {
                    return false;
                }
                if (unitCost < 0)
                    return false;
                else return true;
            }
        } //ChkUnitCost()


        //check all product fields for validity
        public bool ChkUserForAdd(User p)
        {
            int errCnt = 0;
            if (String.IsNullOrEmpty(p.ModelNumber))
            { errCnt++; ModelNumberBrush = errorBrush; }
            else ModelNumberBrush = okBrush;
            if (String.IsNullOrEmpty(p.ModelName))
            { errCnt++; ModelNameBrush = errorBrush; }
            else ModelNameBrush = okBrush;
            if (String.IsNullOrEmpty(p.CategoryName))
            { errCnt++; CategoryNameBrush = errorBrush; }
            else CategoryNameBrush = okBrush;

            if (!ChkUnitCost(p.UnitCost))
            { errCnt++; UnitCostBrush = errorBrush; }

            if (errCnt == 0) { Status = "OK"; return true; }
            else { Status = "ADD, missing or invalid fields."; return false; }
        } //ChkUserForAdd()


        //check all product fields for validity
        public bool ChkUserForUpdate(User p)
        {
            int errCnt = 0;
            if (String.IsNullOrEmpty(p.ModelNumber))
            { errCnt++; ModelNumberBrush = errorBrush; }
            else ModelNumberBrush = okBrush;
            if (String.IsNullOrEmpty(p.ModelName))
            { errCnt++; ModelNameBrush = errorBrush; }
            else ModelNameBrush = okBrush;
            if (String.IsNullOrEmpty(p.CategoryName))
            { errCnt++; CategoryNameBrush = errorBrush; }
            else CategoryNameBrush = okBrush;

            if (!ChkUnitCost(p.UnitCost))
            { errCnt++; UnitCostBrush = errorBrush; }
            else UnitCostBrush = okBrush;

            if (errCnt == 0) { Status = "OK"; return true; }
            else { Status = "Update, missing or invalid fields."; return false; }
        } //ChkUserForUpdate()

    } //class UserDisplayModelStatus
}  //NS: UserMvvm.ViewModels
