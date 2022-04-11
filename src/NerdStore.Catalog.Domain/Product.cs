using NerdStore.Core.DomainObjects;
using System;

namespace NerdStore.Catalog.Domain
{
    public class Product : Entity, IAggregateRoot
    {
        public Guid CategoryId { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool Active { get; private set; }
        public decimal Value { get; private set; }
        public DateTime RegisterDate { get; private set; }
        public string Image { get; private set; }
        public int InventoryQuantity { get; private set; }
        public Category Category { get; private set; }

        public Product(string name, string description, bool active, decimal value, Guid categoryId, DateTime registerDate, string image)
        {
            CategoryId = categoryId;
            Name = name;
            Description = description;
            Active = active;
            Value = value;
            RegisterDate = registerDate;
            Image = image;
        }

        public void Activate() => Active = true;
        public void Deactivate() => Active = false;
        public void ChangeCategory(Category category)
        {
            Category = category;
            CategoryId = category.Id;
        }
        public void ChangeDescription(string description)
        {
            Description = description; 
        }

        public void DecreaseIventory(int quantity)
        {
            if (quantity < 0) quantity *= -1;
            InventoryQuantity -= quantity;
        }
        public void IncreaseInventory(int quantity)
        {
            InventoryQuantity += quantity;
        } 
        public bool HasInventory(int quantity)
        {
            return InventoryQuantity >= quantity;
        }
        public void Validate() 
        { 
            

        
        }

    }
    public class Category : Entity
    {
        public string Name { get; private set; }
        public string Code { get; private set; }

        public override string ToString()
        {
            return $"{Name} - {Code}";
        }
    }

}
