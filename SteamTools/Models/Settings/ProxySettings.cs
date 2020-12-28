using MetroTrilithon.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SteamTools.Models.Settings
{
    public static class ProxySettings
    {
        /// <summary>
        /// ����GOG����
        /// </summary>
        public static SerializableProperty<bool> IsProxyGOG { get; }
            = new SerializableProperty<bool>(GetKey(), Providers.Local, false) { AutoSave = true };

        /// <summary>
        /// ���ô���ű�
        /// </summary>
        public static SerializableProperty<bool> IsEnableScript { get; }
            = new SerializableProperty<bool>(GetKey(), Providers.Local, false) { AutoSave = true };

        /// <summary>
        /// ��������ʱ�Զ���������
        /// </summary>
        public static SerializableProperty<bool> ProgramStartupRunProxy { get; }
            = new SerializableProperty<bool>(GetKey(), Providers.Local, false) { AutoSave = true };

        /// <summary>
        /// ��������ʱ�Զ���������
        /// </summary>
        public static SerializableProperty<IReadOnlyDictionary<int, bool>> SupportProxyServicesStatus { get; }
            = new SerializableProperty<IReadOnlyDictionary<int, bool>>(GetKey(), Providers.Local, new Dictionary<int, bool>());

        private static string GetKey([CallerMemberName] string propertyName = "")
        {
            return nameof(ProxySettings) + "." + propertyName;
        }
    }
}
