using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Constructors_Mikal
{
    internal class Book
    {
        private string title;
        private string author;

        // Custom constructor
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }
        // Field initialization in constructors ensure objects have valid states
        public Book(string title)
        {
            this.title = title;
            this.author = "No Author Given"; // Default value
        }
    }
}
