using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppModels;
using AppDL;

namespace AppBL
{
    public class ApplicationBL : IApplicationBL
    {
        private IAppRepo _repo;

        public ApplicationBL(IAppRepo repo)
        {
            _repo = repo;
        }

        public Stuff AddStuff(Stuff newStuff)
        {
            return _repo.AddStuff(newStuff);
        }

        public User AddUser(User newUser)
        {
            return _repo.AddUser(newUser);
        }

        public List<Stuff> GetStuff()
        {
            return _repo.GetStuff();
        }

        public Stuff GetStuffsByName(string name)
        {
            return _repo.GetStuffsByName(name);
        }

        public User GetUserByName(string name)
        {
            return _repo.GetUserByName(name);
        }

        public List<User> GetUser()
        {
            return _repo.GetUser();
        }

        public Stuff DeleteStuff(Stuff stuff2BDeleted)
        {
            return _repo.DeleteStuff(stuff2BDeleted);
        }
    }
}