﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MicroRabbit.Domain.Core.Events
{
    public abstract class Message : IRequest<bool>
    {
        public string MessageType;
        protected Message()
        {
            MessageType = GetType().Name;
        }
    }
}
