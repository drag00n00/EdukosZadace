namespace AbstractFactoryHW
{
    public class App
    {
        TVFactory TVfactory = new TVFactory();
        DisplayFactory displayFactory = new DisplayFactory();

        List<ISamsung> SamsungEquipment;
        List<IDell> DellEquipment;

        public App()
        {
            SamsungEquipment = new List<ISamsung>() { TVfactory.CreateSamsung(), displayFactory.CreateSamsung() };
            DellEquipment = new List<IDell>() { TVfactory.CreateDell(), displayFactory.CreateDell() };
        }

        public void SellTV()
        {
            //user input on if it is a Samsung or Dell
        }
        public void SellDisplay()
        {
            //user input on if it is a Samsung or Dell
        }
    }
}