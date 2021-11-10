﻿namespace Archipelago.MultiClient.Net.Enums
{
    public enum ArchipelagoPacketType
    {
        RoomInfo,
        ConnectionRefused,
        Connected,
        ReceivedItems,
        LocationInfo,
        RoomUpdate,
        Print,
        PrintJSON,
        Connect,
        ConnectUpdate,
        LocationChecks,
        LocationScouts,
        StatusUpdate,
        Say,
        GetDataPackage,
        DataPackage,
        Sync,
        Bounced,
        Bounce,
        InvalidPacket
    }
}