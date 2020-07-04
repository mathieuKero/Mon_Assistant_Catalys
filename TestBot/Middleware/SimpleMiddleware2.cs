using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TestBot.Middleware
{
    public class SimpleMiddleware2 : IMiddleware
    {
        public async Task OnTurnAsync(ITurnContext turnContext, NextDelegate next, CancellationToken cancellationToken = default)
        {
            await turnContext.SendActivityAsync($"[SimpleMiddleware2] {turnContext.Activity.Type}/OnTurn/Before");

            if(turnContext.Activity.Type == ActivityTypes.Message && turnContext.Activity.Text == "secret password")
            {
                await next(cancellationToken);
            }

            await turnContext.SendActivityAsync($"[SimpleMiddleware2] {turnContext.Activity.Type}/OnTurn/After");
        }
    }
}
