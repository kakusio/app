﻿using System.Collections.Generic;
using System.Linq;

namespace app.web.core
{
  public class CommandRegistry : IFindCommands
  {
    IEnumerable<IProcessASingleRequest> all_commands;
      private IProcessASingleRequest missing_command;

      public CommandRegistry(IProcessASingleRequest missingCommand, IEnumerable<IProcessASingleRequest> allCommands)
      {
          missing_command = missingCommand;
          all_commands = allCommands;
      }

      public IProcessASingleRequest get_the_command_that_can_process(IProvideDetailsToCommands the_request)
    {
          var command_can_proccess_the_request = all_commands.FirstOrDefault(x => x.can_process(the_request));

          return command_can_proccess_the_request ?? missing_command; 
    }
  }
}