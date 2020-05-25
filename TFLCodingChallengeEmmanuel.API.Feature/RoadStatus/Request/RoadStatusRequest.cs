using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TFLCodingChallengeEmmanuel.API.Feature.RoadStatus.Request
{
    public class RoadStatusRequest
    {
        [Required]
        public string Id { get; set; }

        public string AppId { get; set; }

        public string AppKey { get; set; }

        public string BaseUrl { get; set; }

    }
}
