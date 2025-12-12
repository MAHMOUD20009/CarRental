using System;
using System.Data;
using CarRental_DataAccessLayer;

namespace CarRental_BusinessLogicLayer
{
    public class clsCustomer
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode;

        public int? CustomerID { set; get; }
        public int? PersonID { set; get; }
        public string DriverLicenseNumber { set; get; }

        public clsPerson PersonInfo { private set; get; }

        public clsCustomer()
        {
            this.CustomerID = null;
            this.PersonID = null;
            this.DriverLicenseNumber = null;

            this.Mode = enMode.AddNew;
        }

        private clsCustomer(int CustomerID, int PersonID, string DriverLicenseNumber)
        {
            this.CustomerID = CustomerID;
            this.PersonID = PersonID;
            this.DriverLicenseNumber = DriverLicenseNumber;
            this.PersonInfo = clsPerson.FindPerson(PersonID);

            this.Mode = enMode.Update;
        }

        private bool _AddNewCustomer()
        {
            this.CustomerID = clsCustomerDataAccess.AddNewCustomer(this.PersonID.GetValueOrDefault(), this.DriverLicenseNumber);
            return (this.CustomerID != null);
        }


        private bool _UpdateCustomer()
        {
            return clsCustomerDataAccess.UpdateCustomer(this.CustomerID.GetValueOrDefault(), this.PersonID.GetValueOrDefault(), this.DriverLicenseNumber);
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCustomer())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateCustomer();
            }

            return false;
        }

        public static clsCustomer FindCustomer(int CustomerID)
        {
            int PersonID = -1;
            string DriverLicenseNumber = string.Empty;

            if (clsCustomerDataAccess.FindCustomer(CustomerID, ref PersonID, ref DriverLicenseNumber))
                return new clsCustomer(CustomerID, PersonID, DriverLicenseNumber);

            return null;
        }

        public static bool DeleteCustomer(int CustomerID)
        {
            return clsCustomerDataAccess.DeleteCustomer(CustomerID);
        }

        public static DataTable GetAllCustomers()
        {
            return clsCustomerDataAccess.GetAllCustomers();
        }

        public static bool IsCustomerExists(int CustomerID)
        {
            return clsCustomerDataAccess.IsCustomerExists(CustomerID);
        }

    }
}
