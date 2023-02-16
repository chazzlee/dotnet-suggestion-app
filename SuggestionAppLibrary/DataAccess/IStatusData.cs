using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuggestionAppLibrary.DataAccess;

public interface IStatusData
{
    Task CreateStatus(StatusModel status);
    Task<List<StatusModel>> GetStatusesAsync();
}

