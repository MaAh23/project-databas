using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_data.Entities
{
    internal class RoleEntity
    {
        [Key]

        public int Id { get; set; }
        public string RolesName { get; set; }  = null!;
        public string RoleName { get; internal set; }
    }
}
