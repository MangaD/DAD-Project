using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using API;

namespace MSDAD_CLI
{
    class Parser
    {
        private string filename;
        private List<List<string>> commands = new List<List<string>>();

        public Parser (string filename)
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
                 * Group 1: 'wait'
                 * Group 2: integer argument for 'wait'
                 * Group 3: 'list'
                 * Group 4: 'close'
                 * Group 5: string argument for 'close'
                 * Group 6: 'join'
                 * Group 7: meeting topic
                 * Group 8: slot_count (number of slots this user can attend)
                 * Group 9: slots
                 * Group 10: 'create'
                 * Group 11: meeting topic
                 * Group 12: min_attendees
                 * Group 13: number_of_slots
                 * Group 14: number_of_invitees
                 * Group 15: slots + invitees (need to be validated)
                 * Character ; and anything after is ignored
                 */
                string regex = @"(?:(?:(wait)\s+(\d+))|(list)|(?:(close)\s+(\w+))|(?:(join)\s+(\w+)\s+(\d+)\s+(.*))|(?:(create)\s+(\w+)\s+(\d+)\s+(\d+)\s+(\d+)\s+(.*)))?;?.*";

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

                                // wait
                                if (!string.IsNullOrEmpty(m.Groups[1].Value.ToString()))
                                {
                                    if (!Int32.TryParse(m.Groups[2].Value.ToString(), out int ms))
                                    {
                                        throw new ParserException($"Error at line {count + 1}. milliseconds is not " +
                                            "a valid number.");
                                    }

                                    List<string> l = new List<string>() {
                                            m.Groups[1].Value.ToString(),
                                            m.Groups[2].Value.ToString()
                                        };
                                    commands.Add(l);
                                }
                                // list
                                else if (!string.IsNullOrEmpty(m.Groups[3].Value.ToString()))
                                {
                                    List<string> l = new List<string>() {
                                            m.Groups[3].Value.ToString()
                                        };
                                    commands.Add(l);
                                }
                                // close
                                else if (!string.IsNullOrEmpty(m.Groups[4].Value.ToString()))
                                {
                                    List<string> l = new List<string>() {
                                            m.Groups[4].Value.ToString(),
                                            m.Groups[5].Value.ToString()
                                        };
                                    commands.Add(l);
                                }
                                // join
                                else if (!string.IsNullOrEmpty(m.Groups[6].Value.ToString()))
                                {
                                    if (!Int32.TryParse(m.Groups[8].Value.ToString(), out int slotCount))
                                    {
                                        throw new ParserException($"Error at line {count + 1}. slot_count " +
                                            "is not a valid number.");
                                    }

                                    string[] slotsInvitees = m.Groups[9].Value.ToString().Split(' ');

                                    if (slotCount != slotsInvitees.Length)
                                    {
                                        throw new ParserException($"Error at line {count + 1}. slot_count " +
                                            "does not match the quantity of slots provided.");
                                    }

                                    List<string> l = new List<string>() {
                                            m.Groups[6].Value.ToString(),//join
                                            m.Groups[7].Value.ToString(),//topic
                                            slotCount.ToString()//slot_count
                                        };

                                    // Validate slots
                                    for (int i = 0; i < slotCount; i++)
                                    {
                                        try
                                        {
                                            Slot.FromString(slotsInvitees[i]);
                                        }
                                        catch (ArgumentException)
                                        {
                                            throw new ParserException($"Error at line {count + 1}. Invalid slot: {slotsInvitees[i]}");
                                        }
                                        l.Add(slotsInvitees[i]);
                                    }

                                    commands.Add(l);
                                }
                                // create
                                else if (!string.IsNullOrEmpty(m.Groups[10].Value.ToString()))
                                {
                                    if (!Int32.TryParse(m.Groups[12].Value.ToString(), out int minAttendees))
                                    {
                                        throw new ParserException($"Error at line {count + 1}. min_attendees is not " +
                                            "a valid number.");
                                    }
                                    if (!Int32.TryParse(m.Groups[13].Value.ToString(), out int noSlots))
                                    {
                                        throw new ParserException($"Error at line {count + 1}. number_of_slots is " +
                                            "not a valid number.");
                                    }
                                    if (!Int32.TryParse(m.Groups[14].Value.ToString(), out int noInvitees))
                                    {
                                        throw new ParserException($"Error at line {count + 1}. number_of_invitees " +
                                            "is not a valid number.");
                                    }

                                    string[] slotsInvitees = m.Groups[15].Value.ToString().Split(' ');

                                    if (noSlots + noInvitees != slotsInvitees.Length)
                                    {
                                        throw new ParserException($"Error at line {count + 1}. number_of_slots + " +
                                            "number_of_invitees does not match the quantity of arguments provided.");
                                    }

                                    List<string> l = new List<string>() {
                                            m.Groups[10].Value.ToString(),
                                            m.Groups[11].Value.ToString(),//topic
                                            minAttendees.ToString(),
                                            noSlots.ToString(),
                                            noInvitees.ToString()
                                        };

                                    // Validate slots
                                    for (int i = 0; i < noSlots; i++)
                                    {
                                        try
                                        {
                                            Slot.FromString(slotsInvitees[i]);
                                        } catch (ArgumentException)
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
            foreach (var command in commands)
            {
                if (command[0].Equals("list", StringComparison.OrdinalIgnoreCase))
                {
                    Client.ListMeetings();
                }
                else if (command[0].Equals("join", StringComparison.OrdinalIgnoreCase))
                {
                    string topic = command[1];
                    Int32.TryParse(command[2], out int slotCount);

                    List<Slot> slots = new List<Slot>();

                    for (int i = 0; i < slotCount; i++)
                    {
                        slots.Add(Slot.FromString(command[i]));
                    }

                    Client.JoinMeeting(topic, slotCount, slots);
                }
                else if (command[0].Equals("close", StringComparison.OrdinalIgnoreCase))
                {
                    Client.CloseMeeting(command[1]);
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
                        slots.Add(Slot.FromString(command[i]));
                    }

                    for (int i = 0; i < noInvitees; i++)
                    {
                        invitees.Add(command[i]);
                    }

                    Client.CreateMeeting(command[1], (uint) minAttendees, slots, invitees);
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
        {}

    }

}
