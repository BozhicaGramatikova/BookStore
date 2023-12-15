using BookstoreDL.Interfaces;
using BookstoreDL.MemoryDB;
using BookstoreModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreDL.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        public void Add(Author author)
        {
            InMemoryDb.AuthorData.Add(author);
        }

        public void Delete(int id)
        {
            var author = GetbyId(id);
            
        }

        public List<Author> GetAll()
        {
            return InMemoryDb.AuthorData; 
        }

        public Author GetbyId(int id)
        {
            return InMemoryDb.AuthorData// List<Author>
                FirstofDefault(a: Author = async.Id == id);
        }
    }
}
