using NUnit.Framework;

namespace Creational.Abstract_Factory.ExemploDidatico
{
    [TestFixture]
    public class Teste
    {
        private AbstractFactory _factory;
        private Cliente _cliente;
        
        [Test]
        public void Criar_ProductA_e_ProductB_tipo1()
        {
            _factory = new ConcreteFactory1();
            _cliente = new Cliente(_factory);

            //interação entre objetos ProductA e ProductB 
            Assert.AreEqual("ProductB1 interage com ProductA1", _cliente.Run());
        }

        [Test]
        public void Criar_ProductA_e_ProductB_tipo2()
        {
            _factory = new ConcreteFactory2();
            _cliente = new Cliente(_factory);

            //interação entre objetos ProductA e ProductB
            Assert.AreEqual("ProductB2 interage com ProductA2", _cliente.Run());
        }
    }
}
