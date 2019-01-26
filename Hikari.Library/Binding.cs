using Hikari.Library.Objects;

namespace Hikari.Library
{
	public class Binding
	{
		public Binding(IObject value, bool mutable, bool existing)
		{
			Value = value;
			Mutable = mutable;
			Existing = existing;
		}

		public IObject Value { get; set; }

		public bool Mutable { get; }

		public bool Existing { get; }
	}
}