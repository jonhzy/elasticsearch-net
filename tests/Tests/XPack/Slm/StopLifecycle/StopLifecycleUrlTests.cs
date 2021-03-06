﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework.EndpointTests;
using static Tests.Framework.EndpointTests.UrlTester;

namespace Tests.XPack.Slm.StopLifecycle
{
	public class StopLifecycleUrlTests : UrlTestsBase
	{
		[U] public override async Task Urls() =>
			await POST("/_slm/stop")
				.Fluent(c => c.SnapshotLifecycleManagement.Stop())
				.Request(c => c.SnapshotLifecycleManagement.Stop(new StopSnapshotLifecycleManagementRequest()))
				.FluentAsync(c => c.SnapshotLifecycleManagement.StopAsync())
				.RequestAsync(c => c.SnapshotLifecycleManagement.StopAsync(new StopSnapshotLifecycleManagementRequest()));
	}
}
