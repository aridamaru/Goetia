using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goetia.Skills
{
    public class PhysicalSkill : Skill
    {
        private int SkillDamage { get; set; }
        public PhysicalSkill(int id, string name, int damage) : base(id,name)
        {
            SkillDamage = damage;
        }
    }
}
