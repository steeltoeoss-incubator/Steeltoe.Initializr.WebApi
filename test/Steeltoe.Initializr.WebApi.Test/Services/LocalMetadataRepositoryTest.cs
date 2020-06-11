using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;
using Steeltoe.Initializr.WebApi.MetadataRepository;
using Steeltoe.Initializr.WebApi.Services;
using Xunit;

namespace Steeltoe.Initializr.WebApi.Test.Services
{
	public class LocalMetadataRepositoryTest
	{
		[Fact]
		public async Task ConfigurationShouldNotBeNull()
		{
			var options = Options.Create(new MetadataRepositoryOptions());
			options.Value.Uri = "initializr-metadata.json";
			var configRepo = new LocalMetadataRepository(new NullLoggerFactory(), options);
			var config = await configRepo.GetConfiguration();
			config.Should().NotBeNull();
		}
	}
}