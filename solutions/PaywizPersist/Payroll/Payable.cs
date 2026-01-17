namespace Payroll
{
    public interface Payable
    {
        float Pay();
        string Name => "NA";
    }
}
