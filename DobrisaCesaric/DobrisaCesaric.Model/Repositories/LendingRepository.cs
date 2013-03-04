using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DobrisaCesaric.Utility;

namespace DobrisaCesaric.DomainModel.Repositories
{
    public class LendingRepository :Subject
    {
        private static LendingRepository _instance = null;
        List<Lending> _listLending = new List<Lending>();

        public static LendingRepository GetInstance()
        {
            if (_instance == null)
                _instance = new LendingRepository();

            return _instance;
        }

        public int Count()
        {
            return _listLending.Count();
        }

        public void AddLending(Lending inReservation)
        {
            _listLending.Add(inReservation);
            notifyObservers();
        }

        public void RemoveLending(int lendingIndex)
        {
            Lending lending = getLendingByIndex(lendingIndex);
            _listLending.Remove(lending);
            notifyObservers();
        }

        public Lending getLendingByIndex(int index)
        {
            if (0 <= index && index < Count())
                return _listLending[index];
            else
                throw new Exception();
        }
    }
}
