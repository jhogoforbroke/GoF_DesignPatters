using Creational.Factory_Method.ExemploMundoReal.ConcreteCreator;
using Creational.Factory_Method.ExemploMundoReal.ConcreteProduct;
using Creational.Factory_Method.ExemploMundoReal.Creator;
using Creational.Factory_Method.ExemploMundoReal.Product;
using NUnit.Framework;

namespace Creational.Factory_Method.ExemploMundoReal
{
    [TestFixture]
    public class Teste
    {
        private Fabricante _fabricante;
        private Notebook _notebook;

        [Test]
        public void Criar_notebook_Dell()
        {
            _fabricante = new Dell();
            _notebook = _fabricante.Notebook;

            Assert.IsInstanceOf(typeof(Inspiron15R5437), _notebook);
        }

        [Test]
        public void Criar_notebook_Sony()
        {
            _fabricante = new Sony();
            _notebook = _fabricante.Notebook;

            Assert.IsInstanceOf(typeof(SonyVaioFit15Svf), _notebook);
        }

        [Test]
        public void Criar_notebook_Apple()
        {
            _fabricante = new Apple();
            _notebook = _fabricante.Notebook;

            Assert.IsInstanceOf(typeof(MacBookAirMd71), _notebook);
        }
    }
}
