using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TestBot.Bots
{
    public class SimpleBot : IBot
    {
        public async Task OnTurnAsync(ITurnContext turnContext, CancellationToken cancellationToken = default)
        {
            //if(turnContext.Activity.Type is ActivityTypes.Message)
            //{
            //    string input = turnContext.Activity.Text;
            //    await turnContext.SendActivityAsync($"SimpleBot : {input}");
            //}            

            await turnContext.SendActivityAsync($"[SimpleBot] {turnContext.Activity.Type}/onTurn");
        }
    }
}
