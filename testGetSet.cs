namespace Animals {
    public class TestGetSet {

        public void CheckEnumGetSet() {

            JetSet jetSetInstance = new JetSet();

            Console.WriteLine("\n\n\t\t\tTestGetSet.CheckEnumGetSet: initial value is {0}", jetSetInstance.manufacturer);
            Console.WriteLine("\t\t\tlet's try to set manufacturer to Bombardier, should fail");
            try {
                jetSetInstance.manufacturer = AirPlaneManufacturers.Bombardier;
            }
            catch (Exception e) {
              Console.WriteLine("\t\t\tjetSetInstance threw an error: {0} : {1}", e.Message, e.InnerException);  
            }
            finally {
                Console.WriteLine("\t\t\tResult of set to Bombardier is {0}", jetSetInstance.manufacturer);
            }

            try {
                Console.WriteLine("\t\t\tLet's try setting mfg to Airbus");
                jetSetInstance.manufacturer = AirPlaneManufacturers.Airbus;
            } catch (Exception e) {
              Console.WriteLine("\t\t\tjetSetInstance threw an error: {0} : {1}", e.Message, e.InnerException);
            }
            finally {
                Console.WriteLine("\t\t\tResult of set to Airbus is {0}\n", jetSetInstance.manufacturer);
            }            
        }

        public void CheckPreProcessorSetter() {
            JetSet jetSetInstance = new JetSet();

            Console.WriteLine("\n\t\t\tTestGetSet.CheckEPreProcessorSetter: initial value is {0} {1}", jetSetInstance.firstName, jetSetInstance.lastName);
            Console.WriteLine("\t\t\tlet's use mixed upper and lower case first name and last name -- should get capitalized by setter ...");
            try {
                jetSetInstance.firstName = "Bruce";
                jetSetInstance.lastName = "McNeil";
            }
            catch (Exception e) {
              Console.WriteLine("\t\t\tjetSetInstance threw an error: {0} : {1}", e.Message, e.InnerException);  
            }
            finally {
                Console.WriteLine("\t\t\tResult of set to Bruce McNeil is {0} {1}", jetSetInstance.firstName, jetSetInstance.lastName);
            }            
        }
    }
}