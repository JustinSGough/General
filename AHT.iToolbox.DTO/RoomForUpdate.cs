using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AHT.uToolBox.DTO
{
    public class RoomForUpdate : Room, INotifyPropertyChanged
    {
        public string NewUnit
        {   get { return _newUnit; }
            set
            {
                string newValue = value.Trim(' ').ToUpper();
                if (_newUnit != newValue)
                {
                    _newUnit = newValue; NotifyPropertyChangedAndValues();
                }
            }
        } string _newUnit;

        public int NewRoomNumber 
        {   get { return _newRoomNumber; }
            set { if (_newRoomNumber != value) { _newRoomNumber = value; NotifyPropertyChangedAndValues(); } }
        } int _newRoomNumber;

        public string NewBed
        {   get { return _newBed; }
            set { if (_newBed != value.ToUpper()) { _newBed = value.ToUpper(); NotifyPropertyChangedAndValues();} }
        } string _newBed;

        public RoomForUpdate(
            string cono,
            string unit, int roomNumber, string bed,
            string newUnit, int newRoomNumber, string newBed)
            : base(cono, unit, roomNumber, bed)
        {
            NewUnit = newUnit.ToUpper();
            NewRoomNumber = newRoomNumber;
            NewBed = newBed.ToUpper();
        }

        public const string ValuesChangedTag = "ValuesChanged";

        public bool ValuesChanged
        {
            get
            {
                bool valuesChanged = false
                    || NewUnit != Unit
                    || NewRoomNumber != RoomNumber
                    || NewBed != Bed;

                return valuesChanged;
            }
        }

        public override string ToString()
        {
            string s =
                base.ToString() +
                string.Format(
                    //", New Unit{0}, New RoomNumber:{1}, New Bed:{2}",
                    " ==> [{0}, {1}, {2}]",
                    NewUnit, NewRoomNumber, NewBed);

            return s;
        }

        protected void NotifyPropertyChangedAndValues([CallerMemberName] string propertyName = "")
        {
            NotifyPropertyChanged(propertyName);
            NotifyPropertyChanged(ValuesChangedTag);
        }

        public override int GetHashCode()
        {
            int baseHash = base.GetHashCode();
            var justNew = new Room(Cono, NewUnit, NewRoomNumber, NewBed);
            return baseHash + justNew.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            RoomForUpdate other = obj as RoomForUpdate;
            if (other == null) return false;
            return this == other;
        }

        public bool Equals(RoomForUpdate other)
        {
            if (other == null) return false;
            return this == other;
        }

        public static bool operator ==(RoomForUpdate a, RoomForUpdate b)
        {
            if (System.Object.ReferenceEquals(a, b)) return true;
            if (((object)a == null) || ((object)b == null)) return false;

            bool isEqual =
                Room.Compare(a, b)
                && a.NewUnit == b.NewUnit
                && a.NewRoomNumber == b.NewRoomNumber
                && a.NewBed == b.NewBed;

            return isEqual;
        }

        public static bool operator !=(RoomForUpdate a, RoomForUpdate b)
        {
            return !(a == b);
        }
   
    }
}
