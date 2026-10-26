using ReadMoreBooks.Data;

using var context = new BookstoreContext();

context.Database.EnsureCreated();

Console.WriteLine("ReadMoreBooks database created successfully!");

Console.WriteLine($"Database can connect: {context.Database.CanConnect()}");
