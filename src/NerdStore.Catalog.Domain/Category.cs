﻿using NerdStore.Core.DomainObjects;

namespace NerdStore.Catalog.Domain
{
    public class Category : Entity
    {
        public string Name { get; private set; }
        public int Code { get; private set; }

        public Category(string name, int code)
        {
            Name = name;
            Code = code;

            Validate();
        }

        public override string ToString()
        {
            return $"{Name} - {Code}";
        }

        public void Validate()
        {
            AssertionConcern.ValidateEmpty(Name, "O campo nome da categoria não pode estar vazio!");
            AssertionConcern.ValidateEquals(Code, 0, "O campo código da caategoria não pode ser igual a zero!");
        }
    }

}