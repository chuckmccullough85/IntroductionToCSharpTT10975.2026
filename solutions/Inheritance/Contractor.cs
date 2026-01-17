
namespace Payroll
{
    public class Contractor : HumanResource
    {
        public Contractor(string name, int id, float rate) 
        {
            Name = name;
            Id = id;
            PayRate= rate;
        }

        public float PayRate { get; set; }

        public override float Pay()
        {
            return PayRate * 40;
        }
    }
}
