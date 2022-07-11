public class Control
{
    public Position Position { get; private set; }
    public Size Size { get; private set; }
    public bool Enabled { get; set; }
    public bool Visible { get; set; }

    /*public virtual void Draw (string args) { }
    public virtual void Enter(string args) { }
    public virtual void Leave(string args) { }
    public virtual void Action(string args) { }*/
    public delegate void DrawDelegate(string args);
    public delegate void EnterDelegate(string args);
    public delegate void LeaveDelegate(string args);
    public delegate void VisibleDelegate(string args);

    public Control()
    {
        this.Position = new Position();
        this.Size = new Size();
        this.Visible = true;
        this.Enabled = true;
    }
}