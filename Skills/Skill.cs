using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goetia.Skills
{
    public abstract class Skill
    {
        private int _skillId { get; set; }
        private string _skillName { get; set; }
        public Skill(int id, string name)
        {
            _skillId = id;
            _skillName = name;
        }
        public int GetSkillId() => this._skillId;
        public string GetSkillName() => this._skillName;
    }
}
