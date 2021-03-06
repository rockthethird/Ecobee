﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace I8Beef.Ecobee.Protocol.Group
{
    [DataContract]
    public class GroupUpdateResponse : Response
    {
        public GroupUpdateResponse()
        {
            Groups = new List<Objects.Group>();
        }

        /// <summary>
        /// The list of Groups updated by the request.
        /// </summary>
        [DataMember(Name = "groups")]
        public IList<Objects.Group> Groups { get; set; }
    }
}
