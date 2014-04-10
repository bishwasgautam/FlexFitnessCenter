using System;
using System.Collections.Generic;
using FlexFitnessCenter.Entities;

namespace FlexFitnessCenter.DataAccess
{
    public class DataStore : IDataAccess
    {
        public IEnumerable<T> Select<T>()
        {
            #region GenericMember
            if (typeof(T)==typeof(GenericMember))
            {
                return  (IEnumerable<T>) new List<GenericMember>()
                {
                    new GenericMember(){Id = 1, FirstName = "Bishwas", LastName = "Gautam", Sex = "Male",BirthDay = new DateTime(1988,7,26),
                        Address = new Address(){
                            City = "North Chicago",
                            State = "IL",
                            StreetName = "Green Bay Road",
                            StreetNumber = 3504,
                            Country = "USA",
                            SuiteNumber = "309C",
                            ZipCode = 60064
                        },
                        TelephoneDetails = new TelephoneDetails()
                        {
                            CellPhone = 9856872223,
                            HomePhone = 7546784344
                        }},
                    new GenericMember(){Id = 2, FirstName = "Bob", LastName = "Dylan", Sex = "Male",BirthDay = new DateTime(1975,5,26),
                        Address = new Address(){
                            City = "Chicago",
                            State = "IL",
                            StreetName = "My Clap Road",
                            StreetNumber = 454,
                            Country = "USA",
                            SuiteNumber = "234",
                            ZipCode = 64068
                        },
                        TelephoneDetails = new TelephoneDetails()
                        {
                            CellPhone = 5458785454,
                            HomePhone = 4252456578
                        }},
                    new GenericMember(){Id = 3, FirstName = "Raghu", LastName = "Krisnapuram", Sex = "Male",BirthDay = new DateTime(1985,8,16),
                        Address = new Address(){
                            City = "Arlington Heights",
                            State = "IL",
                            StreetName = "Raghu road",
                            StreetNumber = 3504,
                            Country = "USA",
                            SuiteNumber = "4654",
                            ZipCode = 60069
                        },
                        TelephoneDetails = new TelephoneDetails()
                        {
                            CellPhone = 4547814254
                        }},
                    new GenericMember(){Id = 4, FirstName = "Jack", LastName = "Daniels", Sex = "Male",BirthDay = new DateTime(1988,7,26),
                        Address = new Address(){
                            City = "Houston",
                            State = "Tx",
                            StreetName = "Lean dr",
                            StreetNumber = 124,
                            Country = "USA",
                            SuiteNumber = "454A",
                            ZipCode = 77485
                        },
                        TelephoneDetails = new TelephoneDetails()
                        {
                
                            HomePhone = 7546784344
                        }},
                    new GenericMember(){Id = 5, FirstName = "Linda", LastName = "Jackson", Sex = "Female",BirthDay = new DateTime(1998,5,2),
                        Address = new Address(){
                            City = "New Orleans",
                            State = "LA",
                            StreetName = "Hooks Dr",
                            StreetNumber = 1301,
                            Country = "USA",
                            SuiteNumber = "2",
                            ZipCode = 70401
                        },
                        TelephoneDetails = new TelephoneDetails()
                        {
                            Other = 9823435555
                        }},
                    new GenericMember(){Id = 6, FirstName = "Haley", LastName = "Shiner", Sex = "Female",BirthDay = new DateTime(1978,7,16),
                        Address = new Address(){
                            City = "Champagne",
                            State = "IL",
                            StreetName = "Rooke blvd",
                            StreetNumber = 985,
                            Country = "USA",
                            SuiteNumber = "45",
                            ZipCode = 69585
                        },
                        TelephoneDetails = new TelephoneDetails()
                        {
                    
                            HomePhone = 7546784344
                        }},
                    new GenericMember(){Id = 7, FirstName = "Bishwas", LastName = "Gautam", Sex = "Male",BirthDay = new DateTime(1988,7,26),
                        Address = new Address(){
                            City = "North Chicago",
                            State = "IL",
                            StreetName = "Green Bay Road",
                            StreetNumber = 3504,
                            Country = "USA",
                            SuiteNumber = "309C",
                            ZipCode = 60064
                        },
                        TelephoneDetails = new TelephoneDetails()
                        {
                            CellPhone = 9856872223,
                            HomePhone = 7546784344
                        }},
                    new GenericMember(){Id = 8, FirstName = "Bishwas", LastName = "Gautam", Sex = "Male",BirthDay = new DateTime(1988,7,26),
                        Address = new Address(){
                            City = "North Chicago",
                            State = "IL",
                            StreetName = "Green Bay Road",
                            StreetNumber = 3504,
                            Country = "USA",
                            SuiteNumber = "309C",
                            ZipCode = 60064
                        },
                        TelephoneDetails = new TelephoneDetails()
                        {
                            CellPhone = 9856872223,
                            HomePhone = 7546784344
                        }},
                    new GenericMember(){Id = 9, FirstName = "Bishwas", LastName = "Gautam", Sex = "Male",BirthDay = new DateTime(1988,7,26),
                        Address = new Address(){
                            City = "North Chicago",
                            State = "IL",
                            StreetName = "Green Bay Road",
                            StreetNumber = 3504,
                            Country = "USA",
                            SuiteNumber = "309C",
                            ZipCode = 60064
                        },
                        TelephoneDetails = new TelephoneDetails()
                        {
                            CellPhone = 9856872223,
                            HomePhone = 7546784344
                        }},
                    new GenericMember(){Id = 10, FirstName = "Bishwas", LastName = "Gautam", Sex = "Male",BirthDay = new DateTime(1988,7,26),
                        Address = new Address(){
                            City = "North Chicago",
                            State = "IL",
                            StreetName = "Green Bay Road",
                            StreetNumber = 3504,
                            Country = "USA",
                            SuiteNumber = "309C",
                            ZipCode = 60064
                        },
                        TelephoneDetails = new TelephoneDetails()
                        {
                            CellPhone = 9856872223,
                            HomePhone = 7546784344
                        }},
                    new GenericMember(){Id = 11, FirstName = "Bishwas", LastName = "Gautam", Sex = "Male",BirthDay = new DateTime(1988,7,26),
                        Address = new Address(){
                            City = "North Chicago",
                            State = "IL",
                            StreetName = "Green Bay Road",
                            StreetNumber = 3504,
                            Country = "USA",
                            SuiteNumber = "309C",
                            ZipCode = 60064
                        },
                        TelephoneDetails = new TelephoneDetails()
                        {
                            CellPhone = 9856872223,
                            HomePhone = 7546784344
                        }},
                    new GenericMember(){Id = 12, FirstName = "Bishwas", LastName = "Gautam", Sex = "Male",BirthDay = new DateTime(1988,7,26),
                        Address = new Address(){
                            City = "North Chicago",
                            State = "IL",
                            StreetName = "Green Bay Road",
                            StreetNumber = 3504,
                            Country = "USA",
                            SuiteNumber = "309C",
                            ZipCode = 60064
                        },
                        TelephoneDetails = new TelephoneDetails()
                        {
                            CellPhone = 9856872223,
                            HomePhone = 7546784344
                        }},

                };
            }
            #endregion GenericMember
            return new List<T>();
        }
    }
}