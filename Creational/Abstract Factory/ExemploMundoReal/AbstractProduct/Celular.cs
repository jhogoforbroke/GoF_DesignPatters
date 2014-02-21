using System;

namespace Creational.Abstract_Factory.ExemploMundoReal.AbstractProduct
{
    abstract class Celular
    {
        public virtual string FazerLigacao()
        {
            return String.Format("Fazendo uma ligação com meu celular {0}", GetType().Name);
        }
    }
}