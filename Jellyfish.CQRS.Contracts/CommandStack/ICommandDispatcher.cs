namespace Jellyfish.CQRS.Contracts.CommandStack
{
    public interface ICommandDispatcher
    {
        void Dispatch<TCommand>(TCommand command) where TCommand : ICommand;
    }
}