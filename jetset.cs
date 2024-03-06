namespace Animals {
    public enum AirPlaneManufacturers {
        Boeing = 0,
        Airbus = 1,
        Lockheed,
        Bombardier,
        Ilyushin,
    }
    public class JetSet {
        private AirPlaneManufacturers _mfg = AirPlaneManufacturers.Boeing;;
        public AirPlaneManufacturers manufacturer {
            get {
                Console.WriteLine("somebody getting the manufacturer property!");
                Console.WriteLine("I could set a breakpoint here in my debugger to catch this.");
                return _mfg;
            }
            set {
                Console.WriteLine("again I can set a breakpoint here to catch nasty code accessing  my stuff");
                Console.WriteLine("Lets say we want to prevent Ilyushin and Bombardier as valid manufacturers. We can do that in the setter.");
                switch (value) {
                    case AirPlaneManufacturers.Boeing:
                    case AirPlaneManufacturers.Airbus:
                    case AirPlaneManufacturers.Lockheed:
                        // these are exceptable
                        _mfg = value;
                        break;
                    default:
                        throw new ArgumentException("invalid manufacturer: " + value);
                }
                // the throw above will return to the invoker of the set.  The following code will not execute in that case
                _mfg = value;
            }
        }
    }
}
