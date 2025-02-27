﻿using Dignus.Collections;
using Macro.Models;
using System.Diagnostics;
using System.Threading;

namespace Macro.Infrastructure.Interfaces
{
    internal interface IMacroModeController
    {
        void Execute(
            ArrayQueue<Process> processes,
            ArrayQueue<EventTriggerModel> eventTriggerModels,
            CancellationToken cancellationToken);
    }
}
