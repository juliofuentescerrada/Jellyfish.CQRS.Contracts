namespace Jellyfish.CQRS.Contracts.CommandStack
{
    using System.Threading.Tasks;

    public interface ICommandDispatcher
    {
        Task Dispatch<TCommand>(TCommand command) where TCommand : ICommand;
    }
}