namespace Creational.Builder.ExemploDidatico
{
    class Director
    {
        //Metodo que utiliza os passos de criação complexos
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
