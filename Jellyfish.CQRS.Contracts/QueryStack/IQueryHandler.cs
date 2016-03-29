namespace Jellyfish.CQRS.Contracts.QueryStack
{
    using System.Threading.Tasks;

    public interface IQueryHandler<in TQuery, TResult> where TQuery : IQuery where TResult : IQueryResult
    {
        Task<TResult> Handler(TQuery query);
    }
}