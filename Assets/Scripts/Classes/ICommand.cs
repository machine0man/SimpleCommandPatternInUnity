namespace Nature
{
    public interface ICommand 
    {
        void Execute();
        void Undo();
    }
}   
