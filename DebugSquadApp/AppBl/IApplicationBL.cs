using System;
using AppModels;
using System.Collections.Generic;

namespace AppBL
{
    public interface IApplicationBL
    {
        List<User> GetUser();

        void AddUser(User newUser);

        User GetUserByName(string name);

        List<Stuff> GetStuff();

        void AddStuffs(Stuff newTask);

        Stuff GetStuffsByName(string name);
    }
}