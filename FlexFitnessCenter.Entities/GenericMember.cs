using System;
using System.Collections.Generic;
using FlexFitnessCenter.Entities.Abstract;

namespace FlexFitnessCenter.Entities
{
    public class GenericMember : Identifiable
    {
        #region Public Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public DateTime BirthDay{ get; set; }
        public Address Address{ get; set; }
        public TelephoneDetails TelephoneDetails{ get; set; }
        #endregion

        public GenericMember()
        {
            
        }
    }

    public class Address
    {
        #region Public Properties
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string SuiteNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Country{ get; set; }
        #endregion
    }

    public class TelephoneDetails
    {
        #region Public Properties
        public long  CellPhone { 

            set { _numbers.Add("CellPhone", value); }
            get
            {
                return !_numbers.ContainsKey("CellPhone") ? 0 : _numbers["CellPhone"];
            }
        }
        public long HomePhone
        {
            set { _numbers.Add("HomePhone", value); }
            get
            {
                return !_numbers.ContainsKey("HomePhone") ? 0 : _numbers["HomePhone"];
            }
        }
        public long WorkPhone
        {
            set { _numbers.Add("HomePhone", value); }
            get
            {
                return !_numbers.ContainsKey("HomePhone") ? 0 : _numbers["HomePhone"];
            }
        }
        public long Other
        {
            set { _numbers.Add("HomePhone", value); }
            get
            {
                return !_numbers.ContainsKey("HomePhone") ? 0 : _numbers["HomePhone"];
            }
        }
        #endregion
        
        private readonly Dictionary<string, long> _numbers;

        #region Constructor
        public TelephoneDetails()
        {
            _numbers = new Dictionary<string, long>();
        }
        #endregion
    }

    
}
