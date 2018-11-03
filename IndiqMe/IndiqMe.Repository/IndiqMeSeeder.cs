using IndiqMe.Domain;
using IndiqMe.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndiqMe.Repository
{
    public class IndiqMeSeeder
    {
        private readonly ApplicationDbContext _context;

        private const string PASSWORD_HASH = "9XurTqQsYQY1rtAGXRfwEWO/ROghN3DFx9lTT75i/0s=";
        private const string PASSWORD_SALT = "1x7XxoaSO5I0QGIdARCh5A==";

        public IndiqMeSeeder(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            _context.Database.EnsureCreated();

            if (!(_context.Users.Any()
                ))
            {
                var grantee = new User()
                {
                    Name = "Walter Vinicius Lopes Cardoso",
                    Email = "walter@indiqme.com",
                    Linkedin = "linkedin.com/walter.cardoso",
                    Password = PASSWORD_HASH,
                    PasswordSalt = PASSWORD_SALT,
                    CreationDate = DateTime.Now
                };

                var @operator = new User()
                {
                    Name = "Vagner",
                    Email = "vagner@indiqme.com",
                    Linkedin = "linkedin.com/vagner",
                    Profile = Profile.Administrator,
                    Password = PASSWORD_HASH,
                    PasswordSalt = PASSWORD_SALT,
                    CreationDate = DateTime.Now
                };

                _context.Users.AddRange(grantee, @operator);

                _context.SaveChanges();
            }

        }
    }
}
