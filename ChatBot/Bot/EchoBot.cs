using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;

namespace ChatBot.Bot
{
    public class EchoBot : IBot
    {   
        //Echos what the user sends
        public async Task OnTurn(ITurnContext turnContext)
        {
            if (turnContext.Activity.Type is ActivityTypes.Message)
            {
                string input = turnContext.Activity.Text;

                await turnContext.SendActivity($"EchoBot: \"{input}\" String lenght is {input.Length}");
            }
        }
    }
}
