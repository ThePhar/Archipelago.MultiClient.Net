﻿using Archipelago.MultiClient.Net.Converters;
using Archipelago.MultiClient.Net.Enums;
using Newtonsoft.Json;
using System;

namespace Archipelago.MultiClient.Net.Packets
{
    public class ConnectPacket : ArchipelagoPacketBase
    {
        public override ArchipelagoPacketType PacketType => ArchipelagoPacketType.Connect;

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("game")]
        public string Game { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("version")]
        [JsonConverter(typeof(NamedTupleInterchangeConverter))]
        public Version Version { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("items_handling")]
        public ItemsHandlingFlags ItemsHandling { get; set; }
    }
}
