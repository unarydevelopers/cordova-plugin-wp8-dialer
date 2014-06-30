/*
    Copyright 2013-2014 appPlant UG

    Licensed to the Apache Software Foundation (ASF) under one
    or more contributor license agreements.  See the NOTICE file
    distributed with this work for additional information
    regarding copyright ownership.  The ASF licenses this file
    to you under the Apache License, Version 2.0 (the
    "License"); you may not use this file except in compliance
    with the License.  You may obtain a copy of the License at

     http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing,
    software distributed under the License is distributed on an
    "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
    KIND, either express or implied.  See the License for the
    specific language governing permissions and limitations
    under the License.
*/

using System;
using System.Linq;
using System.Runtime.Serialization;

namespace De.APPPlant.Cordova.Plugin.Dialer
{
    /// <summary>
    /// Represents dialer task options
    /// </summary>
    [DataContract]
    class Options
    {
        [DataMember(IsRequired = false, Name = "phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Represents the phone number you want to dial
        /// </summary>
    }
}
