using Confluent.Kafka;
using GypsyIntel.Calculators.DataModels;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace GypsyIntel.Producer
{
    public class Producer
    {
        private ProducerConfig producerConfig;

        public Producer()
        {
            producerConfig = new ProducerConfig()
            {
                BootstrapServers = "localhost:9092",
                ClientId = "GypsyIntel",
                Acks = Acks.Leader
            };
        }

        public async Task Produce(IntelModel intel)
        {
            using (var producer = new ProducerBuilder<string, string>(producerConfig).Build())
            {
                await producer.ProduceAsync(intel.Topic, new Message<string, string> { Key = intel.Id, Value = JsonConvert.SerializeObject(intel) });
            }
        }
    }
}
