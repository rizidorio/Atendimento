using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataContextFactory
    {
        private static atendimentosDataContext dataContext;

        public static atendimentosDataContext atendimentosDataContext
        {
            get
            {
                if (dataContext == null)
                    dataContext = new atendimentosDataContext();
                return dataContext;
            }
        }
    }
}
