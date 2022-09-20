using Domain.Entities;
using Domain.Interfaces;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EFCore.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        protected readonly ApplicationContext context;
        public BookRepository(ApplicationContext context) : base(context)
        {
            this.context = context;
        }

        public IEnumerable<Book> GetByLanguage(string language)
        {
            return context.Books.Where(b => b.language == language).ToList();
        }
    }
}
