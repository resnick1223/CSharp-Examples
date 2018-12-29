using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            AddData("acs303-example");
        }

        private async static Task AddData(string project)
        {
            FirestoreDb db = FirestoreDb.Create(project);

            Dictionary<string, object> city = new Dictionary<string, object>
{
    { "Name", "Tokyo" },
    { "Country", "Japan" }
};
            DocumentReference addedDocRef = await db.Collection("cities").AddAsync(city);
            Console.WriteLine("Added document with ID: {0}.", addedDocRef.Id);
        }
    }
}