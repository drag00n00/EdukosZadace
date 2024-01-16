namespace AbstractFactoryHW
{
    public class TVFactory : Factory
    {
        public override IDell CreateDell()
        {
            return new DellTV();
        }

        public override ISamsung CreateSamsung()
        {
            return new SamsungTV();
        }
    }
}
