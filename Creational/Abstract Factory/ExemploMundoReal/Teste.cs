using Creational.Abstract_Factory.ExemploMundoReal.AbstractFactory;
using Creational.Abstract_Factory.ExemploMundoReal.Client;
using Creational.Abstract_Factory.ExemploMundoReal.ConcreteFactory;
using NUnit.Framework;

namespace Creational.Abstract_Factory.ExemploMundoReal
{
    [TestFixture]
    public class Teste
    {
        private Usuario _usuario;
        private Fabricante _fabricante;

        [Test]
        public void AppleFan_Utiliza_Seus_Gadgets()
        {
            _fabricante = new Apple();
            _usuario = new Usuario(_fabricante);

            const string fraseUtilizacaoApple = "Fazendo uma ligação com meu celular IPhone5S, Trabalhando com meu notebook MacBookAirMd71 e Navegando na internet com meu tablete IPadAir16G";

            Assert.AreEqual(fraseUtilizacaoApple, _usuario.UsarGadget());
        }

        [Test]
        public void SansungFan_Utiliza_Seus_Gadgets()
        {
            _fabricante = new Sansung();
            _usuario = new Usuario(_fabricante);

            const string fraseUtilizacaoApple = "Fazendo uma ligação com meu celular GalaxyS4, Trabalhando com meu notebook SansungAtviBook2 e Navegando na internet com meu tablete GalaxyTab3";

            Assert.AreEqual(fraseUtilizacaoApple, _usuario.UsarGadget());
        }

        [Test]
        public void SonyFan_Utiliza_Seus_Gadgets()
        {
            _fabricante = new Sony();
            _usuario = new Usuario(_fabricante);

            const string fraseUtilizacaoSony = "Fazendo uma ligação com meu celular XperiaZQ, Trabalhando com meu notebook SonyVaioFit15Svf e Navegando na internet com meu tablete XperiaTabletZ4G";

            Assert.AreEqual(fraseUtilizacaoSony, _usuario.UsarGadget());
        }
    }
}
