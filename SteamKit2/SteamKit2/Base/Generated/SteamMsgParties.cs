// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: steammessages_parties.steamclient.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CParties_JoinParty_Request : global::ProtoBuf.IExtensible
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
        public ulong beacon_id
        {
            get => __pbn__beacon_id.GetValueOrDefault();
            set => __pbn__beacon_id = value;
        }
        public bool ShouldSerializebeacon_id() => __pbn__beacon_id != null;
        public void Resetbeacon_id() => __pbn__beacon_id = null;
        private ulong? __pbn__beacon_id;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParties_JoinParty_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong beacon_id
        {
            get => __pbn__beacon_id.GetValueOrDefault();
            set => __pbn__beacon_id = value;
        }
        public bool ShouldSerializebeacon_id() => __pbn__beacon_id != null;
        public void Resetbeacon_id() => __pbn__beacon_id = null;
        private ulong? __pbn__beacon_id;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string connect_string
        {
            get => __pbn__connect_string ?? "";
            set => __pbn__connect_string = value;
        }
        public bool ShouldSerializeconnect_string() => __pbn__connect_string != null;
        public void Resetconnect_string() => __pbn__connect_string = null;
        private string __pbn__connect_string;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParties_BeaconLocation : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint location_type
        {
            get => __pbn__location_type.GetValueOrDefault();
            set => __pbn__location_type = value;
        }
        public bool ShouldSerializelocation_type() => __pbn__location_type != null;
        public void Resetlocation_type() => __pbn__location_type = null;
        private uint? __pbn__location_type;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong location_id
        {
            get => __pbn__location_id.GetValueOrDefault();
            set => __pbn__location_id = value;
        }
        public bool ShouldSerializelocation_id() => __pbn__location_id != null;
        public void Resetlocation_id() => __pbn__location_id = null;
        private ulong? __pbn__location_id;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParties_CreateBeacon_Request : global::ProtoBuf.IExtensible
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
        public uint num_open_slots
        {
            get => __pbn__num_open_slots.GetValueOrDefault();
            set => __pbn__num_open_slots = value;
        }
        public bool ShouldSerializenum_open_slots() => __pbn__num_open_slots != null;
        public void Resetnum_open_slots() => __pbn__num_open_slots = null;
        private uint? __pbn__num_open_slots;

        [global::ProtoBuf.ProtoMember(3)]
        public global::System.Collections.Generic.List<CParties_BeaconLocation> locations { get; } = new global::System.Collections.Generic.List<CParties_BeaconLocation>();

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string connect_string
        {
            get => __pbn__connect_string ?? "";
            set => __pbn__connect_string = value;
        }
        public bool ShouldSerializeconnect_string() => __pbn__connect_string != null;
        public void Resetconnect_string() => __pbn__connect_string = null;
        private string __pbn__connect_string;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue("")]
        public string metadata
        {
            get => __pbn__metadata ?? "";
            set => __pbn__metadata = value;
        }
        public bool ShouldSerializemetadata() => __pbn__metadata != null;
        public void Resetmetadata() => __pbn__metadata = null;
        private string __pbn__metadata;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParties_CreateBeacon_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong beacon_id
        {
            get => __pbn__beacon_id.GetValueOrDefault();
            set => __pbn__beacon_id = value;
        }
        public bool ShouldSerializebeacon_id() => __pbn__beacon_id != null;
        public void Resetbeacon_id() => __pbn__beacon_id = null;
        private ulong? __pbn__beacon_id;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParties_OnReservationCompleted_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong beacon_id
        {
            get => __pbn__beacon_id.GetValueOrDefault();
            set => __pbn__beacon_id = value;
        }
        public bool ShouldSerializebeacon_id() => __pbn__beacon_id != null;
        public void Resetbeacon_id() => __pbn__beacon_id = null;
        private ulong? __pbn__beacon_id;

        [global::ProtoBuf.ProtoMember(2, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong user_steamid
        {
            get => __pbn__user_steamid.GetValueOrDefault();
            set => __pbn__user_steamid = value;
        }
        public bool ShouldSerializeuser_steamid() => __pbn__user_steamid != null;
        public void Resetuser_steamid() => __pbn__user_steamid = null;
        private ulong? __pbn__user_steamid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParties_OnReservationCompleted_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong beacon_id
        {
            get => __pbn__beacon_id.GetValueOrDefault();
            set => __pbn__beacon_id = value;
        }
        public bool ShouldSerializebeacon_id() => __pbn__beacon_id != null;
        public void Resetbeacon_id() => __pbn__beacon_id = null;
        private ulong? __pbn__beacon_id;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParties_CancelReservation_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong beacon_id
        {
            get => __pbn__beacon_id.GetValueOrDefault();
            set => __pbn__beacon_id = value;
        }
        public bool ShouldSerializebeacon_id() => __pbn__beacon_id != null;
        public void Resetbeacon_id() => __pbn__beacon_id = null;
        private ulong? __pbn__beacon_id;

        [global::ProtoBuf.ProtoMember(2, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong user_steamid
        {
            get => __pbn__user_steamid.GetValueOrDefault();
            set => __pbn__user_steamid = value;
        }
        public bool ShouldSerializeuser_steamid() => __pbn__user_steamid != null;
        public void Resetuser_steamid() => __pbn__user_steamid = null;
        private ulong? __pbn__user_steamid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParties_CancelReservation_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong beacon_id
        {
            get => __pbn__beacon_id.GetValueOrDefault();
            set => __pbn__beacon_id = value;
        }
        public bool ShouldSerializebeacon_id() => __pbn__beacon_id != null;
        public void Resetbeacon_id() => __pbn__beacon_id = null;
        private ulong? __pbn__beacon_id;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParties_ChangeNumOpenSlots_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong beacon_id
        {
            get => __pbn__beacon_id.GetValueOrDefault();
            set => __pbn__beacon_id = value;
        }
        public bool ShouldSerializebeacon_id() => __pbn__beacon_id != null;
        public void Resetbeacon_id() => __pbn__beacon_id = null;
        private ulong? __pbn__beacon_id;

        [global::ProtoBuf.ProtoMember(2)]
        public uint num_open_slots
        {
            get => __pbn__num_open_slots.GetValueOrDefault();
            set => __pbn__num_open_slots = value;
        }
        public bool ShouldSerializenum_open_slots() => __pbn__num_open_slots != null;
        public void Resetnum_open_slots() => __pbn__num_open_slots = null;
        private uint? __pbn__num_open_slots;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParties_ChangeNumOpenSlots_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong beacon_id
        {
            get => __pbn__beacon_id.GetValueOrDefault();
            set => __pbn__beacon_id = value;
        }
        public bool ShouldSerializebeacon_id() => __pbn__beacon_id != null;
        public void Resetbeacon_id() => __pbn__beacon_id = null;
        private ulong? __pbn__beacon_id;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParties_DestroyBeacon_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong beacon_id
        {
            get => __pbn__beacon_id.GetValueOrDefault();
            set => __pbn__beacon_id = value;
        }
        public bool ShouldSerializebeacon_id() => __pbn__beacon_id != null;
        public void Resetbeacon_id() => __pbn__beacon_id = null;
        private ulong? __pbn__beacon_id;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParties_DestroyBeacon_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong beacon_id
        {
            get => __pbn__beacon_id.GetValueOrDefault();
            set => __pbn__beacon_id = value;
        }
        public bool ShouldSerializebeacon_id() => __pbn__beacon_id != null;
        public void Resetbeacon_id() => __pbn__beacon_id = null;
        private ulong? __pbn__beacon_id;

    }

    public interface IParties
    {
        CParties_JoinParty_Response JoinParty(CParties_JoinParty_Request request);
        CParties_CreateBeacon_Response CreateBeacon(CParties_CreateBeacon_Request request);
        CParties_OnReservationCompleted_Response OnReservationCompleted(CParties_OnReservationCompleted_Request request);
        CParties_CancelReservation_Response CancelReservation(CParties_CancelReservation_Request request);
        CParties_ChangeNumOpenSlots_Response ChangeNumOpenSlots(CParties_ChangeNumOpenSlots_Request request);
        CParties_DestroyBeacon_Response DestroyBeacon(CParties_DestroyBeacon_Request request);
    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
