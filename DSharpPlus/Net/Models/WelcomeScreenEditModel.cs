﻿using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSharpPlus.Net.Models
{
    public class WelcomeScreenEditModel
    {
        /// <summary>
        /// Sets whether the welcome screen should be enabled.
        /// </summary>
        public Optional<bool> Enabled { internal get; set; }

        /// <summary>
        /// Sets the welcome channels.
        /// </summary>
        public Optional<IEnumerable<DiscordGuildWelcomeScreenChannel>> WelcomeChannels { internal get; set; }

        /// <summary>
        /// Sets the serer description shown.
        /// </summary>
        public Optional<string> Description { internal get; set; }
    }
}
