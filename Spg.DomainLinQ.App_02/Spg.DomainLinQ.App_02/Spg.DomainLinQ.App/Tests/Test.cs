using Microsoft.EntityFrameworkCore;
using Spg.DomainLinQ.App.Infrastructure;
using Spg.DomainLinQ.App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Spg.DomainLinQ.App.Tests
{

    public class Test
    {
        private Shop2000Context GenerateDb()
        {
            DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlite("Data Source=./../../../Shop2000.db");



            Shop2000Context db = new Shop2000Context(optionsBuilder.Options);
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            return db;
        }



        [Fact]
        public void User_addOneEntity_SuccessTest()
        {
            User u = new User( 1, new Guid(), "fist", "last", "email", Genders.NA, new Shop ("xy", new Guid ()), new Address(), new Address());
            // Arrange
            Shop2000Context db = GenerateDb();
            // ...
            db.Add(u);
            db.SaveChanges();
            Assert.Equal(1, db.Users.Count());


            // Act
            // ...



            // Assert
            // ...
        }
    }
}
