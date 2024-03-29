﻿using Suls.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Suls.Services
{
    public class UsersService : IUsersService
    {
        private readonly ApplicationDbContext db;

        public UsersService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void CreateUser(string username, string email, string password)
        {
            var user = new User
            {
                Email = email,
                Username = username,
                Password = ComputeHash(password),
            };

            db.Users.Add(user);
            db.SaveChanges();
        }

        public string GetUserId(string username, string password)
        {
            var passwordHash = ComputeHash(password);
            var user = db.Users.FirstOrDefault(x=>x.Username == username && x.Password == passwordHash);
            return user?.Id;
        }

        public bool IsEmailAvailable(string email)
        {
            return !db.Users.Any(x=>x.Email == email);
        }

        public bool IsUsernameAvailable(string username)
        {
            return !db.Users.Any(x => x.Username == username);

        }

        public static string ComputeHash(string input)
        {
            var bytes = Encoding.UTF8.GetBytes(input);
            using var hash = SHA512.Create();
            var hashedInputBytes = hash.ComputeHash(bytes);

            var hashedInputStringBuilder = new System.Text.StringBuilder(128);
            foreach (var b in hashedInputBytes)
                hashedInputStringBuilder.Append(b.ToString("X2"));
            return hashedInputStringBuilder.ToString();
        }
    }
}
