namespace Creational.Builder.ExemploDidatico
{
    abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetProduct();
    }
}
