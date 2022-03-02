using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transact.SearchFight.Infraestructure.Models.Config
{
    /// <summary>
    /// Google config class
    /// </summary>
    public class GoogleConfig : BaseSearchEngineConfig
    {
        /// <summary>
        /// Google programmable search engine ID 
        /// </summary>
        public string Cx { get; set; }
    }
}
