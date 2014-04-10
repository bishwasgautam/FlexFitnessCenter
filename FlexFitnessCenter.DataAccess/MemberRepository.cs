using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexFitnessCenter.Entities;
using FlexFitnessCenter.Entities.Abstract;

namespace FlexFitnessCenter.DataAccess
{
    public class MemberRepository: GenericRepository<GenericMember>
    {
        private readonly IDataAccess _ds;

        public MemberRepository(IDataAccess ds) : base(ds)
        {
            _ds = ds;
        }

        public List<GenericMember> GetAllMembersByFirstName(string firstName)
        {
            return GetAll().Where(x => x.FirstName.Equals(firstName, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }

        public GenericMember GetMemberById(int id)
        {
            return GetAll().FirstOrDefault(x => x.Id == id);
        }

        public List<GenericMember> GetAllMembersByState(string state)
        {
            return GetAll().Where(x => x.Address.State.Equals(state,StringComparison.CurrentCultureIgnoreCase)).ToList();
        }



    }

   
}
