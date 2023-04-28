namespace BookFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            // Wrtiing to a File

            List<Book> books = new List<Book>() { 
            new Book(){ Title = "Lord of the Rings", Author = "JRR T", Pages=1234 },
            new Book(){ Title= "Harry Potter", Author = "JK R", Pages=2000}
            };

            // File runs in bin folder
            Console.WriteLine(Directory.GetCurrentDirectory());


            // C:\Users\josh_\source\repos\BookFile\BookFile
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            
            string fileName = @"\BookList.txt";

            string fullPath = path + fileName;

            // File does not exist
            if (!File.Exists(fullPath))    
            {
                StreamWriter streamWriter = new StreamWriter(fullPath);
                foreach (Book book in books) 
                {
                    // Title,Author,Pages
                    // Title,Author,Pages
                    streamWriter.WriteLine($"{book.Title},{book.Author},{book.Pages}");
                }
                streamWriter.Close();
            }


            // Adding onto am exisiting file

            Console.WriteLine("Enter a book title");
            string title = Console.ReadLine();

            Console.WriteLine("Enter a book author");
            string author = Console.ReadLine();

            Console.WriteLine("Enter the book pages");
            int pages = int.Parse(Console.ReadLine());

            Book newBook = new Book() { Title=title, Author=author, Pages= pages};

            StreamWriter addWriter = new StreamWriter(fullPath,true);

            addWriter.WriteLine($"{newBook.Title},{newBook.Author},{newBook.Pages}");

            addWriter.Close();



            // Reading From a File

            List<Book> bookFile = new List<Book>();

            StreamReader streamReader = new StreamReader(fullPath);

            string textDump = streamReader.ReadToEnd();

            string[] lines = textDump.Split("\n");

            foreach (string line in lines)
            {
                // check to see if  line empty
                if(line.Length > 0)
                {
                    string[] bookProps = line.Split(",");
                    Book book = new Book() { Title = bookProps[0], Author = bookProps[1],Pages = int.Parse(bookProps[2]) };
                    bookFile.Add(book);
                }
            }

            streamReader.Close();

            // Testing reading from file

            foreach (Book bookF in bookFile) {
                Console.WriteLine(bookF.Title);
            }


        }
    }
}