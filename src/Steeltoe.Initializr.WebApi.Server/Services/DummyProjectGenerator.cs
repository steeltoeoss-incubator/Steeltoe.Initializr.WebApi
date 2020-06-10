using System.IO;
using System.Text;
using System.Threading.Tasks;
using Steeltoe.Initializr.WebApi.Server.Models;

namespace Steeltoe.Initializr.WebApi.Server.Services
{
	/// <summary>
	/// A project generator that uses the Mustache templating framework.
	/// </summary>
	public class DummyProjectGenerator : IProjectGenerator
	{
		public Task<Stream> GenerateProject(ProjectConfiguration projectConfiguration)
		{
			var bytes = new UnicodeEncoding().GetBytes("DummyProject");
			var stream = new MemoryStream(bytes.Length);
			stream.Write(bytes, 0, bytes.Length);
			stream.Seek(0, SeekOrigin.Begin);
			var result = new TaskCompletionSource<Stream>();
			result.SetResult(stream);
			return result.Task;
		}
	}
}
