namespace Extensions
{
    public static class UnityIcon
    {
        public static UnityEngine.Texture2D LoadIcon(string path)
        {
            return UnityEditor.EditorGUIUtility.Load(path) as UnityEngine.Texture2D;
        }

        // https://github.com/halak/unity-editor-icons
        public const string k_ErrorIcon = "d_console.erroricon";
        public const string k_ErrorIconSmall = "d_console.erroricon.sml";
        public const string k_ErrorIconSmallInactive = "d_console.erroricon.inactive.sml";
        public const string k_WarningIcon = "d_console.warnicon";
        public const string k_WarningIconSmall = "d_console.warnicon.sml";
        public const string k_WarningIconSmallInactive = "d_console.warnicon.inactive.sml";
        public const string k_MessageIcon = "d_console.infoicon";
        public const string k_MessageIconSmall = "d_console.infoicon.sml";
        public const string k_MessageIconSmallInactive = "d_console.infoicon.inactive.sml";
        public const string k_ConsoleIcon = "d_UnityEditor.ConsoleWindow";

        public const string k_AvatarBlendBackground = "d_AvatarBlendBackground";
        public const string k_StacktraceBackground = "builtin skins/darkskin/images/projectbrowsericonareabg.png";
        public const string k_BackgroundOdd = "builtin skins/darkskin/images/cn entrybackodd.png";
        public const string k_BackgroundEven = "builtin skins/darkskin/images/cnentrybackeven.png";
        public const string k_BackgroundSelected = "builtin skins/darkskin/images/menuitemhover.png";
    }
}
