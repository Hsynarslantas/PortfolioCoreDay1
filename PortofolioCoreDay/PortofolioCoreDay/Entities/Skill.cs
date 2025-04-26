using Microsoft.AspNetCore.Mvc;
using PortofolioCoreDay.Context;
namespace PortofolioCoreDay.Entities
{
    public class Skill
    {
        PortfolioContext context = new PortfolioContext(); 
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public int SkillValue { get; set; }
        
    }
}

