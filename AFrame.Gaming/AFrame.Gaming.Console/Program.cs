using System;
using Gaming;
using AFrame.Base.Abstractions;
using AFrame.Base.Contracts.Abstractions;
using AFrame.Gaming.Drivers;

namespace Gaming.Console { public class Program { public static async Task Main(string[] args) => await new DefaultDriver().DriveAsync(args).ConfigureAwait(false); } }
