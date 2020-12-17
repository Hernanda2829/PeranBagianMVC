﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;
using PeranBagianMVC.Model;

namespace PeranBagianMVC.Controller
{
    class PenawaranController
    {
        private List<Item> items;

        public PenawaranController()
        {
            items = new List<Item>();
        }

        public void addItem(Item item)
        {
            this.items.Add(item);
        }

        public List<Item> getItems()
        {
            return this.items;
        }
    }
}