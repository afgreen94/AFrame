using System;
using Gaming;
using Abstractions.Contracts;
using Gaming.Drivers;

namespace Gaming.Console { public class Program { public static async Task Main(string[] args) => await new DefaultDriver().DriveAsync(args).ConfigureAwait(false); } }
