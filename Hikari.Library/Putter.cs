namespace Hikari.Library
{
	public class Putter
	{
		bool putting;

		public Putter() => putting = false;

		public string Put(string value)
		{
			if (putting)
				return $" {value}";
			else
			{
				putting = true;
				return value;
			}
		}

		public void Reset() => putting = false;
	}
}