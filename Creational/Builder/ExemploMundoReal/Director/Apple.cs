using Creational.Builder.ExemploMundoReal.Builder;
using Creational.Builder.ExemploMundoReal.Product;

namespace Creational.Builder.ExemploMundoReal.Director
{
    /// <summary>
    /// Director
    /// </summary>
    public class Apple
    {
        protected NotebookBuilder _fabricaDeNotebook;

        public Apple(NotebookBuilder fabricaDeNotebook)
        {
            _fabricaDeNotebook = fabricaDeNotebook;
        }

        //O ConcreteBuilder tem a implementação para a criação de cada parte do Product
        //Porem o Director tem a "receita" de como construir o objeto
        public void ConstruirNotebook()
        {
            _fabricaDeNotebook.buildHD();
            _fabricaDeNotebook.buildMemoriaRAM();
            _fabricaDeNotebook.buildModelo();
            _fabricaDeNotebook.buildPlacaDeVideo();
            _fabricaDeNotebook.buildProcessador();
            _fabricaDeNotebook.buildSistemaOperacional();
            _fabricaDeNotebook.buildTamanhoTela();
        }

        public Notebook CriarNotebook()
        {
            ConstruirNotebook();
            return _fabricaDeNotebook.Notebook;
        }
    }
}
