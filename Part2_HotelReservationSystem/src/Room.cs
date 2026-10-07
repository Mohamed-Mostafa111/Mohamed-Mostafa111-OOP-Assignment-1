using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservation_System
{
	internal class Room
	{
		public readonly int Id;
		public readonly RoomType RoomType;
		public decimal NightlyRate { get; private set; }
		public bool IsUnderMaintenance { get; private set; }
		private  static int IDCounter = 0;
		public bool IsBooked { get; private set;}

		public Room( RoomType roomType, decimal nightlyRate, bool isUnderMaintenance=false,bool IsBooked=false)
		{
			Id = IDCounter++;
			RoomType = roomType;
			NightlyRate = nightlyRate;
			IsUnderMaintenance = isUnderMaintenance;
			this.IsBooked = IsBooked;
		}

		public void AddRoom(Room room)
		{
			SeedingData.Rooms.Add(room);
		}
		public static Room GitRoom(int Id)
		{
			foreach (var room in SeedingData.Rooms)
			{
				if (room.Id==Id)
				{
					return room;
				}
			}
			return null;
		}

		public void MentainanceStart(Room room)
		{
			IsUnderMaintenance=true;
		}
		public void MentainanceEnd(Room room)
		{
			IsUnderMaintenance=true;
		}
		public void BookingStart()
		{
			IsBooked = true;
		}
		public void BookingEnd()
		{
			IsBooked = true;
		}

		public override string ToString()
		{
			return $"<-- {Id} " +
				  $"{RoomType.ToString()} " +
				  $"{NightlyRate} -->";
		}

	}
}
