using Azure.Messaging.ServiceBus;
using EmailProvider_Onatrix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailProvider_Onatrix.Services;

public interface IEmailService
{
    EmailRequest UnpackEmailRequest(ServiceBusReceivedMessage message);

    bool SendEmail(EmailRequest emailRequest);
}
