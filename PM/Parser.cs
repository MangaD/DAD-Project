using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

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
                                    if (!Int32.TryParse(m.Groups[8].Value.ToString(), out int minAttendees))
                                    {
                                        throw new ParserException($"Error at line {count + 1}. min_attendees is not " +
                                            "a valid number.");
                                    }
                                    if (!Int32.TryParse(m.Groups[9].Value.ToString(), out int noSlots))
                                    {
                                        throw new ParserException($"Error at line {count + 1}. number_of_slots is " +
                                            "not a valid number.");
                                    }
                                    if (!Int32.TryParse(m.Groups[10].Value.ToString(), out int noInvitees))
                                    {
                                        throw new ParserException($"Error at line {count + 1}. number_of_invitees " +
                                            "is not a valid number.");
                                    }

                                    string[] slotsInvitees = m.Groups[11].Value.ToString().Split(' ');

                                    if (noSlots + noInvitees != slotsInvitees.Length)
                                    {
                                        throw new ParserException($"Error at line {count + 1}. number_of_slots + " +
                                            "number_of_invitees does not match the quantity of arguments provided.");
                                    }

                                    List<string> l = new List<string>() {
                                            m.Groups[6].Value.ToString(),
                                            m.Groups[7].Value.ToString(),//topic
                                            minAttendees.ToString(),
                                            noSlots.ToString(),
                                            noInvitees.ToString()
                                        };

                                    // Validate slots
                                    for (int i = 0; i < noSlots; i++)
                                    {
                                        try
                                        {
                                            Slot.fromString(slotsInvitees[i]);
                                        }
                                        catch (ArgumentException)
                                        {
                                            throw new ParserException($"Error at line {count + 1}. Invalid slot: {slotsInvitees[i]}");
                                        }
                                        l.Add(slotsInvitees[i]);
                                    }

                                    // Add invitees
                                    for (int i = 0; i < noInvitees; i++)
                                    {
                                        l.Add(slotsInvitees[i]);
                                    }

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
            // TODO
            foreach (var command in commands)
            {
                if (command[0].Equals("list", StringComparison.OrdinalIgnoreCase))
                {
                    //server.listMeetings();
                }
                else if (command[0].Equals("join", StringComparison.OrdinalIgnoreCase))
                {
                    //server.joinMeeting(command[1]);
                }
                else if (command[0].Equals("close", StringComparison.OrdinalIgnoreCase))
                {
                    //server.closeMeeting(command[1]);
                }
                else if (command[0].Equals("create", StringComparison.OrdinalIgnoreCase))
                {
                    string topic = command[1];
                    Int32.TryParse(command[2], out int minAttendees);
                    Int32.TryParse(command[3], out int noSlots);
                    Int32.TryParse(command[4], out int noInvitees);

                    List<Slot> slots = new List<Slot>();
                    List<string> invitees = new List<string>();

                    for (int i = 0; i < noSlots; i++)
                    {
                        slots.Add(Slot.fromString(command[i]));
                    }

                    for (int i = 0; i < noInvitees; i++)
                    {
                        invitees.Add(command[i]);
                    }

                    //server.createMeeting(command[1], (uint)minAttendees, slots, invitees);
                }
                else if (command[0].Equals("wait", StringComparison.OrdinalIgnoreCase))
                {
                    Utilities.Wait(Int32.Parse(command[1]));
                }
                foreach (string s in command)
                {
                    Utilities.WriteDebug(s + " ");
                }
                Console.Write("\r\n");

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
