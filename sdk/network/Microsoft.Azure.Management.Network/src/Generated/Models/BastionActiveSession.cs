// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The session detail for a target.
    /// </summary>
    public partial class BastionActiveSession
    {
        /// <summary>
        /// Initializes a new instance of the BastionActiveSession class.
        /// </summary>
        public BastionActiveSession()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BastionActiveSession class.
        /// </summary>
        /// <param name="sessionId">A unique id for the session.</param>
        /// <param name="startTime">The time when the session started.</param>
        /// <param name="targetSubscriptionId">The subscription id for the
        /// target virtual machine.</param>
        /// <param name="resourceType">The type of the resource.</param>
        /// <param name="targetHostName">The host name of the target.</param>
        /// <param name="targetResourceGroup">The resource group of the
        /// target.</param>
        /// <param name="userName">The user name who is active on this
        /// session.</param>
        /// <param name="targetIpAddress">The IP Address of the target.</param>
        /// <param name="protocol">The protocol used to connect to the target.
        /// Possible values include: 'SSH', 'RDP'</param>
        /// <param name="targetResourceId">The resource id of the
        /// target.</param>
        /// <param name="sessionDurationInMins">Duration in mins the session
        /// has been active.</param>
        public BastionActiveSession(string sessionId = default(string), object startTime = default(object), string targetSubscriptionId = default(string), string resourceType = default(string), string targetHostName = default(string), string targetResourceGroup = default(string), string userName = default(string), string targetIpAddress = default(string), string protocol = default(string), string targetResourceId = default(string), double? sessionDurationInMins = default(double?))
        {
            SessionId = sessionId;
            StartTime = startTime;
            TargetSubscriptionId = targetSubscriptionId;
            ResourceType = resourceType;
            TargetHostName = targetHostName;
            TargetResourceGroup = targetResourceGroup;
            UserName = userName;
            TargetIpAddress = targetIpAddress;
            Protocol = protocol;
            TargetResourceId = targetResourceId;
            SessionDurationInMins = sessionDurationInMins;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a unique id for the session.
        /// </summary>
        [JsonProperty(PropertyName = "sessionId")]
        public string SessionId { get; private set; }

        /// <summary>
        /// Gets the time when the session started.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public object StartTime { get; private set; }

        /// <summary>
        /// Gets the subscription id for the target virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "targetSubscriptionId")]
        public string TargetSubscriptionId { get; private set; }

        /// <summary>
        /// Gets the type of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; private set; }

        /// <summary>
        /// Gets the host name of the target.
        /// </summary>
        [JsonProperty(PropertyName = "targetHostName")]
        public string TargetHostName { get; private set; }

        /// <summary>
        /// Gets the resource group of the target.
        /// </summary>
        [JsonProperty(PropertyName = "targetResourceGroup")]
        public string TargetResourceGroup { get; private set; }

        /// <summary>
        /// Gets the user name who is active on this session.
        /// </summary>
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; private set; }

        /// <summary>
        /// Gets the IP Address of the target.
        /// </summary>
        [JsonProperty(PropertyName = "targetIpAddress")]
        public string TargetIpAddress { get; private set; }

        /// <summary>
        /// Gets the protocol used to connect to the target. Possible values
        /// include: 'SSH', 'RDP'
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; private set; }

        /// <summary>
        /// Gets the resource id of the target.
        /// </summary>
        [JsonProperty(PropertyName = "targetResourceId")]
        public string TargetResourceId { get; private set; }

        /// <summary>
        /// Gets duration in mins the session has been active.
        /// </summary>
        [JsonProperty(PropertyName = "sessionDurationInMins")]
        public double? SessionDurationInMins { get; private set; }

    }
}
