using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    static class Library
    {
        public static List<Media> allMedia = new List<Media>()
        {
            //Adding 5 Books
            new Book("Frankenstein", MediaType.Book, 250),
            new Book("The Kite Runner", MediaType.Book, 100),
            new Book("Harry Potter", MediaType.Book, 150),
            new Book("Wuthering Heights", MediaType.Book, 50),
            new Book("Animal Farm", MediaType.Book, 300),

            //Adding 5 Magazines
            new Magazine("Time", MediaType.Magazine, 25, 1001),
            new Magazine("Fortune", MediaType.Magazine, 30, 1002),
            new Magazine("Vogue", MediaType.Magazine, 20, 1003),
            new Magazine("The Atlantic", MediaType.Magazine, 50, 1004),
            new Magazine("People", MediaType.Magazine, 35, 1005),

            //Adding 5 Movies
            new Movie("Interstellar", MediaType.Movie, 2.49),
            new Movie("Inception", MediaType.Movie, 2.42),
            new Movie("Predestination", MediaType.Movie, 1.37),
            new Movie("Source Code", MediaType.Movie, 1.33),
            new Movie("Passengers", MediaType.Movie, 1.56),
        };

        public static List<LibraryMember> allMembers = new List<LibraryMember>()
        { 
            //Adding Members
            new LibraryMember("Braden Chevalier"),
            new LibraryMember("Nirav Chaudhari"),
            new LibraryMember("Sahil Achhava"),
            new LibraryMember("Harshu Patel"),
            new LibraryMember("Namu Bhoj"),
            new LibraryMember("Yaggu Patel"),
            new LibraryMember("Suti Muraleedharan"),
            new LibraryMember("Dhruv Shah"),
            new LibraryMember("Aakash Singh"),
            new LibraryMember("Harpreet Kaur"),
            new LibraryMember("Harman Singh"),
            new LibraryMember("Anmol Kaur"),
        };

        public static int uniqueSerialNumber = 1;
        public static int uniqueMemberID = 1;
    }
}
