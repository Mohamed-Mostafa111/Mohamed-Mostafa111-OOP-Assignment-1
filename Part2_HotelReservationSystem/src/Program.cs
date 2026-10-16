namespace Hotel_Reservation_System
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Guest guest = new Guest("Mohamed Hamed", "01012345678");

			bool exit = false;

			while (!exit)
			{
				Console.Clear();

				Console.WriteLine("===== Hotel Reservation System =====");
				Console.WriteLine("1. Show Available Rooms");
				Console.WriteLine("2. Make Reservation");
				Console.WriteLine("3. Show My Reservations");
				Console.WriteLine("4. Exit");
				Console.Write("Choose: ");

				string choice = Console.ReadLine();

				switch (choice)
				{
					case "1":
						ShowRooms();
						break;

					case "2":
						Console.Write("Enter the Room Id: ");
						int roomid = int.Parse(Console.ReadLine());
						
						Console.Write("Check-in (yyyy-MM-dd): ");
						string starttime=Console.ReadLine();
						DateTime.TryParse(starttime, out DateTime Checkin);

						Console.Write("Check-out (yyyy-MM-dd): ");
						string EndTime = Console.ReadLine();
						DateTime.TryParse(EndTime, out DateTime CheckOut);
						MakeReservation(SeedingData.Guests[0], roomid,Checkin,CheckOut);

						break;

					case "3":
						ShowReservations(SeedingData.Guests[0]);
						break;

					case "4":
						exit = true;
						break;

					default:
						Console.WriteLine("Invalid choice.");
						break;
				}

				if (!exit)
				{
					Console.WriteLine("\nPress any key to continue...");
					Console.ReadKey();
				}
			}
		}

		public static void ShowRooms()
		{
			foreach (var room in SeedingData.Rooms)
			{
				if (!room.IsBooked&&!room.IsUnderMaintenance)
				{
					Console.WriteLine(room);
				}
			}
		}
		public static void MakeReservation(Guest guest,int roomid,DateTime starttime,DateTime EndTime)
		{
			guest.MakeReservation(roomid, starttime, EndTime);
		}
		public static void ShowReservations(Guest guest)
		{
			foreach(var reservation in guest.reservations)
			{
				Console.WriteLine(reservation);
			}
		}

	}
}
