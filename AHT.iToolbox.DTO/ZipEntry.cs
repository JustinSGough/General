///////////////////////////////////////////////////////////////////////////////
//
//  Copyright © 2017, American Healthtech and CPSI
//
//  File    : ZipEntry.cs
//
//  Notes   : 
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.ComponentModel;

namespace AHT.uToolBox.DTO
{
    public class ZipEntry
    {
        public string   FileName         { get; set; }
        public DateTime CreationTime     { get; }
        public long     UncompressedSize { get; }

        [Browsable(false)] public bool UsesEncryption{ get; }
        [Browsable(false)] public long CompressedSize{ get; }
        [Browsable(false)] public bool IsDirectory   { get; }

        public ZipEntry
        (
            long compressedSize   ,
            long uncompressedSize ,
            bool usesEncryption   ,
            bool isDirectory      ,
            string fileName       ,
            DateTime creationTime 
        )
        {
            CompressedSize   = compressedSize  ;
            UncompressedSize = uncompressedSize;
            UsesEncryption   = usesEncryption  ;
            IsDirectory      = isDirectory     ;
            FileName         = fileName        ;
            CreationTime     = creationTime    ;
        }
    }
}
