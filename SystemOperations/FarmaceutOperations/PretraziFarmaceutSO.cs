﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.FarmaceutOperations
{
    public class PretraziFarmaceutSO : SystemOperationBase
    {
        public Farmaceut Result { get; private set; }
        protected override void Execute(IEntity entity)
        {
            Result = (Farmaceut)repository.Find(entity);
        }
    }
}
