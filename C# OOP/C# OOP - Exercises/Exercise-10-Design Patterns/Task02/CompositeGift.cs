﻿using System;
using CompositePattern.Contracts;
using System.Collections.Generic;

namespace CompositePattern
{
    public class CompositeGift : GiftBase, IGiftOperations
    {
        private ICollection<GiftBase> gifts;

        public CompositeGift(string name, int price)
            : base(name, price)
        {
            gifts = new List<GiftBase>();
        }

        public void Add(GiftBase gift)
        {
            gifts.Add(gift);
        }

        public void Remove(GiftBase gift)
        {
            gifts.Remove(gift);
        }

        public override int CalculateTotalPrice()
        {
            int total = 0;

            Console.WriteLine($"{name} contains following products with prices:");

            foreach (GiftBase gift in gifts)
            {
                total += gift.CalculateTotalPrice();
            }

            return total;
        }
    }
}
