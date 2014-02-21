using System;

namespace Creational.Abstract_Factory.ExemploMundoReal.AbstractProduct
{
    abstract class Tablet
    {
        public virtual string NavegarNaInternet()
        {
            return String.Format("Navegando na internet com meu tablete {0}", GetType().Name);
        }
    }
}