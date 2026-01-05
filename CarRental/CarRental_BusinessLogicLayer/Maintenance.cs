using System;
using System.Data;
using System.Threading.Tasks;
using CarRental_DataAccessLayer;

namespace CarRental_BusinessLogicLayer
{
    public class clsMaintenance
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode;

        public int? MaintenanceID { set; get; }
        public int? VehicleID { set; get; }
        public string Description { set; get; }
        public DateTime? MaintenanceDate { set; get; }
        public float? Cost { set; get; }

        public clsVehicle VehicleInfo;

        public clsMaintenance()
        {
            this.MaintenanceID = null;
            this.VehicleID = null;
            this.Description = null;
            this.MaintenanceDate = null;
            this.Cost = null;

            this.VehicleInfo = new clsVehicle();

            this.Mode = enMode.AddNew;
        }

        private clsMaintenance(int MaintenanceID, int VehicleID, string Description, DateTime MaintenanceDate, float Cost)
        {
            this.MaintenanceID = MaintenanceID;
            this.VehicleID = VehicleID;
            this.Description = Description;
            this.MaintenanceDate = MaintenanceDate;
            this.Cost = Cost;

            this.VehicleInfo = clsVehicle.FindVehicle(VehicleID);

            this.Mode = enMode.Update;
        }


        private bool _AddNewMaintenance()
        {
            this.MaintenanceID = clsMaintenanceDataAccess.AddNewMaintenance(this.VehicleID.GetValueOrDefault(), this.Description, this.MaintenanceDate.GetValueOrDefault(), this.Cost.GetValueOrDefault());

            return (this.MaintenanceID != null);
        }

        private bool _UpdateMaintenance()
        {
            return clsMaintenanceDataAccess.UpdateMaintenance(this.MaintenanceID.GetValueOrDefault(), this.VehicleID.GetValueOrDefault(), this.Description, this.MaintenanceDate.GetValueOrDefault(), this.Cost.GetValueOrDefault());
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewMaintenance())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateMaintenance();
            }

            return false;
        }

        public static clsMaintenance FindMaintenance(int MaintenanceID)
        {
            int VehicleID = -1;
            string Description = string.Empty;
            DateTime MaintenanceDate = DateTime.Now;
            float Cost = 0;

            if (clsMaintenanceDataAccess.FindMaintenance(MaintenanceID, ref VehicleID, ref Description, ref MaintenanceDate, ref Cost))
                return new clsMaintenance(MaintenanceID, VehicleID, Description, MaintenanceDate, Cost);

            return null;
        }

        public static bool DeleteMaintenance(int MaintenanceID)
        {
            return clsMaintenanceDataAccess.DeleteMaintenance(MaintenanceID);
        }

        public static async Task<DataTable> GetPagedMaintenance(int PageNumber, int RowsPerPage)
        {
            return await clsMaintenanceDataAccess.GetPagedMaintenance(PageNumber, RowsPerPage);
        }

        public static bool IsMaintenanceExists(int MaintenanceID)
        {
            return clsMaintenanceDataAccess.IsMaintenanceExists(MaintenanceID);
        }

        public static int GetPageCount(int RowsPerPage = 100)
        {
            return clsMaintenanceDataAccess.GetPageCount(RowsPerPage);
        }
    }
}
