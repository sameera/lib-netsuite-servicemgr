﻿using FluentAssertions;
using SuiteTalk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Celigo.ServiceManager.NetSuite.Meta;
using Xunit;

using Task = System.Threading.Tasks.Task;

namespace Tests.Celigo.ServiceManager.NetSuite.Retries
{
    public class RetryWithPollyTest
    {
        [Fact]
        public async Task Retries_multiple_times_when_concurrent_error_is_encountered()
        {
            var config = new TestConfiguration();
            var client = new PollyClientFactory(config.ApplicationId)
                .CreateClient(config.PassportProvider)
                as PollyNetSuiteClient;

            client.Should().NotBeNull();

            var tasks = new Task<SearchResult>[6];
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = client.searchAsync(new EmployeeSearchBasic());
            }

            var result = await System.Threading.Tasks.Task.WhenAll(tasks);

            client.UnsuccessfulStatuses.Should().NotBeEmpty();
            result.All(r => r.status.isSuccess).Should().BeTrue();
        }
    }
}