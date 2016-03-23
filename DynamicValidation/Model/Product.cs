﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicValidation.Model
{
    public class Product
    {
        public string Name { get; set; }

        public IEnumerable<IFieldValue> FieldValues { get; set; } 
    }
}
