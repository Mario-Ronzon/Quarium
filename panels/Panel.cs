public class Panel
{
    public Label Label1;
    public Label Label2;
    public Label Label3;
    public Label Label4;
    public Label Label5;
    public Label Label6;
    public Radio Radio1;
    public Radio Radio2;
    public Radio Radio3;

    public Panel()
    {
        Label1 = new Label();
        Label2 = new Label();
        Label3 = new Label();
        Label4 = new Label();
        Label5 = new Label();
        Label6 = new Label();
        Radio1 = new Radio();
        Radio2 = new Radio();
        Radio3 = new Radio();
    }

    public void Run()
    {
            Label1.Position.X = 1;
            Label1.Position.Y = 1;
            Label1.Text.BackColor = System.ConsoleColor.Red;
            Label1.Text.ForeColor = System.ConsoleColor.White;
            Label1.Text.Content = "Label";
            Label1.Text.ContentAlign = Align.Center;
            Label1.Size.Width = 20;
            Label1.Draw(string.Empty);

            Label2.Position.X = 25;
            Label2.Position.Y = 1;
            Label2.Text.BackColor = System.ConsoleColor.Red;
            Label2.Text.ForeColor = System.ConsoleColor.White;
            Label2.Text.Content = "Label";
            Label2.Text.ContentAlign = Align.Center;
            Label2.Size.Width = 3;
            Label2.Draw(string.Empty);

            Label3.Position.X = 1;
            Label3.Position.Y = 3;
            Label3.Text.BackColor = System.ConsoleColor.Red;
            Label3.Text.ForeColor = System.ConsoleColor.White;
            Label3.Text.Content = "Label";
            Label3.Text.ContentAlign = Align.Left;
            Label3.Size.Width = 20;
            Label3.Draw(string.Empty);

            Label4.Position.X = 25;
            Label4.Position.Y = 3;
            Label4.Text.BackColor = System.ConsoleColor.Red;
            Label4.Text.ForeColor = System.ConsoleColor.White;
            Label4.Text.Content = "Label";
            Label4.Text.ContentAlign = Align.Left;
            Label4.Size.Width = 3;
            Label4.Draw(string.Empty);

            Label5.Position.X = 1;
            Label5.Position.Y = 5;
            Label5.Text.BackColor = System.ConsoleColor.Red;
            Label5.Text.ForeColor = System.ConsoleColor.White;
            Label5.Text.Content = "Label";
            Label5.Text.ContentAlign = Align.Right;
            Label5.Size.Width = 20;
            Label5.Draw(string.Empty);

            Label6.Position.X = 25;
            Label6.Position.Y = 5;
            Label6.Text.BackColor = System.ConsoleColor.Red;
            Label6.Text.ForeColor = System.ConsoleColor.White;
            Label6.Text.Content = "Label";
            Label6.Text.ContentAlign = Align.Right;
            Label6.Size.Width = 3;
            Label6.Draw(string.Empty);

            Radio1.Position.X = 1;
            Radio1.Position.Y = 8;
            Radio1.RadioChar.ForeColor = System.ConsoleColor.Blue;
            Radio1.RadioChar.BackColor = System.ConsoleColor.DarkGray;
            Radio1.RadioChar.Content = "";
            Radio1.Text.ForeColor = System.ConsoleColor.White;
            Radio1.Text.BackColor = System.ConsoleColor.Black;
            Radio1.Text.Content = "Radio text";
            Radio1.Text.ContentAlign = Align.Right;
            Radio1.Size.Width = 20;
            Radio1.Draw(string.Empty);

            Radio2.Position.X = 1;
            Radio2.Position.Y = 10;
            Radio2.RadioChar.ForeColor = System.ConsoleColor.Blue;
            Radio2.RadioChar.BackColor = System.ConsoleColor.DarkGray;
            Radio2.RadioChar.Content = "";
            Radio2.Text.ForeColor = System.ConsoleColor.White;
            Radio2.Text.BackColor = System.ConsoleColor.Black;
            Radio2.Text.Content = "Radio text";
            Radio2.Text.ContentAlign = Align.Center;
            Radio2.Size.Width = 20;
            Radio2.Draw(string.Empty);

            Radio3.Position.X = 1;
            Radio3.Position.Y = 12;
            Radio3.RadioChar.ForeColor = System.ConsoleColor.Blue;
            Radio3.RadioChar.BackColor = System.ConsoleColor.DarkGray;
            Radio3.RadioChar.Content = "";
            Radio3.Text.ForeColor = System.ConsoleColor.White;
            Radio3.Text.BackColor = System.ConsoleColor.Black;
            Radio3.Text.Content = "Radio text";
            Radio3.Text.ContentAlign = Align.Left;
            Radio3.Size.Width = 20;
            Radio3.Draw(string.Empty);
            System.Console.WriteLine("");
    }
}