namespace Animals {
    public enum AirPlaneManufacturers {
        Boeing = 0,
        Airbus = 1,
        Lockheed,
        Bombardier,
        Ilyushin,
    }
    public class JetSet {
        private AirPlaneManufacturers _mfg = AirPlaneManufacturers.Boeing;
        public AirPlaneManufacturers manufacturer {
            get {
                Console.WriteLine("\t\t\tJetSet: somebody getting the manufacturer property!");
                Console.WriteLine("\t\t\tJetSet: I could set a breakpoint here in my debugger to catch this.");
                return _mfg;
            }
            set {
                Console.WriteLine("\t\t\tJetSet: again I can set a breakpoint here to catch nasty code accessing  my stuff");
                Console.WriteLine("\t\t\tJetSet: Lets say we want to prevent Ilyushin and Bombardier as valid manufacturers. We can do that in the setter.");
                switch (value) {
                    case AirPlaneManufacturers.Boeing:
                    case AirPlaneManufacturers.Airbus:
                    case AirPlaneManufacturers.Lockheed:
                        // these are exceptable
                        _mfg = value;
                        break;
                    default:
                        throw new ArgumentException("JetSet: invalid manufacturer: " + value);
                }
                // the throw above will return to the invoker of the set.  The following code will not execute in that case
                _mfg = value;
            }
        }

        private string _firstName = "";
        public string firstName { 
            get { return _firstName; } 
            set { _firstName = value.ToString().ToUpper();}
        }
        private string _lastName = "";
        public string lastName { 
            get { return _lastName;}  
            set {
                _lastName = value.ToString().ToUpper();
            }
        }
    }
}
