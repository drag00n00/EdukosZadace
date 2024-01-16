namespace AbstractFactoryHW
{
    public class DisplayFactory : Factory
    {
        public override IDell CreateDell()
        {
            return new DellDisplay();
        }

        public override ISamsung CreateSamsung()
        {
            return new SamsungDisplay();
        }
    }
}
