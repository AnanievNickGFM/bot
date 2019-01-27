using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelegramBotLedger.Models
{
    public static class AppSettings
    {
        public static string Url { get; set; } = "https://telegrambotledger.azurewebsites.net:443/{0}";
        public static string Name { get; set; } = "iamnickua_bot";
        public static string ApiKey { get; set; } = "656810353:AAGajm2muULviwBOiUBifNFj_gQ87POG92I";
    }
}