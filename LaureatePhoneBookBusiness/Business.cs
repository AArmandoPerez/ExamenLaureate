using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaureateEntities;
using LaureatePhoneBookDAL;

namespace LaureatePhoneBookBusiness
{
    public class Business
    {

        static DAL dal = new DAL();


        public static string Add_record(Contacts contact)
        {

            return dal.Add_record(contact);

        }


        public static List<Contacts> get_contacts()
        {



            return dal.get_contacts();

        }


        public static List<Contacts> get_RecordbyId(int id)
        {


            return dal.get_RecordbyId(id);

        }


        public static string update_record(Contacts contact)
        {

            return dal.update_record(contact);

        }

        public static string deletedata(int id)
        {

            return dal.deletedata(id);

        }



    }
}
