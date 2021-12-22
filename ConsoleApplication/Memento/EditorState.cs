namespace ConsoleApplication.Memento{
    public class EditorState{//Memento
        private readonly string _content;

        public EditorState(string content){
            _content = content;
        }

        public string Content{
            get{
                return _content;
            }
        }
    }
}