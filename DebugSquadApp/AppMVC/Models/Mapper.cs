using AppModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMVC.Models
{
    public class Mapper : IMapper
    {
        public User Cast2User(UserCRVM user2BCasted)
        {
            return new User
            {
                Name = user2BCasted.Name
            };
        }


       

        public UserCRVM Cast2UserCRVM(User user)
        {
            return new UserCRVM
            {
                Name = user.Name
            };
        }

        public Stuff Cast2Stuff(StuffCRVM stuff2BCasted)
        {
            return new Stuff
            {
                StuffName = stuff2BCasted.StuffName,
                StuffDescription = stuff2BCasted.StuffDescription,
                StuffStatus = stuff2BCasted.StuffStatus
            };
        }

        public StuffCRVM Cast2StuffCRVM(Stuff stuff)
        {
            return new StuffCRVM
            {
                StuffName = stuff.StuffName,
                StuffDescription = stuff.StuffName,
                StuffStatus = stuff.StuffStatus
            };
        }

        public UserIndexVM Cast2UserIndexVM(User user2BCasted)
        {
            return new UserIndexVM
            {
                Name = user2BCasted.Name
            };
        }

        public StuffIndexVM Cast2StuffIndexVM(Stuff stuff2BCasted)
        {
            return new StuffIndexVM
            {
                StuffName = stuff2BCasted.StuffName,
                StuffDescription = stuff2BCasted.StuffDescription,
                StuffStatus = stuff2BCasted.StuffStatus,
                //Name = stuff2BCasted.Name
            };
        }
    }
}