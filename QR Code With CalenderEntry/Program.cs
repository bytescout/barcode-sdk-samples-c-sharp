//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up //
//                                                                                           //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 //
// http://www.bytescout.com                                                                  //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Diagnostics;
using Bytescout.BarCode;

namespace QRCodeWithCalenderEntry
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create new barcode
                using (Barcode barcode = new Barcode())
                {
                    // Set symbology
                    barcode.Symbology = SymbologyType.QRCode;

                    // Get QRCode value in CalenderEntry format
                    barcode.Value = GetCalenderEntryFormatText();

                    // Save barcode to image
                    barcode.SaveImage("result.png");
                }

                // Show image in default image viewer
                Process.Start("result.png");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);

                Console.WriteLine("Press enter key to exit...");
                Console.ReadLine();
            }

        }

        /// <summary>
        /// Return Calender Entry Format
        /// </summary>
        /// <returns></returns>
        private static string GetCalenderEntryFormatText()
        {
            return @"BEGIN:VCALENDAR
BEGIN:VEVENT
DTSTART:20181113T100000Z
DTEND:20181113T150000Z
SUMMARY:New Calendar Entry
DESCRIPTION:Description Text
LOCATION:Chicago
RRULE:FREQ=YEARLY;BYDAY=-1SU;BYMONTH=3
END:VEVENT
END:VCALENDAR";
        }

    }
}
