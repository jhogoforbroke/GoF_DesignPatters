using Creational.Builder.ExemploMundoReal.Product;

namespace Creational.Builder.ExemploMundoReal.Builder
{
    /// <summary>
    /// Builder
    /// </summary>
    public abstract class NotebookBuilder
    {
        //Propriedade protected deve ser herdada para os bulders concretos
        protected Notebook notebook;

        //Accessor publico para a propriedade protected
        public Notebook Notebook
        {
            get { return notebook; }
        }

        //Nesse exemplo iremos inicializar a propriedade Product no construtor do Builder
        protected NotebookBuilder()
        {
            notebook = new Notebook();
        }

        public abstract void buildModelo();

        public abstract void buildPlacaDeVideo();

        public abstract void buildTamanhoTela();

        public abstract void buildProcessador();

        public abstract void buildMemoriaRAM();

        public abstract void buildHD();

        public abstract void buildSistemaOperacional();
        
    }
}
