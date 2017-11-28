namespace WebApiDemo.Models
{
    public class Pokemon
    {
        public string Name { get; set; }
		public int Evolutions { get; set; }
		public string FavoriteBerry { get; set; }
		public Human Owner { get; set; }

		public string Speak()
		{
			return $"{Name} {Name}";
		}

		public bool Catch(Human human) 
		{
			if (human.Age < this.Evolutions)
				return false;

			this.Owner = human;
			return true;
		}
    }
}