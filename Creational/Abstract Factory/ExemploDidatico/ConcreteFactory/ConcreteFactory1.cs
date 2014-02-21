namespace Creational.Abstract_Factory.ExemploDidatico
{
    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CriarProdutoA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CriarProdutoB()
        {
            return new ProductB1();
        }
    }
}