using Creational.Abstract_Factory.ExemploMundoReal.AbstractFactory;
using Creational.Abstract_Factory.ExemploMundoReal.AbstractProduct;
using Creational.Abstract_Factory.ExemploMundoReal.Product;

namespace Creational.Abstract_Factory.ExemploMundoReal.ConcreteFactory
{
    class Sansung : Fabricante
    {
        public override Notebook CriarNotebook()
        {
            return new SansungAtviBook2();
        }

        public override Tablet CriarTablet()
        {
            return new GalaxyTab3();
        }

        public override Celular CriarCelular()
        {
            return new GalaxyS4();
        }
    }
}