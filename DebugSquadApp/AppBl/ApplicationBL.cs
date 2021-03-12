using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppModels;
using AppDL;

namespace AppBL
{
    internal class ApplicationBL : IApplicationBL
    {
        private IAppRepo _repo;

        public void AddStuffs(Stuff newTask)
        {
            _repo.AddStuffs(newTask);
        }

        public void AddUser(User newUser)
        {
            _repo.AddUser(newUser);
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
    }
}