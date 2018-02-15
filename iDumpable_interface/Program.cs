/*
 * C# Program to Demonstrate IDumpable Interface
 */

using System;

namespace iDumpable_interface
{
    interface IDumpable
    {
        string Name { get; set; }
        void Dump();
    }
}
