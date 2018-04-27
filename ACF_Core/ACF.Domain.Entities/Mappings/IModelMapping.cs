using Microsoft.EntityFrameworkCore;

namespace ACF.Domain.Entities.Mappings
{
    public interface IModelMapping
    {
        void BuildModelMapping(ModelBuilder modelBuilder);
    }
}
