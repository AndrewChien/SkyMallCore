﻿using SkyMallCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkyMallCore.Services
{
    public interface ISysUserService
    {
        IList<SysUser> GetUsers();
    }
}
