using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatabaseFirst.Controllers
{
    class PersonController
    {
        AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();

        public void Inserir(Person p)
        {
            contexto.Person.Add(p);
            contexto.SaveChanges();
        }

        public void Deletar(int id)
        {
            var pessoa = BuscarPorID(id);
            if (pessoa != null)
            {
                contexto.Person.Remove(pessoa);
                contexto.SaveChanges();
            }

        }

        public List<Person> Listar()
        {
            return contexto.Person.ToList();
        }

        public Person BuscarPorID(int id)
        {
            return contexto.Person.Find(id);
        }

        public Person Update(Person p)
        {
            
        }
    }
}
