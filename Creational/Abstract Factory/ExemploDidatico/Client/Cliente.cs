namespace Creational.Abstract_Factory.ExemploDidatico
{
    class Cliente
    {
        private readonly AbstractProductA _abstractProductA;
        private readonly AbstractProductB _abstractProductB;

        //Construtor
        public Cliente(AbstractFactory abstractFactory)
        {
            _abstractProductA = abstractFactory.CriarProdutoA();
            _abstractProductB = abstractFactory.CriarProdutoB();
        }

        //Alguma ação
        public string Run()
        {
            return _abstractProductB.Interagir(_abstractProductA);
        }
    }
}