using Creational.Abstract_Factory.ExemploMundoReal.AbstractFactory;
using Creational.Abstract_Factory.ExemploMundoReal.AbstractProduct;
using Creational.Abstract_Factory.ExemploMundoReal.Product;

namespace Creational.Abstract_Factory.ExemploMundoReal.ConcreteFactory
{
    class Apple : Fabricante
    {
        public override Notebook CriarNotebook()
        {
            return new MacBookAirMd71();
        }

        public override Tablet CriarTablet()
        {
            return new IPadAir16G();
        }

        public override Celular CriarCelular()
        {
            return new IPhone5S();
        }
    }
}
