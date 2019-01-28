using System;
using Standard.Types.Collections;

namespace Hikari.Library.Objects
{
	public struct Int : IObject, IEquatable<Int>
	{
		long value;

		public Int(long value) : this() => this.value = value;

		public string ClassName => "Int";

		public string AsString => value.ToString();

		public string Image => AsString;

		public int Hash => value.GetHashCode();

		public bool IsEqualTo(IObject obj) => obj is Int i && value == i.value;

		public bool Match(IObject source, Hash<string, Binding> bindings) => false;

		public bool IsTrue => value != 0;

		public bool Equals(Int other) => IsEqualTo(other);

		public override bool Equals(object obj) => obj is Int i && IsEqualTo(i);

		public override int GetHashCode() => Hash;
	}
}