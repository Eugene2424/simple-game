namespace Game.Application
{
    public interface ICommandMediator
    {
        public void Execute<T>() where T : ICommand;
    }
}