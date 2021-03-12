using AppModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMVC.Models
{
    public interface IMapper
    {
        User Cast2User(UserCRVM user2BCasted);

        UserCRVM Cast2UserCRVM(User user);

        Stuff Cast2Stuff(StuffCRVM stuff2BCasted);

        StuffCRVM Cast2StuffCRVM(Stuff stuff);

        UserIndexVM Cast2UserIndexVM(User user2BCasted);

        StuffIndexVM Cast2StuffIndexVM(Stuff stuff2BCasted);
    }
}