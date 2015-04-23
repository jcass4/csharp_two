using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRentalCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            //USER CLASS TESTER
            User newUser = new User("800111555", "John", "Cassesse", "585-395-2146", "jcass4@brockport.edu", "Student", "Nice guy");
            newUser.insert();
            Console.WriteLine();
            User John = new User();
            John.populate(9);
            John.Notes = "Good guy";
            John.update();
            John.delete();
            Console.WriteLine();

            //RENTAL CLASS TESTER
            Rental newRental = new Rental(3, 2, "2015-04-23", "13:23:04", "2015-05-23", "13:23:04", "", "", 1, 0);
            newRental.insert();
            Console.WriteLine();
            Rental rent = new Rental();
            rent.populate(3);
            rent.DateReturned = DateTime.Now.ToString("yyyy-MM-dd");
            rent.TimeReturned = DateTime.Now.ToString("hh:mm:ss");
            rent.CheckInWorkerID = 1;
            rent.update();
            rent.delete();
            Console.WriteLine();

            //VEHICLE CLASS TESTER
            Vehicle newVehicle = new Vehicle("RoadMaster", "A1429", "SM102", "Blue", "Mens Bike", "Union", "Horrible", "", "Rented", "2015-04-01");
            newVehicle.insert();
            Console.WriteLine();
            Vehicle veh = new Vehicle();
            veh.populate(3);
            veh.Notes = "This is a test";
            veh.DateStatusUpdated = DateTime.Now.ToString("yyyy-MM-dd");
            veh.update();
            veh.delete();
            Console.WriteLine();

            //WORKER CLASS TESTER
            Worker newWorker = new Worker("800561299", "John", "Cassese", "1231231234", "jcass4@brockport.edu", "Student", "2015-01-01", "jcass", "", "Active", "2015-01-01");
            newWorker.insert();
            Console.WriteLine();
            Worker work = new Worker();
            work.populate(6);
            work.Notes = "This is a test";
            work.Status = "Disabled";
            work.DateStatusUpdated = DateTime.Now.ToString("yyyy-MM-dd");
            work.update();
            work.delete();
            Console.WriteLine();
          
            //VEHICLE COLLECTION TESTER
            Console.WriteLine("Good and Active Vehicles:");
            VehicleCollection availBikes = new VehicleCollection();
            availBikes.populateWithGoodAndAvailableBikes();
            Console.WriteLine(availBikes);
            Console.WriteLine();
             
            //RENTAL COLLECTION TESTER
            Console.WriteLine("Rental ID(s) that are out:");
            RentalCollection rentalsOut = new RentalCollection();
            rentalsOut.populateWithRentedOutBikes();
            Console.WriteLine(rentalsOut);
            Console.WriteLine();
        }
    }
}