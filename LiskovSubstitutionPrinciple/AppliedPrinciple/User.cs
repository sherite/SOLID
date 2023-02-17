namespace AppliedPrinciple
{
    interface IVehicle
    {
        void Drive(int miles);
        void FillUpWithFuel();
        int FuelRemaining { get; }
    }

    public class Vehicles
    {
        void MethodWhichUsesIVehicle(IVehicle aVehicle, int miles)
        {
            // Knows only about the interface. Any IVehicle is supported
            if (aVehicle.FuelRemaining < miles)
            {
                aVehicle.FillUpWithFuel();
            }

            aVehicle.Drive(miles);
        }

        void MethodWhichViolatesLSP(IVehicle aVehicle)
        {
            if (aVehicle is Car)
            {
                var car = aVehicle as Car;
                // Do something special for car - this method is not on the IVehicle interface
                car.ChangeGear();
            }
            // etc.
        }

        public class Car
        {
            public void ChangeGear() { }
        }
    }
}
