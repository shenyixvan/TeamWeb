using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace YF.Model
{
    public class applicant
    {
        private int number;

        private string yourname;

        private string sex;

        private string mobile;

        private string majorclass;

        private string address;

        private int math;

        private int physics;

        private int english;

        private int chinese;

        private int two;

        private int total;

        private int type;

        public int Number { get => number; set => number = value; }
        public string Yourname { get => yourname; set => yourname = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Mobile { get => mobile; set => mobile = value; }
        public string Majorclass { get => majorclass; set => majorclass = value; }
        public string Address { get => address; set => address = value; }
        public int Math { get => math; set => math = value; }
        public int Physics { get => physics; set => physics = value; }
        public int English { get => english; set => english = value; }
        public int Chinese { get => chinese; set => chinese = value; }
        public int Two { get => two; set => two = value; }
        public int Total { get => total; set => total = value; }
        public int Type { get => type; set => type = value; }
    }
}
