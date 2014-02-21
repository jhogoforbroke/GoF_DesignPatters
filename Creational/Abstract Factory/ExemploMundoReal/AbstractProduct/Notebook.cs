using System;

namespace Creational.Abstract_Factory.ExemploMundoReal.AbstractProduct
{
    abstract class Notebook
    {
        public virtual string Trabalhar()
        {
            return String.Format("Trabalhando com meu notebook {0}", GetType().Name);
        }
    }
}