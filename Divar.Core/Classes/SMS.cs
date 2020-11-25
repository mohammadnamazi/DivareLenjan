using System;
using System.Collections.Generic;
using System.Text;
using Kavenegar;
using SmsIrRestful;

namespace Divar.Core.Classes
{
    public class SMS
    {
        public void Send(string To, string Body)
        {
            var sender = "1000596446";
            var receptor = To;
            var message = Body;
            var api = new Kavenegar.KavenegarApi("554D7A533570554E765A6B5A2B6A6E4E4868325438476E42426F3735706D626B38425774524D51636B4F593D");
            api.Send(sender, receptor, message);
        }
    }
}
