﻿using System;
using System.Reflection;
using System.Runtime.CompilerServices;

#if DEBUG
[assembly: InternalsVisibleTo("DevExtreme.AspNet.Data.Tests")]
#endif

[assembly: CLSCompliant(true)]

#if !DEBUG
[assembly: AssemblyKeyFile("release.snk")]
#endif