using Creational.Abstract_Factory.ExemploMundoReal.AbstractFactory;
using Creational.Abstract_Factory.ExemploMundoReal.AbstractProduct;
using Creational.Abstract_Factory.ExemploMundoReal.Product;

namespace Creational.Abstract_Factory.ExemploMundoReal.ConcreteFactory
{
    class Sony : Fabricante
    {
        public override Notebook CriarNotebook()
        {
            return new SonyVaioFit15Svf();
        }

        public override Tablet CriarTablet()
        {
            return new XperiaTabletZ4G();
        }

        public override Celular CriarCelular()
        {
            return new XperiaZQ();
        }
    }
}