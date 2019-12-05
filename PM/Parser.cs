using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using API;

namespace PM
{
    class Parser
    {
        private string filename;
        private List<List<string>> commands = new List<List<string>>();

        public Parser(string filename)
        {
            this.filename = filename;
        }

        public void Parse()
        {
            string line;
            int count = 0;
            try
            {
                /**
                 * Group 1: 'Crash', 'Freeze' or 'Unfreeze'
                 * Group 2: server_id
                 * Group 3: 'Wait'
                 * Group 4: time to wait in ms
                 * Group 5: 'Status'
                 * Group 6: 'Server'
                 * Group 7: server_id
                 * Group 8: server url
                 * Group 9: max_faults
                 * Group 10: min_delay
                 * Group 11: max_delay
                 * Group 12: 'Client'
                 * Group 13: client_id
                 * Group 14: client url
                 * Group 15: server url
                 * Group 16: script_file
                 * Group 17: 'AddRoom'
                 * Group 18: location
                 * Group 19: capacity
                 * Group 20: room name
                 */
                string regex = @"(?:(?:(Crash|Freeze|Unfreeze)\s+(.+))|(?:(Wait)\s+(\d+))|(Status)|(?:(Server)\s+([^ ]+)\s+([^\s]+)\s+(\d+)\s+(\d+)\s+(\d+))|(?:(Client)\s+([^ ]+)\s+([^\s]+)\s+([^\s]+)\s+(.+))|(?:(AddRoom)\s+([^\s]+)\s+(\d+)\s+(.+)))?;?.*";

                using (StreamReader sr = new StreamReader(filename))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.Trim();
                        if (!string.IsNullOrEmpty(line))
                        {
                            if (!line.StartsWith(";", StringComparison.CurrentCulture))
                            {
                                MatchCollection matches = Regex.Matches(line, regex, RegexOptions.IgnoreCase);

                                if (matches.Count <= 0)
                                {
                                    throw new ParserException($"Error at line {count + 1}.");
                                }

                                Match m = matches[0];

                                // Crash, Freeze, Unfreeze
                                if (!string.IsNullOrEmpty(m.Groups[1].Value.ToString()))
                                {
                                    List<string> l = new List<string>() {
                                            m.Groups[1].Value.ToString(),
                                            m.Groups[2].Value.ToString()
                                        };
                                    commands.Add(l);
                                }
                                // wait
                                else if (!string.IsNullOrEmpty(m.Groups[3].Value.ToString()))
                                {
                                    if (!Int32.TryParse(m.Groups[4].Value.ToString(), out int ms))
                                    {
                                        throw new ParserException($"Error at line {count + 1}. milliseconds is not " +
                                            "a valid number.");
                                    }
                                    List<string> l = new List<string>() {
                                            m.Groups[3].Value.ToString(),
                                            m.Groups[4].Value.ToString()
                                        };
                                    commands.Add(l);
                                }
                                // status
                                else if (!string.IsNullOrEmpty(m.Groups[5].Value.ToString()))
                                {
                                    List<string> l = new List<string>() {
                                            m.Groups[5].Value.ToString()
                                        };
                                    commands.Add(l);
                                }
                                // server
                                else if (!string.IsNullOrEmpty(m.Groups[6].Value.ToString()))
                                {
                                    if (!Int32.TryParse(m.Groups[9].Value.ToString(), out int maxFaults))
                                    {
                                        throw new ParserException($"Error at line {count + 1}. max_faults is not " +
                                            "a valid number.");
                                    }
                                    if (!Int32.TryParse(m.Groups[10].Value.ToString(), out int minDelay))
                                    {
                                        throw new ParserException($"Error at line {count + 1}. min_delay is " +
                                            "not a valid number.");
                                    }
                                    if (!Int32.TryParse(m.Groups[11].Value.ToString(), out int maxDelay))
                                    {
                                        throw new ParserException($"Error at line {count + 1}. max_delay " +
                                            "is not a valid number.");
                                    }


                                    List<string> l = new List<string>() {
                                            m.Groups[6].Value.ToString(),
                                            m.Groups[7].Value.ToString(),// server id
                                            m.Groups[8].Value.ToString(),// server url
                                            maxFaults.ToString(),
                                            minDelay.ToString(),
                                            maxDelay.ToString()
                                        };

                                    commands.Add(l);
                                }
                                // client
                                else if (!string.IsNullOrEmpty(m.Groups[12].Value.ToString()))
                                {
                                    List<string> l = new List<string>() {
                                            m.Groups[12].Value.ToString(),
                                            m.Groups[13].Value.ToString(),// client id
                                            m.Groups[14].Value.ToString(),// client url
                                            m.Groups[15].Value.ToString(),// server url
                                            m.Groups[16].Value.ToString()// script file
                                        };

                                    commands.Add(l);
                                }
                                // add room
                                else if (!string.IsNullOrEmpty(m.Groups[17].Value.ToString()))
                                {
                                    if (!Int32.TryParse(m.Groups[19].Value.ToString(), out int capacity))
                                    {
                                        throw new ParserException($"Error at line {count + 1}. capacity " +
                                            "is not a valid number.");
                                    }

                                    List<string> l = new List<string>() {
                                            m.Groups[17].Value.ToString(),
                                            m.Groups[18].Value.ToString(),// location
                                            m.Groups[19].Value.ToString(),// capacity
                                            m.Groups[20].Value.ToString(),// room name
                                        };

                                    commands.Add(l);
                                }
                                else
                                {
                                    throw new ParserException($"Error at line {count + 1}.");
                                }
                            }
                        }
                        count++;
                    }

                    Utilities.WriteDebug($"Read {count} lines from '{filename}'.");
                }
            }
            catch (Exception e)
            {
                throw new ParserException("Exception: " + e.Message);
            }
        }

        public void ExecCommands()
        {
            foreach (var command in commands)
            {
                MessageBox.Show("PM Will Execute... " + command[0]);

                if (command[0].Equals("crash", StringComparison.OrdinalIgnoreCase))
                {
                    IServerPM server = Program.GetServer(command[1]);

                    try
                    {
                        server.Crash();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //return;
                    }
                }
                else if (command[0].Equals("freeze", StringComparison.OrdinalIgnoreCase))
                {
                    IServerPM server = Program.GetServer(command[1]);

                    try
                    {
                        server.Freeze();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //return;
                    }
                }
                else if (command[0].Equals("unfreeze", StringComparison.OrdinalIgnoreCase))
                {
                    IServerPM server = Program.GetServer(command[1]);

                    try
                    {
                        server.Unfreeze();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //return;
                    }
                }
                else if (command[0].Equals("wait", StringComparison.OrdinalIgnoreCase))
                {
                    Utilities.Wait(Int32.Parse(command[1]));
                }
                else if (command[0].Equals("status", StringComparison.OrdinalIgnoreCase))
                {
                    Program.PrintStatus();
                }
                else if (command[0].Equals("server", StringComparison.OrdinalIgnoreCase))
                {
                    try
                    {
                        Program.CreateServer(command[1], RemotingAddress.FromString(command[2]),
                            Convert.ToUInt32(command[3]), Convert.ToUInt32(command[4]), Convert.ToUInt32(command[5]));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error creating server: {ex.Message}",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        //return;
                    }
                }
                else if (command[0].Equals("client", StringComparison.OrdinalIgnoreCase))
                {
                    try
                    {
                        Program.CreateClient(command[1], RemotingAddress.FromString(command[2]),
                            RemotingAddress.FromString(command[3]), command[4]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error creating client: {ex.Message}",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        //return;
                    }
                }
                else if (command[0].Equals("AddRoom", StringComparison.OrdinalIgnoreCase))
                {
                    if (Program.serverList.Count == 0)
                    {
                        MessageBox.Show($"Cannot add room '{command[3]}' because there are no servers running.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;//return;
                    }

                    try
                    {
                        Program.serverList[0].Item3.AddRoom(command[1], Convert.ToUInt32(command[2]), command[3]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //return;
                    }
                }

                foreach (string s in command)
                {
                    Utilities.WriteDebug(s + " ");
                }
                Console.Write("\r\n");

                //MessageBox.Show("PM Executed: " + command[0]);
            }
        }
    }

    [Serializable]
    class ParserException : Exception
    {
        public ParserException(string msg)
            : base($"ParserException: {msg}")
        { }

    }
}
