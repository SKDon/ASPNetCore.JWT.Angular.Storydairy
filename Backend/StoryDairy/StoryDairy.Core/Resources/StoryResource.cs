﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StoryDairy.Core.Resources
{
    public class StoryResource
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime ? DateTime { get; set; }
        public string UserId { get; set; }
    }
}
