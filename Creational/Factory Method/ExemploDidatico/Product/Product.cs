using System;

namespace Creational.Factory_Method.ExemploDidatico
{
    abstract class Product
    {
        public virtual void DizerMeuNome()
        {
            Console.WriteLine(this.GetType().Name, "Eu sou o {0}");
        }
    }
}
