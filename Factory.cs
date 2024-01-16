namespace AbstractFactoryHW
{
    public abstract class Factory
    {
        public abstract IDell CreateDell();
        public abstract ISamsung CreateSamsung();
    }
}
