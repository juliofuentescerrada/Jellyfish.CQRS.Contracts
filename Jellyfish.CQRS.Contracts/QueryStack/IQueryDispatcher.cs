namespace Jellyfish.CQRS.Contracts.QueryStack
{
    using System.Threading.Tasks;

    public interface IQueryDispatcher
    {
        Task<TResult> Dispatch<TResult, TQuery>(TQuery query) where TQuery : IQuery where TResult : IQueryResult;
    }
}