using Building_Materials.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_Materials.ViewModel
{
    internal class AppData
    {
        public static Building_MaterialsTradeEntities db = new Building_MaterialsTradeEntities ();
    }
}
