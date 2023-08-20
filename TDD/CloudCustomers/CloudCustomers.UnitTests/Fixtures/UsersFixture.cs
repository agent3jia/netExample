using CloudCustomers.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudCustomers.UnitTests.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() =>
            new List<User>()
            {
                    new User()
                    {
                        Id = 1,
                        Name = "Test1",
                        Address = new Address()
                        {
                            Street = "123 Main st",
                            City = "Madison",
                            ZipCode = "53794"
                        },
                        Email = "jane1@exmaple.com"
                    },
                    new User()
                    {
                        Id = 2,
                        Name = "Test2",
                        Address = new Address()
                        {
                            Street = "123 Main st",
                            City = "SuZhou",
                            ZipCode = "53794"
                        },
                        Email = "jane2@exmaple.com"
                    },
                    new User()
                    {
                        Id = 3,
                        Name = "Test3",
                        Address = new Address()
                        {
                            Street = "123 Main st",
                            City = "SuZhou",
                            ZipCode = "53794"
                        },
                        Email = "jane3@exmaple.com"
                    },
            };

    }
}
