using System;

namespace Creational.Abstract_Factory.ExemploDidatico
{
    public class ProductB2 : AbstractProductB
    {
        public override string Interagir(AbstractProductA a)
        {
            return String.Format(this.GetType().Name + " interage com " + a.GetType().Name);
        }
    }
}