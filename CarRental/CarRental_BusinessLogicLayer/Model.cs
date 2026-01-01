using System;
using System.Data;
using CarRental_DataAccessLayer;

namespace CarRental_BusinessLogicLayer
{
    public class clsModel
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode;

        public int? ModelID { set; get; }
        public int? MakeID { set; get; }
        public string ModelName { set; get; }

        public clsMake MakeInfo;

        public clsModel()
        {
            this.ModelID = null;
            this.MakeID = null;
            this.ModelName = null;

            this.MakeInfo = new clsMake();

            this.Mode = enMode.AddNew;
        }

        private clsModel(int ModelID, int MakeID, string ModelName)
        {
            this.ModelID = ModelID;
            this.MakeID = MakeID;
            this.ModelName = ModelName;

            this.MakeInfo = clsMake.FindMakeByID(MakeID);

            this.Mode = enMode.Update;
        }

        private bool _AddNewModel()
        {
            this.ModelID = clsModelDataAccess.AddNewModel(this.MakeID.GetValueOrDefault(), this.ModelName);
            return (this.ModelID != null);
        }

        private bool _UpdateModel()
        {
            return clsModelDataAccess.UpdateModel(this.ModelID.GetValueOrDefault(), this.MakeID.GetValueOrDefault(), this.ModelName);
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewModel())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateModel();
            }

            return false;
        }

        public static clsModel FindModel(int ModelID)
        {
            int MakeID = -1;
            string ModelName = string.Empty;

            if (clsModelDataAccess.FindModelByID(ModelID, ref MakeID, ref ModelName))
                return new clsModel(ModelID, MakeID, ModelName);

            return null;
        }

        public static clsModel FindModel(string ModelName)
        {
            int ModelID = -1, MakeID = -1;

            if (clsModelDataAccess.FindModelByModelName(ModelName, ref ModelID, ref MakeID))
                return new clsModel(ModelID, MakeID, ModelName);

            return null;
        }

        public static bool DeleteModel(int ModelID)
        {
            return clsModelDataAccess.DeleteModel(ModelID);
        }

        public static DataTable GetAllModels()
        {
            return clsModelDataAccess.GetAllModels();
        }

        public static bool IsModelExists(int ModelID)
        {
            return clsModelDataAccess.IsModelExistsByID(ModelID);
        }

        public static bool IsModelExists(string ModelName)
        {
            return clsModelDataAccess.IsModelExistsByModelName(ModelName);
        }
    }
}
