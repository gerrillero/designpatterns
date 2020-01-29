namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var canvas = new Canvas();
            canvas.CurrentTool = ToolType.BRUSH;
            canvas.MouseDown();
            canvas.MouseUp();
        }
    }
}
