﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.LokacijaOperations
{
    public class ObrisiLokacijaSO : SystemOperationBase
    {
        protected override void Execute(IEntity entity)
        {
            repository.Delete(entity);
        }
    }
}
