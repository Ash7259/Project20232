using Project202322.Shared.Domain;
using System;

namespace Project202322.Shared.Domain
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tags { get; set; }
        public string Type { get; set; }
    }
}