using System.Collections.Generic;
namespace ConsoleApplication.Memento{
    public class History{// CareTaker - State Management
        private Stack<EditorState> statesStack = new Stack<EditorState>();

        public void Push(EditorState state){
            statesStack.Push(state);
        }

        public EditorState Pop(){
            return statesStack.Pop();
        }
    }
}