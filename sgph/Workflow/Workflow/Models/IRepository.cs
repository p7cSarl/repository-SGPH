﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workflow.Models
{
    interface IRepository
    {
        IEnumerable<User> Users { get; }
        Task<int> saveUser(User user);
        User deleteUser(int userId);

        IEnumerable<Project> Projects { get; }
        int saveProject(Project project);
        Project deleteProject(int projectId);
        Project findProject(int id);

        IEnumerable<Client> Clients { get; }
        Task<int> saveClient(Client client);
        Client deleteClient(int clientId);
    }
}
