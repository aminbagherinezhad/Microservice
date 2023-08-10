using System;
using System.Collections.Generic;

namespace ServerSide.Grpc.Models;

public partial class LogMessageReciver
{
    public int Id { get; set; }

    public string MessageLogs { get; set; } = null!;
}
