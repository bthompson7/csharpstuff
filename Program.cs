using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Model model = new Model();
            model.setName("Ben");
            Console.WriteLine(model.getName());

            HttpRequests httpRequests = new HttpRequests();
            httpRequests.makeGetRequest("Ben");

        }

    }


}
