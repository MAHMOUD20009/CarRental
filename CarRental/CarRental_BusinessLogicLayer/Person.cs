using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using CarRental_DataAccessLayer;
using System.Collections.Generic;

namespace CarRental_BusinessLogicLayer
{
    public class clsPerson
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode;

        public int? PersonID { set; get; }
        public string Name { set; get; }
        public DateTime? DateOfBirth { set; get; }
        public bool? Gender { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }

        public clsPerson()
        {
            this.PersonID = null;
            this.Name = null;
            this.DateOfBirth = null;
            this.Gender = false;
            this.Email = null;
            this.Phone = null;

            this.Mode = enMode.AddNew;
        }

        private clsPerson(int PersonID, string Name, DateTime DateOfBirth, bool Gender, string Email, string Phone)
        {
            this.PersonID = PersonID;
            this.Name = Name;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Email = Email;
            this.Phone = Phone;

            this.Mode = enMode.Update;
        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonDataAccess.AddNewPerson(this.Name, this.DateOfBirth.GetValueOrDefault(), this.Gender.GetValueOrDefault(), this.Email, this.Phone);
            return (this.PersonID != null);
        }

        private bool _UpdatePerson()
        {
            return clsPersonDataAccess.UpdatePerson(this.PersonID.GetValueOrDefault(), this.Name, this.DateOfBirth.GetValueOrDefault(), this.Gender.GetValueOrDefault(), this.Email, this.Phone);
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    break;
                case enMode.Update:
                    return _UpdatePerson();
            }

            return false;
        }

        public static clsPerson FindPerson(int PersonID)
        {
            string Name = string.Empty, Email = string.Empty, Phone = string.Empty;
            DateTime DateOfBirth = DateTime.Now;
            bool Gender = false;

            if (clsPersonDataAccess.FindPersonByID(PersonID, ref Name, ref DateOfBirth, ref Gender, ref Email, ref Phone))
                return new clsPerson(PersonID, Name, DateOfBirth, Gender, Email, Phone);
            return null;
        }

        public static bool DeletePerson(int PersonID)
        {
            return clsPersonDataAccess.DeletePerson(PersonID);
        }

        public static async Task<DataTable> GetPagedPeople(int PageNumber = 1, int RowsPerPage = 50)
        {
            return await clsPersonDataAccess.GetPagedPeople(PageNumber, RowsPerPage);
        }
    
        public static bool IsPersonExists(int PersonID)
        {
            return clsPersonDataAccess.IsPersonExists(PersonID);
        }

        public static int GetPersonCount()
        {
            return clsPersonDataAccess.GetPersonCount();
        }

        public static int GetPageCount(int RowsPerPage = 100)
        {
            return clsPersonDataAccess.GetPageCount(RowsPerPage);
        }
    }
}
