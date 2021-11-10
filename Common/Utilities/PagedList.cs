using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Common.Utilities
{
    public class PagedList<T> where T : class
    {
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public int PageSize { get; set; }
        public int ItemCount { get; set; }
        public IEnumerable<T> Items { get; set; }

        public PagedList(IEnumerable<T> items, int currentPage, int pageSize, int count)
        {
            CurrentPage = currentPage;
            ItemCount = count;
            PageCount = (int)Math.Ceiling(count / (double)pageSize);
            PageSize = pageSize;
            Items = items;
        }

        public static async Task<PagedList<T>> CreateAsync(IQueryable<T> source, int pageNumber, int pageSize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

            return new PagedList<T>(items, pageNumber, pageSize, count);
        }
    }
}
