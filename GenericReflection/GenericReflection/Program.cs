namespace GenericReflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "Jannick";
            if(myName.GetType() == typeof(string))
            {
                // Hey it's a 
            }
            //Type type = typeof(ConfigurationManager<>);
        }
    }

    internal class ConfigurationManager<T>
    {
        public T LoadedConfiguration { get; set; }
        public ConfigurationManager(T config)
        {
            LoadedConfiguration = config;
        }

        public static void SaveConfig(T configToSave)
        {
            // Logic
        }
    }
}
