namespace Jellyfish.CQRS.Contracts.QueryStack
{
    public interface IQueryHandler<in TQuery, out TResult> where TQuery : IQuery where TResult : IQueryResult
    {
        TResult Handler(TQuery query);
    }
}