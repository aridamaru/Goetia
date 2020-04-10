using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goetia.CharacterDetails
{
    public class Profession
    {
        private int ProfessionId { get; set; }
        private string ProfessionName { get; set; }
        public Profession()
        {
            ProfessionId = 1;
            ProfessionName = "Novice";
        }
        public Profession(int id, string name)
        {
            ProfessionId = id;
            ProfessionName = name;
        }
        public int GetProfessionId() => this.ProfessionId;
        public string GetProfessionName() => this.ProfessionName;
    }
}
