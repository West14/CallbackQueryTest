using BotFramework;
using BotFramework.Attributes;
using BotFramework.Enums;
using Telegram.Bot;
using Telegram.Bot.Types.ReplyMarkups;

namespace CallbackQueryTest;

public class Handler : BotEventHandler
{
    [Command(InChat.Public, "query", CommandParseMode.Both)]
    public async Task HandleQuery()
    {
        var buttons = new List<InlineKeyboardButton>()
        {
            new("Test")
            {
                CallbackData = "test_callback"
            }
        };

        await Bot.SendTextMessageAsync(Chat.Id, "123", replyMarkup: new InlineKeyboardMarkup(buttons));
    }

    [Update(InChat.All, UpdateFlag.CallbackQuery)]
    public async Task HandleCallback()
    {
        await Bot.AnswerCallbackQueryAsync(CallbackQuery.Id, "Answer", true);
    }
}