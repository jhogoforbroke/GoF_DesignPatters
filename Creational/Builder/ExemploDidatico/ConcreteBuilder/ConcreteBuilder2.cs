namespace Creational.Builder.ExemploDidatico
{
    class ConcreteBuilder2 : Builder
    {
        private Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("PartX");
        }

        public override void BuildPartB()
        {
            _product.Add("PartY");
        }

        public override Product GetProduct()
        {
            return _product;
        }
    }
}
