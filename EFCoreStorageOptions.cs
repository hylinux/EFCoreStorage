using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreStorage;

public class EFCoreStorageOptions
{
    /// <summary>
    /// Gets or sets the connection string to use while creating BotDataContext.
    /// </summary>
    public string? ConnectionString { get; set; }

    /// <summary>
    /// Gets or sets the transaction isolation level to use during write operations.
    /// </summary>
    /// <remarks>
    /// Default IsolationLevel.ReadCommitted
    /// </remarks>
    public IsolationLevel TransactionIsolationLevel => IsolationLevel.ReadCommitted;

}
