using Sequential;
using System;
//todo [Assignment]: add required namespaces

namespace Concurrent
{
    public class ConcurrentServer : SequentialServer
    {
        // todo [Assignment]: implement required attributes specific for concurrent server

        public ConcurrentServer(Setting settings) : base(settings)
        {
            // todo [Assignment]: implement required code
            Console.WriteLine("ConcurrentServer()");
        }
        public override void prepareServer()
        {
            // todo [Assignment]: implement required code
            Console.WriteLine("ConcurrentServer.prepareServer()");
        }
        public override string processMessage(String msg)
        {
            // todo [Assignment]: implement required code
            Console.WriteLine("ConcurrentServer.processMessage(String msg)");
            return "";
        }
    }
}