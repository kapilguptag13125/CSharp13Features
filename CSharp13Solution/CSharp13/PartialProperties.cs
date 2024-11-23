using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13
{
    public class PartialProperties
    {

    }

    public partial class User
    {
        public partial string Name { get; set; }
    }

    public partial class User
    {
        private string _name = string.Empty;
        public partial string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
    }
}
