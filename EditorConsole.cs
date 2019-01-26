using System.Windows.Forms;
using Hikari.Library;
using Standard.Types.Monads;
using Standard.WinForms.Controls;
using static Standard.Types.Monads.MonadFunctions;

namespace Hikari
{
	public partial class EditorConsole : UserControl, IInterfaceContext
	{
		IMaybe<TextBoxInterface> textBoxInterface;
		Putter putter;

		public EditorConsole()
		{
			InitializeComponent();

			textBoxInterface = none<TextBoxInterface>();
			putter = new Putter();
		}

		public ExRichTextBox Editor => textEditor;

		public ExRichTextBox Console => textConsole;

		public void Add(Form form)
		{
			textBoxInterface = new TextBoxInterface(form, textConsole).Some();
		}

		public void Print(string value) => textBoxInterface.IfThen(tbi =>
		{
			tbi.Writer.Write(value);
			putter.Reset();
		});

		public void PrintLine(string value) => textBoxInterface.IfThen(tbi =>
		{
			tbi.Writer.WriteLine(value);
			putter.Reset();
		});

		public void Put(string value)
		{
			var result = putter.Put(value);
			textBoxInterface.IfThen(tbi => tbi.Writer.Write(result));
		}

		public IMaybe<string> ReadLine() => textBoxInterface.Map(tbi => tbi.Reader.ReadLine().SomeIfNotNull());

		public bool Cancelled() => false;

		public void Peek(string message, int index) { }
	}
}