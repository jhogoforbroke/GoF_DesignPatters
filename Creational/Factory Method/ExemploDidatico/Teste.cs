using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Creational.Factory_Method.ExemploDidatico
{
    [TestFixture]
    public class Teste
    {
        static Creator _creator;

        static Product _product; 
        
        [Test]
        public void Criar_um_ProductA()
        {
            _creator = new ConcreteCreatorA();
            _product = _creator.FactoryMethod();

            Assert.IsInstanceOf(typeof (ConcreteProductA), _product);
        }

        [Test]
        public void Criar_um_ProductB()
        {
            _creator = new ConcreteCreatorB();
            _product = _creator.FactoryMethod();

            Assert.IsInstanceOf(typeof(ConcreteProductB), _product);
        }
    }
}
