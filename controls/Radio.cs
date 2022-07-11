public class Radio : Control
{
    public Field RadioChar;
    public Field Text;
    public bool Checked;

    public DrawDelegate Draw { get; set; } = default!;

    public Radio()
    {
        RadioChar = new Field();
        Text = new Field();
        Draw = DrawRadio;
    }

    public void DrawRadio(string args)
    {
        string content = string.Empty;

        System.Console.SetCursorPosition(Position.X, Position.Y);
        System.Console.BackgroundColor = RadioChar.BackColor;
        System.Console.ForegroundColor = RadioChar.ForeColor;
        System.Console.Write(RadioChar.Content);
        System.Console.ResetColor();

        switch(Text.ContentAlign)
        {
            case Align.Center:
            content = 
            Text.FormatStringCenter((byte)(Size.Width - 2), Text.Content, ' ');
            break;
            case Align.Left:
            content = 
            Text.FormatStringLeft((byte)(Size.Width - 2), Text.Content, ' ');
            break;
            case Align.Right:
            content = 
            Text.FormatStringRight((byte)(Size.Width - 2), Text.Content, ' ');
            break;
        }
        System.Console.BackgroundColor = Text.BackColor;
        System.Console.ForegroundColor = Text.ForeColor;
        System.Console.Write(' ' + content);
        System.Console.ResetColor();
        //alineacion vertical y horizontal asi como wrap y tamaño dinamico
        //visible y enabled
    }
}