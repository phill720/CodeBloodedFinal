﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SloganHealth
{
    public static class SloganList
    {
        private static List<string> m_sloganList = new List<string> { "Drink More Water",



























































        public static string GetRandomSlogan()
        {
            int upperbound = m_sloganList.Count;
            Random random = new Random();
            int randomValue = random.Next(0,upperbound+1);

            return m_sloganList[randomValue];
           }
    }
   
}