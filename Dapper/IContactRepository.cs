﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperExample
{
    public interface IContactRepository
    {
        List<Contact> GetAll();
    }
    

}
