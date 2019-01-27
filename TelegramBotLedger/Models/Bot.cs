using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot;
using TelegramBotLedger.Models.Commands;

namespace TelegramBotLedger.Models
{
    public static class Bot
    {
        private static TelegramBotClient _telegramClient;

        private static List<Command> _commandsList;

        public static IReadOnlyList<Command> CommandsList => _commandsList.AsReadOnly();

        public static async Task<TelegramBotClient> Get()
        {
            if (_telegramClient != null)
                return _telegramClient;

            _commandsList = new List<Command>();
            _commandsList.Add(new HelloCommand());

            _telegramClient =  new TelegramBotClient(AppSettings.ApiKey);
            var hook = string.Format(AppSettings.Url, "api/message/update");
            await _telegramClient.SetWebhookAsync(hook);
            return _telegramClient;
        }
    }
}