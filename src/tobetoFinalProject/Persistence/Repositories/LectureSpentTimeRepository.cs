using Application.Services.Repositories;
using Domain.Entities;
using Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class LectureSpentTimeRepository : EfRepositoryBase<LectureSpentTime, Guid, BaseDbContext>, ILectureSpentTimeRepository
{
    public LectureSpentTimeRepository(BaseDbContext context) : base(context)
    {
    }
}