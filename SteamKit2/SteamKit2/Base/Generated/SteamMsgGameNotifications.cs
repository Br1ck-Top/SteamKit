// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: steammessages_gamenotifications.steamclient.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CGameNotifications_Variable : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string key
        {
            get => __pbn__key ?? "";
            set => __pbn__key = value;
        }
        public bool ShouldSerializekey() => __pbn__key != null;
        public void Resetkey() => __pbn__key = null;
        private string __pbn__key;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string value
        {
            get => __pbn__value ?? "";
            set => __pbn__value = value;
        }
        public bool ShouldSerializevalue() => __pbn__value != null;
        public void Resetvalue() => __pbn__value = null;
        private string __pbn__value;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CGameNotifications_LocalizedText : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string token
        {
            get => __pbn__token ?? "";
            set => __pbn__token = value;
        }
        public bool ShouldSerializetoken() => __pbn__token != null;
        public void Resettoken() => __pbn__token = null;
        private string __pbn__token;

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<CGameNotifications_Variable> variables { get; } = new global::System.Collections.Generic.List<CGameNotifications_Variable>();

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string rendered_text
        {
            get => __pbn__rendered_text ?? "";
            set => __pbn__rendered_text = value;
        }
        public bool ShouldSerializerendered_text() => __pbn__rendered_text != null;
        public void Resetrendered_text() => __pbn__rendered_text = null;
        private string __pbn__rendered_text;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CGameNotifications_UserStatus : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid
        {
            get => __pbn__steamid.GetValueOrDefault();
            set => __pbn__steamid = value;
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string state
        {
            get => __pbn__state ?? "";
            set => __pbn__state = value;
        }
        public bool ShouldSerializestate() => __pbn__state != null;
        public void Resetstate() => __pbn__state = null;
        private string __pbn__state;

        [global::ProtoBuf.ProtoMember(3)]
        public CGameNotifications_LocalizedText title { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public CGameNotifications_LocalizedText message { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CGameNotifications_CreateSession_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get => __pbn__appid.GetValueOrDefault();
            set => __pbn__appid = value;
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong context
        {
            get => __pbn__context.GetValueOrDefault();
            set => __pbn__context = value;
        }
        public bool ShouldSerializecontext() => __pbn__context != null;
        public void Resetcontext() => __pbn__context = null;
        private ulong? __pbn__context;

        [global::ProtoBuf.ProtoMember(3)]
        public CGameNotifications_LocalizedText title { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public global::System.Collections.Generic.List<CGameNotifications_UserStatus> users { get; } = new global::System.Collections.Generic.List<CGameNotifications_UserStatus>();

        [global::ProtoBuf.ProtoMember(5, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid
        {
            get => __pbn__steamid.GetValueOrDefault();
            set => __pbn__steamid = value;
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CGameNotifications_CreateSession_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong sessionid
        {
            get => __pbn__sessionid.GetValueOrDefault();
            set => __pbn__sessionid = value;
        }
        public bool ShouldSerializesessionid() => __pbn__sessionid != null;
        public void Resetsessionid() => __pbn__sessionid = null;
        private ulong? __pbn__sessionid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CGameNotifications_DeleteSession_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong sessionid
        {
            get => __pbn__sessionid.GetValueOrDefault();
            set => __pbn__sessionid = value;
        }
        public bool ShouldSerializesessionid() => __pbn__sessionid != null;
        public void Resetsessionid() => __pbn__sessionid = null;
        private ulong? __pbn__sessionid;

        [global::ProtoBuf.ProtoMember(2)]
        public uint appid
        {
            get => __pbn__appid.GetValueOrDefault();
            set => __pbn__appid = value;
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(3, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid
        {
            get => __pbn__steamid.GetValueOrDefault();
            set => __pbn__steamid = value;
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CGameNotifications_DeleteSession_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CGameNotifications_UpdateSession_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong sessionid
        {
            get => __pbn__sessionid.GetValueOrDefault();
            set => __pbn__sessionid = value;
        }
        public bool ShouldSerializesessionid() => __pbn__sessionid != null;
        public void Resetsessionid() => __pbn__sessionid = null;
        private ulong? __pbn__sessionid;

        [global::ProtoBuf.ProtoMember(2)]
        public uint appid
        {
            get => __pbn__appid.GetValueOrDefault();
            set => __pbn__appid = value;
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(3)]
        public CGameNotifications_LocalizedText title { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public global::System.Collections.Generic.List<CGameNotifications_UserStatus> users { get; } = new global::System.Collections.Generic.List<CGameNotifications_UserStatus>();

        [global::ProtoBuf.ProtoMember(6, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid
        {
            get => __pbn__steamid.GetValueOrDefault();
            set => __pbn__steamid = value;
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CGameNotifications_UpdateSession_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CGameNotifications_EnumerateSessions_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get => __pbn__appid.GetValueOrDefault();
            set => __pbn__appid = value;
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(3)]
        public bool include_all_user_messages
        {
            get => __pbn__include_all_user_messages.GetValueOrDefault();
            set => __pbn__include_all_user_messages = value;
        }
        public bool ShouldSerializeinclude_all_user_messages() => __pbn__include_all_user_messages != null;
        public void Resetinclude_all_user_messages() => __pbn__include_all_user_messages = null;
        private bool? __pbn__include_all_user_messages;

        [global::ProtoBuf.ProtoMember(4)]
        public bool include_auth_user_message
        {
            get => __pbn__include_auth_user_message.GetValueOrDefault();
            set => __pbn__include_auth_user_message = value;
        }
        public bool ShouldSerializeinclude_auth_user_message() => __pbn__include_auth_user_message != null;
        public void Resetinclude_auth_user_message() => __pbn__include_auth_user_message = null;
        private bool? __pbn__include_auth_user_message;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue("")]
        public string language
        {
            get => __pbn__language ?? "";
            set => __pbn__language = value;
        }
        public bool ShouldSerializelanguage() => __pbn__language != null;
        public void Resetlanguage() => __pbn__language = null;
        private string __pbn__language;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CGameNotifications_Session : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong sessionid
        {
            get => __pbn__sessionid.GetValueOrDefault();
            set => __pbn__sessionid = value;
        }
        public bool ShouldSerializesessionid() => __pbn__sessionid != null;
        public void Resetsessionid() => __pbn__sessionid = null;
        private ulong? __pbn__sessionid;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong appid
        {
            get => __pbn__appid.GetValueOrDefault();
            set => __pbn__appid = value;
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private ulong? __pbn__appid;

        [global::ProtoBuf.ProtoMember(3)]
        public ulong context
        {
            get => __pbn__context.GetValueOrDefault();
            set => __pbn__context = value;
        }
        public bool ShouldSerializecontext() => __pbn__context != null;
        public void Resetcontext() => __pbn__context = null;
        private ulong? __pbn__context;

        [global::ProtoBuf.ProtoMember(4)]
        public CGameNotifications_LocalizedText title { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public uint time_created
        {
            get => __pbn__time_created.GetValueOrDefault();
            set => __pbn__time_created = value;
        }
        public bool ShouldSerializetime_created() => __pbn__time_created != null;
        public void Resettime_created() => __pbn__time_created = null;
        private uint? __pbn__time_created;

        [global::ProtoBuf.ProtoMember(6)]
        public uint time_updated
        {
            get => __pbn__time_updated.GetValueOrDefault();
            set => __pbn__time_updated = value;
        }
        public bool ShouldSerializetime_updated() => __pbn__time_updated != null;
        public void Resettime_updated() => __pbn__time_updated = null;
        private uint? __pbn__time_updated;

        [global::ProtoBuf.ProtoMember(7)]
        public global::System.Collections.Generic.List<CGameNotifications_UserStatus> user_status { get; } = new global::System.Collections.Generic.List<CGameNotifications_UserStatus>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CGameNotifications_EnumerateSessions_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<CGameNotifications_Session> sessions { get; } = new global::System.Collections.Generic.List<CGameNotifications_Session>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CGameNotifications_GetSessionDetails_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<RequestedSession> sessions { get; } = new global::System.Collections.Generic.List<RequestedSession>();

        [global::ProtoBuf.ProtoMember(2)]
        public uint appid
        {
            get => __pbn__appid.GetValueOrDefault();
            set => __pbn__appid = value;
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string language
        {
            get => __pbn__language ?? "";
            set => __pbn__language = value;
        }
        public bool ShouldSerializelanguage() => __pbn__language != null;
        public void Resetlanguage() => __pbn__language = null;
        private string __pbn__language;

        [global::ProtoBuf.ProtoContract()]
        public partial class RequestedSession : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            public ulong sessionid
            {
                get => __pbn__sessionid.GetValueOrDefault();
                set => __pbn__sessionid = value;
            }
            public bool ShouldSerializesessionid() => __pbn__sessionid != null;
            public void Resetsessionid() => __pbn__sessionid = null;
            private ulong? __pbn__sessionid;

            [global::ProtoBuf.ProtoMember(3)]
            public bool include_auth_user_message
            {
                get => __pbn__include_auth_user_message.GetValueOrDefault();
                set => __pbn__include_auth_user_message = value;
            }
            public bool ShouldSerializeinclude_auth_user_message() => __pbn__include_auth_user_message != null;
            public void Resetinclude_auth_user_message() => __pbn__include_auth_user_message = null;
            private bool? __pbn__include_auth_user_message;

        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CGameNotifications_GetSessionDetails_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<CGameNotifications_Session> sessions { get; } = new global::System.Collections.Generic.List<CGameNotifications_Session>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GameNotificationSettings : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get => __pbn__appid.GetValueOrDefault();
            set => __pbn__appid = value;
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(2)]
        public bool allow_notifications
        {
            get => __pbn__allow_notifications.GetValueOrDefault();
            set => __pbn__allow_notifications = value;
        }
        public bool ShouldSerializeallow_notifications() => __pbn__allow_notifications != null;
        public void Resetallow_notifications() => __pbn__allow_notifications = null;
        private bool? __pbn__allow_notifications;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CGameNotifications_UpdateNotificationSettings_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<GameNotificationSettings> game_notification_settings { get; } = new global::System.Collections.Generic.List<GameNotificationSettings>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CGameNotifications_UpdateNotificationSettings_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CGameNotifications_OnNotificationsRequested_Notification : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid
        {
            get => __pbn__steamid.GetValueOrDefault();
            set => __pbn__steamid = value;
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

        [global::ProtoBuf.ProtoMember(2)]
        public uint appid
        {
            get => __pbn__appid.GetValueOrDefault();
            set => __pbn__appid = value;
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CGameNotifications_OnUserStatusChanged_Notification : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid
        {
            get => __pbn__steamid.GetValueOrDefault();
            set => __pbn__steamid = value;
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong sessionid
        {
            get => __pbn__sessionid.GetValueOrDefault();
            set => __pbn__sessionid = value;
        }
        public bool ShouldSerializesessionid() => __pbn__sessionid != null;
        public void Resetsessionid() => __pbn__sessionid = null;
        private ulong? __pbn__sessionid;

        [global::ProtoBuf.ProtoMember(3)]
        public uint appid
        {
            get => __pbn__appid.GetValueOrDefault();
            set => __pbn__appid = value;
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(4)]
        public CGameNotifications_UserStatus status { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public bool removed
        {
            get => __pbn__removed.GetValueOrDefault();
            set => __pbn__removed = value;
        }
        public bool ShouldSerializeremoved() => __pbn__removed != null;
        public void Resetremoved() => __pbn__removed = null;
        private bool? __pbn__removed;

    }

    public interface IGameNotifications
    {
        CGameNotifications_CreateSession_Response UserCreateSession(CGameNotifications_CreateSession_Request request);
        CGameNotifications_DeleteSession_Response UserDeleteSession(CGameNotifications_DeleteSession_Request request);
        CGameNotifications_UpdateSession_Response UserUpdateSession(CGameNotifications_UpdateSession_Request request);
        CGameNotifications_EnumerateSessions_Response EnumerateSessions(CGameNotifications_EnumerateSessions_Request request);
        CGameNotifications_GetSessionDetails_Response GetSessionDetails(CGameNotifications_GetSessionDetails_Request request);
        CGameNotifications_UpdateNotificationSettings_Response UpdateNotificationSettings(CGameNotifications_UpdateNotificationSettings_Request request);
    }

    public interface IGameNotificationsClient
    {
        NoResponse OnNotificationsRequested(CGameNotifications_OnNotificationsRequested_Notification request);
        NoResponse OnUserStatusChanged(CGameNotifications_OnUserStatusChanged_Notification request);
    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
