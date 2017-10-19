﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WhackAMole.MoleCloud.Models;
using WhackAMole.MoleCloud.Services.Models;

namespace WhackAMole.MoleCloud.Services
{
    internal interface IPodsRequest : IKubeRequest
    {
        Task<KubePod[]> GetAllAsync(string appname = "");
    }

   
}
