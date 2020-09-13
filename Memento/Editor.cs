namespace Memento
{
    public class Editor
    {
        public string Content { get; set; }
        public string FontName { get; set; }
        public string FontSize { get; set; }

        public EditorState CreateState()
        {
            return new EditorState(Content, FontName, FontSize);
        }

        public void RestoreState(EditorState state)
        {
            Content = state.Content;
            FontName = state.FontName;
            FontSize = state.FontSize;
        }

    }
}
