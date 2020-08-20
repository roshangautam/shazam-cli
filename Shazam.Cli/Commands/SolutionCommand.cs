﻿using McMaster.Extensions.CommandLineUtils;

namespace Shazam.Cli.Commands
{
    [Command(Name = "solution", Description = "Commands to interact with a power platform solution")]
    [Subcommand(typeof(PullCommand))]
    [Subcommand(typeof(PushCommand))]
    public class SolutionCommand
    {
        public void OnExecute(CommandLineApplication app)
        {
            app.ShowHelp();
        }
    }
}
