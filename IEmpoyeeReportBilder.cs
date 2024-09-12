﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporter
{
    public interface IEmpoyeeReportBilder
    {
        void BulidHeader();
        void BulidBody();
        void BulidFooter();

        EmployeeReport GetReport();
    }
}
