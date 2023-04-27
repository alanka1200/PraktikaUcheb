using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRATIKATEOR
{
    
    public class User
    {
        public User(int Id, string fName, string Name, int age, string city)
        {
            this.Id = Id;
            this.фамилия = fName;
            this.имя = Name;
            this.возраст = age;
            this.город = city;

        }

        public int Id { get; set; }
        public string фамилия { get; set; }
        public string имя { get; set; }
        public int возраст { get; set; }
        public string город { get; set; }

    }
}
