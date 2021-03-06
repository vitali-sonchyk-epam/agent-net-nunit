﻿using System;
using ReportPortal.Client;
using ReportPortal.Client.Requests;
using ReportPortal.Shared.Reporter;

namespace ReportPortal.NUnitExtension.EventArguments
{
    public class TestItemOutputEventArgs : EventArgs
    {
        public TestItemOutputEventArgs(Service service, AddLogItemRequest request, ITestReporter testReporter, string report)
        {
            Service = service;
            AddLogItemRequest = request;
            TestReporter = testReporter;
            Report = report;
        }

        public Service Service { get; }

        public AddLogItemRequest AddLogItemRequest { get; }

        public ITestReporter TestReporter { get; }

        public string Report { get; }

        public bool Canceled { get; set; }
    }
}
