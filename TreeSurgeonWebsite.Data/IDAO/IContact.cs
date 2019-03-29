using TreeSurgeonWebsite.Data; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeSurgeonWebsite.Data.IDAO
{
  public interface IContact
    {

        IList<Contact> GetContacts();
    }
}
