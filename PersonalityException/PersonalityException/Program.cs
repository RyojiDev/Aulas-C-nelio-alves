using System;
using PersonalityException.Entities;
using PersonalityException.Entities.Exceptions;


namespace PersonalityException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Console.WriteLine();

                Reservation reservation = new Reservation(number, checkin, checkout);
                Console.Write("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkin, checkout);
                Console.Write("Reservation: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("error in resevartion " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }catch(Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }


            }
    }
}




