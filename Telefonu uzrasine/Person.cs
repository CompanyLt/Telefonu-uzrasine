using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonu_uzrasine
{
    public class Person
    {
        int id;
        string name;
        string surName;
        string phoneNUmber;
        string birthDate;
        bool premission;


        public Person(int _id,string _vardas, string _pavarde, string _tel_numeris, string _gimimo_data)
        {
            id = _id;
            premission = false;
            name = _vardas!=null ? _vardas:string.Empty ;
            surName = _pavarde != null ? _pavarde : string.Empty; 
            phoneNUmber = _tel_numeris != null ? _tel_numeris : string.Empty; 
            birthDate = _gimimo_data != null ? _gimimo_data : string.Empty; 


        }

        public Person()
        {
            id=0;
            name = string.Empty;
            surName = string.Empty;
            phoneNUmber = string.Empty;
            birthDate = string.Empty;
            premission = false;
        }

        public Person( string _vardas, string _pavarde, string _tel_numeris, string _gimimo_data)
        {
            id =0;
            name = _vardas;
            surName = _pavarde;
            phoneNUmber = _tel_numeris;
            birthDate = _gimimo_data;
            premission = false;

        }

        public string getName()
        {
            return name;
        }

        public string getSurnName()
        {
            return surName;
        }
        public string getPhoneNumber()
        {
            return phoneNUmber;
        }
        public string getBirthDate()
        {
            return birthDate;
        }

        public int getId()
        {
            return id;
        }
        public bool getPremission()
        {
            return premission;
        }

        public void setName(string _vardas)
        {
            name = _vardas;
        }

        public void setSurName(string _pavarde)
        {
            surName= _pavarde;
        }
        public void setPhoneNumber(string _tel)
        {
        phoneNUmber= _tel;
        }
        public void setBirthDate(string _gimimo_data)
        {
           birthDate = _gimimo_data;
        }

        public void setId(int _id)
        {
           id=_id;
        }

        public void setPremission(bool _leidimas)
        {
            premission=_leidimas;
        }

    }
}
