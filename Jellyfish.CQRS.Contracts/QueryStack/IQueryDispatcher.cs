namespace Jellyfish.CQRS.Contracts.QueryStack
{
    public interface IQueryDispatcher
    {
        TResult Dispatch<TResult, TQuery>(TQuery query) where TQuery : IQuery where TResult : IQueryResult;
    }
}