using System.Collections.Generic;

namespace Memento
{
    public class History
    {
        private Stack<EditorState> EditorStates = new Stack<EditorState>();

        public void Push(EditorState state)
        {
            EditorStates.Push(state);
        }

        public EditorState Pop()
        {
            return EditorStates.Pop();
        }
    }
}
