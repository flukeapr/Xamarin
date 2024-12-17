﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Mvvm.Models
{
    class Product
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public Uri Image { get; set; }
    }
}
