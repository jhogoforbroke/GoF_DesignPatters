using System;

namespace Creational.Abstract_Factory.ExemploDidatico
{
    public class ProductB1 : AbstractProductB
    {
        public override string Interagir(AbstractProductA a)
        {
            return String.Format(this.GetType().Name + " interage com " + a.GetType().Name);
        }
    }
}