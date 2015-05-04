// Guids.cs
// MUST match guids.h
using System;

namespace Company.VSPackage_NotWorking
{
    static class GuidList
    {
        public const string guidVSPackage_NotWorkingPkgString = "8c141faa-1ab2-4952-9517-dc56e1f57efc";
        public const string guidVSPackage_NotWorkingCmdSetString = "43d8d34a-d9bb-4750-8627-ab5612d5e3f0";

        public static readonly Guid guidVSPackage_NotWorkingCmdSet = new Guid(guidVSPackage_NotWorkingCmdSetString);
    };
}