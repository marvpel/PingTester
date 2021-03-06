﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingTester
{
    public static class Strings
    {
        public const string LifeCycleFormNotRunning = "Not running";
        public const string LifeCycleFormRunning = "Running";
        public const string LifeCycleFormStopping = "Stopping... please wait";
        public const string LifeCycleExitError = "Stop execution before closing the application.";

        public const string ImportWarningMessage = "Current data will be overwritten by file data, continue?";
        public const string ChartError = "No data to be charted yet.";
        public const string GenericWarningTitle = "Warning!";
        public const string ExportError = "No data to be exported yet.";
        public const string ParseParameterHostError = "Invalid hostname";
    }
}
