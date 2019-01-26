namespace Hikari
{
   partial class EditorConsole
   {
      /// <summary> 
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary> 
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.table = new System.Windows.Forms.TableLayoutPanel();
         this.textEditor = new Standard.WinForms.Controls.ExRichTextBox();
         this.textConsole = new Standard.WinForms.Controls.ExRichTextBox();
         this.table.SuspendLayout();
         this.SuspendLayout();
         // 
         // table
         // 
         this.table.ColumnCount = 1;
         this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.table.Controls.Add(this.textEditor, 0, 0);
         this.table.Controls.Add(this.textConsole, 0, 1);
         this.table.Dock = System.Windows.Forms.DockStyle.Fill;
         this.table.Location = new System.Drawing.Point(0, 0);
         this.table.Name = "table";
         this.table.RowCount = 2;
         this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.table.Size = new System.Drawing.Size(617, 562);
         this.table.TabIndex = 0;
         // 
         // textEditor
         // 
         this.textEditor.Dock = System.Windows.Forms.DockStyle.Fill;
         this.textEditor.Location = new System.Drawing.Point(3, 3);
         this.textEditor.Name = "textEditor";
         this.textEditor.Size = new System.Drawing.Size(611, 275);
         this.textEditor.TabIndex = 0;
         this.textEditor.Text = "";
         // 
         // textConsole
         // 
         this.textConsole.Dock = System.Windows.Forms.DockStyle.Fill;
         this.textConsole.Location = new System.Drawing.Point(3, 284);
         this.textConsole.Name = "textConsole";
         this.textConsole.Size = new System.Drawing.Size(611, 275);
         this.textConsole.TabIndex = 1;
         this.textConsole.Text = "";
         // 
         // EditorConsole
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.table);
         this.Name = "EditorConsole";
         this.Size = new System.Drawing.Size(617, 562);
         this.table.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TableLayoutPanel table;
      private Standard.WinForms.Controls.ExRichTextBox textEditor;
      private Standard.WinForms.Controls.ExRichTextBox textConsole;
   }
}
