﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoesStore.Models
{
    public class CartItem
    {
        public class Item
        {
            public Shoes Product
            {
                get;
                set;
            }

            public int Quantity
            {
                get;
                set;
            }

        }
    }
}