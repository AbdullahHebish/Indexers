using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexers
{
    internal class BookCollection
    {
        private Book[] books = new Book[3];

		public Book this[int indexer]
		{
			get 
			{
                return books[indexer];
			}

			set { books[indexer] = value; }
		}
        public Book this[string title]
        {
            get
            {
                foreach (var item in books)
                {
                    if (item.Title == title)
                    {
                        return item;
                    }
                }

                return null;
            }


            set {

                    for (var i = 0; i < books.Length; i++)
                    {
                        if (books[i].Title == title)
                        {
                            books[i] = value;
                            return;
                        }
                    }
                    throw new InvalidOperationException("Book not found");
                }
        }
    }
}
