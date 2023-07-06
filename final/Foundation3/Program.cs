using System;

class Program
{
   static void Main(string[] args)
   {
      Address lectureAddress = new Address("1234 1st St", "Nampa", "Idaho");
      LectureEvent lecture = new LectureEvent("John Smith", 100, "Python Data Structures", "An introduction to common data structures in Python", "May 2, 2023", "10:30 A.M.", lectureAddress);

      Console.WriteLine("\nLecture Details: ");
      Console.WriteLine("\nStandard: ");
      Console.WriteLine(lecture.StandardDetails());
      Console.WriteLine("\nFull: ");
      Console.WriteLine(lecture.FullDetails());
      Console.WriteLine("\nShort: ");
      Console.WriteLine(lecture.ShortDescripton());

      Address receptionAddress = new Address("528 W State St", "Boise", "Idaho");
      ReceptionEvent reception = new ReceptionEvent("bookrelease@gmail.com", "Book Release", "Reception to celebrate the release of a the new book", "June 23, 2023", "7:00 P.M.", receptionAddress);
      Console.WriteLine("\nReception Details: ");
      Console.WriteLine("\nStandard: ");
      Console.WriteLine(reception.StandardDetails());
      Console.WriteLine("\nFull: ");
      Console.WriteLine(reception.FullDetails());
      Console.WriteLine("\nShort: ");
      Console.WriteLine(reception.ShortDescripton());

      Address outdooraddress = new Address("8888 N Lake Lowell Ave", "Nampa", "Idaho");
      OutdoorEvent outdoor = new OutdoorEvent("Overcast", "Nichols Family Reunion", "Join us for the Nichols family reunion", "July 22, 2023", "10:00 A.M.", outdooraddress);
      Console.WriteLine("\nOutdoor Details: ");
      Console.WriteLine("\nStandard: ");
      Console.WriteLine(outdoor.StandardDetails());
      Console.WriteLine("\nFull: ");
      Console.WriteLine(outdoor.FullDetails());
      Console.WriteLine("\nShort: ");
      Console.WriteLine(outdoor.ShortDescripton());
   }
}