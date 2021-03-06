﻿using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace BuddySDK.Models
{
    public abstract class ModelBase
    {
        [JsonProperty("id")]
        public string ID
        {
            get;
            set;
        }

        [JsonProperty("location")]
        public virtual BuddyGeoLocation Location { get; set; }

        /* TODO: Make the service return these values */
//
//        [JsonProperty("readPermissions")]
//        public BuddyPermissions ReadPermissions
//        {
//            get;
//            set;
//        }
//
//        [JsonProperty("writePermissions")]
//        public BuddyPermissions WritePermissions
//        {
//            get;
//            set;
//        }

        [JsonProperty("created")]
        public DateTime Created
        {
            get;
            set;
        }

        [JsonProperty("lastModified")]
        public DateTime LastModified
        {
            get;
            set;
        }

        [JsonProperty("tag")]
        public string Tag
        {
            get;
            set;
        }

       
    }
}
