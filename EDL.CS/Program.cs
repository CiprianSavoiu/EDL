using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EDL.CS
{

    public delegate int BizRuleDelegate(int x, int y);


    class Program
    {
        static void Main(string[] args)
        {

            var custs = new List<Customer>
            {
                new Customer
                {
                    City = "Phoenix",
                    FirstName = "Jon",
                    LastName = "Doe",
                    Id = 1
                },
                new Customer
                {
                    City = "Phoenix",
                    FirstName = "Jane",
                    LastName = "Doe",
                    Id = 500
                },
                new Customer
                {
                    City = "Seatle",
                    FirstName = "Suki",
                    LastName = "Pizzoro",
                    Id = 3
                },
                new Customer
                {
                    City = "New York City",
                    FirstName = "Michelle",
                    LastName = "SMith",
                    Id = 4
                }
            };


            var phxCust = custs
                .Where(c => c.City == "Phoenix" && c.Id <100)
                .OrderBy(c => c.FirstName);

            foreach (var cust in phxCust)
            {
                Console.WriteLine(cust.FirstName);
            }


            var data = new ProcessData();

            BizRuleDelegate addDelegate = (x, y) => x + y;
            BizRuleDelegate multiplyDelegate = (x, y) => x * y;

            data.Process(2, 3, multiplyDelegate);

            Func<int, int, int> funcAddDel = (x, y) => x + y;
            Func<int, int, int> funcMultiplyDel = (x, y) => x * y;

            data.ProcessFunct(2, 5, funcAddDel);

            Action<int, int> myAddAction = (x, y) => Console.WriteLine(x + y);
            Action<int, int> myMultiplyAction = (x, y) => Console.WriteLine(x * y);

            data.ProcessAction(2, 3, myAddAction);


            //var del1 = new WorkPerformedHandler(WorkPerformed1);
            //var del2 = new WorkPerformedHandler(WorkPerformed2);
            //var del3 = new WorkPerformedHandler(WorkPerformed3);

            //del1 += del2 + del3;

            //var finalHours = del1(10, WorkType.GenerateReports);

            var worker = new Worker();
            worker.WorkPerformed += (s, e) =>
            {
                Console.WriteLine("Hours worked: " + e.Hours + " " + e.WorkType);
                Console.WriteLine("SSS");
            };
            worker.WorkCompleted += (s, e) => Console.WriteLine("Worker is done");
            
            worker.DoWork(8, WorkType.GenerateReports);


            //Console.WriteLine(finalHours);
            Console.Read();

        }

        //private static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        //{
        //    Console.WriteLine("Hours worked: " + e.Hours + " " + e.WorkType);
        //}

        //static void Worker_WorkCompleted(object sender, EventArgs e)
        //{
        //    Console.WriteLine("Worker is done");
        //}

        //static void DoWork(WorkPerformedHandler del)
        //{
        //    del(5, WorkType.GotoMeetings);
        //}

        //static int WorkPerformed1(int hours, WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed 1 called" + hours);
        //    return hours + 1;
        //}

        //static int WorkPerformed2(int hours, WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed 2 called"+ hours);
        //    return hours + 2;
        //}

        //static int WorkPerformed3(int hours, WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed 2 called" + hours);
        //    return hours + 3;
        //}
    }

    public enum WorkType
    {
        GotoMeetings,
        Golf,
        GenerateReports
    }
}
