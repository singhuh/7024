﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var hospital = Hospital.FromJson(jsonString);

namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Hospital
    {
        [JsonProperty("health_center")]
        public string HealthCenter { get; set; }

        [JsonProperty("health_center_code")]
        public string HealthCenterCode { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("street_name")]
        public string StreetName { get; set; }

        [JsonProperty("sufx")]
        public Sufx Sufx { get; set; }

        [JsonProperty("city")]
        public City City { get; set; }

        [JsonProperty("state")]
        public State State { get; set; }

        [JsonProperty("zipcode")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Zipcode { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("care_type")]
        public string CareType { get; set; }

        [JsonProperty("monday_open", NullValueHandling = NullValueHandling.Ignore)]
        public DayOpen? MondayOpen { get; set; }

        [JsonProperty("monday_close", NullValueHandling = NullValueHandling.Ignore)]
        public string MondayClose { get; set; }

        [JsonProperty("tuesday_open", NullValueHandling = NullValueHandling.Ignore)]
        public DayOpen? TuesdayOpen { get; set; }

        [JsonProperty("tuesday_close", NullValueHandling = NullValueHandling.Ignore)]
        public string TuesdayClose { get; set; }

        [JsonProperty("wednesday_open", NullValueHandling = NullValueHandling.Ignore)]
        public DayOpen? WednesdayOpen { get; set; }

        [JsonProperty("wednesday_close", NullValueHandling = NullValueHandling.Ignore)]
        public string WednesdayClose { get; set; }

        [JsonProperty("thursday_open", NullValueHandling = NullValueHandling.Ignore)]
        public DayOpen? ThursdayOpen { get; set; }

        [JsonProperty("thursday_close", NullValueHandling = NullValueHandling.Ignore)]
        public string ThursdayClose { get; set; }

        [JsonProperty("friday_open", NullValueHandling = NullValueHandling.Ignore)]
        public DayOpen? FridayOpen { get; set; }

        [JsonProperty("friday_close", NullValueHandling = NullValueHandling.Ignore)]
        public string FridayClose { get; set; }

        [JsonProperty("services_provided", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicesProvided { get; set; }

        [JsonProperty("center_description", NullValueHandling = NullValueHandling.Ignore)]
        public string CenterDescription { get; set; }

        [JsonProperty("insurance_accepted", NullValueHandling = NullValueHandling.Ignore)]
        public string InsuranceAccepted { get; set; }

        [JsonProperty("title_x_services", NullValueHandling = NullValueHandling.Ignore)]
        public Adult? TitleXServices { get; set; }

        [JsonProperty("neighborhood")]
        public string Neighborhood { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("adult", NullValueHandling = NullValueHandling.Ignore)]
        public Adult? Adult { get; set; }

        [JsonProperty("pediatrics", NullValueHandling = NullValueHandling.Ignore)]
        public Adult? Pediatrics { get; set; }

        [JsonProperty("ob", NullValueHandling = NullValueHandling.Ignore)]
        public Adult? Ob { get; set; }

        [JsonProperty("nursing_services", NullValueHandling = NullValueHandling.Ignore)]
        public Adult? NursingServices { get; set; }

        [JsonProperty("lab", NullValueHandling = NullValueHandling.Ignore)]
        public Adult? Lab { get; set; }

        [JsonProperty("immunizations", NullValueHandling = NullValueHandling.Ignore)]
        public Adult? Immunizations { get; set; }

        [JsonProperty("outreach_enrollment_services", NullValueHandling = NullValueHandling.Ignore)]
        public Adult? OutreachEnrollmentServices { get; set; }

        [JsonProperty("gyn", NullValueHandling = NullValueHandling.Ignore)]
        public Adult? Gyn { get; set; }

        [JsonProperty("sti_testing", NullValueHandling = NullValueHandling.Ignore)]
        public Adult? StiTesting { get; set; }

        [JsonProperty("pharmacy", NullValueHandling = NullValueHandling.Ignore)]
        public Adult? Pharmacy { get; set; }

        [JsonProperty("diabetic_education", NullValueHandling = NullValueHandling.Ignore)]
        public Adult? DiabeticEducation { get; set; }

        [JsonProperty("wic", NullValueHandling = NullValueHandling.Ignore)]
        public Adult? Wic { get; set; }

        [JsonProperty("behavioral_health", NullValueHandling = NullValueHandling.Ignore)]
        public Adult? BehavioralHealth { get; set; }

        [JsonProperty("safe_place", NullValueHandling = NullValueHandling.Ignore)]
        public Adult? SafePlace { get; set; }

        [JsonProperty("special_hours_notes", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecialHoursNotes { get; set; }
    }

    public enum Adult { AdultNo, No, Yes };

    public enum City { Cincinnati };

    public enum DayOpen { The1000Am, The700Am, The730Am, The745Am, The800Am, The900Am };

    public enum State { Oh };

    public enum Sufx { Av, Dr, Pl, Rd, St };

    public partial class Hospital
    {
        public static List<Hospital> FromJson(string json) => JsonConvert.DeserializeObject<List<Hospital>>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this List<Hospital> self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                AdultConverter.Singleton,
                CityConverter.Singleton,
                DayOpenConverter.Singleton,
                StateConverter.Singleton,
                SufxConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class AdultConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Adult) || t == typeof(Adult?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "No":
                    return Adult.No;
                case "Yes":
                    return Adult.Yes;
                case "no":
                    return Adult.AdultNo;
            }
            throw new Exception("Cannot unmarshal type Adult");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Adult)untypedValue;
            switch (value)
            {
                case Adult.No:
                    serializer.Serialize(writer, "No");
                    return;
                case Adult.Yes:
                    serializer.Serialize(writer, "Yes");
                    return;
                case Adult.AdultNo:
                    serializer.Serialize(writer, "no");
                    return;
            }
            throw new Exception("Cannot marshal type Adult");
        }

        public static readonly AdultConverter Singleton = new AdultConverter();
    }

    internal class CityConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(City) || t == typeof(City?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "CINCINNATI")
            {
                return City.Cincinnati;
            }
            throw new Exception("Cannot unmarshal type City");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (City)untypedValue;
            if (value == City.Cincinnati)
            {
                serializer.Serialize(writer, "CINCINNATI");
                return;
            }
            throw new Exception("Cannot marshal type City");
        }

        public static readonly CityConverter Singleton = new CityConverter();
    }

    internal class DayOpenConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DayOpen) || t == typeof(DayOpen?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "10:00 AM":
                    return DayOpen.The1000Am;
                case "7:00 AM":
                    return DayOpen.The700Am;
                case "7:30 AM":
                    return DayOpen.The730Am;
                case "7:45 AM":
                    return DayOpen.The745Am;
                case "8:00 AM":
                    return DayOpen.The800Am;
                case "9:00 AM":
                    return DayOpen.The900Am;
            }
            throw new Exception("Cannot unmarshal type DayOpen");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (DayOpen)untypedValue;
            switch (value)
            {
                case DayOpen.The1000Am:
                    serializer.Serialize(writer, "10:00 AM");
                    return;
                case DayOpen.The700Am:
                    serializer.Serialize(writer, "7:00 AM");
                    return;
                case DayOpen.The730Am:
                    serializer.Serialize(writer, "7:30 AM");
                    return;
                case DayOpen.The745Am:
                    serializer.Serialize(writer, "7:45 AM");
                    return;
                case DayOpen.The800Am:
                    serializer.Serialize(writer, "8:00 AM");
                    return;
                case DayOpen.The900Am:
                    serializer.Serialize(writer, "9:00 AM");
                    return;
            }
            throw new Exception("Cannot marshal type DayOpen");
        }

        public static readonly DayOpenConverter Singleton = new DayOpenConverter();
    }

    internal class StateConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(State) || t == typeof(State?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "OH")
            {
                return State.Oh;
            }
            throw new Exception("Cannot unmarshal type State");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (State)untypedValue;
            if (value == State.Oh)
            {
                serializer.Serialize(writer, "OH");
                return;
            }
            throw new Exception("Cannot marshal type State");
        }

        public static readonly StateConverter Singleton = new StateConverter();
    }

    internal class SufxConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Sufx) || t == typeof(Sufx?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "AV":
                    return Sufx.Av;
                case "DR":
                    return Sufx.Dr;
                case "PL":
                    return Sufx.Pl;
                case "RD":
                    return Sufx.Rd;
                case "ST":
                    return Sufx.St;
            }
            throw new Exception("Cannot unmarshal type Sufx");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Sufx)untypedValue;
            switch (value)
            {
                case Sufx.Av:
                    serializer.Serialize(writer, "AV");
                    return;
                case Sufx.Dr:
                    serializer.Serialize(writer, "DR");
                    return;
                case Sufx.Pl:
                    serializer.Serialize(writer, "PL");
                    return;
                case Sufx.Rd:
                    serializer.Serialize(writer, "RD");
                    return;
                case Sufx.St:
                    serializer.Serialize(writer, "ST");
                    return;
            }
            throw new Exception("Cannot marshal type Sufx");
        }

        public static readonly SufxConverter Singleton = new SufxConverter();
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}
