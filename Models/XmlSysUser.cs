﻿using System;
using System.Collections.Generic;

namespace Abnormalities;

public partial class XmlSysUser
{
    public string? EpoCode { get; set; }

    public string? EpoUsername { get; set; }

    public string? EpoPassword { get; set; }

    public int? EpoSecurity { get; set; }

    public int? EpoUsertype { get; set; }
}