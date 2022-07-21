namespace Tasks_1
{
    using System.Text;

    public class MovieStar
    {
        public string DateOfBirth { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public string Nationality { get; set; }

        public override string ToString()
        {
            var birthToDate = DateTime.Parse(this.DateOfBirth);
            var year = birthToDate.Year;
            var yearsOld = DateTime.Now.Year - year;
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Name} {this.Surname}");
            sb.AppendLine($"{this.Sex}");
            sb.AppendLine($"{this.Nationality}");
            sb.AppendLine($"{yearsOld} years old");

            return sb.ToString();
        }
    }
}
