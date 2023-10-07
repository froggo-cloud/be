using froggo.API.Data;
using froggo.API.Models;
using froggo.API.Repository.IRepository;

namespace froggo.API.Repository;

public class WaterQualityRepository: Repository<WaterQualityData>, IWaterQualityRepository
{
    private WaterQualityDbContext _db;
    public WaterQualityRepository(WaterQualityDbContext db) : base(db)
    {
        _db = db;
    }

    public void Update(WaterQualityData obj)
    {
        _db.WaterQualityDatas?.Update(obj);
    }
    
}