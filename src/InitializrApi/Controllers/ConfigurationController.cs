// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Mvc;
using Steeltoe.InitializrApi.Services;
using System.Threading.Tasks;

namespace Steeltoe.InitializrApi.Controllers
{
    /// <summary>
    /// Project generation configuration endpoint.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ConfigurationController : ControllerBase
    {
        private readonly IConfigurationRepository _configurationRepository;

        /// <summary>
        /// Create a new ConfigurationController.
        /// </summary>
        /// <param name="configurationRepository">configuration repository</param>
        public ConfigurationController(IConfigurationRepository configurationRepository)
        {
            _configurationRepository = configurationRepository;
        }

        /// <summary>
        /// Implements <code>GET</code>..
        /// </summary>
        /// <returns>configuration</returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var config = await _configurationRepository.GetConfiguration();
            return Ok(config);
        }
    }
}
