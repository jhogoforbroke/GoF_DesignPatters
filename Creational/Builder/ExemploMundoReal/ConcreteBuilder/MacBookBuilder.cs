using Creational.Builder.ExemploMundoReal.Builder;

namespace Creational.Builder.ExemploMundoReal.ConcreteBuilder
{
    /// <summary>
    /// ConcreteBuilder
    /// </summary>
    public class MacBookBuilder : NotebookBuilder
    {
        public override void buildModelo()
        {
            notebook.Modelo = "MacBook Air MD711";
        }

        public override void buildPlacaDeVideo()
        {
            notebook.PlacaDeVideo = "Intel HD Graphics 5000";
        }

        public override void buildTamanhoTela()
        {
            notebook.TamanhoTela = "11\"";
        }

        public override void buildProcessador()
        {
            notebook.Processador = "Intel Core i5 Dual Core";
        }

        public override void buildMemoriaRAM()
        {
            notebook.MemoriaRAM = "4 GB";
        }

        public override void buildHD()
        {
            notebook.HD = "128 GB SSD";
        }

        public override void buildSistemaOperacional()
        {
            notebook.SistemaOperacional = "Mac OS Mountain Lion";
        }
    }
}
