namespace ConsoleApplication.Memento{
    public class Editor{
        public string Content{get;set;}

        public EditorState CreateState(){
            return new EditorState(Content);
        }

        public void RestoreState(EditorState state){
            Content = state.Content;
        }
    }
}