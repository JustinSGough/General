///////////////////////////////////////////////////////////////////////////////
//
//  Copyright © 2017, American Healthtech and CPSI
//
//  File    : Resident.cs
//
//  Notes   : Data transfer class for residents.
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.ComponentModel;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace AHT.uToolBox.DTO
{
    public class Resident : DtoBase, INotifyPropertyChanged
    {
        public int       RowNum                   { get; set; }
        public string    Cono                     { get; set; }
        public int       Resno                    { get; set; }
        public string    NameFirst                { get; set; }
        public string    NameLast                 { get; set; }
        public string    NameMi                   { get; set; }
        public string    NameTitle                { get; set; }
        public string    Addr1                    { get; set; }
        public string    Addr2                    { get; set; }
        public string    City                     { get; set; }
        public string    State                    { get; set; }
        public string    Zip                      { get; set; }
        public string    Phone                    { get; set; }
        public string    Sex                      { get; set; }
        public string    Marital                  { get; set; }
        public string    MaritalStatusDescription { get; set; }
        public int?      Race                     { get; set; }
        public string    RaceDescription          { get; set; }
        public string    Ssn                      { get; set; }
        public DateTime? BirthDate                { get; set; }
        public string    McrId                    { get; set; }
        public string    McdId                    { get; set; }
        public string    Mrno                     { get; set; }
        public string    Occupation               { get; set; }
        public string    County                   { get; set; }
        public string    Birthplace               { get; set; }
        public int?      Religion                 { get; set; }
        public string    Religiondescription      { get; set; }
        public bool?     MilitaryService          { get; set; }
        public bool?     UsCitizen                { get; set; }
        public string    Language                 { get; set; }

        public Resident() { }

        public Resident(Resident r)
        {
            RowNum                   = r.RowNum                  ;
            Cono                     = r.Cono                    ;
            Resno                    = r.Resno                   ;
            NameFirst                = r.NameFirst               ;
            NameLast                 = r.NameLast                ;
            NameMi                   = r.NameMi                  ;
            NameTitle                = r.NameTitle               ;
            Addr1                    = r.Addr1                   ;
            Addr2                    = r.Addr2                   ;
            City                     = r.City                    ;
            State                    = r.State                   ;
            Zip                      = r.Zip                     ;
            Phone                    = r.Phone                   ;
            Sex                      = r.Sex                     ;
            Marital                  = r.Marital                 ;
            MaritalStatusDescription = r.MaritalStatusDescription;
            Race                     = r.Race                    ;
            RaceDescription          = r.RaceDescription         ;
            Ssn                      = r.Ssn                     ;
            BirthDate                = r.BirthDate               ;
            McrId                    = r.McrId                   ;
            McdId                    = r.McdId                   ;
            Mrno                     = r.Mrno                    ;
            Occupation               = r.Occupation              ;
            County                   = r.County                  ;
            Birthplace               = r.Birthplace              ;
            Religion                 = r.Religion                ;
            Religiondescription      = r.Religiondescription     ;
            MilitaryService          = r.MilitaryService         ;
            UsCitizen                = r.UsCitizen               ;
            Language                 = r.Language                ;
        }                                  
    }                       
}                      
                                  
                                  
                                  
                                  
                                  
                                  
                                  
                                  
                                  
                                  
                                  
                                  
                                  
                                  
                                  
                                  
                                  
                                  
                                  
                                  
                                  
                                  
                                  
                                  
                                  























