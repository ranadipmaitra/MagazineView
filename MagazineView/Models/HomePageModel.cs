using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagazineView.Models
{
    public class HomePageModel
    {
        public List<IssueDataModel> IssueDetails { get; set; }
    }
    public class IssueDataModel
    {
        public IssueDataModel(string ImageFile)
        {
            IssueCoverImageFile = ImageFile;
        }
        public String IssueCoverImageFile { get; set; }

    }
}
