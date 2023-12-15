using BookstoreModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookstoreDL.MemoryDB
{
    public static class InMemoryDB
    {
        public static List<Author> AuthorData =
            new List<Author>()
            {

                new Author()
                {
                    Id = 1,
                    Name = "Author1",
                    BirthDay = DateTime.Now
                }
            };
        new Author()
        {
            Id = 2,
                    Name = "Author2",
                    BirthDay = DateTime.Now
                },
           new Author()
        {
            Id = 3,
                    Name = "Author3",
                    BirthDay = DateTime.Now
                };

    }
