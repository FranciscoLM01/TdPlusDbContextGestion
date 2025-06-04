using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;

namespace TdPlusDbContextGestion.Domain.Entities.TranSPEi
{
    public class Module
    {
        public string? Name { get; set; }
        public Submodule? Submodule { get; set; }
    }

    public class Role
    {
        public Profile? Profile { get; set; }
        public List<Module>? Modules { get; set; }
    }

    public class Profile
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }

    public class Authentication
    {
        public User? User { get; set; }
        public List<Role>? Roles { get; set; }
        public List<Module>? AvailableModules { get; set; }

        // TODO: this fix is only to allow work with SPEI
        [NotMapped]
        public List<string>? AvailablePermissions { get; set; }
    }

    public class Submodule
    {
        public string? Name { get; set; }
        public List<object>? Permissions { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public int IndirectParticipantId { get; set; }
        public int ProfileId { get; set; }
        public string? Name { get; set; }
        public string? FatherLastName { get; set; }
        public string? MotherLastName { get; set; }
        public string? Email { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? PhoneNumber { get; set; }
        public int InternalUser { get; set; }
    }
}
