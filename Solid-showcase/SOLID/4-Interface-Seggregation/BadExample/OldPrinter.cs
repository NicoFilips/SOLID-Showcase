namespace Solid_showcase.Solid._4_Interface_Seggregation.BadExample;

public class OldPrinter : IMachine
{
    public void Print() { /* implement */ }
    public void Scan() { throw new NotImplementedException(); }  // Unsupported
    public void Fax() { throw new NotImplementedException(); }   // Unsupported
}