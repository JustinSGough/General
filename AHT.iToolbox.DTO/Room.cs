///////////////////////////////////////////////////////////////////////////////
//
//  Copyright © TODO_COPYRIGHT_YEAR, TODO_COPYRIGHT_HOLDER
//
//  File    : Room.cs
//
//  Notes   : 
//
///////////////////////////////////////////////////////////////////////////////

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AHT.uToolBox.DTO
{
    public class Room : INotifyPropertyChanged
    {
        public string Cono    { get; set; }   
        public string Unit    { get; set; }   
        public int RoomNumber { get; set; }
        public string Bed     { get; set; }
        
        public Room(string cono, string unit, int roomNumber, string bed)
        {
            Cono = cono;
            Unit = unit;
            RoomNumber = roomNumber;
            Bed = bed;
        }

        public override string ToString()
        {
            string s = string.Format(
                //"Cono:{0}, Unit{1}, RoomNumber:{2}, Bed:{3}",
                "{0} [{1}, {2}, {3}]",
                Cono, Unit, RoomNumber, Bed);
            return s;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// This method is called by the Set accessor of each property.
        /// The CallerMemberName attribute that is applied to the optional propertyName
        /// parameter causes the property name of the caller to be substituted as an argument.
        /// </summary>
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public override bool Equals(object obj)
        {
            Room other = obj as Room;
            if (other == null) return false;
            return this == other;
        }

        public bool Equals(Room other)
        {
            if (other == null) return false;
            return this == other;
        }

        public override int GetHashCode()
        {
            int hash = 0;
            string hString = Cono + Unit + RoomNumber.ToString() + Bed;
            foreach (char c in hString) hash += (int)c;
            return hash;
        }

        public static bool operator ==(Room a, Room b)
        {
            if (System.Object.ReferenceEquals(a, b)) return true;
            if (((object)a == null) || ((object)b == null)) return false;

            bool isEqual =
                (a.Cono == b.Cono
                && a.Unit == b.Unit
                && a.RoomNumber == b.RoomNumber
                && a.Bed == b.Bed);

            return isEqual;
        }

        public static bool operator !=(Room a, Room b)
        {
            return !(a == b);
        }

        public static bool Compare(Room a, Room b)
        {
            return (a == b);
        }
        
    }

}
