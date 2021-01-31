using KilicGames.Campaings.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilicGames.Campaings.Abstract
{
    public interface ICampaingService
    {
        void Add(Campaing campaing);
        void Delete(Campaing campaing);
        void Update(Campaing campaing);
    }
}
