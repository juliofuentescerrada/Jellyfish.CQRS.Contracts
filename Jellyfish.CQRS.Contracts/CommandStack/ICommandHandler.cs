namespace Jellyfish.CQRS.Contracts.CommandStack
{
    using System.Threading.Tasks;

    public interface ICommandHandler<in TCommand> where TCommand : ICommand
    {
        Task Handle(TCommand command);
    }
}