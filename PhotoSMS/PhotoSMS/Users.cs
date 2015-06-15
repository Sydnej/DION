using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSMS
{
    class Users
    {

        string name;
        string surname;
        string login;
        string password;
        string email;

        void setName(string name) { this.name = name; }
        string getName() { return this.name; }

        void setSurname(string sname) { this.surname = sname; }
        string getSurname() { return this.surname; }

        void setLogin(string log) { this.login = log; }
        string getLogin() { return this.login; }

        void setPasword(string psswd) { this.password = psswd; }
        string getPassword() { return this.password; }

        void setEmail(string em) { this.email = em; }
        string getEmail() { return this.email; }

    }
}
