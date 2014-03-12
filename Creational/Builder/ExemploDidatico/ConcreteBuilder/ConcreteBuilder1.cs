﻿namespace Creational.Builder.ExemploDidatico
{
    class ConcreteBuilder1 : Builder
    {
        private Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("PartA");
        }

        public override void BuildPartB()
        {
            _product.Add("PartB");
        }

        public override Product GetProduct()
        {
            return _product;
        }
    }
}