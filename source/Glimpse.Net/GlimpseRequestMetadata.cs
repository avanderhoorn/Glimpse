﻿using System;

namespace Glimpse.Net
{
    public class GlimpseRequestMetadata
    {
        public string Json { get; set; }
        public string Browser { get; set; }
        public string ClientName { get; set; }
        public string RequestTime { get; set; }
        public Guid RequestId { get; set; }
        public string IsAjax { get; set; }
    }
}
