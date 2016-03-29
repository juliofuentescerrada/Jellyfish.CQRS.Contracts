using System.Threading.Tasks;

namespace Jellyfish.CQRS.Contracts.QueryStack
{
    public interface IQueryDispatcher
    {
        Task<TResult> Dispatch<TResult, TQuery>(TQuery query) where TQuery : IQuery where TResult : IQueryResult;
    }
}