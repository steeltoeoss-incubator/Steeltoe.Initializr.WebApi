// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

namespace Steeltoe.InitializrApi.Models
{
    /// <summary>
    /// A model of the specification used to generate a project.
    /// </summary>
    public sealed class ProjectSpecification
    {
        /// <summary>
        /// Gets or sets the project name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the project description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the Steeltoe version.
        /// </summary>
        public string SteeltoeVersion { get; set; }

        public string DotnetFrameworkTargetId { get; set; }

        public string DotnetTemplateId { get; set; }

        public string DotnetLanguageId { get; set; }

        public override string ToString()
        {
            return $"[name={Name}]";
        }
    }
}
