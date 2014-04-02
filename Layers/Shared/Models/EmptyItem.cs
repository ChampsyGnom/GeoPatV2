using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emash.GeoPat.Layers.Shared.Models
{
    public  class EmptyItem : DynamicObject
    {
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            // just set the result to null and return true 
            result = null;
            return true;
        }
    } 
}
