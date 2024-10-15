using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_EntityFramework
{
    public class ContactRepository
    {
        public Entities contexto = new Entities();
        public List<Contact> ObtenerTodos()
        {
            var contact = from custM in contexto.Contact select custM;

            return contact.ToList();
        }

        public int InsertarContact(Contact contact)
        {
            contexto.Contact.Add(contact);
            return contexto.SaveChanges();
        }
        
    }
}
