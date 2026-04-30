namespace ConsoleApp1
{
    public class Customer
    {
        private int id;
        private string name;
        private int phoneNumber;

        public Customer(int id, string name, int phoneNumber)
        {
            this.id = id;
            this.name = name;
            this.phoneNumber = phoneNumber;
        }
        // get/set
        public int GetId() { return id; }
        public void SetId(int id) { this.id = id; }

        public string GetName() { return name; }
        public void SetName(string name) { this.name = name; }

        public int GetPhoneNumber() { return phoneNumber; }
        public void SetPhoneNumber(int phoneNumber) { this.phoneNumber = phoneNumber; }

        public void PrintDetails()
        {
            Console.WriteLine($"ID: {id}, Name: {name}, Phone: {phoneNumber}");
        }
    }
}