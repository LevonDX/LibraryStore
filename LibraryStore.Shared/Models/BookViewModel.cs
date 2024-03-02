using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryStore.Shared.Models
{
    public class BookViewModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public ICollection<string> Authors { get; set; }
    }
}
