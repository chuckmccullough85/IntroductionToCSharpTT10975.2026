using Location;

namespace Payroll
{
    public class HumanResource : Payable
    {
        private int _id;
        private string _name = string.Empty;
        public DateTime DateOfBirth { get; set; }

        public Address? HomeAddress { get; set; }
        public int Id
        { get => _id; set => _id = value; }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public override bool Equals(object? obj)
        {
            return obj is Employee employee &&
                   _name == employee._name &&
                   _id == employee._id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_name, _id);
        }
        public virtual float Pay() => 0; 
    }
}