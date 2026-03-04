using CinemaRefactored;
namespace c__OOP_03

{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region PART 01 

            #region Q1

            #region A

            // compoaition : when a class has a reference to another class as a field, and the lifecycle of the contained class is managed by the containing class.
            // In composition, the contained class cannot exist independently of the containing class.
            // If the containing class is destroyed, the contained class is also destroyed.
            //جزء لا يتجزا من الجامعة لو الجامعة اتفلت القسم بينتهى
            #endregion

            #region B

            //association : when a class has a reference to another class, but the lifecycle of the associated class is not managed by the containing class.
            // الساءق مش معاة ملكية العربية الى بيسوقها وكل واح مستقل عن التانى
            #endregion

            #region C

            // inheritance : 
            // الكلب يرث صفات الحيوان


            #endregion

            #region D
            // aggregation : when a class has a reference to another class,
            // but the lifecycle of the contained class is not managed by the containing class.

            //الفريق الكورة بيحتوى على لاعيبة لكن لو الفريق اتفلت اللعيبة مش هتتأثر ويقر ينضم لفريق تانى

            #endregion

            #region E

            // Dependency : when a class depends on another class for its functionality, but does not have a reference to it as a field.

            // استخدام موثت وقت معين في برنامجك عشان تنفذ وظيفة معينة بس مش بتحتوى على الكلاس ده كفيلد

            #endregion

            #endregion

            #region Q2

            #region A

            // protecded feild : a field that can be accessed by the class itself and its derived classes, but not by other classes.


            #endregion

            #region B

            //protecded internal feild : a field that can be accessed by the class itself, its derived classes, and other classes in the same assembly,
            //but not by classes in other assemblies.

            // private protected feild : a field that can be accessed by the class itself and its derived classes,
            // but not by other classes, including those in the same assembly.


            #endregion

            #region C

            // *  class : بيمنع الوراثة من الكلاس ده

            // *  method : بيمنع الوراثة من الميثود ده


            #endregion

            #region D

            // yes can make new from sealed class but can't inherit from it

            #endregion

            #endregion


            #endregion

            #region PART 02

            Cinema myCinema = new Cinema(" nile cinema ");
            myCinema.startcinema();

        Ticket ticket1 = new StandardTicket("The Batman", 100, "A1");
        Ticket ticket2 = new VIPTicket("The Batman", 150, "Lounge Access");
            Ticket ticket3 = new ImaxTicket("The Batman", 200);

        myCinema.AddTicket(ticket1);
        myCinema.AddTicket(ticket2);
                myCinema.AddTicket(ticket3);    
        myCinema.PrintTickets();

        Console.WriteLine("Total Tickets: " + Ticket.GetTotalTickets());
         myCinema.stopcinema();



        #endregion
    }
    }
}

