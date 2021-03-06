using Elastic.Xunit.XunitPlumbing;
using Nest;

namespace Examples.Ccr.Apis.Follow
{
	public class PutFollowPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		public void Line25()
		{
			// tag::73646c12ad33a813ab2280f1dc83500e[]
			var response0 = new SearchResponse<object>();
			// end::73646c12ad33a813ab2280f1dc83500e[]

			response0.MatchesExample(@"PUT /<follower_index>/_ccr/follow?wait_for_active_shards=1
			{
			  ""remote_cluster"" : ""<remote_cluster>"",
			  ""leader_index"" : ""<leader_index>""
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line88()
		{
			// tag::c1f565c68d7bfce4a4251c7919444977[]
			var response0 = new SearchResponse<object>();
			// end::c1f565c68d7bfce4a4251c7919444977[]

			response0.MatchesExample(@"PUT /follower_index/_ccr/follow?wait_for_active_shards=1
			{
			  ""remote_cluster"" : ""remote_cluster"",
			  ""leader_index"" : ""leader_index"",
			  ""max_read_request_operation_count"" : 1024,
			  ""max_outstanding_read_requests"" : 16,
			  ""max_read_request_size"" : ""1024k"",
			  ""max_write_request_operation_count"" : 32768,
			  ""max_write_request_size"" : ""16k"",
			  ""max_outstanding_write_requests"" : 8,
			  ""max_write_buffer_count"" : 512,
			  ""max_write_buffer_size"" : ""512k"",
			  ""max_retry_delay"" : ""10s"",
			  ""read_poll_timeout"" : ""30s""
			}");
		}
	}
}