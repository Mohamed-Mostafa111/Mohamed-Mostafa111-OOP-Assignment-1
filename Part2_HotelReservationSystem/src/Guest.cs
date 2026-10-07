using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservation_System
{
	internal class Guest
	{
		public readonly int Id;
		public readonly string Name;
		public readonly string PhoneNumber ;
		private static int IDCounter = 0;
		private readonly  List<Reservations> ReservationOperations= new List<Reservations>();
		public  IReadOnlyList<Reservations> reservations {
			get 
			{
				return ReservationOperations;
			}
		}

		public Guest(string name, string phoneNumber)
		{
			Id = IDCounter++;
			Name = name;
			PhoneNumber = phoneNumber;
		}

	
		public void MakeReservation(int roomId,DateTime StartDate,DateTime EndDate)
		{
			var TimeDuration = EndDate.Date - StartDate.Date;

			if (TimeDuration.TotalDays<=0)
			{
				throw new ArgumentException( "Check-out date must be after check-in date.");	
			}
			var targetRoom = Room.GitRoom(roomId);

			if (targetRoom==null)
			{
				throw new ArgumentException("Room does not exist.");
			}
			if (targetRoom.IsUnderMaintenance)
			{
				throw new InvalidOperationException("This room is currently under maintenance.");
			}

			var bookingStatus = Reservations.CheckDoubleBooked(StartDate, EndDate, targetRoom);
			if (bookingStatus)
			{
				throw new InvalidOperationException("This room is currently Booked.");
			}
			var NewReservation=new Reservations(StartDate, EndDate, targetRoom);
			ReservationOperations.Add(NewReservation);

		}
		public void removeReservation(int roomId)
		{
			foreach(var reservation in SeedingData.Reservations)
			{
				if(reservation.Room.Id == roomId)
				{
					reservation.Cancel();
					reservation.Room.BookingEnd();
					break;
				}
			}
			throw new ArgumentException("Room does not exist.");

		}

	}
}
