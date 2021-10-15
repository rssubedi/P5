using System.Collections.Generic;

namespace P5
{
    public class FakePreferenceRepository : IPreferenceRepository
    {
        public const string PREFERENCE_PROJECT_ID = "Project_Id";
        public const string PREFERENCE_PROJECT_NAME = "Project_Name";
        private const string NO_ERROR = "";
        private static Dictionary<string, Dictionary<string, string>> _Preferences = new Dictionary<string, Dictionary<string, string>>();

        public string GetPreference(string UserName, string PreferenceName)
        {
            Dictionary<string, string> NameValuePair = new Dictionary<string, string>();
            string value = "";
            if (_Preferences.TryGetValue(UserName, out NameValuePair))
            {
                NameValuePair.TryGetValue(PreferenceName, out value);
            }
            return value;
        }
        public string SetPreference(string UserName, string PreferenceName, string Value)
        {
            Dictionary<string, Dictionary<string, string>> preferences = new Dictionary<string, Dictionary<string, string>>();
            Dictionary<string, string> NameValuePair;
            if (_Preferences.TryGetValue(UserName, out NameValuePair))
            {
                if (NameValuePair.ContainsKey(PreferenceName))
                {
                    NameValuePair[PreferenceName] = Value;
                }
                else
                {
                    NameValuePair.Add(PreferenceName, Value);
                }
                _Preferences[UserName] = NameValuePair;
            }
            else
            {
                NameValuePair = new Dictionary<string, string>();
                NameValuePair.Add(PreferenceName, Value);
                _Preferences.Add(UserName, NameValuePair);
            }
            return NO_ERROR;
        }
    }
}
