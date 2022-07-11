public class Field
{
    public string Content { get; set; }
    public System.ConsoleColor BackColor { get; set; }
    public System.ConsoleColor ForeColor { get; set; }
    public Align ContentAlign;

    public Field() 
    {
        Content = string.Empty;
        BackColor = System.Console.BackgroundColor;
        ForeColor = System.Console.BackgroundColor;
        ContentAlign = Align.Left;
    }

    public string FormatStringCenter(byte size, string stringToFormat,
    char defaultChar)
    {
        string result;
        if(stringToFormat == null) 
        return new string(defaultChar, size);
        //if string to format length equals size then return the same string
        if(stringToFormat.Length == size) return stringToFormat;
        //if string to format length < size then add blank spaces
        if(stringToFormat.Length < size)
        {
            int leftSideLength;//+1
            int rightSideLength;
            float operation = (float)(size - stringToFormat.Length) / 2;

            leftSideLength = (int)operation;
            rightSideLength = (int)operation;
            if(operation % 1 != 0) rightSideLength++;
            result = new string(defaultChar, leftSideLength) + stringToFormat
            + new string(defaultChar, rightSideLength);
        }
        //if not trim string to format
        else
        {
            int rightSideLength = stringToFormat.Length - size;
            result = stringToFormat.Remove(
                stringToFormat.Length - rightSideLength, rightSideLength);
        }
        return result;
    }

    public string FormatStringLeft(byte size, string stringToFormat,
    char defaultChar)
    {
        string result;
        if(stringToFormat == null) 
        return new string(defaultChar, size);
        //if string to format length equals size then return the same string
        if(stringToFormat.Length == size) return stringToFormat;
        //if string to format length < size then add blank spaces
        if(stringToFormat.Length < size)
        {
            int rightSideLength = size - stringToFormat.Length;
            result = stringToFormat
            + new string(defaultChar, rightSideLength);
        }
        //if not trim string to format
        else
        {
            int rightSideLength = stringToFormat.Length - size;
            result = stringToFormat.Remove(
                stringToFormat.Length - rightSideLength, rightSideLength);
        }
        return result;
    }

    public string FormatStringRight(byte size, string stringToFormat,
    char defaultChar)
    {
        string result;
        if(stringToFormat == null) 
        return new string(defaultChar, size);
        //if string to format length equals size then return the same string
        if(stringToFormat.Length == size) return stringToFormat;
        //if string to format length < size then add blank spaces
        if(stringToFormat.Length < size)
        {
            int leftSideLength = size - stringToFormat.Length;
            result = new string(defaultChar, leftSideLength)
            + stringToFormat;
        }
        //if not trim string to format
        else
        {
            int leftSideLength = stringToFormat.Length - size;
            result = stringToFormat.Remove(
                stringToFormat.Length - leftSideLength, leftSideLength);
        }
        return result;
    }
}