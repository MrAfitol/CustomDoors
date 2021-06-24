using Exiled.API.Interfaces;
using System.ComponentModel;

namespace CustomDoors
{
    public class Config : IConfig
    {
        [Description("Indicates whether the plugin is enabled or not")]
        public bool IsEnabled { get; set; } = true;

        [Description("Should use this door ?")]
        public bool IsEnabledDoor1 { get; set; } = true;

        [Description("Should use this door ?")]
        public bool IsEnabledDoor2 { get; set; } = true;

        [Description("Should use this door ?")]
        public bool IsEnabledDoor3 { get; set; } = true;

        [Description("Should use this door ?")]
        public bool IsEnabledDoor4 { get; set; } = true;
    }
}
