using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    public static class Inventory
    {
        public static BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public static BindingList<Part> AllParts { get; set; } = new BindingList<Part>();
        public static int lastPartID = 0;
        public static int lastProductID = 0;

        public static void AddProduct(Product newProduct)
        {
            lastProductID++;
            newProduct.ProductID = lastProductID;

            Products.Add(newProduct);
        }

        public static bool RemoveProduct(int productID)
        {
            Product productToRemove = Products.FirstOrDefault(p => p.ProductID == productID);
            if (productToRemove != null)
            {
                Products.Remove(productToRemove);
                return true;
            }
            return false;
        }

        public static Product LookupProduct(int productID)
        {
            return Products.FirstOrDefault(p => p.ProductID == productID);
        }

        public static void UpdateProduct(int productID, Product updatedProduct)
        {
            Product existingProduct = Products.FirstOrDefault(p => p.ProductID == productID);
            int index = Products.IndexOf(existingProduct);

            Products[index] = updatedProduct;
        }

        public static void AddPart(Part newPart)
        {
            lastPartID++;
            newPart.PartID = lastPartID;

            AllParts.Add(newPart);
        }

        public static bool DeletePart(Part part)
        {
            Part partToDelete = AllParts.FirstOrDefault(p => p.PartID == part.PartID);
            if (partToDelete != null)
            {
                AllParts.Remove(partToDelete);
                return true;
            }
            return false;
        }

        public static Part LookupPart(int partID)
        {
            return AllParts.FirstOrDefault(p => p.PartID == partID);
        }

        public static void UpdatePart(int partID, Part modifiedPart)
        {
            Part existingPart = AllParts.FirstOrDefault(p => p.PartID == partID);
            int index = AllParts.IndexOf(existingPart);

            AllParts[index] = modifiedPart;
        }
    }
}
