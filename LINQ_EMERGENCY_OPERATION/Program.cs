using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_EMERGENCY_OPERATION
{
    class Program
    {
        static void Main(string[] args)
        {
            #region IEnumerable to array
            IEnumerable<int> item = Enumerable.Range(1, 300);
            Console.WriteLine($"start type - {item}");
            int[] en = item.ToArray();
            Console.WriteLine($"Result type - {en}");
            int i = 0;
            foreach (var itm in en)
            {
                if (i == 20)
                { Console.WriteLine(); i++; }
                Console.Write(itm + " ");

            }
            #endregion


            #region IEnumerable to List
            //string[] cars = { "Alfa Romeo", "Aston Martin", "Audi", "Nissan", "Chevrolet",  "Chrysler", "Dodge", "BMW",
            //                "Ferrari",  "Bentley", "Ford", "Lexus", "Mercedes", "Toyota", "Volvo", "Subaru", "Жигули :)"};
            //var list = cars.ToList().Where(a => a.StartsWith("A"));
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region IEnumerable to Dictionary
            //  Dictionary<int, Employers> eDictionary = Employers.getEmployers().ToDictionary(k => k.Id);
            //Employers e = eDictionary[2];
            //Console.WriteLine($"Работник под номером 2 - {e.Name}  {e.Family}  {e.Age}"); 
            //Dictionary<string, Employers> eDictionary2 = Employers.getEmployers().ToDictionary(k => k.Id, new KeyEqu());
            //Employers emp = eDictionary2["2"];
            //Console.WriteLine($"Работник под номером 2 - {emp.Name}  {emp.Family}  {emp.Age}");
            //emp = eDictionary2["0002"];
            //Console.WriteLine($"Работник под номером 0002 - {emp.Name}  {emp.Family}  {emp.Age}");
            //var Dict = Employers.getEmployers().ToDictionary(KID => KID.Id, s => string.Format($"Name {s.Name}, Family - {s.Family}"), new KeyEqu());
            //Console.WriteLine(Dict["3"]);
            #endregion

            #region lookUP
            //ILookup<string, string> look = Employers.getEmployers().ToLookup(bd => bd.Age, st => string.Format($"Name - {st.Name}, Family - {st.Family}"), new KeyEqu());
            //var str = look["66"];
            //foreach (var item in str)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region SequenceEquals
            //string[] arr = { "5", "91", "11", "8", "34" };
            //string[] arr2 = { "005", "00091", "0011", "008", "000034" };
            //var se = arr.SequenceEqual(arr2, new KeyEqu());
            //Console.WriteLine(se);
            #endregion

            #region First FirstOrDefault Last LastOrDefault
            //Employers[] emp = Employers.getEmployers();

            //try
            //{
            //    var em = emp.First(e => e.Age.StartsWith("1000"));

            //    Console.WriteLine($"Id = {em.Id}, Name = {em.Name}, Family = {em.Family}, Age = {em.Age}");
            //}
            //catch (Exception ex) 
            //{

            //    Console.WriteLine(ex.Message);
            //}
            //var lod = emp.LastOrDefault(e => e.Family.StartsWith("P"));
            //Console.WriteLine($"Id = {lod.Id}, Name = {lod.Name}, Family = {lod.Family}, Age = {lod.Age}");
            #endregion

            #region ElementAt ElementAtOrDefault
            //string[] arr = { "5", "91", "11", "8", "34" };
            //var Elementat = arr.ElementAt(3);
            //Console.WriteLine(Elementat);
            //var Elementatordefault = arr.ElementAtOrDefault(-100);
            //Console.WriteLine(Elementatordefault == default(string) ? "Error" : Elementatordefault);

            //bool contains = arr.Contains("00091", new KeyEqu());
            //Console.WriteLine(contains);
            //any, all



            #endregion

            #region Count LongCount Sum
            //            int[] ct = { 10, 32, 10, 9, 19, 8, 341 };
            //var count = ct.Count(t=>t < 40);
            //Console.WriteLine(count + " |" + count.GetType().ToString());
            //longcount
            //var sum = ct.Sum(cts => (cts<10));
            //Console.WriteLine($"Sum all elements = {sum}");

            #endregion

            #region Min Max Avg Agrigate
            //int[] ct = { 10, 32, 10, 9, 19, 8, 341 };
            //Employer[] empl = Employer.getEmployer();
            //var min = ct.Min();
            //var max = ct.Max(c=> c< 300);

            //Console.WriteLine(min + " " + max);
            //var maxEmp = empl.Max(ss => ss.Family);
            //Console.WriteLine(maxEmp);

            //var avg = empl.Average(name => name.Name.Length);
            //Console.WriteLine(avg);

            //var agr = ct.Aggregate((a, b) => a + b);

            //Console.WriteLine(agr);

            #endregion
            Console.ReadKey();


        }
    }
}
