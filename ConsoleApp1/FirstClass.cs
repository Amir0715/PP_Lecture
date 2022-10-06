namespace ConsoleApp1
{
    public class House
    {
        float Length;
        float Height;
        float Width;
    }

    public class Book
    {
        public int PageCount;
        public string Author;
        public string Title;
        public string Genre;
        public string Publisher;

        // private string Description;

        private string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            set { 
                if (value != null)
                    _description = value;
            }
        }

        internal float internalFloat;

        public Book(int pageCount, string author, string title, string genre, string publisher) {
            Console.WriteLine("Конструктор Book");
            PageCount = pageCount;
            Author = author;
            Title = title;
            Genre = genre;
            Publisher = publisher;
        }

        public string GetDescription(bool canRead) {
            if (canRead) { 
                return Description;
            }
            return null;
        }

        public void SetDescription(string description) {
            if (description != null)
            {
                Description = description;
            }
        }

        public int GetPageCount()
        {
            return PageCount;
        }

        public void Increment(ref int x)
        {
            x = x + 1;
        }

        public void Sum(int x, int y, out int result)
        {
            result = x + y;
        }
    }
}