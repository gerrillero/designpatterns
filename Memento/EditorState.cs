namespace Memento
{
    public class EditorState
    {
        public string Content { get; }
        public string FontName { get; }
        public string FontSize { get; }

        public EditorState(string content, string fontName, string fontSize)
        {
            Content = content;
            FontName = fontName;
            FontSize = fontSize;
        }

    }
}
