namespace Model
{
    public class Vehiculo
    {
        private string color;
        private int persons;
        private decimal price;

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public int Persons
        {
            get { return this.persons; }
            set { this.persons = value; }
        }
        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
    }
}
