using System.Linq;
namespace LINQ_30_exercises

{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new()
            {
            0,1,2,3,3,3,4,5,4,6,1,7,8,1,9
            };
            List<int> large = new()
            {55, 200, 740, 76, 230, 482, 95,80 };


            List<string> weekDays = new()
            { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            List<string> cities = new()
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
            };

            string name = "Kamran";

            //// 1.
            //var even = list.Where(ev => ev % 2 == 0).AsEnumerable();
            //foreach (int i in even)
            //{
            //    Console.WriteLine(i);
            //}

            //// 2.
            //var odd = list.Where(ev => ev % 2 != 0).AsEnumerable();
            //foreach (int i in odd)
            //{
            //    Console.WriteLine(i);
            //}

            //// 3.
            //var squareList = from int num in list
            //                 let square = num * num
            //                 select new { num, square };

            //// 4. 
            //foreach (var square in squareList)
            //{
            //    Console.WriteLine(square);
            //}

            //// 5. 
            //var frequency = list.Where(x => x == 1).ToList().Count;
            //Console.WriteLine(frequency);

            //// 6. 
            //var nameCount = name.Where(x => x == 'a').ToList().Count;
            //Console.WriteLine(nameCount);

            //// 7. 
            //var days = from weekDay in weekDays
            //           select weekDay;
            //foreach (var day in days)
            //{
            //    Console.WriteLine(day);
            //}

            //// 8. 
            //var result = from x in list
            //             group x by x into y
            //             select y;
            //foreach (var arrEle in result)
            //{
            //    Console.WriteLine("number: " + arrEle.Key + "\t Sum: " + arrEle.Sum() + "\t Count: " + arrEle.Count());
            //}

            //// 9. 
            //var specifyCity = cities.Where(x => x.StartsWith('R')).Where(x => x.EndsWith('E')).ToList();
            //foreach (var i in specifyCity)
            //{
            //    Console.WriteLine(i);
            //}

            //// 10. 
            //var large80 = large.Where(l => l > 80).ToList();
            //foreach (var l in large80)
            //{
            //    Console.WriteLine(l);
            //}

            //// 11.
            //list.Sort();
            //list.Reverse();
            //Console.Write("Take on List: ");
            //int take = Convert.ToInt32(Console.ReadLine());
            //foreach (int i in list.Take(take))
            //{
            //    Console.WriteLine(i);
            //}

            ////////// Tasklarin hamsini yazardim, Yoruldugum ucun burda saxladim 😁

        }
    }
}