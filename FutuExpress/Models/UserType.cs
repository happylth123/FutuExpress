using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutuExpress.Models
{
    /// <summary>
    /// User Type
    /// </summary>
    public enum UserType
    {
        /// <summary>
        /// the Administrator
        /// </summary>
        [Description("Administrator")]
        Administrator = 0,

        /// <summary>
        /// the Customer
        /// </summary>
        [Description("User")]
        User = 1,
    }
}
