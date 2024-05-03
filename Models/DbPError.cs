using System;
using System.Collections.Generic;

namespace Abnormalities;

public partial class DbPError
{
    public int? PosCode { get; set; }

    public int? PosNamecode { get; set; }

    public string? PosShortmsg { get; set; }

    public string? PosMessage { get; set; }
}
