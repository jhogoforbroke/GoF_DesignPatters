using Creational.Factory_Method.ExemploMundoReal.ConcreteProduct;
using Creational.Factory_Method.ExemploMundoReal.Creator;

namespace Creational.Factory_Method.ExemploMundoReal.ConcreteCreator
{
    /// <summary>
    /// ConcreteCreator
    /// </summary>
    class Apple : Fabricante
    {
        protected override void CriarNotebook()
        {
            Notebook = new MacBookAirMd71();
        }
    }
}