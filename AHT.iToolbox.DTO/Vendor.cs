///////////////////////////////////////////////////////////////////////////////
//
//  Copyright © 2017, CPSI
//
//  File    : Vendor.cs
//
//  Notes   : DTO for vendors.
//
///////////////////////////////////////////////////////////////////////////////

using AHT.uToolBox.Utility;
using System.Collections.Generic;
using System;

namespace AHT.uToolBox.DTO
{
    public class Vendor : DtoBase
    {
        public enum Col
        {
            Active          ,
            dtLastUpdate_dt ,
            i1099_typ       ,
            iBalance_typ    ,
            iCritical_fl    ,
            iPayTo_fl       ,
            iTaxID_typ      ,
            mBalanceDue_amt ,
            mCreditAvail_amt,
            mCreditLimit_amt,
            mCreditMemo_amt ,
            mFedWH_amt      ,
            mFinChg_amt     ,
            mMinPayment_amt ,
            mOverdue_amt    ,
            sAccount_cd     ,
            sAddress1       ,
            sAddress2       ,
            sCity           ,
            sComment        ,
            sCono_cd        ,
            sContact_nm     ,
            sContactPhone   ,
            sDBA_nm         ,
            sDiscount_acct  ,
            sEmailAddress   ,
            sExpense_acct   ,
            sFax            ,
            sLastUpdate_id  ,
            sPayTo_cd       ,
            sPhone          ,
            sPhoneExt       ,
            sPrice_cd       ,
            sReseller_num   ,
            sSortKey        ,
            sSortKeyHidden  ,
            sState          ,
            sTax_cd         ,
            sTaxID          ,
            sTerms_cd       ,
            sVendor_cd      ,
            sVendor_nm      ,
            sWebAddress     ,
            sZipCode        ,
            uniqueid        ,
            ytd_1099_vendor ,
        }

        public bool?     Active          { get { return _active          ;} set { if (this[Col.Active          ].Ok(value)) _active           = value;}} bool?     _active               ;
        public DateTime? dtLastUpdate_dt { get { return _dtLastUpdate_dt ;} set { if (this[Col.dtLastUpdate_dt ].Ok(value)) _dtLastUpdate_dt  = value;}} DateTime? _dtLastUpdate_dt      ;
        public int?      i1099_typ       { get { return _i1099_typ       ;} set { if (this[Col.i1099_typ       ].Ok(value)) _i1099_typ        = value;}} int?     _i1099_typ             ;
        public int?      iBalance_typ    { get { return _iBalance_typ    ;} set { if (this[Col.iBalance_typ    ].Ok(value)) _iBalance_typ     = value;}} int?     _iBalance_typ          ;
        public int?      iCritical_fl    { get { return _iCritical_fl    ;} set { if (this[Col.iCritical_fl    ].Ok(value)) _iCritical_fl     = value;}} int?     _iCritical_fl          ;
        public int?      iPayTo_fl       { get { return _iPayTo_fl       ;} set { if (this[Col.iPayTo_fl       ].Ok(value)) _iPayTo_fl        = value;}} int?     _iPayTo_fl;
        public int?      iTaxID_typ      { get { return _iTaxID_typ      ;} set { if (this[Col.iTaxID_typ      ].Ok(value)) _iTaxID_typ       = value;}} int?     _iTaxID_typ            ;
        public decimal?  mBalanceDue_amt { get { return _mBalanceDue_amt ;} set { if (this[Col.mBalanceDue_amt ].Ok(value)) _mBalanceDue_amt  = value;}} decimal? _mBalanceDue_amt       ;
        public decimal?  mCreditAvail_amt{ get { return _mCreditAvail_amt;} set { if (this[Col.mCreditAvail_amt].Ok(value)) _mCreditAvail_amt = value;}} decimal? _mCreditAvail_amt      ;
        public decimal?  mCreditLimit_amt{ get { return _mCreditLimit_amt;} set { if (this[Col.mCreditLimit_amt].Ok(value)) _mCreditLimit_amt = value;}} decimal? _mCreditLimit_amt      ;
        public decimal?  mCreditMemo_amt { get { return _mCreditMemo_amt ;} set { if (this[Col.mCreditMemo_amt ].Ok(value)) _mCreditMemo_amt  = value;}} decimal? _mCreditMemo_amt       ;
        public decimal?  mFedWH_amt      { get { return _mFedWH_amt      ;} set { if (this[Col.mFedWH_amt      ].Ok(value)) _mFedWH_amt       = value;}} decimal? _mFedWH_amt            ;
        public decimal?  mFinChg_amt     { get { return _mFinChg_amt     ;} set { if (this[Col.mFinChg_amt     ].Ok(value)) _mFinChg_amt      = value;}} decimal? _mFinChg_amt           ;
        public decimal?  mMinPayment_amt { get { return _mMinPayment_amt ;} set { if (this[Col.mMinPayment_amt ].Ok(value)) _mMinPayment_amt  = value;}} decimal? _mMinPayment_amt       ;
        public decimal?  mOverdue_amt    { get { return _mOverdue_amt    ;} set { if (this[Col.mOverdue_amt    ].Ok(value)) _mOverdue_amt     = value;}} decimal? _mOverdue_amt          ;
        public string    sAccount_cd     { get { return _sAccount_cd     ;} set { if (this[Col.sAccount_cd     ].Ok(value)) _sAccount_cd      = value;}} string   _sAccount_cd           ;
        public string    sAddress1       { get { return _sAddress1       ;} set { if (this[Col.sAddress1       ].Ok(value)) _sAddress1        = value;}} string   _sAddress1             ;
        public string    sAddress2       { get { return _sAddress2       ;} set { if (this[Col.sAddress2       ].Ok(value)) _sAddress2        = value;}} string   _sAddress2             ;
        public string    sCity           { get { return _sCity           ;} set { if (this[Col.sCity           ].Ok(value)) _sCity            = value;}} string   _sCity                 ;
        public string    sComment        { get { return _sComment        ;} set { if (this[Col.sComment        ].Ok(value)) _sComment         = value;}} string   _sComment              ;
        public string    sCono_cd        { get { return _sCono_cd        ;} set { if (this[Col.sCono_cd        ].Ok(value)) _sCono_cd         = value;}} string   _sCono_cd              ;
        public string    sContact_nm     { get { return _sContact_nm     ;} set { if (this[Col.sContact_nm     ].Ok(value)) _sContact_nm      = value;}} string   _sContact_nm           ;
        public string    sContactPhone   { get { return _sContactPhone   ;} set { if (this[Col.sContactPhone   ].Ok(value)) _sContactPhone    = value;}} string   _sContactPhone         ;
        public string    sDBA_nm         { get { return _sDBA_nm         ;} set { if (this[Col.sDBA_nm         ].Ok(value)) _sDBA_nm          = value;}} string   _sDBA_nm               ;
        public string    sDiscount_acct  { get { return _sDiscount_acct  ;} set { if (this[Col.sDiscount_acct  ].Ok(value)) _sDiscount_acct   = value;}} string   _sDiscount_acct        ;
        public string    sEmailAddress   { get { return _sEmailAddress   ;} set { if (this[Col.sEmailAddress   ].Ok(value)) _sEmailAddress    = value;}} string   _sEmailAddress         ;
        public string    sExpense_acct   { get { return _sExpense_acct   ;} set { if (this[Col.sExpense_acct   ].Ok(value)) _sExpense_acct    = value;}} string   _sExpense_acct         ;
        public string    sFax            { get { return _sFax            ;} set { if (this[Col.sFax            ].Ok(value)) _sFax             = value;}} string   _sFax                  ;
        public string    sLastUpdate_id  { get { return _sLastUpdate_id  ;} set { if (this[Col.sLastUpdate_id  ].Ok(value)) _sLastUpdate_id   = value;}} string   _sLastUpdate_id        ;
        public string    sPayTo_cd       { get { return _sPayTo_cd       ;} set { if (this[Col.sPayTo_cd       ].Ok(value)) _sPayTo_cd        = value;}} string   _sPayTo_cd             ;
        public string    sPhone          { get { return _sPhone          ;} set { if (this[Col.sPhone          ].Ok(value)) _sPhone           = value;}} string   _sPhone                ;
        public string    sPhoneExt       { get { return _sPhoneExt       ;} set { if (this[Col.sPhoneExt       ].Ok(value)) _sPhoneExt        = value;}} string   _sPhoneExt             ;
        public string    sPrice_cd       { get { return _sPrice_cd       ;} set { if (this[Col.sPrice_cd       ].Ok(value)) _sPrice_cd        = value;}} string   _sPrice_cd             ;
        public string    sReseller_num   { get { return _sReseller_num   ;} set { if (this[Col.sReseller_num   ].Ok(value)) _sReseller_num    = value;}} string   _sReseller_num         ;
        public string    sSortKey        { get { return _sSortKey        ;} set { if (this[Col.sSortKey        ].Ok(value)) _sSortKey         = value;}} string   _sSortKey              ;
        public string    sSortKeyHidden  { get { return _sSortKeyHidden  ;} set { if (this[Col.sSortKeyHidden  ].Ok(value)) _sSortKeyHidden   = value;}} string   _sSortKeyHidden        ;
        public string    sState          { get { return _sState          ;} set { if (this[Col.sState          ].Ok(value)) _sState           = value;}} string   _sState                ;
        public string    sTax_cd         { get { return _sTax_cd         ;} set { if (this[Col.sTax_cd         ].Ok(value)) _sTax_cd          = value;}} string   _sTax_cd               ;
        public string    sTaxID          { get { return _sTaxID          ;} set { if (this[Col.sTaxID          ].Ok(value)) _sTaxID           = value;}} string   _sTaxID                ;
        public string    sTerms_cd       { get { return _sTerms_cd       ;} set { if (this[Col.sTerms_cd       ].Ok(value)) _sTerms_cd        = value;}} string   _sTerms_cd             ;
        public string    sVendor_cd      { get { return _sVendor_cd      ;} set { if (this[Col.sVendor_cd      ].Ok(value)) _sVendor_cd       = value;}} string   _sVendor_cd            ;
        public string    sVendor_nm      { get { return _sVendor_nm      ;} set { if (this[Col.sVendor_nm      ].Ok(value)) _sVendor_nm       = value;}} string   _sVendor_nm            ;
        public string    sWebAddress     { get { return _sWebAddress     ;} set { if (this[Col.sWebAddress     ].Ok(value)) _sWebAddress      = value;}} string   _sWebAddress           ;
        public string    sZipCode        { get { return _sZipCode        ;} set { if (this[Col.sZipCode        ].Ok(value)) _sZipCode         = value;}} string   _sZipCode              ;
        public int?      ytd_1099_vendor { get { return _ytd_1099_vendor ;} set { if (this[Col.ytd_1099_vendor ].Ok(value)) _ytd_1099_vendor  = value;}} int?     _ytd_1099_vendor       ;
        public Guid      uniqueid        { get { return _uniqueid        ;} set { if (this[Col.uniqueid        ].Ok(value)) _uniqueid         = value;}} Guid     _uniqueid              ;

        static Dictionary<Col, SqlDescriptor> _lookup;

        public SqlDescriptor this[Col i]
        {
            get { return _lookup[i]; }
            set { _lookup[i] = value; }
        }

        //public object this[Col i]
        //{
        //    get { return _lookup[i]; }
        //    set { _lookup[i] = value; }
        //}

        static Vendor()
        {
            _lookup = MakeDescriptors();
        }

        static Dictionary<Col, SqlDescriptor> MakeDescriptors()
        {
            var d = new Dictionary<Col, SqlDescriptor>();

            d.Add(Col.Active          , new SqlDescriptor(Col.Active          .ToString(), SqlType.Bit             , 0                 ,1                   ,true));
            d.Add(Col.dtLastUpdate_dt , new SqlDescriptor(Col.dtLastUpdate_dt .ToString(), SqlType.Datetime        , SqlScript.DateMin , SqlScript.DateMax  ,true));
            d.Add(Col.i1099_typ       , new SqlDescriptor(Col.i1099_typ       .ToString(), SqlType.Int             , SqlScript.IntMin  , SqlScript.IntMax   ,true));
            d.Add(Col.iBalance_typ    , new SqlDescriptor(Col.iBalance_typ    .ToString(), SqlType.Int             , SqlScript.IntMin  , SqlScript.IntMax   ,true));
            d.Add(Col.iCritical_fl    , new SqlDescriptor(Col.iCritical_fl    .ToString(), SqlType.Int             , SqlScript.IntMin  , SqlScript.IntMax   , true));
            d.Add(Col.iPayTo_fl       , new SqlDescriptor(Col.iPayTo_fl       .ToString(), SqlType.Int             , SqlScript.IntMin  , SqlScript.IntMax   , true));
            d.Add(Col.iTaxID_typ      , new SqlDescriptor(Col.iTaxID_typ      .ToString(), SqlType.Int             , SqlScript.IntMin  , SqlScript.IntMax   ,true));
            d.Add(Col.mBalanceDue_amt , new SqlDescriptor(Col.mBalanceDue_amt .ToString(), SqlType.Money           , SqlScript.MoneyMin, SqlScript.MoneyMax ,true ));
            d.Add(Col.mCreditAvail_amt, new SqlDescriptor(Col.mCreditAvail_amt.ToString(), SqlType.Money           , SqlScript.MoneyMin, SqlScript.MoneyMax, true));
            d.Add(Col.mCreditLimit_amt, new SqlDescriptor(Col.mCreditLimit_amt.ToString(), SqlType.Money           , SqlScript.MoneyMin, SqlScript.MoneyMax, true));
            d.Add(Col.mCreditMemo_amt , new SqlDescriptor(Col.mCreditMemo_amt .ToString(), SqlType.Money           , SqlScript.MoneyMin, SqlScript.MoneyMax ,true ));
            d.Add(Col.mFedWH_amt      , new SqlDescriptor(Col.mFedWH_amt      .ToString(), SqlType.Money           , SqlScript.MoneyMin, SqlScript.MoneyMax ,true ));
            d.Add(Col.mFinChg_amt     , new SqlDescriptor(Col.mFinChg_amt     .ToString(), SqlType.Money           , SqlScript.MoneyMin, SqlScript.MoneyMax ,true ));
            d.Add(Col.mMinPayment_amt , new SqlDescriptor(Col.mMinPayment_amt .ToString(), SqlType.Money           , SqlScript.MoneyMin, SqlScript.MoneyMax ,true ));
            d.Add(Col.mOverdue_amt    , new SqlDescriptor(Col.mOverdue_amt    .ToString(), SqlType.Money           , SqlScript.MoneyMin, SqlScript.MoneyMax ,true ));
            d.Add(Col.sAccount_cd     , new SqlDescriptor(Col.sAccount_cd     .ToString(), SqlType.Varchar         , 0                 , 30                 ,true ));
            d.Add(Col.sAddress1       , new SqlDescriptor(Col.sAddress1       .ToString(), SqlType.Varchar         , 0                 , 40                 ,true ));
            d.Add(Col.sAddress2       , new SqlDescriptor(Col.sAddress2       .ToString(), SqlType.Varchar         , 0                 , 40                 ,true ));
            d.Add(Col.sCity           , new SqlDescriptor(Col.sCity           .ToString(), SqlType.Varchar         , 0                 , 20                 ,true ));
            d.Add(Col.sComment        , new SqlDescriptor(Col.sComment        .ToString(), SqlType.Varchar         , 0                 , 250                ,true ));
            d.Add(Col.sCono_cd        , new SqlDescriptor(Col.sCono_cd        .ToString(), SqlType.Varchar         , 1                 , 4                  ,false ));
            d.Add(Col.sContact_nm     , new SqlDescriptor(Col.sContact_nm     .ToString(), SqlType.Varchar         , 0                 , 35                 ,true ));
            d.Add(Col.sContactPhone   , new SqlDescriptor(Col.sContactPhone   .ToString(), SqlType.Varchar         , 0                 , 20                 ,true ));
            d.Add(Col.sDBA_nm         , new SqlDescriptor(Col.sDBA_nm         .ToString(), SqlType.Varchar         , 0                 , 40                 ,true ));
            d.Add(Col.sDiscount_acct  , new SqlDescriptor(Col.sDiscount_acct  .ToString(), SqlType.Varchar         , 0                 , 48                 ,true ));
            d.Add(Col.sEmailAddress   , new SqlDescriptor(Col.sEmailAddress   .ToString(), SqlType.Varchar         , 0                 , 30                 ,true ));
            d.Add(Col.sExpense_acct   , new SqlDescriptor(Col.sExpense_acct   .ToString(), SqlType.Varchar         , 0                 , 48                 ,true ));
            d.Add(Col.sFax            , new SqlDescriptor(Col.sFax            .ToString(), SqlType.Varchar         , 0                 , 20                 ,true ));
            d.Add(Col.sLastUpdate_id  , new SqlDescriptor(Col.sLastUpdate_id  .ToString(), SqlType.Varchar         , 16                , 16                 ,true ));
            d.Add(Col.sPayTo_cd       , new SqlDescriptor(Col.sPayTo_cd       .ToString(), SqlType.Varchar         , 0                 , 10                 ,true ));
            d.Add(Col.sPhone          , new SqlDescriptor(Col.sPhone          .ToString(), SqlType.Varchar         , 0                 , 20                 ,true ));
            d.Add(Col.sPhoneExt       , new SqlDescriptor(Col.sPhoneExt       .ToString(), SqlType.Varchar         , 0                 , 5                  ,true ));
            d.Add(Col.sPrice_cd       , new SqlDescriptor(Col.sPrice_cd       .ToString(), SqlType.Varchar         , 0                 , 8                  ,true ));
            d.Add(Col.sReseller_num   , new SqlDescriptor(Col.sReseller_num   .ToString(), SqlType.Varchar         , 0                 , 20                 ,true ));
            d.Add(Col.sSortKey        , new SqlDescriptor(Col.sSortKey        .ToString(), SqlType.Varchar         , 0                 , 40                 ,true ));
            d.Add(Col.sSortKeyHidden  , new SqlDescriptor(Col.sSortKeyHidden  .ToString(), SqlType.Varchar         , 0                 , 40                 ,true ));
            d.Add(Col.sState          , new SqlDescriptor(Col.sState          .ToString(), SqlType.Varchar         , 0                 , 2                  ,true ));
            d.Add(Col.sTax_cd         , new SqlDescriptor(Col.sTax_cd         .ToString(), SqlType.Varchar         , 0                 , 8                  ,true ));
            d.Add(Col.sTaxID          , new SqlDescriptor(Col.sTaxID          .ToString(), SqlType.Varchar         , 20                , 20                 ,true ));
            d.Add(Col.sTerms_cd       , new SqlDescriptor(Col.sTerms_cd       .ToString(), SqlType.Varchar         , 0                 , 8                  ,true ));
            d.Add(Col.sVendor_cd      , new SqlDescriptor(Col.sVendor_cd      .ToString(), SqlType.Varchar         , 1                 , 10                 ,false ));
            d.Add(Col.sVendor_nm      , new SqlDescriptor(Col.sVendor_nm      .ToString(), SqlType.Varchar         , 0                 , 60                 ,true ));
            d.Add(Col.sWebAddress     , new SqlDescriptor(Col.sWebAddress     .ToString(), SqlType.Varchar         , 0                 , 30                 ,true ));
            d.Add(Col.sZipCode        , new SqlDescriptor(Col.sZipCode        .ToString(), SqlType.Varchar         , 0                 , 9                  ,true ));
            d.Add(Col.ytd_1099_vendor , new SqlDescriptor(Col.ytd_1099_vendor .ToString(), SqlType.Tinyint         , 0                 , 0                  , true ));
            d.Add(Col.uniqueid        , new SqlDescriptor(Col.uniqueid        .ToString(), SqlType.Uniqueidentifier,    36     , 36                 , false ));

            return d;
        }
    }
}
