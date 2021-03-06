using Elastic.Xunit.XunitPlumbing;
using Nest;

namespace Examples.Ilm
{
	public class UpdateLifecyclePolicyPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		public void Line29()
		{
			// tag::0c44088f251488432966131135f1bd1c[]
			var response0 = new SearchResponse<object>();
			// end::0c44088f251488432966131135f1bd1c[]

			response0.MatchesExample(@"PUT _ilm/policy/my_policy
			{
			  ""policy"": {
			    ""phases"": {
			      ""hot"": {
			        ""actions"": {
			          ""rollover"": {
			            ""max_size"": ""25GB""
			          }
			        }
			      },
			      ""delete"": {
			        ""min_age"": ""30d"",
			        ""actions"": {
			          ""delete"": {}
			        }
			      }
			    }
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line60()
		{
			// tag::2c37ed0b33658d73a712e7942ea7433a[]
			var response0 = new SearchResponse<object>();
			// end::2c37ed0b33658d73a712e7942ea7433a[]

			response0.MatchesExample(@"PUT _ilm/policy/my_policy
			{
			  ""policy"": {
			    ""phases"": {
			      ""hot"": {
			        ""actions"": {
			          ""rollover"": {
			            ""max_size"": ""25GB""
			          }
			        }
			      },
			      ""delete"": {
			        ""min_age"": ""10d"", \<1>
			        ""actions"": {
			          ""delete"": {}
			        }
			      }
			    }
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line142()
		{
			// tag::fc541f5741c1fe052439ededa84ffe8a[]
			var response0 = new SearchResponse<object>();
			// end::fc541f5741c1fe052439ededa84ffe8a[]

			response0.MatchesExample(@"PUT _ilm/policy/my_executing_policy
			{
			  ""policy"": {
			    ""phases"": {
			      ""hot"": {
			        ""actions"": {
			          ""rollover"": {
			            ""max_docs"": 1
			          }
			        }
			      },
			      ""delete"": {
			        ""min_age"": ""10d"",
			        ""actions"": {
			          ""delete"": {}
			        }
			      }
			    }
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line182()
		{
			// tag::0f6fa3a706a7c17858d3dbe329839ea6[]
			var response0 = new SearchResponse<object>();
			// end::0f6fa3a706a7c17858d3dbe329839ea6[]

			response0.MatchesExample(@"GET my_index/_ilm/explain");
		}

		[U(Skip = "Example not implemented")]
		public void Line225()
		{
			// tag::f94601bc9cd640adb939af67116a40c8[]
			var response0 = new SearchResponse<object>();
			// end::f94601bc9cd640adb939af67116a40c8[]

			response0.MatchesExample(@"PUT _ilm/policy/my_executing_policy
			{
			  ""policy"": {
			    ""phases"": {
			      ""hot"": {
			        ""min_age"": ""1d"", \<1>
			        ""actions"": {
			          ""rollover"": {
			            ""max_docs"": 1
			          }
			        }
			      },
			      ""delete"": {
			        ""min_age"": ""10d"",
			        ""actions"": {
			          ""delete"": {}
			        }
			      }
			    }
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line304()
		{
			// tag::416c65c55a53d0161426cc09ae999c72[]
			var response0 = new SearchResponse<object>();
			// end::416c65c55a53d0161426cc09ae999c72[]

			response0.MatchesExample(@"PUT _ilm/policy/my_executing_policy
			{
			  ""policy"": {
			    ""phases"": {
			      ""warm"": {
			        ""min_age"": ""1d"",
			        ""actions"": {
			          ""forcemerge"": {
			            ""max_num_segments"": 1
			          }
			        }
			      },
			      ""delete"": {
			        ""min_age"": ""10d"",
			        ""actions"": {
			          ""delete"": {}
			        }
			      }
			    }
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line494()
		{
			// tag::552b6761ef052efa1e83f8a3c30d6f78[]
			var response0 = new SearchResponse<object>();
			// end::552b6761ef052efa1e83f8a3c30d6f78[]

			response0.MatchesExample(@"PUT my_index/_settings
			{
			  ""lifecycle.name"": ""my_other_policy""
			}");
		}
	}
}