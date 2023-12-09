using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Instock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int partID)
        {
            Part partToRemove = AssociatedParts.FirstOrDefault(p => p.PartID == partID);
            if (partToRemove != null)
            {
                AssociatedParts.Remove(partToRemove);
                return true;
            }
            return false;
        }

        public Part LookupAssociatedPart(int partID)
        {
            return AssociatedParts.FirstOrDefault(p => p.PartID == partID);
        }
    }
}
