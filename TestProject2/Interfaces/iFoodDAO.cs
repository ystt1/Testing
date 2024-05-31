﻿using QLQCF.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.Interfaces
{
    internal interface IFoodDAO
    {
        Food GetFoodByBillInfo(BillInfo billInfo);
        float GetPricewithName(string v);
    }
}
