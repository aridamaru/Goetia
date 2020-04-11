using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goetia.Skills
{
    public abstract class Skill
    {
        private int SkillId { get; set; }
        private string SkillName { get; set; }
        public Skill(int id, string name)
        {
            SkillId = id;
            SkillName = name;
        }
        public int GetSkillId() => this.SkillId;
        public string GetSkillName() => this.SkillName;
    }
}
