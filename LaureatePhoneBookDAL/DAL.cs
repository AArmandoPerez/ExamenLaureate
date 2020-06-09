using LaureateEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace LaureatePhoneBookDAL
{
    public class DAL
    {

        public string Add_record(Contacts contact)
        {
            using (LaureatePhoneBook_DBEntities db = new LaureatePhoneBook_DBEntities())
            {
                try
                {

                    db.Contacts.Add(contact);
                    db.SaveChanges();
                    return "Inserted";

                }
                catch (Exception ex)
                {

                    return "failed";

                }

            }

        }




        public List<Contacts> get_contacts()
        {

            using (LaureatePhoneBook_DBEntities db = new LaureatePhoneBook_DBEntities())
            {
                try
                {


                    return db.Contacts.ToList();

                }
                catch (Exception ex)
                {

                    throw ex;

                }

            }

        }




        public List<Contacts> get_RecordbyId(int id)
        {

            using (LaureatePhoneBook_DBEntities db = new LaureatePhoneBook_DBEntities())
            {
                try
                {

                    return db.Contacts.Where(q => q.ID_Contact == id).ToList();

                }
                catch (Exception ex)
                {

                    throw ex;

                }

            }

        }



        public string update_record(Contacts contact)
        {

            using (LaureatePhoneBook_DBEntities db = new LaureatePhoneBook_DBEntities())
            {
                try
                {



                    var result = db.Contacts.SingleOrDefault(b => b.ID_Contact == contact.ID_Contact);
                    if (result != null)
                    {

                        result.Nombre = contact.Nombre;
                        result.PhoneNumber = contact.PhoneNumber;
                        result.Email = contact.Email;
                        result.Location = contact.Location;
                        db.SaveChanges();

                        return "Updated";

                    }
                    else
                    {
                        return "No hay registro";
                    }


                }
                catch (Exception ex)
                {

                    return "failed";

                }

            }

        }




        public string deletedata(int id)
        {

            using (LaureatePhoneBook_DBEntities db = new LaureatePhoneBook_DBEntities())
            {
                try
                {



                    var result = db.Contacts.SingleOrDefault(b => b.ID_Contact == id);
                    if (result != null)
                    {

                        db.Contacts.Remove(result);
                        db.SaveChanges();

                        return "Contacto Borrado";

                    }
                    else
                    {
                        return "No hay registro";
                    }


                }
                catch (Exception ex)
                {

                    return "failed";

                }

            }

        }


    }
}
