using AppModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDL
{
    public class AppRepoDB : IAppRepo
    {
        private readonly AppDBContext _context;

        public AppRepoDB(AppDBContext context)
        {
            _context = context;
        }

        public Stuff AddStuff(Stuff newStuff)
        {
            _context.Stuffs.Add(newStuff);
            _context.SaveChanges();
            return newStuff;
        }

        public User AddUser(User newUser)
        {
            _context.Users.Add(newUser);
            _context.SaveChanges();
            return newUser;
        }

        public List<Stuff> GetStuff()
        {
            return _context.Stuffs
                .AsNoTracking()
                .Select(stuff => stuff)
                .ToList();
        }

        public Stuff GetStuffsByName(string name)
        {
            return _context.Stuffs
                .AsNoTracking()
                .FirstOrDefault(stuff => stuff.StuffName == name);
        }

        public List<User> GetUser()
        {
            return _context.Users
                .AsNoTracking()
                .Select(user => user)
                .ToList();
        }

        public User GetUserByName(string name)
        {
            return _context.Users
                .AsNoTracking()
                .FirstOrDefault(user => user.Name == name);
        }

        public Stuff DeleteStuff(Stuff stuff2BDeleted)
        {
            _context.Stuffs.Remove(stuff2BDeleted);
            _context.SaveChanges();
            return stuff2BDeleted;
        }
    }
}