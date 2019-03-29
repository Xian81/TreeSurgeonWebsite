using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeSurgeonWebsite.Data.IDAO;

namespace TreeSurgeonWebsite.Data.DAO
{
    public class ContactDAO : IContact
    {
        private TreeWebsite treeWebsite;
        public ContactDAO() { treeWebsite = new TreeWebsite(); }

        public IList<Contact> GetContacts()
        {
            throw new NotImplementedException();
        }
    }
}
