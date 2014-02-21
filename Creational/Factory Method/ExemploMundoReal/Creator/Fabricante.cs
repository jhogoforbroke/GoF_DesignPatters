using Creational.Factory_Method.ExemploMundoReal.Product;

namespace Creational.Factory_Method.ExemploMundoReal.Creator
{
    /// <summary>
    /// Creator
    /// </summary>
    abstract class Fabricante
    {
        //OBS: É muito comum utilizar o Product como uma propriedade do Creator isso evita a criação de instancias desnecessarias em alguns casos
        public Notebook Notebook { get; protected set; }

        protected Fabricante()
        {
            CriarNotebook();
        }

        protected abstract void CriarNotebook();
    }
}
