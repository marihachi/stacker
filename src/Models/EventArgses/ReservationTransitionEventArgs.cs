using Stacker.Models.Enums;
using System;

namespace Stacker.Models.EventArgses
{
	public class ReservationTransitionEventArgs : EventArgs
	{
		public ReservationTransitionEventArgs(ReservationTransitionType type, AgTimeReservation reservation)
		{
			Type = type;
			Reservation = reservation;
		}

		public ReservationTransitionType Type { get; set; }

		public AgTimeReservation Reservation { get; set; }
	}
}
