using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
using System.Runtime.Serialization;

namespace QueueServices
{
    class QueueServicesClient
    {

        static void Main(string[] args)
        {
            //CreateFireEvent("Emergency", "RED", 120, "Emergency - Notify Fire Dept.", "92610");
            //Sender.Send(CreateFireEvent("Emergency", "RED", 120, "Emergency - Notify Fire Dept.", "92610"));
            //Receiver.Receive();

            //Queue testing
            QSender.SendQ(CreateFireEvent("Emergency", "RED", 112, "Emergency - Notify Fire Dept.", "92708"));
            //QSender.SendQ(CreateFireEvent("Warning", "Yellow", 105, "Warning - Notify Fire Dept.", "92610"));

            //Topic testing
            //TopicSender.SendToTopic(CreateWeatherEvent("Fire", 126, true, "Foothill Ranch", "92610"));
            TopicSender.SendToTopic(CreateWeatherEvent("Wind", 108, true, "Fountain Valley", "92708"));
            
        }

        private static FireEvent CreateFireEvent(string alertType, string alertColor, Int32 teperature, string alertMessage, string zipCode)
        {
            FireEvent fireEvent = new FireEvent();
            fireEvent.AlertType = alertType;
            fireEvent.AlertColor = alertColor;
            fireEvent.Temperature = teperature;
            fireEvent.AlertMessage = alertMessage;
            fireEvent.ZipCode = zipCode;
            return fireEvent;
        }

        private static WeatherEvent CreateWeatherEvent(string eventType, Int32 temperature, bool isAlert, string affectedArea, string zipCode)
        {
            WeatherEvent weatherEvent = new WeatherEvent();
            weatherEvent.EventType = eventType;
            weatherEvent.Temperature = temperature;
            weatherEvent.IsAlert = isAlert;
            weatherEvent.AffectedArea = affectedArea;
           weatherEvent.ZipCode = zipCode;
            return weatherEvent;
        }

    }

    class QReceiver
    {

        const string QueueName = "firealertqueue";
        static string ServiceNamespace = "apressrecipens";
        static string IssuerName = "owner";
        static string IssuerKey = "tXj+aIoZFKPt2X0dcaRCkUojrRaefzU55t6xaaHbWy4=";

        public static void ReceiveQ()
        {


            Console.WriteLine("In Receive method().");

            TokenProvider credentials = TokenProvider.CreateSharedSecretTokenProvider(QReceiver.IssuerName, QReceiver.IssuerKey);
            Uri serviceUri = ServiceBusEnvironment.CreateServiceUri("sb", QReceiver.ServiceNamespace, string.Empty);

            MessagingFactory factory = null;

            factory = MessagingFactory.Create(serviceUri, credentials);

            QueueClient sessionQueueClient = factory.CreateQueueClient(QReceiver.QueueName);

            //Create sessionQueueClient and subscribe to SessionIDs that have a value of "Mike"
            MessageSession sessionReceiver = sessionQueueClient.AcceptMessageSession("92610", TimeSpan.FromSeconds(60));
            BrokeredMessage receivedMessage;

            while ((receivedMessage = sessionReceiver.Receive(TimeSpan.FromSeconds(60))) != null)
            {
                Console.WriteLine("Received Messages.");
                var data = receivedMessage.GetBody<FireEvent>(new DataContractSerializer(typeof(FireEvent)));
                //Console.WriteLine(String.Format("Customer Name: {0}", data.CustomerName));
                Console.WriteLine("SessionID: {0}", receivedMessage.SessionId);
                //remove message from Topic
                receivedMessage.Complete();
            }

            Console.WriteLine("All received on this session...press enter to exit");
            Console.Read();
        }
    }

    class QSender
    {

        const string QueueName = "firealertqueue";
        static string ServiceNamespace = "apressrecipens";
        static string IssuerName = "owner";
        static string IssuerKey = "Some Valid Issuer Key";

         public static void SendQ(FireEvent fireEvent)
        {
            TokenProvider credentials = TokenProvider.CreateSharedSecretTokenProvider(QSender.IssuerName, QSender.IssuerKey);
            Uri serviceUri = ServiceBusEnvironment.CreateServiceUri("sb", QSender.ServiceNamespace, string.Empty);

            MessagingFactory factory = null;

            factory = MessagingFactory.Create(serviceUri, credentials);

            QueueClient qClient = factory.CreateQueueClient(QSender.QueueName);

            BrokeredMessage brokeredMessage = new BrokeredMessage(fireEvent, new DataContractSerializer(typeof(FireEvent)));
            brokeredMessage.Properties.Add("ZipCode", fireEvent.ZipCode);
            brokeredMessage.Properties.Add("AlertType", fireEvent.AlertType);
            brokeredMessage.Properties.Add("EventType", "Weather");
            brokeredMessage.Properties.Add("IsAlert", true);

            qClient.Send(brokeredMessage);

            Console.WriteLine("press enter to exit....");
            Console.Read();
        }
    }


    class TopicSender
    {

        const string TopicName = "weatheralerttopic";
        static string ServiceNamespace = "apressrecipens";
        static string IssuerName = "owner";
        static string IssuerKey = "tXj+aIoZFKPt2X0dcaRCkUojrRaefzU55t6xaaHbWy4=";

        public static void SendToTopic(WeatherEvent weatherEvent)
        {
            TokenProvider credentials = TokenProvider.CreateSharedSecretTokenProvider(TopicSender.IssuerName, TopicSender.IssuerKey);
            Uri serviceUri = ServiceBusEnvironment.CreateServiceUri("sb", TopicSender.ServiceNamespace, string.Empty);

            MessagingFactory factory = null;

            factory = MessagingFactory.Create(serviceUri, credentials);

            TopicClient topicClient = factory.CreateTopicClient(TopicSender.TopicName);

            BrokeredMessage brokeredMessage = new BrokeredMessage(weatherEvent, new DataContractSerializer(typeof(WeatherEvent)));
            brokeredMessage.Properties.Add("ZipCode", weatherEvent.ZipCode);
            brokeredMessage.Properties.Add("EventType", weatherEvent.EventType);
            brokeredMessage.Properties.Add("AlertType", "Weather");
            brokeredMessage.Properties.Add("IsAlert", true);

            topicClient.Send(brokeredMessage);

            Console.WriteLine("Sent to Topic...press enter to exit");
            Console.Read();
        }
    }


}
