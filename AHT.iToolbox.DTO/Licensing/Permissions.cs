///////////////////////////////////////////////////////////////////////////////
//
//  Copyright © 2017, American Healthtech and American Healthtech and CPSI
//
//  File    : Permissions.cs
//
//  Notes   : Permission flag enumeration for access rights, enable/disable, etc.
//
///////////////////////////////////////////////////////////////////////////////

using System;

namespace AHT.uToolBox.DTO.Licensing
{
    /// <summary>
    /// Permission flag enumeration for access rights, enable/disable, etc.
    /// </summary>
    [Flags]
    public enum Permissions : UInt32
    {
        None = 0,
        All = UInt32.MaxValue,
    }
}
