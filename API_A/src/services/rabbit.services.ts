import ampq from "amqplib";

export class RabbitMqService{
    async enviar(mensagem: string) : Promise<any>{
        const fila = "Fila - Folhas";
        const rabbitURL = "amqp://localhost";
        try{
            const connection = await ampq.connect(rabbitURL);
            const channel = await connection.createChannel();

            await channel.assertQueue(fila, {
                autoDelete: false,
                exclusive: false,
                durable: false,
                arguments: null,
            });

            await channel.sendToQueue(fila, Buffer.from(mensagem));
            await channel.close();
            await connection.close();
        }catch (erro){
            console.log(erro);
        }
    }
}