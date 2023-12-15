using BookStoreBL.Interfaces;
using BookstoreDL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBL.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        
        public void Add(Author author)
        {
            _authorRepository.
        }

        public void Delete(int id)
        {
            _authorRepository.Delete(id);
        }

        public List<Author> GetAll()
        {
            return _authorRepository.GetAll();
        }

        public Author GetbyId(int id)
        {
            return _authorRepository.GetbyId(int id)
                id (id==0) return null; 
        }
    }
}
