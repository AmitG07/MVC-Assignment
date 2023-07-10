using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer.Interface
{
    interface IGetFromDb
    {
        string GetEvent(int id);
    }
}
