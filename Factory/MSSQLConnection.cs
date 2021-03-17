﻿using System;

namespace Factory
{
    internal class MSSQLConnection : IConnection
    {
        public void Connect()
        {
            Console.WriteLine("Connect to MSSQL");
        }
    }
}