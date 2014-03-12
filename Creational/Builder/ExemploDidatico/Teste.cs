using NUnit.Framework;

namespace Creational.Builder.ExemploDidatico
{
    [TestFixture]
    public class Teste
    {
        private readonly Director _director = new Director();

        private readonly Builder _builder1 = new ConcreteBuilder1();
        private readonly Builder _builder2 = new ConcreteBuilder2();
        
        [Test]
        public void Criar_um_Product1_com_suas_respectivas_partes()
        {
            _director.Construct(_builder1);
            var product1 = _builder1.GetProduct();

            //PartA e PartB
            Assert.AreEqual("Product Parts:\r\nPartA\r\nPartB\r\n", product1.Show());
        }

        [Test]
        public void Criar_um_Product2_com_suas_respectivas_partes()
        {
            _director.Construct(_builder2);
            var product2 = _builder2.GetProduct();

            //PartX e PartY
            Assert.AreEqual("Product Parts:\r\nPartX\r\nPartY\r\n", product2.Show());
        }

    }
}
