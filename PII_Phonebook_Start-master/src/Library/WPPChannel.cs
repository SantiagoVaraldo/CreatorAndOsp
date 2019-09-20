using WhatsAppApiUCU;
using System;

namespace Library
{
         public class WPPChannel : IMessageChannel
         {
                  const string accountSid = "ACa8395e7223e7719988c09db8dfb68f0f";
                  const string authToken = "fdcaac12dc7e5b031908429ee402e7a4";

                  public void Send(string PhoneFrom, string PhoneTo, string TextTo)
                  {
                           var whatsApp = new WhatsAppApi(accountSid, authToken);
                           string sid = whatsApp.Send(PhoneTo,TextTo);
                           Console.WriteLine(sid);
                  }
         }
}