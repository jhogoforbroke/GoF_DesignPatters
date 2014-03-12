using System.Collections.Generic;
using System.Text;

namespace Creational.Builder.ExemploDidatico
{
    class Product
    {
        private List<string> _parts = new List<string>();
 
        public void Add(string part)
        {
            _parts.Add(part);
        }

        public string Show()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Product Parts:");
            foreach (var part in _parts)
            {
                stringBuilder.AppendLine(part);
            }
            return stringBuilder.ToString();
        }
    }
}
