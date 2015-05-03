﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml;
using CEP.Common.Events;

namespace CEP.Server.Adaptor
{
    [ServiceContract]
    public interface IEventImportService
    {
        [OperationContract]
        void SendEvent(RawEvent obj);
    }

}
