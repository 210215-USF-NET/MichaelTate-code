using System;
using AppModels;
using System.Collections.Generic;

namespace AppBL
{
    public interface IApplicationBL
    {
        List<User> GetUser();

        User AddUser(User newUser);

        User GetUserByName(string name);

        List<Stuff> GetStuff();

        Stuff AddStuff(Stuff newTask);

        Stuff GetStuffsByName(string name);

        Stuff DeleteStuff(Stuff stuff2BDeleted);
    }
}