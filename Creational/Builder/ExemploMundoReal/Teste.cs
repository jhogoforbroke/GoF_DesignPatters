using Creational.Builder.ExemploMundoReal.Builder;
using Creational.Builder.ExemploMundoReal.ConcreteBuilder;
using Creational.Builder.ExemploMundoReal.Director;
using NUnit.Framework;

namespace Creational.Builder.ExemploMundoReal
{
    [TestFixture]
    public class Teste
    {
        private NotebookBuilder _macBookBuilder;

        private Apple _apple;

        [Test]
        public void Criar_notebook_AppleMacBookAirMD711_com_seus_respectivos_componentes()
        {
            _macBookBuilder = new MacBookBuilder();
            _apple = new Apple(_macBookBuilder);

            //Aqui é realizado um processo interno de montagem de cada parte do objeto Product
            var notebook = _apple.CriarNotebook();

            Assert.AreEqual("MacBook Air MD711", notebook.Modelo);
            Assert.AreEqual("128 GB SSD", notebook.HD);
            Assert.AreEqual("4 GB", notebook.MemoriaRAM);
            Assert.AreEqual("Intel HD Graphics 5000", notebook.PlacaDeVideo);
            Assert.AreEqual("Intel Core i5 Dual Core", notebook.Processador);
            Assert.AreEqual("Mac OS Mountain Lion", notebook.SistemaOperacional);
            Assert.AreEqual("11\"", notebook.TamanhoTela);
        }
    }
}
