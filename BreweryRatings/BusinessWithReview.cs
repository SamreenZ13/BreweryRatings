﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Yelp;
//
//    var yelpRating = YelpRating.FromJson(jsonString);

namespace Yelp
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using ReviewNamespace;

    public partial class BusinessWithReview : Business
    {
        private Review[] _reviews;
        private long _total;
        private string[] _possibleLanguage;

        [JsonProperty("reviews")]
        public Review[] Reviews { get => _reviews; set => _reviews = value; }

        [JsonProperty("total")]
        public long Total { get => _total; set => _total = value; }

        [JsonProperty("possible_languages")]
        public string[] PossibleLanguages { get => _possibleLanguage; set => _possibleLanguage = value; }
    }

    public partial class BusinessWithReview
    {
        public static BusinessWithReview FromJson(string json) => JsonConvert.DeserializeObject<BusinessWithReview>(json, Yelp.Converter.Settings);
    }

    public static class Serialize2
    {
        public static string ToJson(this BusinessWithReview self) => JsonConvert.SerializeObject(self, Yelp.Converter.Settings);
    }
}
