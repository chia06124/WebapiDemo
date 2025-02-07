﻿using Newtonsoft.Json.Linq;
using Newtonsoft.JsonResult;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLModel.Interface
{
    public interface IRepository<TEntity>
    {
        void Create(TEntity entity);
        string Get(JObject data);

        void Update(TEntity data);
        void Delete(JObject data);
    }
}
