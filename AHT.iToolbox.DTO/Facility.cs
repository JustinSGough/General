using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHT.uToolBox.DTO
{
    public class Facility : DtoBase
    {
        public string Cono
        {
            get { return _cono; }
            set { if (_cono != value) { _cono = value; NotifyPropertyChanged(); } }
        }
        protected string _cono;

        public string Name
        {
            get { return _name; }
            set { if (_name != value) { _name = value; NotifyPropertyChanged(); } }
        }
        protected string _name;

        public bool Active
        {
            get { return _active; }
            set { if (_active != value) { _active = value; NotifyPropertyChanged();} }
        }
        protected bool _active = true;


        public Facility()
        {

        }

        public Facility(string cono, string name, bool active = true)
        {
            _cono = cono;
            _name = name;
            _active = active;
        }
    }
}
