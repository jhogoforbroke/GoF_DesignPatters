using Creational.Factory_Method.ExemploMundoReal.ConcreteProduct;
using Creational.Factory_Method.ExemploMundoReal.Creator;

namespace Creational.Factory_Method.ExemploMundoReal.ConcreteCreator
{
    /// <summary>
    /// ConcreteCreator
    /// </summary>
    class Dell : Fabricante
    {
        protected override void CriarNotebook()
        {
            Notebook = new Inspiron15R5437();
        }
    }
}