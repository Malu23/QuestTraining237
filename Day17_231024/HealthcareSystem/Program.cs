using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
// using AppUtilities;

namespace HealthcareSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new HealthCareManager().ListUpcomingAppontmentsInNextSevenDays();
        }
    }
}
