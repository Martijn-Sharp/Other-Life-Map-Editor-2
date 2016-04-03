using OtherLife.MapDefinitions.Models;

namespace OtherLife.MapDefinitions.Repository
{
    public interface IMapRepository
    {
        Map Get();

        void Save(Map map);
    }
}
