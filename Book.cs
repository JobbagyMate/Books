using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    internal class Book
    {
        private string language;
        private int stock;
        private int price;
        private string title;
        private int year;

        public long ISBN { get; set; }
        public List<Author> Authors { get; set; }
        public string Title
        {
            get => title; 
            set
            {
                if (value.Length < 3 ||
                    value.Length > 64) 
                    throw new Exception("Invalid title!");
                title = value;
            }
        }
        public int Year
        {
            get => year; 
            set
            {
                if (value < 2007 || 
                    value > DateTime.Today.Year) 
                    throw new Exception("Invalid year!");
                year = value;
            }
        }
        public string Language
        {
            get => language; 
            set
            {
                if (value != "angol" ||
                    value != "német" ||
                    value != "magyar") 
                    throw new Exception("Invalid language!");
                language = value;
            }
        }
        public int Stock
        {
            get => stock; 
            set
            {
                if (value < 0) 
                    throw new Exception("Invalid stock value!");
                stock = value;
            }
        }
        public int Price
        {
            get => price; 
            set
            {
                if (value < 1000 || 
                    value > 10000) 
                    throw new Exception("Invalid price!");
                price = value;
            }
        }

        public Book(string title, params string[] authorNames)
        {
            ISBN = long.Parse(
                $"{Random.Shared.Next(10000, 1000000)}" +
                $"{Random.Shared.Next(10000, 1000000)}");

            Title = title;

            List<Author> tempAuts = [];
            foreach (var an in authorNames Authors.Add(new(an));
            Authors = tempAuts;
        }

        public override string ToString()
        {
            if (Stock == 0)
            {
                _ = $"{Stock} beszerzés alatt";
            }
            else
            {
                _ = $"{Stock} db";
            }
        }
    }
}
