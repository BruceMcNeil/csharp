namespace Animals {
    public class TestGetSet {

        public void CheckEnumGetSet() {

            JetSet jetSetInstance = new JetSet();

            Console.WriteLine("initial value is {0}", jetSetInstance.manufacturer);
            Console.WriteLine("let's try to set manufacturer to Bombardier, should fail");
            try {
                jetSetInstance.manufacturer = AirPlaneManufacturers.Bombardier;
            }
            catch (Exception e) {
  
            }
            finally {
                Console.WriteLine("Result of set to Bombardier is {0}", jetSetInstance.manufacturer);
            }

            try {
                Console.WriteLine("Let's try setting mfg to Airbus");
                jetSetInstance.manufacturer = AirPlaneManufacturers.Airbus;
            } catch (Exception e) {
              Console.WriteLine("jetSetInstance threw an error: {0} : {1}", e.Message, e.InnerException);
            }
            finally {
                Console.WriteLine("Result of set to Airbus is {0}", jetSetInstance.manufacturer);
            }            
        }
    }
}