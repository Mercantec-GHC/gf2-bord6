using System;
using System.Collections.Generic;
using System.DirectoryServices.Protocols;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AD_Konsol
{
    public class ADService
    {
        private static string _server = "10.133.71.100";
        private static string _username = "adReader";
        private static string _password = "Merc1234!";
        private static string _domain = "mags.local";

        public LdapConnection Connect()
        {
            var credential = new NetworkCredential($"{_username}@{_domain}", _password);
            var connection = new LdapConnection(_server)
            {
                Credential = credential,
                AuthType = AuthType.Negotiate
            };

            return connection;
        }
        public List<ADGroup> SearchGroups(string groupName)
        {
            var groups = GetAllGroups();
            if (string.IsNullOrEmpty(groupName))
            {
                return groups;
            }
            return groups.Where(g => g.Name.Contains(groupName, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public List<ADGroup> GetGroupsWithMembers()
        {
            var groups = GetAllGroups();
            foreach (var group in groups)
            {
                group.Members = GetGroupMembers(group.Name);
            }
            return groups;

        }

        private List<ADUser> GetGroupMembers(string groupName)
        {
            // TODO: Query LDAP for users in the group
            return new List<ADUser>(); // Return actual members here
        }

        public string GetServer()
        {
            try
            {
                using (var connection = Connect())
                {
                    Console.WriteLine("Connecting to server...");
                    connection.Bind();
                    return "Kørende";
                }
            }
            catch (Exception message)
            {
                return $"Ikke kørende - {message}";
            }
        }

        public List<ADGroup> GetAllGroups()
        {
            // Opret en tom liste til at gemme alle AD grupper
            var groups = new List<ADGroup>();

            // Opret forbindelse til Active Directory
            using (var connection = Connect())
            {
                // Definer søgningen:
                // - Hvor skal vi søge: i "mags.local" domænet
                // - Hvad søger vi efter: alle objekter af typen "group"
                // - Hvilke informationer vil vi have: 
                // - navn (cn) og beskrivelse
                var searchRequest = new SearchRequest(
                "DC=mags,DC=local", // Søg i dette domæne
                "(objectClass=group)", // Find alle grupper
                SearchScope.Subtree, // Søg i hele domænet
                "cn", // Gruppens navn
                  "description" // Gruppens beskrivelse
                  );

                try
                {
                    // Udfør søgningen
                    var response = (SearchResponse)connection.SendRequest(searchRequest);

                    // For hver gruppe vi finder
                    foreach (SearchResultEntry gruppe in response.Entries)
                    {
                        // Opret et nyt ADGroup objekt med informationerne
                        var nyGruppe = new ADGroup
                        {
                            // Hvis værdien ikke findes, brug "N/A" som standard
                            Name = gruppe.Attributes["cn"]?[0]?.ToString() ?? "N/A",
                            Description = gruppe.Attributes["description"]?[0]?.ToString() ?? "N/A"
                        };

                        // Tilføj gruppen til vores liste
                        groups.Add(nyGruppe);
                    }
                }
                catch (Exception ex)
                {
                    // Hvis noget går galt, fortæl hvad der skete
                    throw new Exception($@"Der skete en fejl ved hentning af grupper:
	     {ex.Message}");
                }
            }

            // Send alle de fundne grupper tilbage
            return groups;
        }



        public  List<ADUser> GetAllUsers()
        {
            var users = new List<ADUser>();

            using (var connection = Connect())
            {
                var searchRequest = new SearchRequest(
                    "DC=mags,DC=local",
                    "(objectClass=user)",
                    SearchScope.Subtree,
                    "cn",
                    "samAccountName",
                    "mail",
                    "department",
                    "title",
                    "distinguishedName"
                );

                try
                {
                    var response = (SearchResponse)connection.SendRequest(searchRequest);

                    foreach (SearchResultEntry entry in response.Entries)
                    {
                        var user = new ADUser
                        {
                            Name = entry.Attributes["cn"]?[0]?.ToString() ?? "N/A",
                            Username = entry.Attributes["samAccountName"]?[0]?.ToString()
                            ?? "N/A",
                            Email = entry.Attributes["mail"]?[0]?.ToString() ?? "N/A",
                            Department = entry.Attributes["department"]?[0]?.ToString()
                            ?? "N/A",
                            Title = entry.Attributes["title"]?[0]?.ToString() ?? "N/A",
                            DistinguishedName = entry.Attributes
                            ["distinguishedName"]?[0]?.ToString() ?? "N/A"
                        };

                        users.Add(user);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Fejl ved hentning af brugere: {ex.Message}");
                }
            }

            return users;
        }


        public List<ADUser> SearchUsers(string name, string email, string department)
        {
            var users = GetAllUsers();
            var matchingUsers = new List<ADUser>();

            foreach (var user in users)
            {   
                bool matches = true;

                // Check name
                if (name != null && name != "")
                {
                    if (user.Name == null || !user.Name.Contains(name))
                    {
                        matches = false;
                    }
                }

                // Check email
                if (email != null && email != "")
                {
                    if (user.Email == null || !user.Email.Contains(email))
                    {
                        matches = false;
                    }
                }

                // Check department
                if (department != null && department != "")
                {
                    if (user.Department == null || !user.Department.Contains(department))
                    {
                        matches = false;
                    }
                }

                if (matches)
                {
                    matchingUsers.Add(user);
                }
            }

            return matchingUsers;
        }

    }
        public class ADUser
        {
            public string Name { get; set; }
            public string Username { get; set; }
            public string Email { get; set; }
            public string Department { get; set; }
            public string Title { get; set; }
            public string DistinguishedName { get; set; }
        }
        public class ADGroup
        {
            public string Name { get; set; }
            public string Description { get; set; }

            public List<ADUser> Members { get; set; } = new List<ADUser>();
        }
}
