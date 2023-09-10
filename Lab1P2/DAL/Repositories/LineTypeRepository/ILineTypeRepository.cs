using Domain.Models;

namespace DAL.Repositories.LineTypeRepository;

public interface ILineTypeRepository
{
    public Task Add(LineType lineType);
    public Task Delete(Guid id);
    public Task<LineType> GetById(Guid id);
}