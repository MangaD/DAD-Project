using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

using API;

namespace Client
{
    class Parser
    {
        private IServer server;
        private string filename;
        private List<List<string>> commands = new List<List<string>>();

        public Parser (string filename, IServer server)
        {
            this.filename = filename;
            this.server = server;
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
                 * Group 4: 'join' or 'close'
                 * Group 5: string argument for 'join' or 'close'
                 * Group 6: 'create'
                 * Group 7: meeting topic
                 * Group 8: min_attendees
                 * Group 9: number_of_slots
                 * Group 10: number_of_invitees
                 * Group 11: slots + invitees (need to be validated)
                 * Character ; and anything after is ignored
                 */
                string regex = @"(?:(?:(wait)\s+(\d+))|(list)|(?:(join|close)\s+(\w+))|(?:(create)\s+(\w+)\s+(\d+)\s+(\d+)\s+(\d+)\s+(.*)))?;?.*";

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
                                    Utilities.WriteError($"Error at line {count + 1}.");
                                    Console.ReadKey();
                                    Environment.Exit(0);
                                }

                                Match m = matches[0];

                                if (!string.IsNullOrEmpty(m.Groups[1].Value.ToString()))
                                {
                                    List<string> l = new List<string>() {
                                            m.Groups[1].Value.ToString(),
                                            m.Groups[2].Value.ToString()
                                        };
                                    commands.Add(l);
                                }
                                else if (!string.IsNullOrEmpty(m.Groups[3].Value.ToString()))
                                {
                                    List<string> l = new List<string>() {
                                            m.Groups[3].Value.ToString()
                                        };
                                    commands.Add(l);
                                }
                                else if (!string.IsNullOrEmpty(m.Groups[4].Value.ToString()))
                                {
                                    List<string> l = new List<string>() {
                                            m.Groups[4].Value.ToString(),
                                            m.Groups[5].Value.ToString()
                                        };
                                    commands.Add(l);
                                }
                                else if (!string.IsNullOrEmpty(m.Groups[6].Value.ToString()))
                                {
                                    if (!Int32.TryParse(m.Groups[8].Value.ToString(), out int minAttendees))
                                    {
                                        Utilities.WriteError($"Error at line {count + 1}. min_attendees is not a valid number.");
                                        Console.ReadKey();
                                        Environment.Exit(0);
                                    }
                                    if (!Int32.TryParse(m.Groups[9].Value.ToString(), out int noSlots))
                                    {
                                        Utilities.WriteError($"Error at line {count + 1}. number_of_slots is not a valid number.");
                                        Console.ReadKey();
                                        Environment.Exit(0);
                                    }
                                    if (!Int32.TryParse(m.Groups[10].Value.ToString(), out int noInvitees))
                                    {
                                        Utilities.WriteError($"Error at line {count + 1}. number_of_invitees is not a valid number.");
                                        Console.ReadKey();
                                        Environment.Exit(0);
                                    }

                                    string[] slotsInvitees = m.Groups[11].Value.ToString().Split(' ');

                                    if (noSlots + noInvitees < slotsInvitees.Length ||
                                        noSlots + noInvitees > slotsInvitees.Length)
                                    {
                                        Utilities.WriteError($"Error at line {count + 1}. number_of_slots + number_of_invitees does not match the quantity of arguments provided.");
                                        Console.ReadKey();
                                        Environment.Exit(0);
                                    }

                                    string location;
                                    int day, mon, year;

                                    for (int i = 0; i < noSlots; i++)
                                    {
                                        string r = @"(\w+),(\d{4})-(\d{1,2})-(\d{1,2})";

                                        MatchCollection mat = Regex.Matches(slotsInvitees[i], r);

                                        if (mat.Count <= 0)
                                        {
                                            Utilities.WriteError($"Error at line {count + 1}. Invalid slot: {slotsInvitees[i]}");
                                            Console.ReadKey();
                                            Environment.Exit(0);
                                        }

                                        Match m2 = mat[0];

                                        location = m2.Groups[1].Value.ToString();
                                        year = Int32.Parse(m2.Groups[2].Value.ToString());
                                        mon = Int32.Parse(m2.Groups[3].Value.ToString());
                                        day = Int32.Parse(m2.Groups[4].Value.ToString());
                                        Utilities.WriteDebug($"Loc: {location}, Year: {year}, Month: {mon}, Day: {day}");
                                    }

                                    List<string> l = new List<string>() {
                                            m.Groups[6].Value.ToString(),
                                            m.Groups[7].Value.ToString(),
                                            m.Groups[8].Value.ToString(),
                                            m.Groups[9].Value.ToString(),
                                            m.Groups[10].Value.ToString(),
                                            m.Groups[11].Value.ToString()
                                        };
                                    commands.Add(l);
                                }
                                else
                                {
                                    Utilities.WriteError($"Error at line {count + 1}.");
                                    Console.ReadKey();
                                    Environment.Exit(0);
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
                Utilities.WriteError("Exception: " + e.Message);
            }
        }

        public void ExecCommands()
        {
            // TODO
            foreach (var command in commands)
            {
                if (command[0].Equals("list", StringComparison.OrdinalIgnoreCase))
                {
                    server.listMeetings();
                }
                else if (command[0].Equals("join", StringComparison.OrdinalIgnoreCase))
                {
                    server.joinMeeting(command[1]);
                }
                else if (command[0].Equals("close", StringComparison.OrdinalIgnoreCase))
                {
                    server.closeMeeting(command[1]);
                }
                else if (command[0].Equals("create", StringComparison.OrdinalIgnoreCase))
                {
                    /*string topic = command[1];
                    Int32.TryParse(command[2], out int minAttendees);
                    Int32.TryParse(command[3], out int noSlots);
                    Int32.TryParse(command[4], out int noInvitees);

                    string location;
                    int day, mon, year;

                    for (int i = 0; i < noSlots; i++)
                    {
                        string r = @"(\w+),(\d{4})-(\d{1,2})-(\d{1,2})";

                        MatchCollection mat = Regex.Matches(slotsInvitees[i], r);

                        if (mat.Count <= 0)
                        {
                            Utilities.WriteError($"Error at line {count + 1}. Invalid slot: {slotsInvitees[i]}");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }

                        Match m2 = mat[0];

                        location = m2.Groups[1].Value.ToString();
                        year = Int32.Parse(m2.Groups[2].Value.ToString());
                        mon = Int32.Parse(m2.Groups[3].Value.ToString());
                        day = Int32.Parse(m2.Groups[4].Value.ToString());
                        Utilities.WriteDebug($"Loc: {location}, Year: {year}, Month: {mon}, Day: {day}");
                    }

                    server.createMeeting(command[1]);*/
                }
                else if (command[0].Equals("wait", StringComparison.OrdinalIgnoreCase))
                {
                    Utilities.Wait(command[1]);
                }
                foreach (string s in command)
                {
                    Utilities.WriteDebug(s + " ");
                }
                Console.Write("\r\n");

            }
        }
    }
}
