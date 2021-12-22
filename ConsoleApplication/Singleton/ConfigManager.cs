using System.Collections.Generic;
namespace ConsoleApplication.Singleton{
    public class ConfigManager{
        private Dictionary<string,object> _settings = new Dictionary<string,object>();
        private static ConfigManager _instance = new ConfigManager();

        private ConfigManager(){}

        public static ConfigManager GetInstance(){
            return _instance;
        }

        public void Set(string key , object value){
            _settings.Add(key,value);
        }

        public object Get(string key){
            return _settings[key];
        }
    }
}