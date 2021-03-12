using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppModels;

namespace AppDL
{
    public interface IAppRepo
    {
        List<User> GetUser();

        User AddUser(User newUser);

        User GetUserByName(string name);

        Stuff AddStuff(Stuff newStuff);

        List<Stuff> GetStuff();

        public Stuff GetStuffsByName(string name);

        Stuff DeleteStuff(Stuff stuff2BDeleted);
    }
}