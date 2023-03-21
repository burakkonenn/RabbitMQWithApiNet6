namespace RabbitMQWithApiNet6.RabbitMQ
{
    public interface IRabitMQProducer
    {
        public void SendProductMessage<T>(T message);

    }
}
