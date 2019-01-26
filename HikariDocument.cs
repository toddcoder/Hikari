using Standard.WinForms.Documents;

namespace Hikari
{
	public class HikariDocument
	{
		Document document;
		EditorConsole editorConsole;

		public HikariDocument(Document document, EditorConsole editorConsole)
		{
			this.document = document;
			this.editorConsole = editorConsole;
		}

		public Document Document => document;

		public EditorConsole EditorConsole => editorConsole;
	}
}