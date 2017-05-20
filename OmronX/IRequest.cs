using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using OmronModels;

namespace OmronX
{
    [ServiceContract]
    public interface IRequest
    {
        [OperationContract]
        bool ProcessRequest(OmronDroidRequests request);
        string SendPartDeliveryUpdate();
    }
}
