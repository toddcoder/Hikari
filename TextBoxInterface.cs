using System.IO;
using System.Windows.Forms;
using Standard.WinForms.Consoles;
using Standard.WinForms.Controls;

namespace Hikari
{
	public class TextBoxInterface
	{
		TextBoxConsole console;
		TextWriter writer;
		TextReader reader;

		public TextBoxInterface(Form form, ExRichTextBox textBox)
		{
			console = new TextBoxConsole(form, textBox);
			writer = console.Writer();
			reader = console.Reader();
		}

		public TextWriter Writer => writer;

		public TextReader Reader => reader;
	}
}