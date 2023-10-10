using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatValidator.String
{
    public interface IValidator
    {
        public bool Validate(string text);
    }
}
