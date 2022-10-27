using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Wolverine.Transports;

public interface IBrokerQueue : IBrokerEndpoint
{
    ValueTask PurgeAsync(ILogger logger);
    ValueTask<Dictionary<string, string>> GetAttributesAsync();
}