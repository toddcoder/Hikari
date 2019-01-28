using Standard.Types.Collections;

namespace Hikari.Library.Objects
{
	public interface IObject
	{
		string ClassName { get; }

		string AsString { get; }

		string Image { get; }

		int Hash { get; }

		bool IsEqualTo(IObject obj);

		bool Match(IObject source, Hash<string, Binding> bindings);

		bool IsTrue { get; }
   }
}