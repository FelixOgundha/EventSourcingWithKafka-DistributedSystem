﻿using CQRS.Core.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post.Common.Events
{
    public class PostRemovedEvent : BaseEvent
    {
        public PostRemovedEvent() : base(nameof(PostRemovedEvent))
        {
        }
    }
}
