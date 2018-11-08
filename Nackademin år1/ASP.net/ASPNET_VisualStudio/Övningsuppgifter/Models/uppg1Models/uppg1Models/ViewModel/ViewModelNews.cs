using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uppg1Models.Models;

namespace uppg1Models.ViewModel
{
    public class ViewModelNews
    {
        public News currentNews { get; set; }
        public List<NewsSubject> subjects { get; set; }
    }
}
