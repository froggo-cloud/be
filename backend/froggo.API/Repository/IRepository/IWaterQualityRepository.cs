using froggo.API.Data;
using froggo.API.Models;

namespace froggo.API.Repository.IRepository;

public interface IWaterQualityRepository : IRepository<WaterQualityData>
{
    void Update(WaterQualityData obj);
}