﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace BE
{
    public abstract class IEntity
    {
        public ObjectId Id { get; set; }
    }
}
