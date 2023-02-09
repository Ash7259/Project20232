using Project202322.Shared.Domain;
using Project23.Shared.Domain;
using System;

namespace Project202322.Shared.Domain
{
    public class Product : BaseDomainModel
    {
        public new int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public int Rating { get; set; }
    }
}