// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;
using Xunit;

namespace System.IO.Tests
{
    public abstract partial class FileSystemTest
    {
        protected static int geteuid()
        {
            throw new PlatformNotSupportedException();
        }

        protected static int mkfifo(string path, int mode)
        {
            throw new PlatformNotSupportedException();
        }
    }
}
