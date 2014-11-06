﻿using DistributeSample.Commands;
using ECommon.Components;
using ENode.Commanding;
using ENode.Infrastructure.Impl;

namespace DistributeSample.CommandProducer.Providers
{
    [Component]
    public class CommandTypeCodeProvider : DefaultTypeCodeProvider<ICommand>
    {
        public CommandTypeCodeProvider()
        {
            RegisterType<CreateNoteCommand>(100);
        }
    }
}
