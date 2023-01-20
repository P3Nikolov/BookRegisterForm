using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm2023
{
    public class Book
    {
        private string author;
        private string title;
        private string izdatelstvo;
        private string janr;
        private string korica;
        private string tematika;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Izdatelstvo
        {
            get { return izdatelstvo; }
            set { izdatelstvo = value; }
        }
        public string Janr
        {
            get { return janr; }
            set { janr = value; }
        }
        public string Korica
        {
            get { return korica; }
            set { korica = value; }
        }
        public string Tematika
        {
            get { return tematika; }
            set { tematika = value; }
        }


        public Book(string author, string title, string izdatelstvo, string janr, string korica, string tematika)
        {
            Author = author;
            Title = title;
            Izdatelstvo = izdatelstvo;
            Janr = janr;
            Korica = korica;
            Tematika = tematika;
        }
    }
}
