﻿using PKSim.Core.Model;
using PKSim.Core.Services;
using OSPSuite.Core.Extensions;
using OSPSuite.Core.Services;
using OSPSuite.Presentation.UICommands;

namespace PKSim.Presentation.UICommands
{
   public class ExportSimulationResultsToCSVCommand : ActiveObjectUICommand<Simulation>
   {
      private readonly ISimulationExportTask _simulationTask;

      public ExportSimulationResultsToCSVCommand(ISimulationExportTask simulationTask, IActiveSubjectRetriever activeSubjectRetriever) : base(activeSubjectRetriever)
      {
         _simulationTask = simulationTask;
      }

      protected override async void PerformExecute()
      {
         await _simulationTask.SecureAwait(x => x.ExportResultsToCSVAsync(Subject));
      }
   }
}