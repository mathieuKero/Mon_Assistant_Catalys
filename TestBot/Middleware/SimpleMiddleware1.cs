using Microsoft.Bot.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TestBot.Middleware
{
    public class SimpleMiddleware1 : IMiddleware
    {
        public async Task OnTurnAsync(ITurnContext turnContext, NextDelegate next, CancellationToken cancellationToken = default)
        {
            await turnContext.SendActivityAsync($"[SimpleMiddleware1] {turnContext.Activity.Type}/OnTurn/Before");

            await next(cancellationToken);

            await turnContext.SendActivityAsync($"[SimpleMiddleware1] {turnContext.Activity.Type}/OnTurn/After");
        }
    }
}
