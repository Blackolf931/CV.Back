namespace CV.BLL.Interfaces
{
    public interface IGenericServices<TModel> where TModel : class
    {
        Task<IEnumerable<TModel>> GetAll(CancellationToken ct);

        Task<TModel> GetById(int id, CancellationToken ct);

        Task<TModel> Create(TModel model, CancellationToken ct);

        Task<TModel> Update(TModel model, CancellationToken ct);

        Task DeleteById(int id, CancellationToken ct);
    }
}
