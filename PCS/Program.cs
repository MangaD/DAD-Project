using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

using API;

namespace PCS
{
    class Program
    {
        private static UInt16 PCSPort = 10000;
        private static string PCSChannel = "MSPCS";

        public static Dictionary<string, Process> clientProcesses = new Dictionary<string, Process>();
        public static Dictionary<string, Process> serverProcesses = new Dictionary<string, Process>();

        static void Main(string[] args)
        {
            TcpChannel pcsChannel = new TcpChannel(PCSPort);
            ChannelServices.RegisterChannel(pcsChannel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(PCSServices),
                PCSChannel, WellKnownObjectMode.Singleton);

            System.Console.WriteLine("<enter> to quit PCS...");
            System.Console.ReadLine();
        }
    }

    public class PCSServices : MarshalByRefObject, IPCS
    {

        public void StartClient(string username, RemotingAddress clientRA, RemotingAddress serverRA, string scriptFile)
        {
            if (Program.clientProcesses.ContainsKey(username))
            {
                throw new RemotingException($"PCS: Client with username '{ username }' already exists.");
            }

            var procPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory() +
                @"\..\..\..\Client\bin\Debug\Client.exe"));

            Console.WriteLine($"Starting client:\n\t" +
                $"Username: {username}\n\t" +
                $"Client URL: {clientRA.ToString()}\n\t" +
                $"Server URL: {serverRA.ToString()}\n\t" +
                $"Script path: {scriptFile}\n\t" +
                $"Proc. path: {procPath}");

            Process client = RunProcess(procPath,
                $"{username} {clientRA.ToString()} {serverRA.ToString()} {scriptFile}");

            client.Exited += new EventHandler(delegate (Object o, EventArgs a)
            {
                Program.clientProcesses.Remove(username);
                Console.WriteLine($"Client '{username}' has exited.");
            });

            Program.clientProcesses.Add(username, client);
        }

        public void StartServer(string serverId, RemotingAddress serverRA, uint maxFaults, uint minDelay, uint maxDelay)
        {
            if (Program.serverProcesses.ContainsKey(serverId))
            {
                throw new RemotingException($"PCS: Server with ID '{ serverId }' already exists.");
            }

            var procPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory() +
                @"\..\..\..\Server\bin\Debug\Server.exe"));

            Console.WriteLine($"Starting server:\n\t" +
                $"ID: {serverId}\n\t" +
                $"URL: {serverRA.ToString()}\n\t" +
                $"Max Faults: {maxFaults}\n\t" +
                $"Min Delay: {minDelay}\n\t" +
                $"Max Delay: {maxDelay}\n\t" +
                $"Proc. path: {procPath}");

            Process server = RunProcess(procPath,
                $"{serverId} {serverRA.ToString()} {maxFaults} {minDelay} {maxDelay}");

            server.Exited += new EventHandler(delegate (Object o, EventArgs a)
            {
                Program.serverProcesses.Remove(serverId);
                Console.WriteLine($"Server '{serverId}' has exited.");
            });

            Program.serverProcesses.Add(serverId, server);
        }

        private static Process RunProcess(string path, string args)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = path;
            proc.StartInfo.Arguments = args;

            // Set working directory to this process path instead of PCS path
            proc.StartInfo.WorkingDirectory = new FileInfo(path).Directory.FullName;

            // In case we want them to use the PCS shell we set this to false
            proc.StartInfo.UseShellExecute = true;

            // In case we want to redirect output to PCS we set these to true
            proc.StartInfo.RedirectStandardError = false;
            proc.StartInfo.RedirectStandardInput = false;

            // Necessary for Exited event to fire
            // https://stackoverflow.com/questions/4504170/why-is-my-processs-exited-method-not-being-called
            proc.EnableRaisingEvents = true;

            proc.Start();

            return proc;
        }
    }

}
