using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._05___Dependency_Inversion_Principle.Violation
{
    public class Client
    {
        #region ==== Props ====

        public int ClientId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public bool IsActive { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }
        #endregion

        #region ==== Methods ====
        public bool IsValid()
        {
            #region [1] ============ [Check Valid User] ============
            if (!IsActive || Age < 18 || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Name))
            {
                return false;
            }
            return true;
            #endregion
        }
        #endregion
    }
}