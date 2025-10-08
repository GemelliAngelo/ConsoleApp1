using DbRelationships.Entities;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Text.Json;

namespace DbRelationships
{
    internal class Program
    {
        private static readonly string _connectionString = "Server=localhost;Database=LibraryDb;User Id=sa;Password=bitspa.1;TrustServerCertificate=true";

        static void Main(string[] args)
        {
            var booksDict = GetBooks();
            foreach (KeyValuePair<int,Book> book in booksDict)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine(JsonSerializer.Serialize(book.Value));
            }
        }

        static Dictionary<int,Book> GetBooks()
        {
            var query = "SELECT B.Id, B.Name, C.Id AS CategoryId, C.Name AS Category, BD.ISBN, BD.PublicationDate, A.Id AS AuthorId, A.FirstName, A.LastName" +
                " FROM BookAuthors AS BA" +
                " INNER JOIN Books AS B ON B.Id = BA.BookId" +
                " INNER JOIN Categories AS C ON C.Id = B.CategoryId" +
                " INNER JOIN BookDetails BD ON BD.BookId = B.Id" +
                " INNER JOIN Authors AS A ON A.Id = BA.AuthorId";

            using var connection = new SqlConnection(_connectionString);
            var cmd = new SqlCommand(query, connection);
            connection.Open();
            var dr = cmd.ExecuteReader();

            if (!dr.HasRows)
            {
                throw new Exception("No records found!");
            }

            var books = new List<Book>();
            var booksDict = new Dictionary<int, Book>();

            while (dr.Read())
            {
                var book = new Book()
                {
                    Id = dr.GetInt32("Id"),
                    Name = dr.GetString("Name"),
                    Category = new Category() { Id = dr.GetInt32("CategoryId"), Name = dr.GetString("Category") },
                    ISBN = dr.GetString("ISBN"),
                    PublicationDate = dr.GetDateTime("PublicationDate"),
                    Authors = [new Author() {
                        Id = dr.GetInt32("AuthorId"),
                        FirstName = dr.GetString("FirstName"),
                        LastName = dr.GetString("LastName") }
                    ]
                };

                try
                {
                    booksDict.Add(book.Id, book);
                }
                catch (Exception)
                {
                    booksDict[book.Id].Authors.Add(new Author()
                    {
                        Id = dr.GetInt32("AuthorId"),
                        FirstName = dr.GetString("FirstName"),
                        LastName = dr.GetString("LastName")
                    });
                }
            }

            return booksDict;
        }
    }
}
