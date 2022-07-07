using DoAnPBL3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.BLL
{
    class BLL_QLQT
    {
        private static BLL_QLQT _Instance;
        public static BLL_QLQT Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLQT();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private BLL_QLQT()
        {

        }

        public string GetIDByAccountUsername(string accountUsername)
        {
            return DAL_QLQT.Instance.GetIDByAccountUsername(accountUsername);
        }
    }
}
