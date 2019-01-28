using System;
using Standard.Types.Collections;

namespace Hikari.Library.Objects
{
	public struct Selector : IObject
	{
		public string ClassName => "Selector";

		public string AsString { get; }

		public string Image { get; }

		public int Hash { get; }

		public bool IsEqualTo(IObject obj) => TODO_IMPLEMENT_ME;

		public bool Match(IObject source, Hash<string, Binding> bindings) => TODO_IMPLEMENT_ME;

		public bool IsTrue { get; }
	}
}