public class Label : Control
{
    public Field Text { get; set; }
    public DrawDelegate Draw { get; set; } = default!;

    public Label()
    {
        Text = new Field();
        Draw = DrawLabel;
    }

    public void DrawLabel(string args)
    {
        string content = string.Empty;
        System.Console.SetCursorPosition(Position.X, Position.Y);
        System.Console.BackgroundColor = Text.BackColor;
        System.Console.ForegroundColor = Text.ForeColor;
        switch(Text.ContentAlign)
        {
            case Align.Center:
            content = Text.FormatStringCenter(Size.Width, Text.Content, ' ');
            break;
            case Align.Left:
            content = Text.FormatStringLeft(Size.Width, Text.Content, ' ');
            break;
            case Align.Right:
            content = Text.FormatStringRight(Size.Width, Text.Content, ' ');
            break;
        }
        System.Console.Write(content);
        System.Console.ResetColor();
        //alineacion vertical y horizontal asi como wrap y tamaño dinamico
        //visible y enabled
    }
}