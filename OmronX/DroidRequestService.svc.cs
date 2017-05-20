using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using OmronServiceHelper;
using OmronModels;

namespace OmronX
{
    public class DroidRequestService : IRequest
    {
        private OmronServiceHelper.OmronHelper _omronHelper = new OmronServiceHelper.OmronHelper();
        public bool ProcessRequest(OmronDroidRequests request)
        {

            return true;
        }

        public string SendPartDeliveryUpdate()
        {
            return "";
        }


        private void ProcessDroidRequest() {
        }

    }
}
