using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UFAR.SS.Core.Services.Author;
using UFAR.SS.Data.DAO;
using UFAR.SS.Data.Entities;

namespace UFAR.SS.Services
{
    public class AuthorService : IAuthorServices
    {
        ApplicationDBContext context;
        public AuthorService(ApplicationDBContext _context) {
            context = _context;
        }
        public void AddAuthor(AuthorEntity author)
        //To do business Logic
        {
            author.FirstName = "FirstName";
            author.LastName = "LastName";
            author.NickName = "NickName";

            context.Add(author);
            context.SaveChanges();
        }
        //Soft Delete
        public void RemoveAuthor(int authorId)
        {
            context.Author.FirstOrDefault(x => x.Id == authorId).isDeleted = true;
            context.SaveChanges();
        }
        public void UpdateAuthor(AuthorEntity entity)
        {
            context.Update(entity);
            context.SaveChanges();
        }
        //Hard Delete
        public void DeleteAuthor(AuthorEntity entity)
        {
            context.Remove(entity);
            context.SaveChanges();
        }
        public List<AuthorEntity> GetAuthor()
        {
            return context.Author.ToList();
        }
        public AuthorEntity GetAuthorById(int authorId)
        {
            return context.Author.FirstOrDefault(x => x.Id == authorId);
        }
        public AuthorEntity GetAuthorByFirstName(string authorName)
        {
            return context.Author.FirstOrDefault(x => x.FirstName == authorName);
        }
        public AuthorEntity GetAuthorByLastName(string authorName)
        {
            return context.Author.FirstOrDefault(x => x.LastName == authorName);
        }
        public AuthorEntity GetAuthorByNickName(string authorName)
        {
            return context.Author.FirstOrDefault(x => x.NickName == authorName);
        }

        public void addAuthor(AuthorEntity author)
        {
            throw new NotImplementedException();
        }
    }
}