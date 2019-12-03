using System;
using SuperSocket.SocketBase;
using SuperWebSocket;

namespace WebSocket
{
    class Program
    {
        public static WebSocketServer wsServer;
        public static void Main()
        {
            wsServer = new WebSocketServer();
            int port = 8088;
            wsServer.Setup(port);

            wsServer.NewSessionConnected += WsServer_NewSessionConnected;
            wsServer.NewMessageReceived += WsServer_NewMessageReceived;
            wsServer.NewDataReceived += WsServer_NewDataReceived;
            wsServer.SessionClosed += WsServer_SessionClosed;

            wsServer.Start();

            Console.WriteLine("Server Running on port: " + port + "Press enter to EXIT!");
            Console.ReadKey();
            wsServer.Stop();
        }

        private static void WsServer_SessionClosed(WebSocketSession session, CloseReason value)
        {
            Console.WriteLine("SessionClosed");
        }

        private static void WsServer_NewDataReceived(WebSocketSession session, byte[] value)
        {
            Console.WriteLine("NewDataReceived");
        }

        private static void WsServer_NewMessageReceived(WebSocketSession session, string value)
        {
            Console.WriteLine("NewMessageReceived");
            if(value == "Hello")
            {
                session.Send("Hello to you too");
            }
        }

        private static void WsServer_NewSessionConnected(WebSocketSession session)
        {
            Console.WriteLine("NewSessionConnected");
        }
    }
}
