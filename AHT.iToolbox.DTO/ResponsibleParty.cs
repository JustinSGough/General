///////////////////////////////////////////////////////////////////////////////
//
//  Copyright © 2017, American Healthtech and CPSI
//
//  File    : ResponsibleParty.cs
//
//  Notes   : Data transfer class for responsible parties.
//
///////////////////////////////////////////////////////////////////////////////

using AHT.uToolBox.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace AHT.uToolBox.DTO
{
    /// <summary>
    /// Data transfer class for responsible parties.
    /// </summary>
    public class ResponsibleParty : DtoBase, INotifyPropertyChanged
    {
        public int RowNum { get; set; }

        public string Cono            { get; set; }
        public int    Resno           { get; set; }
        public short  RpInd           { get; set; }
        public string NameLast        { get; set; }
        public string NameFirst       { get; set; }
        public string NameMi          { get; set; }
        public string NameTitle       { get; set; }
        public string Addr1           { get; set; }
        public string Addr2           { get; set; }
        public string City            { get; set; }
        public string State           { get; set; }
        public string Zip             { get; set; }
        public string PhoneDay        { get; set; }
        public string PhoneEve        { get; set; }
        public string PhoneFax        { get; set; }
        public string Email           { get; set; }
        public string Email2          { get; set; }
        public string BestTime        { get; set; }
        public int?   Relationship    { get; set; }
        public string Priority        { get; set; }
        public string Note            { get; set; }
        public bool?  CpMeeting       { get; set; }
        public bool?  StmtCopy        { get; set; }
        public bool?  PowerAttny      { get; set; }
        public bool?  HealthCareProxy { get; set; }
        public Guid   Uniqueid        { get; set; }
        public string PhoneCell       { get; set; }
        public bool?  AllowCcEmail    { get; set; }
        public bool?  TfStmtCopy      { get; set; }

   
        static ResponsibleParty()
        {
        }

        public ResponsibleParty() { }

        public ResponsibleParty(ResponsibleParty r)
        {
            RowNum          = r.RowNum;
            Cono            = r.Cono;
            Resno           = r.Resno;
            RpInd           = r.RpInd;
            NameLast        = r.NameLast;
            NameFirst       = r.NameFirst;
            NameMi          = r.NameMi;
            NameTitle       = r.NameTitle;
            Addr1           = r.Addr1;
            Addr2           = r.Addr2;
            City            = r.City;
            State           = r.State;
            Zip             = r.Zip;
            PhoneDay        = r.PhoneDay;
            PhoneEve        = r.PhoneEve;
            PhoneFax        = r.PhoneFax;
            Email           = r.Email;
            Email2          = r.Email2;
            BestTime        = r.BestTime;
            Relationship    = r.Relationship;
            Priority        = r.Priority;
            Note            = r.Note;
            CpMeeting       = r.CpMeeting;
            StmtCopy        = r.StmtCopy;
            PowerAttny      = r.PowerAttny;
            HealthCareProxy = r.HealthCareProxy;
            Uniqueid        = r.Uniqueid;
            PhoneCell       = r.PhoneCell;
            AllowCcEmail    = r.AllowCcEmail;
            TfStmtCopy      = r.TfStmtCopy;
        }
    }
}
