using System;
using System.Collections.Generic;

namespace AngularBlok.API.Models
{
    public partial class Comment
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string Name { get; set; }
        public string ContentMain { get; set; }
        public DateTime PublishData { get; set; }

        public virtual Article Article { get; set; }
    }
}
