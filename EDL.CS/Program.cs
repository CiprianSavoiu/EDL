using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDL.CS
{

    class Program
    {
        static void Main(string[] args)
        {
            //var del1 = new WorkPerformedHandler(WorkPerformed1);
            //var del2 = new WorkPerformedHandler(WorkPerformed2);
            //var del3 = new WorkPerformedHandler(WorkPerformed3);

            //del1 += del2 + del3;

            //var finalHours = del1(10, WorkType.GenerateReports);

            var worker = new Worker();
            worker.WorkPerformed += new EventHandler<WorkPerformedEventArgs>(Worker_WorkPerformed);
            worker.WorkCompleted += new EventHandler(Worker_WorkCompleted);
            worker.DoWork(8, WorkType.GenerateReports);


            //Console.WriteLine(finalHours);
            Console.Read();

        }

        static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine("Hours worked: " + e.Hours + " " + e.WorkType);
        }

        static void Worker_WorkCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Worker is done");
        }

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
