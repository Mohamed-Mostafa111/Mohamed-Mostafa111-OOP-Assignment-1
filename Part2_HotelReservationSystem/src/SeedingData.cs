using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservation_System
{
	internal static class SeedingData
	{
		public static List<Guest> Guests = new List<Guest>
	    {
			new Guest( "Ahmed Ali", "01012345678"),
			new Guest( "Mohamed Hassan", "01023456789"),
			new Guest( "Omar Mahmoud", "01034567890"),
			new Guest( "Youssef Ibrahim", "01045678901"),
			new Guest( "Mostafa Khaled", "01056789012"),
			new Guest( "Karim Adel", "01067890123"),
			new Guest( "Hassan Tarek", "01078901234"),
			new Guest( "Mahmoud Samir", "01089012345"),
			new Guest( "Amr Nabil", "01090123456"),
			new Guest( "Tarek Wael", "01101234567")
	    };

		public static List<Room> Rooms = new List<Room>
	    {
			new Room( RoomType.Single, 1000),
			new Room( RoomType.Single, 1100),
			new Room( RoomType.Single, 1200),

			new Room( RoomType.Double, 1800),
			new Room( RoomType.Double, 2000),
			new Room( RoomType.Double, 2200),
			new Room( RoomType.Suite, 3500),
			new Room( RoomType.Suite, 4000),
			new Room( RoomType.Single, 1500),
			new Room( RoomType.Single, 1200),
			new Room( RoomType.Double, 2000),
			new Room( RoomType.Suite, 3000),

			new Room( RoomType.Suite, 5000)

	    };
		public static List<Reservations> Reservations = new List<Reservations>
		{
			new Reservations(
				new DateTime(2026, 10, 1),
				new DateTime(2026, 10, 5),
				Rooms[0]
			),

			new Reservations(
				new DateTime(2026, 10, 3),
				new DateTime(2026, 10, 7),
				Rooms[1]
			),

			new Reservations(
				new DateTime(2026, 10, 5),
				new DateTime(2026, 10, 10),
				Rooms[3]
			),

			new Reservations(
				new DateTime(2026, 10, 10),
				new DateTime(2026, 10, 15),
				Rooms[4]
			),

			new Reservations(
				new DateTime(2026, 10, 15),
				new DateTime(2026, 10, 20),
				Rooms[6]
			),

			new Reservations(
				new DateTime(2026, 10, 20),
				new DateTime(2026, 10, 25),
				Rooms[7]
			),

			new Reservations(
				new DateTime(2026, 10, 25),
				new DateTime(2026, 10, 30),
				Rooms[8]
			),

			new Reservations(
				new DateTime(2026, 11, 1),
				new DateTime(2026, 11, 5),
				Rooms[2]
			),

			new Reservations(
				new DateTime(2026, 11, 5),
				new DateTime(2026, 11, 10),
				Rooms[5]
			),

			new Reservations(
				new DateTime(2026, 11, 10),
				new DateTime(2026, 11, 15),
				Rooms[9]
			)
		};
	}
}