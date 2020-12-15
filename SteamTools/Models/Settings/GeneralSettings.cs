using MetroTrilithon.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SteamTools.Models.Settings
{
    public static class GeneralSettings
    {
        /// <summary>
        /// ����������
        /// </summary>
        public static SerializableProperty<string> Culture { get; }
            = new SerializableProperty<string>(GetKey(), Providers.Roaming) { AutoSave = true };

        /// <summary>
        /// ��ȡָʾ������Ŵ󾵵����á�
        /// </summary>
        public static SerializableProperty<double> BrowserZoomFactor { get; }
            = new SerializableProperty<double>(GetKey(), Providers.Local, 1.0);


        private static string GetKey([CallerMemberName] string propertyName = "")
        {
            return nameof(GeneralSettings) + "." + propertyName;
        }
    }
}
