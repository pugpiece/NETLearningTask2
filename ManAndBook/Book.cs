using System;
using System.Collections.Generic;
using System.Text;

namespace ManAndBook
{
    class Book
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != null)
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Wrong data was inputed");
                }
            }
        }

        private int _pageAmmount;
        public int PageAmmount
        {
            get
            {
                return _pageAmmount;
            }
            set
            {
                if (value > 0)
                {
                    _pageAmmount = value;
                }
                else
                {
                    throw new ArgumentException("Wrong data was inputed");
                }
            }
        }

        private string _publisher;
        public string Publisher
        {
            get
            {
                return _publisher;
            }
            set
            {
                if (value != null)
                {
                    _publisher = value;
                }
                else
                {
                    throw new ArgumentException("Wrong data was inputed");
                }
            }
        }

        private DateTime? _publishDate;
        public DateTime? PublishDate
        {
            get
            {
                return _publishDate;
            }
            set
            {
                if (value != null)
                {
                    _publishDate = value;
                }
                else
                {
                    throw new ArgumentException("Wrong data was inputed");
                }
            }
        }

        private DateTime? _writtenDate;
        public DateTime? WrittenDate
        {
            get
            {
                return _writtenDate;
            }
            set
            {
                if (value != null && value <= PublishDate)
                {
                    _writtenDate = value;
                }
                else
                {
                    throw new ArgumentException("Wrong data was inputed");
                }
            }
        }

        private Author _author;
        public Author Author
        {
            get
            {
                return _author;
            }
            set
            {
                if (value != null && value.BirthYear <= ((DateTime)WrittenDate).Year)
                {
                    _author = value;
                }
                else
                {
                    throw new ArgumentException("Wrong data was inputed");
                }
            }
        }

        public Book(string newName, int newPageAmmount, string newPublisher, DateTime? newPublishDate, DateTime? newWrittenDate, Author newAuthor)
        {
            Name = newName;
            PageAmmount = newPageAmmount;
            Publisher = newPublisher;
            PublishDate = newPublishDate;
            WrittenDate = newWrittenDate;
            Author = newAuthor;

        }

        public override string ToString()
        {
            return $"{Name} {PageAmmount} {Publisher} {PublishDate} {WrittenDate} {Author.Name} {Author.Surname}";
        }
        
       
    }
}
