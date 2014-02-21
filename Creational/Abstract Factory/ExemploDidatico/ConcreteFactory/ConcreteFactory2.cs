namespace Creational.Abstract_Factory.ExemploDidatico
{
    class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CriarProdutoA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CriarProdutoB()
        {
            return new ProductB2();
        }
    }
}