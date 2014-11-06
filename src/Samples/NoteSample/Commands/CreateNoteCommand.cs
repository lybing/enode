﻿using System;
using ENode.Commanding;

namespace NoteSample.Commands
{
    [Serializable]
    public class CreateNoteCommand : AggregateCommand<string>, ICreatingAggregateCommand
    {
        public string Title { get; private set; }

        public CreateNoteCommand(string noteId, string title) : base(noteId)
        {
            Title = title;
        }
    }
}
