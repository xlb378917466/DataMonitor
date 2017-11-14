﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMonitor.DQ.Infrastructure.DTO
{
    /// <summary>
    /// 实时数据记录实体
    /// </summary>
    public class RealtimeRecord
    {
        public decimal Temperature { get; set; }

        public decimal Humidity { get; set; }

        public string DeviceAddressHex { get; set; }





    }
}
