using System;
using Creational.Abstract_Factory.ExemploMundoReal.AbstractFactory;
using Creational.Abstract_Factory.ExemploMundoReal.AbstractProduct;

namespace Creational.Abstract_Factory.ExemploMundoReal.Client
{
    class Usuario
    {
        private readonly Celular _celular;
        private readonly Notebook _notebook;
        private readonly Tablet _tablet;

        public Usuario(Fabricante fabricante)
        {
            _celular = fabricante.CriarCelular();
            _notebook = fabricante.CriarNotebook();
            _tablet = fabricante.CriarTablet();
        }

        public string UsarGadget()
        {
            return String.Concat(_celular.FazerLigacao(), ", ", _notebook.Trabalhar(), " e ",
                                 _tablet.NavegarNaInternet());
        }
    }
}
