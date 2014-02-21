using Creational.Abstract_Factory.ExemploMundoReal.AbstractProduct;

namespace Creational.Abstract_Factory.ExemploMundoReal.AbstractFactory
{
    abstract class Fabricante
    {
        public abstract Notebook CriarNotebook();
        public abstract Tablet CriarTablet();
        public abstract Celular CriarCelular();
    }
}
