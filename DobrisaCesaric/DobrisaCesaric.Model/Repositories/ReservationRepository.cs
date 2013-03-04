using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DobrisaCesaric.Utility;

namespace DobrisaCesaric.DomainModel.Repositories
{
    public class ReservationRepository : Subject
    {
        private static ReservationRepository _instance = null;
        List<Reservation> _listReservation = new List<Reservation>();

        public static ReservationRepository GetInstance()
        {
            if (_instance == null)
                _instance = new ReservationRepository();

            return _instance;
        }

        public int Count
        {
            get { return _listReservation.Count; }
        }

        public void AddReservation(Reservation inReservation)
        {
            _listReservation.Add(inReservation);
        }

        public Reservation getReservationByIndex(int index)
        {
            if (0 <= index && index < Count)
                return _listReservation[index];
            else
                throw new Exception();
        }
    }
}
