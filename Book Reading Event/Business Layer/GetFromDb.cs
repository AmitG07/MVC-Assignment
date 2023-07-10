using Business_Layer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer
{
    class GetFromDb : IGetFromDb
    {
        public string GetEvent(int id)
        {
            return "Amit" + id;
        }
    }
}
