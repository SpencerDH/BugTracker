using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BugTracker
{
    public class PaginatedList<T> : List<T>
    {
        public int pageNumber { get; private set; }
        public int numPages { get; private set; }
        public int count { get; private set; }
        public List<List<int>> boxesList { get; set; }
        public List<int> currentPagesBox { get; set; }
        public int boxSize { get; set; }
        public PaginatedList(IEnumerable<T> querySource, int pageNumber, int pageSize)
        {
            // Set the number of pages in a box as a fixed value
            boxSize = 5;

            // Get the length of the query
            this.count = querySource.Count();

            // Check if there are still items to be paginated
            /*
            if ((pageNumber * pageSize) >= count)
            {
                throw new ArgumentException("The product of pageNumber and pageSize cannot be greater than the length of querySource");
            }
            */

            this.pageNumber = pageNumber;
            var items = querySource.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            this.numPages = (int)Math.Ceiling(count / (double)pageSize);

            this.AddRange(items);

            /*
             * Here we calculate the list of boxes of pages and return the one to which this page belongs.
             */

            List<int> pagesList = Enumerable.Range(1, this.numPages).ToList();
            boxesList = new List<List<int>>(); 
            while (pagesList.Count > boxSize)
            {
                List<int> tempList = new List<int>();
                tempList = pagesList.GetRange(0, boxSize);
                boxesList.Add(tempList);
                pagesList.RemoveRange(0, boxSize);
            }

            if (pagesList.Count > 0)
            {
                boxesList.Add(pagesList);
            }

            currentPagesBox = new List<int>();
            foreach (var pagesBox in boxesList)
            {
                if (pagesBox.Contains(pageNumber))
                {
                    currentPagesBox = pagesBox;
                }
            }
        }

        public bool HasPreviousPage()
        {
            return pageNumber > 1;
        }

        public bool HasNextPage()
        {
            return pageNumber < numPages;
        }

    }
}
