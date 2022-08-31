using EnigmaCamp.Debugging;

namespace EnigmaCamp
{
    public class EnigmaCampConsts
    {
        public const string LocalizationSourceName = "EnigmaCamp";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "59a8126735de4e82ba5cb98f11866ba9";
    }
}
