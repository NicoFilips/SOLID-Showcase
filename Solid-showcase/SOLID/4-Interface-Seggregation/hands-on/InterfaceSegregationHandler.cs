using Solid_showcase.Solid._4_Interface_Seggregation;

namespace Solid_showcase.SOLID._4_Interface_Segregation.hands_on
{
    public class InterfaceSegregationHandler
    {
        public void DemonstrateInterfaceSegregation()
        {
            IPrinter printer = new OldPrinter();
            IScanner scanner = new MultiFunctionPrinter();
            IFax fax = new MultiFunctionPrinter();

            printer.Print();
            scanner.Scan();
            fax.Fax();
        }
    }
}