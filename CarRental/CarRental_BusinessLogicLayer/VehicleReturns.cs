
using System;
using System.Data;
using CarRental_DataAccessLayer;

namespace CarRental_BusinessLogicLayer
{
    public class clsVehicleReturns
    {
        private enum enMode {AddNew = 0, Update = 1};
        private enMode Mode;

        public int ReturenID {set; get;}
public DateTime ActualReturnDate {set; get;}
public byte ActualRentalDays {set; get;}
public short Mileage {set; get;}
public short ConsumedMileage {set; get;}
public string FinalCheckNotes {set; get;}
public string AdditionalCharges {set; get;}
public string ActualTotalDueAmount {set; get;}

        public clsVehicleReturns() 
        {
            this.ReturenID = -1;
this.ActualReturnDate = DateTime.Now;
this.ActualRentalDays = 0;
this.Mileage = -1;
this.ConsumedMileage = -1;
this.FinalCheckNotes = string.Empty;
this.AdditionalCharges = string.Empty;
this.ActualTotalDueAmount = string.Empty;

            this.Mode = enMode.AddNew;
        }

        private clsVehicleReturns(int ReturenID, DateTime ActualReturnDate, byte ActualRentalDays, short Mileage, short ConsumedMileage, string FinalCheckNotes, string AdditionalCharges, string ActualTotalDueAmount)
        {
            this.ReturenID = ReturenID;
this.ActualReturnDate = ActualReturnDate;
this.ActualRentalDays = ActualRentalDays;
this.Mileage = Mileage;
this.ConsumedMileage = ConsumedMileage;
this.FinalCheckNotes = FinalCheckNotes;
this.AdditionalCharges = AdditionalCharges;
this.ActualTotalDueAmount = ActualTotalDueAmount;

            this.Mode = enMode.Update;
        }
        
        
        private bool _AddNew()
        {
            this.ReturenID = clsVehicleReturnsDataAccess.AddNew(this.ReturenID, this.ActualReturnDate, this.ActualRentalDays, this.Mileage, this.ConsumedMileage, this.FinalCheckNotes, this.AdditionalCharges, this.ActualTotalDueAmount);
            return (this.ReturenID != null);
        }
        
        
        private bool _Update()
        {
            return clsVehicleReturnsDataAccess.Update(this.ReturenID, this.ActualReturnDate, this.ActualRentalDays, this.Mileage, this.ConsumedMileage, this.FinalCheckNotes, this.AdditionalCharges, this.ActualTotalDueAmount);
        }
        
        public bool Save()
        {
            switch(this.Mode)
            {
                case enMode.AddNew:
                    if(_AddNew())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else{
                        return false;
                    }   
                case enMode.Update:
                    return _Update();
            }
            
            return false;
        }

        
        public static bool Delete(int ReturenID)
        {
            return clsVehicleReturnsDataAccess.Delete(ReturenID);
        }
        
        
        public static DataTable GetAllData()
        {
            return clsVehicleReturnsDataAccess.GetAllData();
        }
    }
}
