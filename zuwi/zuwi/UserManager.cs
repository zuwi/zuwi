using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using zuwi.Models;

namespace zuwi
{
    public class UserManager
    {

        private ZuwiDBModelContainer _db = new ZuwiDBModelContainer();
        private PasswordHasher _hasher = new PasswordHasher();

        public bool ValidateUser(string email, string password)
        {
            return _hasher.VerifyHashedPassword(_db.Users.Where(u => u.Email == email).First().Password, password) == PasswordVerificationResult.Success;
        }

        public User GetUser(string email)
        {
            return _db.Users.Where(u => u.Email == email).First();
        }

        public bool UserExists(string email)
        {
            return _db.Users.Any(u => u.Email == email);
        }

        public User CreateUser(string email, string password)
        {
            User user = new User()
            {
                Email = email,
                Password = _hasher.HashPassword(password)
            };
            user.Roles.Add(_db.Roles.Where(r => r.Name == "User").First());
            _db.Users.Add(user);
            _db.SaveChanges();
            return user;
        }
    }
}