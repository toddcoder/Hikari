using Standard.Types.Monads;

namespace Hikari.Library
{
	public interface IInterfaceContext
	{
		void Print(string value);

		void PrintLine(string value);

		void Put(string value);

		IMaybe<string> ReadLine();

		bool Cancelled();

		void Peek(string message, int index);
   }
}