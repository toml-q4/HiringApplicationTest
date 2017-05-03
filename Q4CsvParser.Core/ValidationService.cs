﻿using System;
using Q4CsvParser.Core.Contracts;

namespace Q4CsvParser.Core
{
    /// <summary>
    /// This file must be unit tested
    /// </summary>
    public class ValidationService : IValidationService
    {
        /// <summary>
        /// Takes in a file name and determines whether it is a csv file or not.
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public bool IsCsvFile(string filename)
        {
            if (filename.Contains(@".csv"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
