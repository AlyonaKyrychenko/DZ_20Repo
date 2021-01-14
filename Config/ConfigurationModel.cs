using System;
using System.Reflection;

namespace DZ_20
{
    public class ConfigurationModel
    {
        public FieldInfo FieldInfo { get; set; }
        public object Instance { get; set; }
        public IConfig Config { get; set; }

    }
}
