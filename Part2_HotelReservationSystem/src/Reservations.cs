using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservation_System
{
	internal class Reservations
	{
		public readonly int roomid;
		public DateTime CheckInDate{get;  set;}
		public DateTime CheckOutDate {get;  set;}
		public ReservationStatus Status{get;  private set;}
		public Room Room{get; set;}
		public decimal TotalCosts{get; set;}

		public Reservations(DateTime CheckInDate ,DateTime CheckOutDate,Room room)
		{
			this.CheckInDate = CheckInDate;
			this.CheckOutDate = CheckOutDate;
			Room = room;
			Room.BookingStart();
			Status = ReservationStatus.Pending;
			TotalCosts = (int)((CheckOutDate - CheckInDate).TotalDays) * room.NightlyRate;
		}

		public static bool CheckDoubleBooked(DateTime CheckInDate, DateTime CheckOutDate, Room targetRoom)
		{
			foreach (var reservation in SeedingData.Reservations)
			{
				if (reservation.Room.Id == targetRoom.Id &&
					reservation.Status != ReservationStatus.Cancelled &&
					reservation.Status != ReservationStatus.CheckedOut)
				{
					if (CheckInDate < reservation.CheckOutDate &&
						CheckOutDate > reservation.CheckInDate)
					{
						return true;
					}
				}
			}
			return false;
		}

		public void Confirm()
		{
			if (Status != ReservationStatus.Pending)
				throw new InvalidOperationException(
					"Only pending reservations can be confirmed.");

			Status = ReservationStatus.Confirmed;
		}
		public void CheckIn()
		{
			if (Status != ReservationStatus.Confirmed)
				throw new InvalidOperationException(
					"Only confirmed reservations can be checked in.");

			Status = ReservationStatus.CheckedIn;
		}
		public void CheckOut()
		{
			if (Status != ReservationStatus.CheckedIn)
				throw new InvalidOperationException(
					"Only checked-in reservations can be checked out.");

			Status = ReservationStatus.CheckedOut;
		}
		public void Cancel()
		{
			if (Status != ReservationStatus.Pending &&
				Status != ReservationStatus.Confirmed)
			{
				throw new InvalidOperationException(
					"Only pending or confirmed reservations can be cancelled.");
			}

			Status = ReservationStatus.Cancelled;
		}

		public override string ToString()
		{
			return $"Duration: from {CheckInDate.ToString()} to {CheckOutDate.ToString()}\n" +
				   $"Room Id :{Room.Id}\n" +
				   $"Room Type:{Room.RoomType}\n" +
				   $"Nightly Rate:{Room.NightlyRate} \n	" +
				   $"Total Costs:{TotalCosts}\n" +
				   $"<----------------------------------------------------------->\n";


		}
	}
}
