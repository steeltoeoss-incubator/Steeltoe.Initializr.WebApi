// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using FluentAssertions;
using Xunit;

namespace Steeltoe.InitializrApi.Test
{
    public class ProgramTest
    {
        [Fact]
        public void About()
        {
            var about = new Program.About().GetAbout();
            about.Name.Should().Be("Steeltoe.InitializrApi");
            about.Vendor.Should().Be("SteeltoeOSS/VMware");
            about.Url.Should().Be("https://github.com/SteeltoeOSS/InitializrApi/");
            about.Version.Should().NotBeNull();
            about.Version.Should().StartWith("0.7.0");
            about.Commit.Should().NotBeNull();
            about.Commit.Length.Should().Be(40); // Git SHA string length
        }

    }
}
