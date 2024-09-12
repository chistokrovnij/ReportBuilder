using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporter
{
    public class EmployeReportDirector
    {
        private readonly IEmpoyeeReportBilder _builder;

        public EmployeReportDirector(IEmpoyeeReportBilder bilder)
        {
            _builder = bilder;
        }

        public void Builder()
        {
            _builder.BulidHeader();

            _builder.BulidBody();

            _builder.BulidFooter();
        }
    }
}
