﻿using System;
using System.Collections.Generic;

namespace Abnormalities;

public partial class DbPUser
{
    public string? PosEmpid { get; set; }

    public string? PosUsername { get; set; }

    public string? PosPassword { get; set; }

    public int? PosSecurity { get; set; }

    public int? PosUsertype { get; set; }
}
